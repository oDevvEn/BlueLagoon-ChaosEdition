using System.Diagnostics;

namespace Blue_Lagoon___Chaos_Edition {
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
            Game.mainMenu = this;
        }

        #region Rage Quit
        private void QuitButton_Click(object sender, EventArgs e) {
            this.Close();
        }
        #endregion

        #region Play
        private void PlayButton_Click(object sender, EventArgs e) {
            GetConnectionInfo connectionInfo = new GetConnectionInfo();
            connectionInfo.ShowDialog();
            if (connectionInfo.successful) {
                Game game = new Game(connectionInfo.username.Text, connectionInfo.ipAddress.Text, int.Parse(connectionInfo.port.Text));
                if (!game.IsDisposed) {
                    game.Show();
                    this.Hide();
                }
            }
        }
        #endregion

        #region Statistics
        private void StatisticsButton_Click(object sender, EventArgs e) {
            #region Update statistics labels 
            // sorry couldn't think of a better method
            if (sender == StatisticsButton) {
                SettlersPlacedText.Text             = "Settlers Placed:              " + Statistics.GetStatistic(0);
                VillagesPlacedText.Text             = "Villages Placed:              " + Statistics.GetStatistic(1);
                ServersJoinedText.Text              = "Servers Joined:               " + Statistics.GetStatistic(2);
                GamesPlayedText.Text                = "Games Played:                 " + Statistics.GetStatistic(3);
                ExplorationPhasesWonText.Text       = "Exploration Phases Won:       " + Statistics.GetStatistic(4);
                ExplorationPhasesLostText.Text      = "Exploration Phases Lost:      " + Statistics.GetStatistic(5);
                SettlementPhasesWonText.Text        = "Settlment Phases Won:         " + Statistics.GetStatistic(6);
                SettlementPhasesLostText.Text       = "Settlement Phases Lost:       " + Statistics.GetStatistic(7);
                SettlementPhasesUnplayableText.Text = "Settlement Phases Unplayable: " + Statistics.GetStatistic(8);
            }
            #endregion

            #region Animation
            // Animation variables
            int direction = (BackgroundPanel.Location.X == 0 ? -1 : 1);
            double progress = 0;
            int startPos = (BackgroundPanel.Location.X == 0 ? 0 : -this.Size.Width);

            // Delta time for similar speeds across any hardware
            Stopwatch sw = new Stopwatch();
            double dT = 0;
            sw.Start();

            // Animation Loop
            do {
                sw.Restart();

                // Calculate animation position
                progress += dT * 2; // 0.5 seconds
                double easeFunction = 1 - Math.Pow(1 - progress, 5); // "Ease Out Quint"

                // Move everything
                BackgroundPanel.Location = new Point((int)Math.Clamp(this.Size.Width * easeFunction * direction + direction + startPos, -this.Size.Width, 0), 0);
                BackgroundPanel.Refresh();
                
                // Calculate delta time
                dT = sw.ElapsedMilliseconds / 1000.0;
            } while (BackgroundPanel.Location.X != 0 && BackgroundPanel.Location.X != -this.Size.Width);
            #endregion
        }
        #endregion

        #region Scale UI
        float scale;
        void LoopControlFonts(Control controls) {
            foreach (Control control in controls.Controls) {
                if (control is Button || control is Label)
                    control.Font = new Font(control.Font.FontFamily, control.Font.Size * scale);
            }
        }
        private void MainMenu_Load(object sender, EventArgs e) {
            // Setup BackgroundPanel
            BackgroundPanel.Size = new Size(this.Size.Width * 2, this.Size.Height);
            BackgroundPanel.Location = new Point(0,0); // idk if require didn't test :p

            // Scale fonts of labels/buttons
            scale = MathF.Min(this.Size.Width / 1280f, this.Size.Height / 720f) * 96f / (this.DeviceDpi * 1.05f);
            LoopControlFonts(MainMenuPanel);
            LoopControlFonts(StatisticsPanel);
        }
        #endregion
    }
}
