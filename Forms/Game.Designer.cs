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
            ControlPanel = new TableLayoutPanel();
            SettlerCountText = new Label();
            VillageCountText = new Label();
            PlayerListTable = new TableLayoutPanel();
            LeaveButton = new Button();
            MapPanel = new Panel();
            BackgroundPanel.SuspendLayout();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.ColumnCount = 2;
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.22F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.78F));
            BackgroundPanel.Controls.Add(ControlPanel, 1, 0);
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
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.FromArgb(40, 40, 40);
            ControlPanel.ColumnCount = 1;
            ControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ControlPanel.Controls.Add(SettlerCountText, 0, 1);
            ControlPanel.Controls.Add(VillageCountText, 0, 2);
            ControlPanel.Controls.Add(PlayerListTable, 0, 0);
            ControlPanel.Controls.Add(LeaveButton, 0, 4);
            ControlPanel.Dock = DockStyle.Fill;
            ControlPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            ControlPanel.Location = new Point(1014, 0);
            ControlPanel.Margin = new Padding(0);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.RowCount = 5;
            ControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            ControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            ControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5F));
            ControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            ControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            ControlPanel.Size = new Size(266, 720);
            ControlPanel.TabIndex = 0;
            // 
            // SettlerCountText
            // 
            SettlerCountText.AutoSize = true;
            SettlerCountText.Dock = DockStyle.Fill;
            SettlerCountText.Font = new Font("Consolas", 12F);
            SettlerCountText.ForeColor = Color.White;
            SettlerCountText.Location = new Point(2, 290);
            SettlerCountText.Margin = new Padding(2);
            SettlerCountText.Name = "SettlerCountText";
            SettlerCountText.Size = new Size(262, 50);
            SettlerCountText.TabIndex = 10;
            SettlerCountText.Text = "Settler Count: 12345";
            SettlerCountText.TextAlign = ContentAlignment.BottomCenter;
            // 
            // VillageCountText
            // 
            VillageCountText.AutoSize = true;
            VillageCountText.Dock = DockStyle.Fill;
            VillageCountText.Font = new Font("Consolas", 12F);
            VillageCountText.ForeColor = Color.White;
            VillageCountText.Location = new Point(2, 344);
            VillageCountText.Margin = new Padding(2);
            VillageCountText.Name = "VillageCountText";
            VillageCountText.Size = new Size(262, 50);
            VillageCountText.TabIndex = 11;
            VillageCountText.Text = "Village Count: 12345";
            VillageCountText.TextAlign = ContentAlignment.TopCenter;
            // 
            // PlayerListTable
            // 
            PlayerListTable.AutoScroll = true;
            PlayerListTable.ColumnCount = 1;
            PlayerListTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PlayerListTable.Dock = DockStyle.Fill;
            PlayerListTable.Location = new Point(6, 4);
            PlayerListTable.Margin = new Padding(6, 4, 6, 4);
            PlayerListTable.Name = "PlayerListTable";
            PlayerListTable.RowCount = 1;
            PlayerListTable.RowStyles.Add(new RowStyle());
            PlayerListTable.Size = new Size(254, 280);
            PlayerListTable.TabIndex = 3;
            // 
            // LeaveButton
            // 
            LeaveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LeaveButton.BackColor = Color.FromArgb(30, 30, 30);
            LeaveButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34);
            LeaveButton.FlatAppearance.BorderSize = 2;
            LeaveButton.FlatStyle = FlatStyle.Flat;
            LeaveButton.Font = new Font("Segoe UI", 26F);
            LeaveButton.ForeColor = Color.White;
            LeaveButton.ImeMode = ImeMode.NoControl;
            LeaveButton.Location = new Point(20, 632);
            LeaveButton.Margin = new Padding(20);
            LeaveButton.Name = "LeaveButton";
            LeaveButton.Size = new Size(226, 68);
            LeaveButton.TabIndex = 4;
            LeaveButton.Text = "Leave";
            LeaveButton.UseVisualStyleBackColor = false;
            LeaveButton.Click += LeaveButton_Click;
            // 
            // MapPanel
            // 
            MapPanel.BackColor = Color.FromArgb(0, 114, 255);
            MapPanel.Dock = DockStyle.Fill;
            MapPanel.Location = new Point(0, 0);
            MapPanel.Margin = new Padding(0);
            MapPanel.Name = "MapPanel";
            MapPanel.Size = new Size(1014, 720);
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
            ControlPanel.ResumeLayout(false);
            ControlPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal TableLayoutPanel BackgroundPanel;
        public Panel MapPanel;
        private TableLayoutPanel ControlPanel;
        internal TableLayoutPanel PlayerListTable;
        private Button LeaveButton;
        private Label SettlerCountText;
        private Label VillageCountText;
    }
}