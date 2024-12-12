using Timer = System.Windows.Forms.Timer;

namespace Blue_Lagoon___Chaos_Edition {
    public partial class Leaderboard : Form {

        public Leaderboard(Game game, byte[] scores) {
            InitializeComponent();

            // Scale UI
            this.Scale(Program.scaleSizeF);
            WaitingBar.TextFont = new Font(WaitingBar.TextFont.FontFamily, WaitingBar.TextFont.Size * Program.scale);
            Program.ScaleUI(LeaderboardLabel);
            Program.ScaleUI(PlayerColumn);
            Program.ScaleUI(ScoreColumn);

            // Timer for progress bar (leaderboard only shown for 5 seconds)
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += ProgressBarUpdate;
            timer.Start();

            // Loop through every score and display every player with their score on leaderboard
            for (int i = 0; i < scores.Length; i += 2) {
                // Setup username variable
                Label username = new Label() {
                    Text = game.tableLayoutPanel3.GetControlFromPosition(0, i / 2)?.Text,
                    Font = new Font("Segoe UI", 12F * Program.scale),
                    TextAlign = ContentAlignment.TopCenter,
                    Dock = DockStyle.Fill,
                };

                // Setup score label
                Label score = new Label() {
                    Text = ((scores[i] * 256) + scores[i + 1]).ToString(),
                    Font = new Font("Segoe UI", 12F * Program.scale),
                    TextAlign = ContentAlignment.TopCenter,
                    Dock = DockStyle.Fill,
                };

                // Display player and score
                LeaderboardPanel.Controls.Add(username);
                LeaderboardPanel.Controls.Add(score, 1, i / 2 + 1);
            }
        }

        private void ProgressBarUpdate(object? sender, EventArgs e) {
            // Update progress bar
            WaitingBar.PerformStep();
            WaitingBar.CustomText = $"Closing in {Math.Round(5.0 - (WaitingBar.Value / 20.0), 1)}s..."; // love "1.299999999999998s" errors

            // Check if it has been 5 seconds (if progress bar is at 100%) & close
            if (WaitingBar.Value >= 100)
                this.Close();
        }
    }
}