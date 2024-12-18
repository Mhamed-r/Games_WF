using System.Runtime.CompilerServices;
using Timer = System.Threading.Timer;

namespace Memory_Matching_Game
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            Load_tiles();
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int Score = 0;
        int x = 0;
        int y = 0;
        int count = 0;
        Random rnd = new Random();
        private void Load_tiles() {

            PictureBox[] Tile = new PictureBox[100];
            for (int i = 0; i < Tile.Length; i++)
            {
                int num= rnd.Next(0,2);
                Tile[i]=new PictureBox();
                Tile[i].Height = 40;
                Tile[i].Width = 40;
                Tile[i].Left = x;
                Tile[i].Top=y;
                Tile[i].BorderStyle = BorderStyle.FixedSingle;
                Tile[i].Image=imageList1.Images[2];
                if (num==0)  Tile[i].Tag = "Boom";
                else Tile[i].Tag = "Flag";
                Tile[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Tile[i].Click += new System.EventHandler(Click);
                PL_Game.Controls.Add(Tile[i]);
                x += 40;
                count++;
                if (count==10)
                {
                    x = 0;
                    y += 40;
                    count=0;
                }

            }
       
    }

        private void Click(object sender, EventArgs e)
        {
            PictureBox Pics = (PictureBox)sender;

            if (Pics.Tag.ToString() == "Boom") { Pics.Image = imageList1.Images[0]; Score -= 5; }

            else { 
                Pics.Image = imageList1.Images[1];
            Score+=5;
            }
           
            if (Score<=0)
            {
                Score = 0;
                MessageBox.Show("Game Over");
                
               // Load_tiles();

                //for (int i = 0; i < 100; i++)
                //{
                //    Pics[i].Image = imageList1.Images[2];
                //}


            }
            Lb_Score.Text = Score.ToString();
        }
    }
}
