namespace Blue_Lagoon___Chaos_Edition {
    public partial class GetUsername : Form {
        public bool successful = false;

        public GetUsername() {
            InitializeComponent();

            if (!File.Exists("username.txt"))
                File.Create("username.txt").Close();
            else {
                string text = File.ReadAllText("username.txt");
                if (!string.IsNullOrWhiteSpace(text)) {
                    if (text.Length > 32)
                        text.Substring(0, 32);

                    username.Text = text;
                }
            }

        }

        private void ConfirmButton_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(username.Text)) {
                StreamWriter file = new StreamWriter("D:/log.txt", false);
                file.WriteLine(username.Text);
                file.Close();

                successful = true;
                this.Close();
            }
        }
    }
}
