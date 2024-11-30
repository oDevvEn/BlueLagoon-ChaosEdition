using Blue_Lagoon___Chaos_Edition.Properties;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Net.Sockets;
using System.Text;

namespace Blue_Lagoon___Chaos_Edition {
    public partial class Game : Form {
        readonly static int displaySize = Screen.PrimaryScreen.Bounds.Size.Height * 17 / 13;
        public readonly static Bitmap[] hexImages = [Resources.hexWater, Resources.hexLand, Resources.hexSnow, Resources.hexDesert];
        public static Form mainMenu;

        byte[] username;
        TcpClient client;
        NetworkStream stream;

        Hexagon[,] map;
        int mapSize;
        int displayY;
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

        public Game(string username, string ipAddress, int port) {
            InitializeComponent(); // wat dis

            Hexagon.game = this;
            this.username = Encoding.Unicode.GetBytes(username);
            if (ConnectServer(ipAddress, port))
                Task.Run(HandleData);
            else
                ExitGame();
        }

        public void HexClickEvent(object? sender, EventArgs args) {
            Debug.Write("click");
            if (sender is Hexagon) {
                Hexagon hex = (Hexagon)sender;
                stream.Write([200, (byte)hex.y, (byte)hex.x]);
            }
        }

        // i love when i have to actually use main thread to manage "stuff" (an excellent word to describe everything)
        void AddPlayerName(string name) {
            Label lbl = new Label();
            lbl.Text = name;
            tableLayoutPanel3.Controls.Add(lbl);
        }
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

        bool ConnectServer(string ipAddress, int port) {
            try {
                client = new TcpClient(ipAddress, port);
                stream = client.GetStream();

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
                    // map receieved
                    case 210: {
                            mapSize = ReadByte();
                            displayY = (Screen.PrimaryScreen.Bounds.Size.Height - displaySize * (mapSize - 1) * 13 / (mapSize * 18) - displaySize / mapSize) / 2;
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

                                // Clear Map - Get every control that is map related
                                /*List<Control> badControls = new List<Control>();
                                foreach (Control control in BackgroundPanel.Controls) 
                                    if (BackgroundPanel.GetCellPosition(control).Equals(new TableLayoutPanelCellPosition(0, 0))) 
                                        badControls.Add(control);
                               
                                // Clear Map - incinerate located controls
                                foreach (Control control in badControls) {
                                    BackgroundPanel.Controls.Remove(control);
                                    control.Dispose();
                                }*/
                                foreach (Control control in MapPanel.Controls)
                                    control.Dispose();
                                Invoke(MapPanel.Controls.Clear);

                                // Draw Map i guess?
                                Invoke(DrawMap, mapData);
                            }
                            break;
                        }


                    // object placed on map
                    case 211: {
                            byte[] data = new byte[5]; //y x color(rgb)
                            if (ReadBuffer(data))
                                Invoke(map[data[0], data[1]].PlaceObject, Color.FromArgb(255, data[2], data[3], data[4]));
                            break;
                        }


                    // player received
                    case 220: {
                            byte[] buffer = new byte[128];
                            if (ReadBuffer(buffer)) 
                                Invoke(AddPlayerName, Encoding.Unicode.GetString(buffer));
                            break;
                        }


                    // empty buffer
                    case -1: {
                            await Task.Delay(200);
                            break;
                        }


                    // bad buffer
                    default: {
                            while (ReadByte() != -1)
                                continue;

                            break;
                        }
                }
            }
        }

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

        void ExitGame() {
            stream?.Close();
            client?.Close();

            Invoke(mainMenu.Show);
            Invoke(this.Close);
        }

    }

    public class Hexagon : PictureBox {
        public static Game game;
        public static Region region;
        
        Bitmap baseImage;
        public int y;
        public int x;

        public Hexagon(int y, int x, int hexType) : base() {
            this.y = y;
            this.x = x;

            this.Size = game.hexSize;
            this.Location = game.GetHexPosition(y, x);
            this.Region = region;

            //this.Visible = false;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Transparent;
            baseImage = Game.hexImages[hexType];
            Clear();

            this.Click += game.HexClickEvent;
        }

        public void Clear() {
            this.Image = baseImage;
        }

        public void PlaceObject(Color color) {
            Bitmap settler = Resources.settler;
            Bitmap img = (Bitmap)baseImage.Clone();
            
            for (int y = 0; y < img.Height; y++) {
                for (int x = 0; x < img.Width; x++) {
                    Color pixel = settler.GetPixel(x, y);
                    if (pixel.A == 255)
                        img.SetPixel(x, y, pixel.Equals(Color.FromArgb(255, 255, 255, 255)) ? color : pixel);
                }
            }

            this.Image = img;
        }
    }
}
