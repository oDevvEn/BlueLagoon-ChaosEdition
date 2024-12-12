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
            username.BackColor = Color.FromArgb(30, 30, 30);
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 14F);
            username.ForeColor = Color.White;
            username.Location = new Point(144, 28);
            username.MaxLength = 32;
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(228, 25);
            username.TabIndex = 0;
            username.TextAlign = HorizontalAlignment.Center;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.FromArgb(30, 30, 30);
            ConfirmButton.FlatAppearance.BorderColor = Color.FromArgb(34, 34, 34);
            ConfirmButton.FlatAppearance.BorderSize = 2;
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.Font = new Font("Segoe UI", 16F);
            ConfirmButton.ForeColor = Color.White;
            ConfirmButton.Location = new Point(127, 145);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(130, 44);
            ConfirmButton.TabIndex = 1;
            ConfirmButton.Text = "Connect";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // UsernameText
            // 
            UsernameText.AutoSize = true;
            UsernameText.Font = new Font("Segoe UI", 18F);
            UsernameText.ForeColor = Color.White;
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
            ServerText.ForeColor = Color.White;
            ServerText.Location = new Point(52, 63);
            ServerText.Name = "ServerText";
            ServerText.Size = new Size(86, 32);
            ServerText.TabIndex = 3;
            ServerText.Text = "Server:";
            ServerText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ipAddress
            // 
            ipAddress.BackColor = Color.FromArgb(30, 30, 30);
            ipAddress.BorderStyle = BorderStyle.None;
            ipAddress.Font = new Font("Segoe UI", 14F);
            ipAddress.ForeColor = Color.White;
            ipAddress.Location = new Point(144, 70);
            ipAddress.Name = "ipAddress";
            ipAddress.PlaceholderText = "IP Address";
            ipAddress.Size = new Size(157, 25);
            ipAddress.TabIndex = 4;
            ipAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // port
            // 
            port.BackColor = Color.FromArgb(30, 30, 30);
            port.BorderStyle = BorderStyle.None;
            port.Font = new Font("Segoe UI", 14F);
            port.ForeColor = Color.White;
            port.Location = new Point(307, 70);
            port.MaxLength = 5;
            port.Name = "port";
            port.PlaceholderText = "Port";
            port.Size = new Size(65, 25);
            port.TabIndex = 5;
            port.TextAlign = HorizontalAlignment.Center;
            port.TextChanged += port_TextChanged;
            // 
            // GetConnectionInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
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
            Name = "GetConnectionInfo";
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