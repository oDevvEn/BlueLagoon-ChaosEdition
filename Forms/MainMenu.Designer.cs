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
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // PlayButton
            // 
            PlayButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlayButton.Font = new Font("Segoe UI", 90F, FontStyle.Regular, GraphicsUnit.Document);
            PlayButton.ImeMode = ImeMode.NoControl;
            PlayButton.Location = new Point(100, 241);
            PlayButton.Margin = new Padding(20);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(200, 64);
            PlayButton.TabIndex = 0;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // StatisticsButton
            // 
            StatisticsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatisticsButton.Font = new Font("Segoe UI", 90F, FontStyle.Regular, GraphicsUnit.Document);
            StatisticsButton.ImeMode = ImeMode.NoControl;
            StatisticsButton.Location = new Point(100, 345);
            StatisticsButton.Margin = new Padding(20);
            StatisticsButton.Name = "StatisticsButton";
            StatisticsButton.Size = new Size(200, 64);
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
            QuitButton.Location = new Point(100, 449);
            QuitButton.Margin = new Padding(20);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(200, 64);
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
            tableLayoutPanel1.Controls.Add(QuitButton, 1, 5);
            tableLayoutPanel1.Controls.Add(StatisticsButton, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 2, 6);
            tableLayoutPanel1.Controls.Add(PlayButton, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6666651F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.33333254F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.333334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6666651F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 600);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(526, 585);
            label1.Name = "label1";
            label1.Size = new Size(271, 15);
            label1.TabIndex = 4;
            label1.Text = "game only tested with 16:9 screen ratio (1366x768)";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 95F, FontStyle.Regular, GraphicsUnit.Document);
            label2.Location = new Point(85, 68);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(230, 117);
            label2.TabIndex = 5;
            label2.Text = "Blue Lagoon (Chaos Edition)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
        private Label label2;
    }
}