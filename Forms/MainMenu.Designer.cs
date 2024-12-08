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
            label1 = new Label();
            MainMenuPanel.SuspendLayout();
            BackgroundPanel.SuspendLayout();
            StatisticsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlayButton.Font = new Font("Segoe UI", 29F);
            PlayButton.ImeMode = ImeMode.NoControl;
            PlayButton.Location = new Point(20, 286);
            PlayButton.Margin = new Padding(20);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(338, 83);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // StatisticsButton
            // 
            StatisticsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatisticsButton.Font = new Font("Segoe UI", 29F);
            StatisticsButton.ImeMode = ImeMode.NoControl;
            StatisticsButton.Location = new Point(20, 409);
            StatisticsButton.Margin = new Padding(20);
            StatisticsButton.Name = "StatisticsButton";
            StatisticsButton.Size = new Size(338, 83);
            StatisticsButton.TabIndex = 2;
            StatisticsButton.Text = "Statistics";
            StatisticsButton.UseVisualStyleBackColor = true;
            StatisticsButton.Click += StatisticsButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuitButton.Font = new Font("Segoe UI", 29F);
            QuitButton.ImeMode = ImeMode.NoControl;
            QuitButton.Location = new Point(20, 532);
            QuitButton.Margin = new Padding(20);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(338, 83);
            QuitButton.TabIndex = 3;
            QuitButton.Text = "Rage Quit";
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += QuitButton_Click;
            // 
            // MainMenuPanel
            // 
            MainMenuPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            MainMenuPanel.Location = new Point(131, 3);
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
            MainMenuPanel.Size = new Size(378, 714);
            MainMenuPanel.TabIndex = 4;
            // 
            // GameTitle
            // 
            GameTitle.AutoSize = true;
            GameTitle.BackColor = Color.Transparent;
            GameTitle.Dock = DockStyle.Fill;
            GameTitle.Font = new Font("Segoe UI Semibold", 34F, FontStyle.Bold);
            GameTitle.Location = new Point(5, 81);
            GameTitle.Margin = new Padding(5);
            GameTitle.Name = "GameTitle";
            GameTitle.Size = new Size(368, 142);
            GameTitle.TabIndex = 5;
            GameTitle.Text = "Blue Lagoon (Chaos Edition)";
            GameTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.ColumnCount = 5;
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            BackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            BackgroundPanel.Controls.Add(MainMenuPanel, 1, 0);
            BackgroundPanel.Controls.Add(StatisticsPanel, 3, 0);
            BackgroundPanel.Controls.Add(label1, 2, 0);
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
            StatisticsPanel.Location = new Point(2051, 3);
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
            StatisticsPanel.Size = new Size(378, 714);
            StatisticsPanel.TabIndex = 5;
            // 
            // GoBackButton
            // 
            GoBackButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GoBackButton.Font = new Font("Segoe UI", 29F);
            GoBackButton.ImeMode = ImeMode.NoControl;
            GoBackButton.Location = new Point(20, 548);
            GoBackButton.Margin = new Padding(20);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(338, 67);
            GoBackButton.TabIndex = 7;
            GoBackButton.Text = "Go Back";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += StatisticsButton_Click;
            // 
            // StatisticsLabel
            // 
            StatisticsLabel.AutoSize = true;
            StatisticsLabel.BackColor = Color.Transparent;
            StatisticsLabel.Dock = DockStyle.Fill;
            StatisticsLabel.Font = new Font("Segoe UI Semibold", 40F, FontStyle.Bold);
            StatisticsLabel.Location = new Point(5, 76);
            StatisticsLabel.Margin = new Padding(5);
            StatisticsLabel.Name = "StatisticsLabel";
            StatisticsLabel.Size = new Size(368, 132);
            StatisticsLabel.TabIndex = 6;
            StatisticsLabel.Text = "Statistics";
            StatisticsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettlersPlacedText
            // 
            SettlersPlacedText.AutoSize = true;
            SettlersPlacedText.Dock = DockStyle.Fill;
            SettlersPlacedText.Font = new Font("Consolas", 12F);
            SettlersPlacedText.Location = new Point(0, 213);
            SettlersPlacedText.Margin = new Padding(0);
            SettlersPlacedText.Name = "SettlersPlacedText";
            SettlersPlacedText.Size = new Size(378, 35);
            SettlersPlacedText.TabIndex = 8;
            SettlersPlacedText.Text = "label1";
            SettlersPlacedText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VillagesPlacedText
            // 
            VillagesPlacedText.AutoSize = true;
            VillagesPlacedText.Dock = DockStyle.Fill;
            VillagesPlacedText.Font = new Font("Consolas", 12F);
            VillagesPlacedText.Location = new Point(0, 248);
            VillagesPlacedText.Margin = new Padding(0);
            VillagesPlacedText.Name = "VillagesPlacedText";
            VillagesPlacedText.Size = new Size(378, 35);
            VillagesPlacedText.TabIndex = 9;
            VillagesPlacedText.Text = "label2";
            VillagesPlacedText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ServersJoinedText
            // 
            ServersJoinedText.AutoSize = true;
            ServersJoinedText.Dock = DockStyle.Fill;
            ServersJoinedText.Font = new Font("Consolas", 12F);
            ServersJoinedText.Location = new Point(0, 283);
            ServersJoinedText.Margin = new Padding(0);
            ServersJoinedText.Name = "ServersJoinedText";
            ServersJoinedText.Size = new Size(378, 35);
            ServersJoinedText.TabIndex = 10;
            ServersJoinedText.Text = "label3";
            ServersJoinedText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettlementPhasesUnplayableText
            // 
            SettlementPhasesUnplayableText.AutoSize = true;
            SettlementPhasesUnplayableText.Dock = DockStyle.Fill;
            SettlementPhasesUnplayableText.Font = new Font("Consolas", 12F);
            SettlementPhasesUnplayableText.Location = new Point(0, 493);
            SettlementPhasesUnplayableText.Margin = new Padding(0);
            SettlementPhasesUnplayableText.Name = "SettlementPhasesUnplayableText";
            SettlementPhasesUnplayableText.Size = new Size(378, 35);
            SettlementPhasesUnplayableText.TabIndex = 16;
            SettlementPhasesUnplayableText.Text = "Settlement Phases Unplayable: 12345";
            SettlementPhasesUnplayableText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettlementPhasesLostText
            // 
            SettlementPhasesLostText.AutoSize = true;
            SettlementPhasesLostText.Dock = DockStyle.Fill;
            SettlementPhasesLostText.Font = new Font("Consolas", 12F);
            SettlementPhasesLostText.Location = new Point(0, 458);
            SettlementPhasesLostText.Margin = new Padding(0);
            SettlementPhasesLostText.Name = "SettlementPhasesLostText";
            SettlementPhasesLostText.Size = new Size(378, 35);
            SettlementPhasesLostText.TabIndex = 15;
            SettlementPhasesLostText.Text = "label8";
            SettlementPhasesLostText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettlementPhasesWonText
            // 
            SettlementPhasesWonText.AutoSize = true;
            SettlementPhasesWonText.Dock = DockStyle.Fill;
            SettlementPhasesWonText.Font = new Font("Consolas", 12F);
            SettlementPhasesWonText.Location = new Point(0, 423);
            SettlementPhasesWonText.Margin = new Padding(0);
            SettlementPhasesWonText.Name = "SettlementPhasesWonText";
            SettlementPhasesWonText.Size = new Size(378, 35);
            SettlementPhasesWonText.TabIndex = 14;
            SettlementPhasesWonText.Text = "label7";
            SettlementPhasesWonText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExplorationPhasesLostText
            // 
            ExplorationPhasesLostText.AutoSize = true;
            ExplorationPhasesLostText.Dock = DockStyle.Fill;
            ExplorationPhasesLostText.Font = new Font("Consolas", 12F);
            ExplorationPhasesLostText.Location = new Point(0, 388);
            ExplorationPhasesLostText.Margin = new Padding(0);
            ExplorationPhasesLostText.Name = "ExplorationPhasesLostText";
            ExplorationPhasesLostText.Size = new Size(378, 35);
            ExplorationPhasesLostText.TabIndex = 13;
            ExplorationPhasesLostText.Text = "label6";
            ExplorationPhasesLostText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExplorationPhasesWonText
            // 
            ExplorationPhasesWonText.AutoSize = true;
            ExplorationPhasesWonText.Dock = DockStyle.Fill;
            ExplorationPhasesWonText.Font = new Font("Consolas", 12F);
            ExplorationPhasesWonText.Location = new Point(0, 353);
            ExplorationPhasesWonText.Margin = new Padding(0);
            ExplorationPhasesWonText.Name = "ExplorationPhasesWonText";
            ExplorationPhasesWonText.Size = new Size(378, 35);
            ExplorationPhasesWonText.TabIndex = 12;
            ExplorationPhasesWonText.Text = "label5";
            ExplorationPhasesWonText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GamesPlayedText
            // 
            GamesPlayedText.AutoSize = true;
            GamesPlayedText.Dock = DockStyle.Fill;
            GamesPlayedText.Font = new Font("Consolas", 12F);
            GamesPlayedText.Location = new Point(0, 318);
            GamesPlayedText.Margin = new Padding(0);
            GamesPlayedText.Name = "GamesPlayedText";
            GamesPlayedText.Size = new Size(378, 35);
            GamesPlayedText.TabIndex = 11;
            GamesPlayedText.Text = "label4";
            GamesPlayedText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(515, 708);
            label1.Name = "label1";
            label1.Size = new Size(240, 12);
            label1.TabIndex = 6;
            label1.Text = "please make sure your display is 16:9 or close enough";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2560, 720);
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
        private Label label1;
    }
}