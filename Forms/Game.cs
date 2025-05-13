using Blue_Lagoon___Chaos_Edition.Properties;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Net.Sockets;
using System.Text;

namespace Blue_Lagoon___Chaos_Edition {
    public partial class Game : Form {
        #region Variables
        // Const references
        public static int displaySize;
        public readonly static Random random = new Random();

        // Networking variables
        byte[] username;
        TcpClient client;
        NetworkStream stream;

        // Map/Display variables
        Hexagon[,] map;
        int mapSize;
        int displayY;
        
        // Hex configuration variables
        public Size hexSize;
        public Point GetHexPosition(int y, int x) => new Point(x // no complex mathematics done here
            * displaySize / mapSize +
  (y % 2
                                                                 ==

             1 ?
                                displaySize / mapSize
   / 2 : 0) +
                                                        displayY - x,
                                                                            y
     * displaySize
                                                      *
                                            13
      / (mapSize
                                                                              * 18) + displayY);
        #endregion

        #region Launch - Setup "things" & Scale UI
        public Game(string username, string ipAddress, int port) {
            InitializeComponent(); // wat dis

            // Setup const references
            displaySize = Program.mainMenu.Size.Height * 17 / 13;
            Hexagon.game = this;

            // Networking Setup
            this.username = Encoding.Unicode.GetBytes(username);
            if (!ConnectServer(ipAddress, port))
                ExitGame();
        }
        private void Game_Load(object sender, EventArgs e) {
            // This is done here to prevent errors - adding items before window is loaded
            Task.Run(HandleData);

            // Scale UI
            foreach (Control control in ControlPanel.Controls) {
                if (control is Label || control is Button)
                    Program.ScaleUI(control);

                if (control is Button button)
                    Program.ScaleButtonBorder(button);
                
            }
        }
        #endregion

        #region Main Thread "Stuff"
        // i love when i have to actually use main thread to manage "stuff" (an excellent word to describe everything)

        // Add player to player list
        void AddPlayerName(string name) {
            Label lbl = new Label();
            Program.ScaleUI(lbl, 12f);
            lbl.Text = name;
            lbl.Dock = DockStyle.Fill;
            lbl.ForeColor = Color.White;
            PlayerListTable.Controls.Add(lbl);
        }

        // Update settler/village counters
        void UpdateCounter(int type, string count) {
            // Update counter
            if (type == 0)
                SettlerCountText.Text = "Settler Count: " + count;
            else if (type == 1)
                VillageCountText.Text = "Village Count: " + count;

            // Make texts inline with each other
            int lenDiff = SettlerCountText.Text.Length - VillageCountText.Text.Length;
            if (lenDiff > 0)
                VillageCountText.Text = VillageCountText.Text[0..14] + new string(' ', lenDiff) + VillageCountText.Text[14..];
            else if (lenDiff < 0)
                SettlerCountText.Text = SettlerCountText.Text[0..14] + new string(' ', -lenDiff) + SettlerCountText.Text[14..];
        }

        // Render the whole map I think? idk
        void DrawMap(byte[] mapData) {
            int i = 0;
            for (int y = 0; y < mapSize; y++) {
                for (int x = 0; x < mapSize; x++) {
                    Hexagon hex = new Hexagon(y, x, mapData[i++]);
                    MapPanel.Controls.Add(hex);
                    hex.BringToFront();
                    map[y, x] = hex;
                }
            }
        }

        // Clears anything a hexagon may have on it, just leaving the bare map
        void ClearMap() {
            foreach (Hexagon hex in map)
                hex.Clear();
        }
        #endregion

        #region Main Networking
        bool ConnectServer(string ipAddress, int port) {
            try {
                // Connect to server
                client = new TcpClient(ipAddress, port);
                stream = client.GetStream();

                // Send username
                stream.Write(username, 0, username.Length);
                return true;
            }
            catch {
                return false;
            }
        }
        async void HandleData() {
            while (client.Connected) {
                int dataType = ReadByte();
                switch (dataType) {
                    #region Map Handling & Game State
                    // Map receieved
                    case 210: {
                            // Setup constants
                            mapSize = ReadByte();
                            displayY = (Program.mainMenu.Size.Height - displaySize * (mapSize - 1) * 13 / (mapSize * 18) - displaySize / mapSize) / 2;
                            hexSize = new Size(displaySize / mapSize, displaySize / mapSize);

                            byte[] mapData = new byte[mapSize * mapSize];
                            if (mapSize != -1 && ReadBuffer(mapData)) {
                                // Hex configuration
                                map = new Hexagon[mapSize, mapSize];
                                GraphicsPath graphicsPath = new GraphicsPath();
                                graphicsPath.AddPolygon(new Point[6] { new Point(hexSize.Width/2, 0),
                                                                        new Point(hexSize.Width, hexSize.Height / 4),
                                                                        new Point(hexSize.Width, hexSize.Height * 3 / 4),
                                                                        new Point(hexSize.Width/2, hexSize.Height),
                                                                        new Point(0, hexSize.Height * 3 / 4),
                                                                        new Point(0, hexSize.Height / 4) });
                                Hexagon.region = new Region(graphicsPath);

                                // Clear map
                                foreach (Control control in MapPanel.Controls)
                                    control.Dispose();
                                Invoke(MapPanel.Controls.Clear);

                                // Draw Map i guess?
                                Invoke(DrawMap, mapData);
                            }
                            break;
                        }

                    // Object placed on map
                    case 211: {
                            int type = ReadByte();
                            switch (type) {
                                // Place settler
                                case 0:
                                case 1: {
                                        byte[] data = new byte[5]; // y x color(rgb)
                                        if (ReadBuffer(data))
                                            Invoke(map[data[0], data[1]].PlaceSettler, Color.FromArgb(255, data[2], data[3], data[4]), type == 1);
                                        break;
                                    }

                                // no available data??
                                case -1: {
                                        break;
                                    }

                                // Place resource
                                default: {
                                        byte[] data = new byte[2]; // y x
                                        if (ReadBuffer(data))
                                            Invoke(map[data[0], data[1]].PlaceResource, type - 2);
                                        break;
                                    }
                            }
                            break;
                        }

                    // Hexagon cleared
                    case 212: {
                            byte[] data = new byte[2]; // y x
                            if (ReadBuffer(data))
                                Invoke(map[data[0], data[1]].Clear);
                            break;
                        }

                    // Natural disaster
                    case 213: {
                            int disaster = ReadByte();

                            if (0 <= disaster && disaster <= 3)
                                Invoke(new NaturalDisaster(disaster).Show);

                            break;
                        }


                    // Clear map -- Settlement Phase time
                    case 218: {
                            // Display leaderboard
                            byte[] scores = new byte[2 * PlayerListTable.Controls.Count];
                            if (ReadBuffer(scores))
                                new Leaderboard(this, scores).ShowDialog();

                            // Clean map to only have empty hexes
                            Invoke(ClearMap);
                            break;
                        }

                    // Game end
                    case 219: {
                            // Display leaderboard
                            byte[] scores = new byte[2 * PlayerListTable.Controls.Count];
                            if (ReadBuffer(scores))
                                new Leaderboard(this, scores).ShowDialog();

                            // Clear map
                            Invoke(MapPanel.Controls.Clear);
                            foreach (Hexagon hex in map)
                                Invoke(hex.Dispose);
                            break;
                        }
                    #endregion

                    #region Player Handling
                    // Player joined -- add to list
                    case 220: {
                            byte[] buffer = new byte[128];
                            if (ReadBuffer(buffer))
                                Invoke(AddPlayerName, Encoding.UTF32.GetString(buffer).TrimEnd());

                            break;
                        }

                    // Player left -- remove from list
                    case 221: {
                            int index = ReadByte();
                            if (index != -1)
                                Invoke(() => PlayerListTable.GetControlFromPosition(0, index)?.Dispose());

                            break;
                        }

                    // Player turn update
                    case 222: {
                            int index = ReadByte();

                            if (index != -1) {
                                for (int i = 0; i < PlayerListTable.Controls.Count; i++) {
                                    Control label = PlayerListTable.GetControlFromPosition(0, i);
                                    label.ForeColor = index == i ? Color.Green : Color.White;
                                }
                            }

                            break;
                        }
                    #endregion

                    #region Display Update
                    case 230: {
                            byte[] buffer = new byte[3]; // type, i/256, i%256
                            if (ReadBuffer(buffer)) {
                                Invoke(UpdateCounter, buffer[0], ((buffer[1] * 256) + buffer[2]).ToString());
                            }

                            break;
                        }
                    #endregion

                    #region Statistics Handling
                    case 240: {
                            int type = ReadByte();
                            if (type != -1)
                                Statistics.IncrementStatistic(type);

                            break;
                        }

                    #endregion

                    #region Other
                    // empty buffer
                    case -1: {
                            await Task.Delay(200);
                            break;
                        }

                    /* this code has been removed for somehow breaking my switch statement
                    // bad buffer -- clear it
                    default: {
                            Debug.WriteLine("lmao" + dataType);
                            int a = 0;
                            while (a != -1) {
                                a = ReadByte();
                                Debug.WriteLine("baddddddddddddddd " + a);
                            }

                            break;
                        }*/
                    #endregion
                }
            }

            // client no longer connected or something
            ExitGame();
        }
        #endregion

        #region Networking Data Handling Functions
        int ReadByte() {
            try {
                return stream.ReadByte();
            }
            catch {
                ExitGame();
                return -1;
            }
        }
        bool ReadBuffer(byte[] buffer) {
            try {
                stream.Read(buffer, 0, buffer.Length);
                return true;
            }
            catch {
                ExitGame();
                return false;
            }
        }
        public void HexClickEvent(object? sender, MouseEventArgs args) {
            if (sender is Hexagon) {
                Hexagon hex = (Hexagon)sender;
                try {
                    stream.Write([200, Convert.ToByte(args.Button != MouseButtons.Left), (byte)hex.y, (byte)hex.x]);
                }
                catch {
                    ExitGame();
                }
            }
        }
        #endregion

        #region Quitting
        private void LeaveButton_Click(object sender, EventArgs e) {
            ExitGame();
        }
        void ExitGame() {
            // Close connection
            stream?.Close();
            client?.Close();

            // Go back to main menu
            try { this.Close(); }
            catch {
                try { Invoke(this.Close); }
                catch { /* ??? */ }
            }
        }
        #endregion
    }

    public class Hexagon : PictureBox {
        #region Variables
        // Const refernece variables
        static readonly Random random = new Random();
        static readonly Bitmap[] ResourceTypes = [Resources.resStatulette, Resources.resWood, Resources.resStone, Resources.resFish, Resources.resMeat, Resources.resWheat];
        static readonly Bitmap[][] MapImages = [[Resources.hexWater1],
                                                [Resources.hexLand1, Resources.hexLand2, Resources.hexLand3, Resources.hexLand4],
                                                [Resources.hexSnow1],
                                                [Resources.hexDesert1, Resources.hexDesert2]];
        public static Game game;
        public static Region region;
        
        // Hex data
        Bitmap baseImage;
        public int y;
        public int x;
        #endregion

        public Hexagon(int y, int x, int hexType) : base() {
            // Hex data variable
            this.y = y;
            this.x = x;
            Bitmap[] images = MapImages[hexType]; // temp
            baseImage = images[random.Next(images.Length)];
            Clear();

            // Hex configuration
            this.Size = game.hexSize;
            this.Location = game.GetHexPosition(y, x);
            this.Region = region;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;

            this.MouseClick += game.HexClickEvent;
        }
        
        #region Hex Modifying
        public void Clear() {
            this.Image = baseImage;
        }        
        public void PlaceSettler(Color color, bool village) {
            // Image variables
            Bitmap settler = village ? Resources.village : Resources.settler;
            Bitmap img = (Bitmap)baseImage.Clone();
            
            // Add settler/village to hex and replace background color of settler/village to client's color during this process
            for (int y = 0; y < img.Height; y++) {
                for (int x = 0; x < img.Width; x++) {
                    Color pixel = settler.GetPixel(x, y);
                    if (pixel.A == 255)
                        img.SetPixel(x, y, pixel.Equals(Color.FromArgb(255, 255, 255, 255)) ? color : pixel);
                }
            }

            // Set hex's image to newly crafted image with settler/village
            this.Image = img;
        }
        public void PlaceResource(int type) {
            // Image variables
            Bitmap resource = ResourceTypes[type];
            Bitmap img = (Bitmap)baseImage.Clone();

            // Add resource to hex
            for (int y = 0; y < img.Height; y++) {
                for (int x = 0; x < img.Width; x++) {
                    Color pixel = resource.GetPixel(x, y);
                    if (pixel.A == 255)
                        img.SetPixel(x, y, pixel);
                }
            }

            // Set hex's image to newly crafted image
            this.Image = img;
        }
        #endregion
    }
}
