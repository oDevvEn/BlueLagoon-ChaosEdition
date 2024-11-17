using Blue_Lagoon___Chaos_Edition.Properties;
using System.Net.Sockets;
using System.Text;

namespace Blue_Lagoon___Chaos_Edition {
    public partial class Game : Form {
        static int displaySize = Screen.PrimaryScreen.Bounds.Size.Height * 17 / 13;
        static int displayY = (Screen.PrimaryScreen.Bounds.Size.Height - displaySize * (mapSize - 1) * 13 / (mapSize * 18) - displaySize / mapSize) / 2;
        public static Form mainMenu;

        readonly static Bitmap[] hexImages = [Resources.hexWater, Resources.hexLand, Resources.hexSnow, Resources.hexDesert];
        readonly int[][] hexOffsets0 = [[-1, 0], [-1, 1], [0, 1], [1, 1], [1, 0], [0, -1]];
        readonly int[][] hexOffsets1 = [[-1, -1], [-1, 0], [0, 1], [1, 0], [1, -1], [0, -1]];
        const int mapSize = 16;
        int[,] map;
        string username;

        public Game(string username) {
            InitializeComponent(); // wat dis

            map = new int[mapSize, mapSize];
            this.username = username;
        }

        public void DrawMap() {
            for (int y = 0; y < map.GetLength(0); y++) {
                for (int x = 0; x < map.GetLength(1); x++) {
                    PictureBox hex = new PictureBox();

                    hex.Visible = false;
                    hex.Image = hexImages[map[y, x]];
                    hex.SizeMode = PictureBoxSizeMode.StretchImage;

                    hex.Size = new Size(displaySize / mapSize, displaySize / mapSize);
                    hex.Location = new Point(x * displaySize / mapSize + (y % 2 == 1 ? displaySize / mapSize / 2 : 0) + displayY - x,
                                            y * displaySize * 13 / (mapSize * 18) + displayY);

                    this.Controls.Add(hex);
                }
            }
        }

        // THIS IS DONE SO TRANSPARENCY WORKS
        private void Game_Paint(object sender, PaintEventArgs e) {
            DoubleBuffered = true;
            for (int i = 0; i < Controls.Count; i++) {
                if (Controls[i] is PictureBox) {
                    PictureBox p = (PictureBox)Controls[i];
                    e.Graphics.DrawImage(p.Image, p.Left, p.Top, p.Width, p.Height);
                }
            }
        }

        private void Game_Load(object sender, EventArgs e) {
            Label lbl = new Label();
            lbl.Text = "Waiting for server............";
            this.Controls.Add(lbl);
            
            TcpClient client = new TcpClient("127.0.0.1", 60420);
            using (NetworkStream stream = client.GetStream()) {
                Byte[] buffer = Encoding.Unicode.GetBytes(username);
                stream.Write(buffer, 0, buffer.Length);

                buffer = new byte[mapSize * mapSize];
                stream.Read(buffer, 0, buffer.Length);

                int i = 0;
                for (int y = 0; y < mapSize; y++) {
                    for (int x = 0; x < mapSize; x++) {
                        map[y, x] = buffer[i++];
                    }
                }
            }

            this.Controls.Remove(lbl);

            DrawMap();
        }
    }
}
