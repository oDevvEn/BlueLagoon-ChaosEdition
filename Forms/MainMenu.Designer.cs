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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            Username = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlayButton.Font = new Font("Segoe UI", 90F, FontStyle.Regular, GraphicsUnit.Document);
            PlayButton.ImeMode = ImeMode.NoControl;
            PlayButton.Location = new Point(100, 298);
            PlayButton.Margin = new Padding(20);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(200, 48);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Play AI";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // StatisticsButton
            // 
            StatisticsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatisticsButton.Font = new Font("Segoe UI", 90F, FontStyle.Regular, GraphicsUnit.Document);
            StatisticsButton.ImeMode = ImeMode.NoControl;
            StatisticsButton.Location = new Point(100, 386);
            StatisticsButton.Margin = new Padding(20);
            StatisticsButton.Name = "StatisticsButton";
            StatisticsButton.Size = new Size(200, 48);
            StatisticsButton.TabIndex = 2;
            StatisticsButton.Text = "Statistics";
            StatisticsButton.UseVisualStyleBackColor = true;
            StatisticsButton.Click += StatisticsButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            QuitButton.Font = new Font("Segoe UI", 90F, FontStyle.Regular, GraphicsUnit.Document);
            QuitButton.ImeMode = ImeMode.NoControl;
            QuitButton.Location = new Point(100, 474);
            QuitButton.Margin = new Padding(20);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(200, 48);
            QuitButton.TabIndex = 3;
            QuitButton.Text = "Rage Quit";
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += QuitButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(QuitButton, 1, 6);
            tableLayoutPanel1.Controls.Add(StatisticsButton, 1, 5);
            tableLayoutPanel1.Controls.Add(label1, 2, 7);
            tableLayoutPanel1.Controls.Add(PlayButton, 1, 4);
            tableLayoutPanel1.Controls.Add(Username, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.5454545F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.772727F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.772727F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.772727F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.772727F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.Size = new Size(800, 600);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(585, 585);
            label1.Name = "label1";
            label1.Size = new Size(212, 15);
            label1.TabIndex = 4;
            label1.Text = "game only tested with 16:9 screen ratio";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Username.Font = new Font("Segoe UI", 30F);
            Username.Location = new Point(100, 210);
            Username.Margin = new Padding(20);
            Username.MaxLength = 32;
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(200, 61);
            Username.TabIndex = 5;
            Username.Text = "fix me";
            Username.TextAlign = HorizontalAlignment.Center;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            Text = "MainMenu";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button PlayButton;
        private Button StatisticsButton;
        private Button QuitButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox Username;
    }
}