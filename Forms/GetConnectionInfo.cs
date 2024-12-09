namespace Blue_Lagoon___Chaos_Edition {
    public partial class GetConnectionInfo : Form {
        public bool successful = false;

        public GetConnectionInfo() {
            InitializeComponent();

            // Scale UI
            this.Scale(Program.scaleSizeF);
            foreach (Control control in this.Controls)
                if (control is Label || control is TextBox || control is Button)
                    Program.ScaleUI(control);

            if (File.Exists("server.txt")) {
                // Retrieve data from file
                string[] text = File.ReadAllLines("server.txt");

                // Put data in textboxes
                if (text.Length == 3) {
                    if (!string.IsNullOrWhiteSpace(text[0]))
                        username.Text = text[0].Length > 32 ? text[0][..32] : text[0];
                    if (!string.IsNullOrWhiteSpace(text[1]))
                        ipAddress.Text = text[1].Length > 32767 ? text[1][..32767] : text[1];
                    if (!string.IsNullOrWhiteSpace(text[2]) && int.TryParse(text[2], out _)) {
                        port.Text = text[2].Length > 5 ? text[2][..5] : text[2];
                        previousPortText = port.Text;
                    }
                }

                // Put placeholders if no valid data
                else
                    port.Text = "60420";
            }
            else
                port.Text = "60420";
        }

        #region Partial input sanitisation (ensure int entered)
        string previousPortText = "60420";
        private void port_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(port.Text, out _))
                previousPortText = port.Text;
            else
                port.Text = previousPortText;
        }
        #endregion

        #region Confirm Button
        private void ConfirmButton_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(username.Text) && !string.IsNullOrWhiteSpace(ipAddress.Text) && int.TryParse(port.Text, out _)) {
                // Store connection in file for next time
                using (StreamWriter file = new StreamWriter("server.txt", false)) {
                    file.WriteLine(username.Text);
                    file.WriteLine(ipAddress.Text);
                    file.WriteLine(port.Text);
                }

                // Exit
                successful = true;
                this.Close();
            }
        }
        #endregion
    }
}
