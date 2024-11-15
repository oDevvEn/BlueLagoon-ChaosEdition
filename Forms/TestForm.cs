namespace Blue_Lagoon___Chaos_Edition {
    public partial class TestForm : Form {
        public TestForm() {
            InitializeComponent();
            FastNoiseLite noise = new FastNoiseLite();
            noise.SetNoiseType(FastNoiseLite.NoiseType.Perlin);

            long et1 = 0;
            long et2 = 0;
            long et3 = 0;
            long et4 = 0;
            long et5 = 0;
            long et6 = 0;

            for (int x = 0; x < 50; x++) {
                for (int y = 0; y < 50; y++) {
                    float value = noise.GetNoise(x*10, y*10) > .01 ? 1 : 0;
                    int color = (int)(value * 255);

                    long t1 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    Label lbl = new Label();
                    long t2 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    lbl.Location = new Point(x*15,y*10);
                    long t3 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    lbl.Text = value.ToString();
                    long t4 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    lbl.BackColor = Color.FromArgb(255, color, color, color);
                    long t5 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    lbl.ForeColor = Color.FromArgb(255, color, color, color);
                    long t6 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    this.Controls.Add(lbl);
                    long t7 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

                    et1 += t2 - t1;
                    et2 += t3 - t2;
                    et3 += t4 - t3;
                    et4 += t5 - t4;
                    et5 += t6 - t5;
                    et6 += t7 - t6;
                }
            }

            long et7 = 0;
            foreach (Control obj in this.Controls) {
                if (obj is Label) {
                    long t8 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
                    obj.Location = new Point(obj.Location.X+1, obj.Location.Y+1);
                    long t9 = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

                    et7 += t9 - t8;
                }
            }

            et1 = et1;
        }
    }
}
