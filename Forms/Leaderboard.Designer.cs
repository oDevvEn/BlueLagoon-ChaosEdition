namespace Blue_Lagoon___Chaos_Edition {
    partial class Leaderboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            BackgroundPanel = new TableLayoutPanel();
            LeaderboardPanel = new TableLayoutPanel();
            PlayerColumn = new Label();
            ScoreColumn = new Label();
            WaitingBar = new ProgressBarSample.TextProgressBar();
            LeaderboardLabel = new Label();
            BackgroundPanel.SuspendLayout();
            LeaderboardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.ColumnCount = 1;
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            BackgroundPanel.Controls.Add(LeaderboardPanel, 0, 2);
            BackgroundPanel.Controls.Add(WaitingBar, 0, 0);
            BackgroundPanel.Controls.Add(LeaderboardLabel, 0, 1);
            BackgroundPanel.Dock = DockStyle.Fill;
            BackgroundPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            BackgroundPanel.Location = new Point(0, 0);
            BackgroundPanel.Margin = new Padding(0);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.RowCount = 3;
            BackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            BackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            BackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            BackgroundPanel.Size = new Size(400, 250);
            BackgroundPanel.TabIndex = 0;
            // 
            // LeaderboardPanel
            // 
            LeaderboardPanel.AutoScroll = true;
            LeaderboardPanel.ColumnCount = 2;
            LeaderboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            LeaderboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            LeaderboardPanel.Controls.Add(PlayerColumn, 0, 0);
            LeaderboardPanel.Controls.Add(ScoreColumn, 1, 0);
            LeaderboardPanel.Dock = DockStyle.Fill;
            LeaderboardPanel.Location = new Point(3, 78);
            LeaderboardPanel.Name = "LeaderboardPanel";
            LeaderboardPanel.RowCount = 1;
            LeaderboardPanel.RowStyles.Add(new RowStyle());
            LeaderboardPanel.Size = new Size(394, 169);
            LeaderboardPanel.TabIndex = 4;
            // 
            // PlayerColumn
            // 
            PlayerColumn.AutoSize = true;
            PlayerColumn.Dock = DockStyle.Fill;
            PlayerColumn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            PlayerColumn.Location = new Point(3, 0);
            PlayerColumn.Name = "PlayerColumn";
            PlayerColumn.Size = new Size(269, 169);
            PlayerColumn.TabIndex = 1;
            PlayerColumn.Text = "Player";
            PlayerColumn.TextAlign = ContentAlignment.TopCenter;
            // 
            // ScoreColumn
            // 
            ScoreColumn.AutoSize = true;
            ScoreColumn.Dock = DockStyle.Fill;
            ScoreColumn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ScoreColumn.Location = new Point(278, 0);
            ScoreColumn.Name = "ScoreColumn";
            ScoreColumn.Size = new Size(113, 169);
            ScoreColumn.TabIndex = 0;
            ScoreColumn.Text = "Score";
            ScoreColumn.TextAlign = ContentAlignment.TopCenter;
            // 
            // WaitingBar
            // 
            WaitingBar.BackColor = SystemColors.ControlDarkDark;
            WaitingBar.CustomText = "title bar";
            WaitingBar.Dock = DockStyle.Fill;
            WaitingBar.Location = new Point(0, 0);
            WaitingBar.Margin = new Padding(0);
            WaitingBar.Name = "WaitingBar";
            WaitingBar.ProgressColor = Color.ForestGreen;
            WaitingBar.Size = new Size(400, 25);
            WaitingBar.Step = 1;
            WaitingBar.Style = ProgressBarStyle.Continuous;
            WaitingBar.TabIndex = 1;
            WaitingBar.TextColor = Color.Black;
            WaitingBar.TextFont = new Font("Segoe UI", 11F, FontStyle.Bold);
            WaitingBar.VisualMode = ProgressBarSample.ProgressBarDisplayMode.CustomText;
            // 
            // LeaderboardLabel
            // 
            LeaderboardLabel.AutoSize = true;
            LeaderboardLabel.Dock = DockStyle.Fill;
            LeaderboardLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            LeaderboardLabel.Location = new Point(3, 25);
            LeaderboardLabel.Name = "LeaderboardLabel";
            LeaderboardLabel.Size = new Size(394, 50);
            LeaderboardLabel.TabIndex = 3;
            LeaderboardLabel.Text = "Leaderboard";
            LeaderboardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 250);
            Controls.Add(BackgroundPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Leaderboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Blue Lagoon - Chaos Edition";
            BackgroundPanel.ResumeLayout(false);
            BackgroundPanel.PerformLayout();
            LeaderboardPanel.ResumeLayout(false);
            LeaderboardPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel BackgroundPanel;
        private ProgressBarSample.TextProgressBar WaitingBar;
        private Label LeaderboardLabel;
        private TableLayoutPanel LeaderboardPanel;
        private Label PlayerColumn;
        private Label ScoreColumn;
    }
}