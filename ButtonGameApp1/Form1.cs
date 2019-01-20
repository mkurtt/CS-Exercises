using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGameApp1
{
    public partial class Form1 : Form
    {
        private List<Tile> selections = new List<Tile>();

        public static int TotalTileCount = 30;

        public static string[] TotalTypes =
        {
            "X",
            "+",
            "O",
            "#",
            "@"
        };

        public static string[] RandomTypes;

        private static int[][] Connections =
        {
            new int[] {5, 0},
            new int[] {6, 1},
            new int[] {7, 2},
            new int[] {9, 0, 3},
            new int[] {10, 1, 4},
            new int[] {12, 2},
            new int[] {13, 3},
            new int[] {14, 4},
            new int[] {16, 5},
            new int[] {17, 7},
            new int[] {18, 6},
            new int[] {20, 8},
            new int[] {21, 9},
            new int[] {22, 7, 12},
            new int[] {23, 10},
            new int[] {24, 11},
            new int[] {26, 13},
            new int[] {27, 12},
            new int[] {28, 14}
        };

        private static Tile[] allTiles = new Tile[TotalTileCount];

        internal static Tile[] AllTiles { get => allTiles; set => allTiles = value; }
        internal List<Tile> Selections { get => selections; set => selections = value; }


        public int time { get; set; }

        private ErrorProvider ep { get; set; }


        public Form1()
        {
            InitializeComponent();
            FillWithTiles();
            FillConnections();
            SetRandomTypes();
            SetTileAction();

            time = 0;
            label1.Font = new Font("Arial", 18, FontStyle.Bold);
        }

        public void EnableLowerLayers()
        {
            int changeIndexLeft = -1; // 1
            int changeIndexRight = -1 ; // 2
            int i = 0;
            foreach (int[] conns in Connections)
            {
                if (conns.Length == 2)
                {
                    if (conns[1] == selections[0].ID || conns[1] == selections[1].ID)
                    {
                        foreach (var item in AllTiles)
                        {
                            if (item.ID == conns[0])
                            {
                                item.Enabled = true;
                                break;
                            }
                        }
                    }
                }
                else if (conns.Length == 3)
                {
                    if (conns[1] == selections[0].ID || conns[1] == selections[1].ID)
                    {
                        changeIndexRight = i;
                    }
                    if (conns[2] == selections[0].ID || conns[2] == selections[1].ID)
                    {
                        changeIndexLeft = i;
                    }
                }

                if(changeIndexRight >= 0)
                {
                    Connections[changeIndexRight] = new int[] { conns[0], conns[2] };
                    changeIndexRight = -1;
                    EnableLowerLayers();
                }
                else if (changeIndexLeft >= 0)
                {
                    Connections[changeIndexLeft] = new int[] { conns[0], conns[1] };
                    changeIndexLeft = -1;
                    EnableLowerLayers();
                }

                i++;
            }
        }

        public void CheckSelectedTiles()
        {
            if (selections[0].type == selections[1].type)
            {
                selections[0].Enabled = false;
                selections[0].Visible = false;
                selections[1].Enabled = false;
                selections[1].Visible = false;
                EnableLowerLayers();
            }
            selections[0].IsSelected = false;
            selections[1].IsSelected = false;
            selections.Clear();
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            Tile t = sender as Tile;

            if (t.IsSelected)
            {
                return;
            }

            t.IsSelected = true;

            selections.Add(t);

            if (selections.Count == 2)
                CheckSelectedTiles();

            bool end = true;
            foreach (var item in AllTiles)
            {
                if (item.Enabled == true)
                {
                    end = false;
                }
            }

            if (end)
            {
                timer1.Stop();
                MessageBox.Show("Congratz! Time: " + time);
            }

        }

        public void SetTileAction()
        {
            foreach (var item in AllTiles)
            {
                item.Click += new EventHandler(Tile_Click);
            }
        }

        public void SetRandomTypes()
        {
            Random rnd = new Random();
            RandomTypes = new string[TotalTileCount / 2];

            for (int i = 0; i < TotalTileCount / 2; i++)
            {
                RandomTypes[i] = TotalTypes[rnd.Next(5)];
            }


            List<int> rndList = new List<int>();


            while (rndList.Count < TotalTileCount)
            {
                int a = rnd.Next(TotalTileCount);
                if (!rndList.Contains(a))
                    rndList.Add(a);
            }

            foreach (var i in rndList)
            {
                if (i >= 15)
                {
                    AllTiles[i].type = RandomTypes[i - 15];
                }
                else
                {
                    AllTiles[i].type = RandomTypes[i];
                }

            }

        }

        public void FillConnections()
        {
            foreach (int[] conns in Connections)
            {
                AllTiles[conns[0]].OnTop.Add(AllTiles[conns[1]]);
                if (conns.Length == 3)
                {
                    AllTiles[conns[0]].OnTop.Add(AllTiles[conns[2]]);
                }

                AllTiles[conns[0]].Enabled = false;
            }
        }

        public void FillWithTiles()
        {


            int X = 0;
            int Y = 0;


            int LineCounter = 0; ;

            for (int i = 0; i < TotalTileCount; i++)
            {
                
                if (i < 5)
                {
                    AllTiles[i] = new Tile(Layers.layer1);
                    AllTiles[i].ID = i;


                    if (i == 0)
                    {
                        X = 6;
                        X += AllTiles[i].Width + 6;
                        Y = 6;
                        Y += AllTiles[i].Height / 2 + 3;
                    }

                    Point loc = new Point(X, Y);

                    Controls.Add(AllTiles[i]);
                    AllTiles[i].Location = loc;

                    if (i == 0 || i == 3)
                    {
                        X += AllTiles[i].Width + 6;
                        X += AllTiles[i].Width + 6;
                    }

                    else if (i == 1)
                    {
                        X -= AllTiles[i].Width + 6;
                        Y += AllTiles[i].Height / 2 + 3;
                    }

                    else if (i == 2)
                    {
                        X -= AllTiles[i].Width + 6;
                        Y += AllTiles[i].Height / 2 + 3;
                    }

                }
                else if (i < 15)
                {
                    AllTiles[i] = new Tile(Layers.layer2);
                    AllTiles[i].ID = i;

                    if (i == 5)
                    {
                        X = 6;
                        X += AllTiles[i].Width + 6;
                        Y = 6;
                    }

                    Point loc = new Point(X, Y);

                    Controls.Add(AllTiles[i]);
                    AllTiles[i].Location = loc;

                    if (i == 5 || i == 9 || i == 13)
                    {
                        X += AllTiles[i].Width + 6;
                        X += AllTiles[i].Width + 6;
                    }


                    else if (i == 6 || i == 11)
                    {
                        X = 6;
                        X += AllTiles[i].Width + 6;
                        X += AllTiles[i].Width + 6;
                        Y += AllTiles[i].Height / 2 + 3;
                    }

                    else if (i == 7)
                    {
                        X = 6;
                        Y = 6;
                        Y += AllTiles[i].Height + 6;
                    }

                    else if (i == 8 || i == 10)
                    {
                        X += AllTiles[i].Width + 6;
                    }

                    else if (i == 12)
                    {
                        X = 6;
                        Y = 6;
                        X += AllTiles[i].Width + 6;
                        Y += AllTiles[i].Height + 6;
                        Y += AllTiles[i].Height + 6;
                    }

                }
                else
                {
                    AllTiles[i] = new Tile(Layers.layer3);
                    AllTiles[i].ID = i;
                    if (i == 15)
                    {
                        X = 6;
                        Y = 6;
                        LineCounter = 0;
                    }

                    Point loc = new Point(X, Y);

                    Controls.Add(AllTiles[i]);

                    AllTiles[i].Location = loc;

                    X += AllTiles[i].Width + 6;
                    LineCounter++;
                    if (LineCounter >= 5)
                    {
                        LineCounter = 0;
                        Y += AllTiles[i].Height + 6;
                        X = 6;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ep = new ErrorProvider();
            ep.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            if(textBox1.Text.Trim() == "")
                ep.SetError(textBox1, "This area must be filled!");
            else
            {
                btnStart.Enabled = false;
                btnStart.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            this.Text = $"{textBox1.Text}, Time: {time}";
        }
    }
}

