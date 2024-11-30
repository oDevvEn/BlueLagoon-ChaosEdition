namespace Blue_Lagoon___Chaos_Edition {
    public partial class GetConnectionInfo : Form {
        public bool successful = false;

        public GetConnectionInfo() {
            InitializeComponent();

            // Retrieve data from file & put in textboxes
            if (File.Exists("server.txt")) {
                string[] text = File.ReadAllLines("server.txt");

                if (text.Length == 3) {
                    if (!string.IsNullOrWhiteSpace(text[0]))
                        username.Text = text[0].Length > 32 ? text[0][..32] : text[0];
                    if (!string.IsNullOrWhiteSpace(text[1]))
                        ipAddress.Text = text[1].Length > 32767 ? text[1][..32767] : text[1];
                    if (!string.IsNullOrWhiteSpace(text[2]) && int.TryParse(text[2], out _))
                        port.Text = text[2].Length > 5 ? text[2][..5] : text[2];
                }
                else
                    port.Text = "60420";
            }
            else
                port.Text = "60420";
        }

        // Store data in a file from textboxes
        private void ConfirmButton_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(username.Text) && !string.IsNullOrWhiteSpace(ipAddress.Text) && int.TryParse(port.Text, out _)) {
                using (StreamWriter file = new StreamWriter("server.txt", false)) {
                    file.WriteLine(username.Text);
                    file.WriteLine(ipAddress.Text);
                    file.WriteLine(port.Text);
                }

                successful = true;
                this.Close();
            }
        }
    }
}
