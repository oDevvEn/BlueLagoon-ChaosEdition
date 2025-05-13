namespace Blue_Lagoon___Chaos_Edition {
    partial class MainMenu {
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
            PlayButton = new Button();
            StatisticsButton = new Button();
            QuitButton = new Button();
            MainMenuPanel = new TableLayoutPanel();
            GameTitle = new Label();
            BackgroundPanel = new TableLayoutPanel();
            StatisticsPanel = new TableLayoutPanel();
            GoBackButton = new Button();
            StatisticsLabel = new Label();
            SettlersPlacedText = new Label();
            VillagesPlacedText = new Label();
            ServersJoinedText = new Label();
            SettlementPhasesUnplayableText = new Label();
            SettlementPhasesLostText = new Label();
            SettlementPhasesWonText = new Label();
            ExplorationPhasesLostText = new Label();
            ExplorationPhasesWonText = new Label();
            GamesPlayedText = new Label();
            pleasetext = new Label();
            MainMenuPanel.SuspendLayout();
            BackgroundPanel.SuspendLayout();
            StatisticsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlayButton.BackColor = Color.FromArgb(30, 30, 30);
            PlayButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34);
            PlayButton.FlatAppearance.BorderSize = 2;
            PlayButton.FlatStyle = FlatStyle.Flat;
            PlayButton.Font = new Font("Segoe UI", 29F);
            PlayButton.ForeColor = Color.White;
            PlayButton.ImeMode = ImeMode.NoControl;
            PlayButton.Location = new Point(20, 287);
            PlayButton.Margin = new Padding(20);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(344, 84);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // StatisticsButton
            // 
            StatisticsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatisticsButton.BackColor = Color.FromArgb(30, 30, 30);
            StatisticsButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34);
            StatisticsButton.FlatAppearance.BorderSize = 2;
            StatisticsButton.FlatStyle = FlatStyle.Flat;
            StatisticsButton.Font = new Font("Segoe UI", 29F);
            StatisticsButton.ForeColor = Color.White;
            StatisticsButton.ImeMode = ImeMode.NoControl;
            StatisticsButton.Location = new Point(20, 411);
            StatisticsButton.Margin = new Padding(20);
            StatisticsButton.Name = "StatisticsButton";
            StatisticsButton.Size = new Size(344, 84);
            StatisticsButton.TabIndex = 2;
            StatisticsButton.Text = "Statistics";
            StatisticsButton.UseVisualStyleBackColor = false;
            StatisticsButton.Click += StatisticsButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuitButton.BackColor = Color.FromArgb(30, 30, 30);
            QuitButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34);
            QuitButton.FlatAppearance.BorderSize = 2;
            QuitButton.FlatStyle = FlatStyle.Flat;
            QuitButton.Font = new Font("Segoe UI", 29F);
            QuitButton.ForeColor = Color.White;
            QuitButton.ImeMode = ImeMode.NoControl;
            QuitButton.Location = new Point(20, 535);
            QuitButton.Margin = new Padding(20);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(344, 84);
            QuitButton.TabIndex = 3;
            QuitButton.Text = "Rage Quit";
            QuitButton.UseVisualStyleBackColor = false;
            QuitButton.Click += QuitButton_Click;
            // 
            // MainMenuPanel
            // 
            MainMenuPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainMenuPanel.BackColor = Color.FromArgb(230, 40, 40, 40);
            MainMenuPanel.ColumnCount = 1;
            MainMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            MainMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            MainMenuPanel.Controls.Add(QuitButton, 0, 5);
            MainMenuPanel.Controls.Add(StatisticsButton, 0, 4);
            MainMenuPanel.Controls.Add(PlayButton, 0, 3);
            MainMenuPanel.Controls.Add(GameTitle, 0, 1);
            MainMenuPanel.Dock = DockStyle.Fill;
            MainMenuPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            MainMenuPanel.Location = new Point(128, 0);
            MainMenuPanel.Margin = new Padding(0);
            MainMenuPanel.Name = "MainMenuPanel";
            MainMenuPanel.RightToLeft = RightToLeft.No;
            MainMenuPanel.RowCount = 7;
            MainMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6666708F));
            MainMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 21.3333321F));
            MainMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5.333333F));
            MainMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.3333359F));
            MainMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.333334F));
            MainMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.333334F));
            MainMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.666666F));
            MainMenuPanel.Size = new Size(384, 720);
            MainMenuPanel.TabIndex = 4;
            // 
            // GameTitle
            // 
            GameTitle.AutoSize = true;
            GameTitle.BackColor = Color.Transparent;
            GameTitle.Dock = DockStyle.Fill;
            GameTitle.Font = new Font("Segoe UI Semibold", 34F, FontStyle.Bold);
            GameTitle.ForeColor = Color.White;
            GameTitle.Location = new Point(5, 81);
            GameTitle.Margin = new Padding(5);
            GameTitle.Name = "GameTitle";
            GameTitle.Size = new Size(374, 143);
            GameTitle.TabIndex = 5;
            GameTitle.Text = "Blue Lagoon (Chaos Edition)";
            GameTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.BackColor = Color.FromArgb(40, 40, 40);
            BackgroundPanel.BackgroundImage = Properties.Resources.background;
            BackgroundPanel.BackgroundImageLayout = ImageLayout.Zoom;
            BackgroundPanel.ColumnCount = 5;
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            BackgroundPanel.Controls.Add(MainMenuPanel, 1, 0);
            BackgroundPanel.Controls.Add(StatisticsPanel, 3, 0);
            BackgroundPanel.Controls.Add(pleasetext, 2, 0);
            BackgroundPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            BackgroundPanel.Location = new Point(0, 0);
            BackgroundPanel.Name = "BackgroundPanel";
            BackgroundPanel.RowCount = 1;
            BackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BackgroundPanel.Size = new Size(2560, 720);
            BackgroundPanel.TabIndex = 5;
            // 
            // StatisticsPanel
            // 
            StatisticsPanel.BackColor = Color.FromArgb(230, 40, 40, 40);
            StatisticsPanel.ColumnCount = 1;
            StatisticsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            StatisticsPanel.Controls.Add(GoBackButton, 0, 11);
            StatisticsPanel.Controls.Add(StatisticsLabel, 0, 1);
            StatisticsPanel.Controls.Add(SettlersPlacedText, 0, 2);
            StatisticsPanel.Controls.Add(VillagesPlacedText, 0, 3);
            StatisticsPanel.Controls.Add(ServersJoinedText, 0, 4);
            StatisticsPanel.Controls.Add(SettlementPhasesUnplayableText, 0, 10);
            StatisticsPanel.Controls.Add(SettlementPhasesLostText, 0, 9);
            StatisticsPanel.Controls.Add(SettlementPhasesWonText, 0, 8);
            StatisticsPanel.Controls.Add(ExplorationPhasesLostText, 0, 7);
            StatisticsPanel.Controls.Add(ExplorationPhasesWonText, 0, 6);
            StatisticsPanel.Controls.Add(GamesPlayedText, 0, 5);
            StatisticsPanel.Dock = DockStyle.Fill;
            StatisticsPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            StatisticsPanel.Location = new Point(2048, 0);
            StatisticsPanel.Margin = new Padding(0);
            StatisticsPanel.Name = "StatisticsPanel";
            StatisticsPanel.RowCount = 13;
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            StatisticsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            StatisticsPanel.Size = new Size(384, 720);
            StatisticsPanel.TabIndex = 5;
            // 
            // GoBackButton
            // 
            GoBackButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GoBackButton.BackColor = Color.FromArgb(30, 30, 30);
            GoBackButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34);
            GoBackButton.FlatAppearance.BorderSize = 2;
            GoBackButton.FlatStyle = FlatStyle.Flat;
            GoBackButton.Font = new Font("Segoe UI", 29F);
            GoBackButton.ForeColor = Color.White;
            GoBackButton.ImeMode = ImeMode.NoControl;
            GoBackButton.Location = new Point(20, 560);
            GoBackButton.Margin = new Padding(20);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(344, 68);
            GoBackButton.TabIndex = 7;
            GoBackButton.Text = "Go Back";
            GoBackButton.UseVisualStyleBackColor = false;
            GoBackButton.Click += StatisticsButton_Click;
            // 
            // StatisticsLabel
            // 
            StatisticsLabel.AutoSize = true;
            StatisticsLabel.BackColor = Color.Transparent;
            StatisticsLabel.Dock = DockStyle.Fill;
            StatisticsLabel.Font = new Font("Segoe UI Semibold", 40F, FontStyle.Bold);
            StatisticsLabel.ForeColor = Color.White;
            StatisticsLabel.Location = new Point(5, 77);
            StatisticsLabel.Margin = new Padding(5);
            StatisticsLabel.Name = "StatisticsLabel";
            StatisticsLabel.Size = new Size(374, 134);
            StatisticsLabel.TabIndex = 6;
            StatisticsLabel.Text = "Statistics";
            StatisticsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettlersPlacedText
            // 
            SettlersPlacedText.AutoSize = true;
            SettlersPlacedText.BackColor = Color.Transparent;
            SettlersPlacedText.Dock = DockStyle.Fill;
            SettlersPlacedText.Font = new Font("Consolas", 12F);
            SettlersPlacedText.ForeColor = Color.White;
            SettlersPlacedText.Location = new Point(0, 216);
            SettlersPlacedText.Margin = new Padding(0);
            SettlersPlacedText.Name = "SettlersPlacedText";
            SettlersPlacedText.Size = new Size(384, 36);
            SettlersPlacedText.TabIndex = 8;
            SettlersPlacedText.Text = "label1";
            SettlersPlacedText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VillagesPlacedText
            // 
            VillagesPlacedText.AutoSize = true;
            VillagesPlacedText.BackColor = Color.Transparent;
            VillagesPlacedText.Dock = DockStyle.Fill;
            VillagesPlacedText.Font = new Font("Consolas", 12F);
            VillagesPlacedText.ForeColor = Color.White;
            VillagesPlacedText.Location = new Point(0, 252);
            VillagesPlacedText.Margin = new Padding(0);
            VillagesPlacedText.Name = "VillagesPlacedText";
            VillagesPlacedText.Size = new Size(384, 36);
            VillagesPlacedText.TabIndex = 9;
            VillagesPlacedText.Text = "label2";
            VillagesPlacedText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ServersJoinedText
            // 
            ServersJoinedText.AutoSize = true;
            ServersJoinedText.BackColor = Color.Transparent;
            ServersJoinedText.Dock = DockStyle.Fill;
            ServersJoinedText.Font = new Font("Consolas", 12F);
            ServersJoinedText.ForeColor = Color.White;
            ServersJoinedText.Location = new Point(0, 288);
            ServersJoinedText.Margin = new Padding(0);
            ServersJoinedText.Name = "ServersJoinedText";
            ServersJoinedText.Size = new Size(384, 36);
            ServersJoinedText.TabIndex = 10;
            ServersJoinedText.Text = "label3";
            ServersJoinedText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettlementPhasesUnplayableText
            // 
            SettlementPhasesUnplayableText.AutoSize = true;
            SettlementPhasesUnplayableText.BackColor = Color.Transparent;
            SettlementPhasesUnplayableText.Dock = DockStyle.Fill;
            SettlementPhasesUnplayableText.Font = new Font("Consolas", 12F);
            SettlementPhasesUnplayableText.ForeColor = Color.White;
            SettlementPhasesUnplayableText.Location = new Point(0, 504);
            SettlementPhasesUnplayableText.Margin = new Padding(0);
            SettlementPhasesUnplayableText.Name = "SettlementPhasesUnplayableText";
            SettlementPhasesUnplayableText.Size = new Size(384, 36);
            SettlementPhasesUnplayableText.TabIndex = 16;
            SettlementPhasesUnplayableText.Text = "Settlement Phases Unplayable: 12345";
            SettlementPhasesUnplayableText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettlementPhasesLostText
            // 
            SettlementPhasesLostText.AutoSize = true;
            SettlementPhasesLostText.BackColor = Color.Transparent;
            SettlementPhasesLostText.Dock = DockStyle.Fill;
            SettlementPhasesLostText.Font = new Font("Consolas", 12F);
            SettlementPhasesLostText.ForeColor = Color.White;
            SettlementPhasesLostText.Location = new Point(0, 468);
            SettlementPhasesLostText.Margin = new Padding(0);
            SettlementPhasesLostText.Name = "SettlementPhasesLostText";
            SettlementPhasesLostText.Size = new Size(384, 36);
            SettlementPhasesLostText.TabIndex = 15;
            SettlementPhasesLostText.Text = "label8";
            SettlementPhasesLostText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettlementPhasesWonText
            // 
            SettlementPhasesWonText.AutoSize = true;
            SettlementPhasesWonText.BackColor = Color.Transparent;
            SettlementPhasesWonText.Dock = DockStyle.Fill;
            SettlementPhasesWonText.Font = new Font("Consolas", 12F);
            SettlementPhasesWonText.ForeColor = Color.White;
            SettlementPhasesWonText.Location = new Point(0, 432);
            SettlementPhasesWonText.Margin = new Padding(0);
            SettlementPhasesWonText.Name = "SettlementPhasesWonText";
            SettlementPhasesWonText.Size = new Size(384, 36);
            SettlementPhasesWonText.TabIndex = 14;
            SettlementPhasesWonText.Text = "label7";
            SettlementPhasesWonText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExplorationPhasesLostText
            // 
            ExplorationPhasesLostText.AutoSize = true;
            ExplorationPhasesLostText.BackColor = Color.Transparent;
            ExplorationPhasesLostText.Dock = DockStyle.Fill;
            ExplorationPhasesLostText.Font = new Font("Consolas", 12F);
            ExplorationPhasesLostText.ForeColor = Color.White;
            ExplorationPhasesLostText.Location = new Point(0, 396);
            ExplorationPhasesLostText.Margin = new Padding(0);
            ExplorationPhasesLostText.Name = "ExplorationPhasesLostText";
            ExplorationPhasesLostText.Size = new Size(384, 36);
            ExplorationPhasesLostText.TabIndex = 13;
            ExplorationPhasesLostText.Text = "label6";
            ExplorationPhasesLostText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExplorationPhasesWonText
            // 
            ExplorationPhasesWonText.AutoSize = true;
            ExplorationPhasesWonText.BackColor = Color.Transparent;
            ExplorationPhasesWonText.Dock = DockStyle.Fill;
            ExplorationPhasesWonText.Font = new Font("Consolas", 12F);
            ExplorationPhasesWonText.ForeColor = Color.White;
            ExplorationPhasesWonText.Location = new Point(0, 360);
            ExplorationPhasesWonText.Margin = new Padding(0);
            ExplorationPhasesWonText.Name = "ExplorationPhasesWonText";
            ExplorationPhasesWonText.Size = new Size(384, 36);
            ExplorationPhasesWonText.TabIndex = 12;
            ExplorationPhasesWonText.Text = "label5";
            ExplorationPhasesWonText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GamesPlayedText
            // 
            GamesPlayedText.AutoSize = true;
            GamesPlayedText.BackColor = Color.Transparent;
            GamesPlayedText.Dock = DockStyle.Fill;
            GamesPlayedText.Font = new Font("Consolas", 12F);
            GamesPlayedText.ForeColor = Color.White;
            GamesPlayedText.Location = new Point(0, 324);
            GamesPlayedText.Margin = new Padding(0);
            GamesPlayedText.Name = "GamesPlayedText";
            GamesPlayedText.Size = new Size(384, 36);
            GamesPlayedText.TabIndex = 11;
            GamesPlayedText.Text = "label4";
            GamesPlayedText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pleasetext
            // 
            pleasetext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pleasetext.AutoSize = true;
            pleasetext.BackColor = Color.Transparent;
            pleasetext.Font = new Font("Segoe UI", 7F);
            pleasetext.ForeColor = Color.DimGray;
            pleasetext.Location = new Point(515, 708);
            pleasetext.Name = "pleasetext";
            pleasetext.Size = new Size(240, 12);
            pleasetext.TabIndex = 6;
            pleasetext.Text = "please make sure your display is 16:9 or close enough";
            pleasetext.TextAlign = ContentAlignment.BottomLeft;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1386, 720);
            Controls.Add(BackgroundPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            Text = "MainMenu";
            WindowState = FormWindowState.Maximized;
            Load += MainMenu_Load;
            MainMenuPanel.ResumeLayout(false);
            MainMenuPanel.PerformLayout();
            BackgroundPanel.ResumeLayout(false);
            BackgroundPanel.PerformLayout();
            StatisticsPanel.ResumeLayout(false);
            StatisticsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button PlayButton;
        private Button StatisticsButton;
        private Button QuitButton;
        private TableLayoutPanel MainMenuPanel;
        private Label GameTitle;
        private TableLayoutPanel BackgroundPanel;
        private TableLayoutPanel StatisticsPanel;
        private Button GoBackButton;
        private Label StatisticsLabel;
        private Label SettlersPlacedText;
        private Label VillagesPlacedText;
        private Label ServersJoinedText;
        private Label SettlementPhasesUnplayableText;
        private Label SettlementPhasesLostText;
        private Label SettlementPhasesWonText;
        private Label ExplorationPhasesLostText;
        private Label ExplorationPhasesWonText;
        private Label GamesPlayedText;
        private Label pleasetext;
    }
}