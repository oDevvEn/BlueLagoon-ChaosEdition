namespace Blue_Lagoon___Chaos_Edition {
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
            Game.mainMenu = this;
            Game.displaySize = this.Size.Height * 17 / 13;
        }

        private void QuitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            GetConnectionInfo connectionInfo = new GetConnectionInfo();
            connectionInfo.ShowDialog();
            if (connectionInfo.successful) {
                Game game = new Game(connectionInfo.username.Text, connectionInfo.ipAddress.Text, int.Parse(connectionInfo.port.Text));
                if (!game.IsDisposed) { 
                    game.Show();
                    this.Hide();
                }
            }
        }

        private void StatisticsButton_Click(object sender, EventArgs e) {
            StatisticsMenu statisticsMenu = new StatisticsMenu();
            statisticsMenu.Show();
            this.Hide();
        }
    }
}
