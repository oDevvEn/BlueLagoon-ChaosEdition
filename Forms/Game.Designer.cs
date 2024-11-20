namespace Blue_Lagoon___Chaos_Edition {
    partial class Game {
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
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.ColumnCount = 2;
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.22F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.78F));
            BackgroundPanel.Dock = DockStyle.Fill;
            BackgroundPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            BackgroundPanel.Location = new Point(0, 0);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.RowCount = 1;
            BackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BackgroundPanel.Size = new Size(1280, 720);
            BackgroundPanel.TabIndex = 0;
            BackgroundPanel.Paint += BackgroundPanel_Paint;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1280, 720);
            Controls.Add(BackgroundPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Game";
            Text = "Game";
            WindowState = FormWindowState.Maximized;
            Shown += Game_Shown;
            ResumeLayout(false);
        }

        #endregion

        internal TableLayoutPanel BackgroundPanel;
    }
}