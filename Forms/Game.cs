using Blue_Lagoon___Chaos_Edition.Properties;
using Microsoft.VisualBasic.Devices;

namespace Blue_Lagoon___Chaos_Edition {
    public partial class Game : Form {
        const int mapSize = 16;
        static int displaySize = Screen.PrimaryScreen.Bounds.Size.Height * 17 / 13;
        static int displayY = (Screen.PrimaryScreen.Bounds.Size.Height - displaySize * (mapSize-1) * 13 / (mapSize * 18) - displaySize/mapSize) / 2;
        public static Form mainMenu;
        FastNoiseLite noise;
        Random random;

        readonly static Bitmap[] hexImages = [Resources.hexWater, Resources.hexLand, Resources.hexSnow, Resources.hexDesert];
        readonly int[][] hexOffsets0 = [[-1, 0], [-1, 1], [0, 1], [1, 1], [1, 0], [0, -1]];
        readonly int[][] hexOffsets1 = [[-1, -1], [-1, 0], [0, 1], [1, 0], [1, -1], [0, -1]];
        int[,] map;


        public Game() {
            InitializeComponent(); // wat dis

            random = new Random();
            noise = new FastNoiseLite();
            noise.SetNoiseType(FastNoiseLite.NoiseType.OpenSimplex2);
            map = new int[mapSize, mapSize];

            List<List<int>> islands;
            do {
                GenerateMap();
                islands = DetectIslands();
            } while (!ValidateIslands(islands));
            SetIslandBiomes(islands);

            DrawMap();
        }

        public void GenerateMap() {
            int xOffset = random.Next(-10000, 10000);
            int yOffset = random.Next(-10000, 10000);

            for (int y = 0; y < mapSize; y++) {
                for (int x = 0; x < mapSize; x++) {
                    map[y, x] = noise.GetNoise(x * 15 + xOffset, y * 15 + yOffset) > 0.05 ? 1 : 0;
                }
            }
        }

        public List<List<int>> DetectIslands() {
            bool[,] searched = new bool[mapSize, mapSize];
            List<List<int>> islands = new List<List<int>>();

            for (int y = 0; y < mapSize; y++) {
                for (int x = 0; x < mapSize; x++) {
                    if (searched[y, x] || map[y, x] == 0) {
                        searched[y, x] = true;
                        continue;
                    }

                    List<int> islandPos = new List<int>();

                    void SearchNearby(int y, int x) {
                        if (0 <= y && y < mapSize && 0 <= x && x < mapSize && !searched[y, x]) {
                            searched[y, x] = true;
                            if (map[y, x] == 0)
                                return;

                            islandPos.Add(y * mapSize + x);
                            foreach (int[] o in (y % 2 == 0 ? hexOffsets0 : hexOffsets1))
                                SearchNearby(y + o[0], x + o[1]);
                        }
                    }

                    SearchNearby(y, x);
                    islands.Add(islandPos);

                }
            }

            return islands;
        }

        public bool ValidateIslands(List<List<int>> islands) {
            int bigIslandCount = 0;
            List<List<int>> removeIslands = new List<List<int>>();

            foreach (List<int> island in islands) {
                if (island.Count > 6)
                    bigIslandCount++;
                else {
                    foreach (int hex in island)
                        map[hex / mapSize, hex % mapSize] = 0;
                    removeIslands.Add(island);
                }
            }

            foreach (List<int> island in removeIslands)
                islands.Remove(island);

            if (bigIslandCount == 8 && islands.Count == 8)
                return true;
            return false;
        }

        public void SetIslandBiomes(List<List<int>> islands) {
            foreach (List<int> island in islands) {
                int biome = random.Next(1, 4);

                foreach (int hex in island)
                    map[hex / mapSize, hex % mapSize] = biome;
            }
        }

        public void DrawMap() {
            for (int y = 0; y < mapSize; y++) {
                for (int x = 0; x < mapSize; x++) {
                    PictureBox hex = new PictureBox();
                    hex.BackColor = Color.Transparent;
                    hex.Image = hexImages[map[y, x]];
                    hex.SizeMode = PictureBoxSizeMode.StretchImage;

                    hex.Size = new Size(displaySize / mapSize, displaySize / mapSize);
                    hex.Location = new Point(x * displaySize / mapSize + (y % 2 == 1 ? displaySize / mapSize / 2 : 0) + displayY - x,
                                            y * displaySize  * 13 / (mapSize * 18) + displayY);

                    hex.BringToFront();
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
                    p.Visible = false;
                    e.Graphics.DrawImage(p.Image, p.Left, p.Top, p.Width, p.Height);
                }
            }
        }
    }
}
