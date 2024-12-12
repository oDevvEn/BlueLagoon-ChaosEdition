using System;
using Timer = System.Windows.Forms.Timer;

namespace Blue_Lagoon___Chaos_Edition {
    public partial class NaturalDisaster : Form {
        public readonly static Random random = new Random();
        public readonly static string[][] disasterAlerts = [
            ["There has been an uprising leading to a village being destroyed!",
                "A revolt has led to a village being destroyed!"],
            ["A mysterious force on an island has led to many settlers dying!",
                "A mysterious force has led to many settlers on a single island dying!",
                "Some mysterious force is killing many settlers on an island..."],
            ["There has been a world wide flood causing some settlers to drown!",
                "A world wide flood has led to some settlers drowning!"],
            ["A wild tornado appeared wiping out settlers in it path!",
                "A tornado has led to some settlers going missing..."]
        ];

        public NaturalDisaster(int disaster) {
            InitializeComponent();

            // Scale UI
            this.Scale(Program.scaleSizeF);
            WaitingBar.TextFont = new Font(WaitingBar.TextFont.FontFamily, WaitingBar.TextFont.Size * Program.scale);
            Program.ScaleUI(NaturalDisasterLabel);
            Program.ScaleUI(NaturalDisasterText);

            // Set starting position of this form
            this.Location = new Point(Program.mainMenu.Location.X + (Program.mainMenu.Size.Width - this.Size.Width) / 2,
                                      Program.mainMenu.Location.Y + (int)(2 * Program.scale));

            // Assign a disaster alert
            string[] possibleTexts = disasterAlerts[disaster];
            NaturalDisasterText.Text = possibleTexts[random.Next(possibleTexts.Length)];

        }
        private void NaturalDisaster_Load(object sender, EventArgs e) {
            this.TopMost = true;

            // Timer for progress bar (leaderboard only shown for 5 seconds)
            Timer timer = new Timer();
            timer.Interval = 50;
            timer.Tick += ProgressBarUpdate;
            timer.Start();
        }

        private void ProgressBarUpdate(object? sender, EventArgs e) {
            // Update progress bar
            WaitingBar.PerformStep();
            WaitingBar.CustomText = $"Closing in {Math.Round(2.0 - (WaitingBar.Value / 50.0), 1)}s..."; // love "1.299999999999998s" errors

            // Check if it has been 5 seconds (if progress bar is at 100%) & close
            if (WaitingBar.Value >= 100)
                this.Close();
        }

    }
}