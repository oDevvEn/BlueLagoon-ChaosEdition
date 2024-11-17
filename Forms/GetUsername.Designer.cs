namespace Blue_Lagoon___Chaos_Edition {
    partial class GetUsername {
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
            username = new TextBox();
            ConfirmButton = new Button();
            UsernameText = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 14F);
            username.Location = new Point(20, 65);
            username.MaxLength = 32;
            username.Name = "username";
            username.Size = new Size(344, 32);
            username.TabIndex = 0;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Font = new Font("Segoe UI", 15F);
            ConfirmButton.Location = new Point(127, 140);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(130, 44);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // UsernameText
            // 
            UsernameText.AutoSize = true;
            UsernameText.Font = new Font("Segoe UI", 18F);
            UsernameText.Location = new Point(74, 19);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(236, 32);
            UsernameText.TabIndex = 2;
            UsernameText.Text = "Enter your username";
            UsernameText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GetUsername
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(UsernameText);
            Controls.Add(ConfirmButton);
            Controls.Add(username);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(400, 250);
            MinimumSize = new Size(400, 250);
            Name = "GetUsername";
            Text = "Blue Lagoon - Chaos Edition";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConfirmButton;
        private Label UsernameText;
        internal TextBox username;
    }
}