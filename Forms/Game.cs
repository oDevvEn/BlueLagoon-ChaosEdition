using Blue_Lagoon___Chaos_Edition.Properties;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Blue_Lagoon___Chaos_Edition {
    public partial class Game : Form {
        public static int displaySize = Screen.PrimaryScreen.Bounds.Size.Height * 17 / 13;
        public static int displayY = (Screen.PrimaryScreen.Bounds.Size.Height - displaySize * (mapSize - 1) * 13 / (mapSize * 18) - displaySize / mapSize) / 2;
        public static Form mainMenu;

        readonly static Bitmap[] hexImages = [Resources.hexWater, Resources.hexLand, Resources.hexSnow, Resources.hexDesert];
        readonly int[][] hexOffsets0 = [[-1, 0], [-1, 1], [0, 1], [1, 1], [1, 0], [0, -1]];
        readonly int[][] hexOffsets1 = [[-1, -1], [-1, 0], [0, 1], [1, 0], [1, -1], [0, -1]];
        
        public string username;
        public int[,] map;
        public const int mapSize = 16;

        public Game(string username) {
            InitializeComponent(); // wat dis

            map = new int[mapSize, mapSize];
            this.username = username;

            GameHandler gH = new GameHandler(this);
            gH.ConnectServer();
            gH.HandleData();
        }

        public void DrawMap() {
            List<Control> badControls = new List<Control>();
            foreach (Control control in BackgroundPanel.Controls)
                if (BackgroundPanel.GetCellPosition(control).Equals(new TableLayoutPanelCellPosition(0, 0)))
                    badControls.Add(control);
       
            foreach (Control control in badControls) {
                BackgroundPanel.Controls.Remove(control);
                control.Dispose();
            }

            for (int y = 0; y < mapSize; y++) {
                for (int x = 0; x < mapSize; x++) {
                    PictureBox hex = new PictureBox();

                    hex.Visible = false;
                    hex.Image = hexImages[map[y, x]];
                    hex.SizeMode = PictureBoxSizeMode.StretchImage;

                    hex.Size = new Size(displaySize / mapSize, displaySize / mapSize);
                    hex.Location = new Point(x * displaySize / mapSize + (y % 2 == 1 ? displaySize / mapSize / 2 : 0) + displayY - x,
                                            y * displaySize * 13 / (mapSize * 18) + displayY);

                    BackgroundPanel.Controls.Add(hex, 0, 0);
                }
            }
        }

        // THIS IS DONE SO TRANSPARENCY WORKS
        private void BackgroundPanel_Paint(object sender, PaintEventArgs e) {
            DoubleBuffered = true;
            for (int i = 0; i < BackgroundPanel.Controls.Count; i++) {
                if (BackgroundPanel.Controls[i] is PictureBox) {
                    PictureBox p = (PictureBox)BackgroundPanel.Controls[i];
                    e.Graphics.DrawImage(p.Image, p.Left, p.Top, p.Width, p.Height);
                }
            }
        }

        private void Game_Shown(object sender, EventArgs e) {
            Label lbl = new Label();
            lbl.Text = "Waiting for server............";
            BackgroundPanel.Controls.Add(lbl, 1, 0);
            this.Refresh();
            //BackgroundPanel.Refresh();

            BackgroundPanel.Controls.Remove(lbl);
        }
    }

    class GameHandler {
        Game form;
        TcpClient client;
        NetworkStream stream;

        public GameHandler(Game form) {
            this.form = form;
        }

        public Exception? ConnectServer() {
            try {
                client = new TcpClient("127.0.0.1", 60420);
                stream = client.GetStream();

                Byte[] username = Encoding.Unicode.GetBytes(form.username);
                stream.Write(username, 0, username.Length);

                return null;
            }
            catch (Exception ex) {
                return ex;
            }
        }

        public async void HandleData() {
            while (client.Connected) {
                await Task.Delay(250);
                int dataType = stream.ReadByte();

                switch (dataType) {
                        case 0: { // map receieved
                            Byte[] buffer = new byte[Game.mapSize * Game.mapSize];
                            if (ReadBuffer(buffer)) {
                                int i = 0;
                                for (int y = 0; y < Game.mapSize; y++) {
                                    for (int x = 0; x < Game.mapSize; x++) {
                                        form.map[y, x] = buffer[i++];
                                    }
                                }
                            }
                            form.DrawMap();
                            break;
                        }

                        case 1: { // object placed on map
                            Byte[] buffer = new byte[6]; //y x type color(rgb)
                            if (ReadBuffer(buffer)) {
                                PictureBox obj = new PictureBox();
                                
                                obj.Visible = false;
                                obj.Size = new Size(Game.displaySize / Game.mapSize, Game.displaySize / Game.mapSize);
                                obj.Location = new Point(buffer[1] * Game.displaySize / Game.mapSize + (buffer[0] % 2 == 1 ? Game.displaySize / Game.mapSize / 2 : 0) + Game.displayY - buffer[1],
                                                        buffer[0] * Game.displaySize * 13 / (Game.mapSize * 18) + Game.displayY);

                                Bitmap img = Resources.settler;
                                
                                for (int y = 0; y < img.Height; y++) {
                                    for (int x = 0; x < img.Width; x++) {
                                        if (img.GetPixel(x, y).Equals(Color.FromArgb(255,255,255,255))) {
                                            img.SetPixel(x, y, Color.FromArgb(255, buffer[3], buffer[4], buffer[5]));
                                        }
                                    }
                                }

                                obj.Image = img;

                                form.BackgroundPanel.Controls.Add(obj, 0, 0);
                            }

                            break;
                        }
                }
            }
        }

        bool ReadBuffer(Byte[] buffer) {
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
            stream.Close();
            client.Close();
            Game.mainMenu.Show();
            form.Close();
        }
    }
}
