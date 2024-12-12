namespace Blue_Lagoon___Chaos_Edition {
    partial class NaturalDisaster {
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
            NaturalDisasterText = new Label();
            WaitingBar = new ProgressBarSample.TextProgressBar();
            NaturalDisasterLabel = new Label();
            BackgroundPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.ColumnCount = 1;
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            BackgroundPanel.Controls.Add(NaturalDisasterText, 0, 2);
            BackgroundPanel.Controls.Add(WaitingBar, 0, 0);
            BackgroundPanel.Controls.Add(NaturalDisasterLabel, 0, 1);
            BackgroundPanel.Dock = DockStyle.Fill;
            BackgroundPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            BackgroundPanel.Location = new Point(0, 0);
            BackgroundPanel.Margin = new Padding(0);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.RowCount = 3;
            BackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            BackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            BackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            BackgroundPanel.Size = new Size(300, 100);
            BackgroundPanel.TabIndex = 0;
            // 
            // NaturalDisasterText
            // 
            NaturalDisasterText.AutoSize = true;
            NaturalDisasterText.Dock = DockStyle.Fill;
            NaturalDisasterText.Font = new Font("Segoe UI", 11F);
            NaturalDisasterText.Location = new Point(3, 55);
            NaturalDisasterText.Name = "NaturalDisasterText";
            NaturalDisasterText.Size = new Size(294, 45);
            NaturalDisasterText.TabIndex = 4;
            NaturalDisasterText.Text = "A mysterious force has led to many settlers on a single island dying!";
            NaturalDisasterText.TextAlign = ContentAlignment.MiddleCenter;
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
            WaitingBar.Size = new Size(300, 20);
            WaitingBar.Step = 2;
            WaitingBar.Style = ProgressBarStyle.Continuous;
            WaitingBar.TabIndex = 1;
            WaitingBar.TextColor = Color.Black;
            WaitingBar.TextFont = new Font("Segoe UI", 11F, FontStyle.Bold);
            WaitingBar.VisualMode = ProgressBarSample.ProgressBarDisplayMode.CustomText;
            // 
            // NaturalDisasterLabel
            // 
            NaturalDisasterLabel.AutoSize = true;
            NaturalDisasterLabel.Dock = DockStyle.Fill;
            NaturalDisasterLabel.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            NaturalDisasterLabel.Location = new Point(3, 20);
            NaturalDisasterLabel.Name = "NaturalDisasterLabel";
            NaturalDisasterLabel.Size = new Size(294, 35);
            NaturalDisasterLabel.TabIndex = 3;
            NaturalDisasterLabel.Text = "Natural Disaster";
            NaturalDisasterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NaturalDisaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 100);
            Controls.Add(BackgroundPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NaturalDisaster";
            StartPosition = FormStartPosition.Manual;
            Text = "Blue Lagoon - Chaos Edition";
            Load += NaturalDisaster_Load;
            BackgroundPanel.ResumeLayout(false);
            BackgroundPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel BackgroundPanel;
        private ProgressBarSample.TextProgressBar WaitingBar;
        private Label NaturalDisasterLabel;
        private Label NaturalDisasterText;
    }
}