
namespace BankDeposits
{
    public partial class Captcha : Form
    {
        private string text = String.Empty;
        public Captcha()
        {
            InitializeComponent();
        }

        private Bitmap CreateImage(int Width, int Height)
        {           
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);        
            int Xpos = 10;
            int Ypos = 10;
            Brush[] colors = { Brushes.Black, Brushes.Red, Brushes.RoyalBlue, Brushes.Yellow, Brushes.Green, Brushes.White, Brushes.Tomato, Brushes.Sienna, Brushes.Pink };
            Pen[] colorpens = { Pens.Black, Pens.Red, Pens.RoyalBlue, Pens.Green, Pens.Yellow, Pens.White, Pens.Tomato, Pens.Sienna, Pens.Pink };
            FontStyle[] fontstyle = { FontStyle.Bold, FontStyle.Italic, FontStyle.Regular, FontStyle.Strikeout, FontStyle.Underline};
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };
            Graphics g = Graphics.FromImage((Image)result);
            g.Clear(Color.Gray);
            g.RotateTransform(rnd.Next(rotate.Length));
            string ALF = "7890QWERTYUIOPASDFGHJKLZXCVBNM";
            text = String.Empty;
            for (int i = 0; i < 5; ++i)
                  text += ALF[rnd.Next(ALF.Length)];
            g.DrawString(text,
            new Font("Arial", 25, fontstyle[rnd.Next(fontstyle.Length)]),
            colors[rnd.Next(colors.Length)],
            new PointF(Xpos, Ypos));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, 0),
            new Point(Width - 1, Height - 1));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
            new Point(0, Height - 1),
            new Point(Width - 1, 0));
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);
            return result;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (userInput.Text == this.text)
            {
                MessageBox.Show("Верно!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }               
        }

        private void update_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void Captcha_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }
    }
}
