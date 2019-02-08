public partial class Form1 : Form
    {
        static public PictureBox pb = new PictureBox();

        public Form1()
        {
            InitializeComponent();

            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Location = new System.Drawing.Point(0, 0);
            pb.Size = this.ClientSize;

            Image img = Image.FromFile("C:\\Users\\pc\\source\\repos\\SlidePicture\\SlidePicture\\bin\\background.bmp");
            pb.Image = img;

            this.Controls.Add(pb);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(PictureSlide);
            t.Start();
        }

        public void PictureSlide()
        {
            

            while (true)
            {
                Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

                Rectangle rectLast = new Rectangle(this.ClientSize.Width - 1, 0, 1, this.ClientSize.Height);
                Rectangle rectRest = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height);

                pb.DrawToBitmap(bmp, rectLast);
                pb.DrawToBitmap(bmp, rectRest);

                pb.Image = bmp;
            }
        }

        
    }
