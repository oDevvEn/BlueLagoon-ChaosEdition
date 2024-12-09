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
            tableLayoutPanel3 = new TableLayoutPanel();
            MapPanel = new Panel();
            BackgroundPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.ColumnCount = 2;
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.22F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.78F));
            BackgroundPanel.Controls.Add(tableLayoutPanel3, 1, 0);
            BackgroundPanel.Controls.Add(MapPanel, 0, 0);
            BackgroundPanel.Dock = DockStyle.Fill;
            BackgroundPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            BackgroundPanel.Location = new Point(0, 0);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.RowCount = 1;
            BackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BackgroundPanel.Size = new Size(1280, 720);
            BackgroundPanel.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(1020, 4);
            tableLayoutPanel3.Margin = new Padding(6, 4, 6, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(254, 248);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // MapPanel
            // 
            MapPanel.Dock = DockStyle.Fill;
            MapPanel.Location = new Point(3, 3);
            MapPanel.Name = "MapPanel";
            MapPanel.Size = new Size(1008, 714);
            MapPanel.TabIndex = 3;
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
            Load += Game_Load;
            BackgroundPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        internal TableLayoutPanel BackgroundPanel;
        internal TableLayoutPanel tableLayoutPanel3;
        public Panel MapPanel;
    }
}