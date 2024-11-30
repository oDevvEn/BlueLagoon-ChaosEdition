namespace Blue_Lagoon___Chaos_Edition {
    partial class GetConnectionInfo {
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
            ServerText = new Label();
            ipAddress = new TextBox();
            port = new TextBox();
            SuspendLayout();
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 14F);
            username.Location = new Point(144, 21);
            username.MaxLength = 32;
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(228, 32);
            username.TabIndex = 0;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Font = new Font("Segoe UI", 16F);
            ConfirmButton.Location = new Point(127, 145);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(130, 44);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "Connect";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // UsernameText
            // 
            UsernameText.AutoSize = true;
            UsernameText.Font = new Font("Segoe UI", 18F);
            UsernameText.Location = new Point(12, 21);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(126, 32);
            UsernameText.TabIndex = 2;
            UsernameText.Text = "Username:";
            UsernameText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ServerText
            // 
            ServerText.AutoSize = true;
            ServerText.Font = new Font("Segoe UI", 18F);
            ServerText.Location = new Point(52, 63);
            ServerText.Name = "ServerText";
            ServerText.Size = new Size(86, 32);
            ServerText.TabIndex = 3;
            ServerText.Text = "Server:";
            ServerText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ipAddress
            // 
            ipAddress.Font = new Font("Segoe UI", 14F);
            ipAddress.Location = new Point(144, 66);
            ipAddress.Name = "ipAddress";
            ipAddress.PlaceholderText = "IP Address";
            ipAddress.Size = new Size(157, 32);
            ipAddress.TabIndex = 4;
            ipAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // port
            // 
            port.Font = new Font("Segoe UI", 14F);
            port.Location = new Point(307, 66);
            port.MaxLength = 5;
            port.Name = "port";
            port.PlaceholderText = "Port";
            port.Size = new Size(65, 32);
            port.TabIndex = 5;
            port.TextAlign = HorizontalAlignment.Center;
            // 
            // GetUsername
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(port);
            Controls.Add(ipAddress);
            Controls.Add(ServerText);
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
        private Label ServerText;
        internal TextBox ipAddress;
        internal TextBox port;
    }
}