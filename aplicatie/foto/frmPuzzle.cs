using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace foto
{
    public partial class frmPuzzle : Form
    {
        public frmPuzzle()
        {
            InitializeComponent();
        }
        //------------------------------------------------------  <design>
        void bordura(int grosime)
        {
            sus.Size = jos.Size = new Size(this.Width, grosime);
            st.Size = dr.Size = new Size(grosime, this.Height);
            sus.Location = new Point(0, 0);
            jos.Location = new Point(0, this.Height - 5);
            st.Location = new Point(0, 0);
            dr.Location = new Point(this.Width - 5, 0);
            lblClose.Location = new Point(this.Width - 5 - lblClose.Width, 5);
        }
        Point lastPoint;
        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //------------------------------------------------------ </design>
        string[] fisiere = new string[100];
        int nrFisiere = 0, primul, ultimul;

        int prim = -1, ultim = -1, mutari = 0;
        int[] pozitii = new int[100];
        private MainMenu ImageMenu;
        private MenuItem FileMenu;
        private MenuItem FileOpen;
        private MenuItem FileExit;
        private Bitmap ImageFile;
        private int ImageSize;
        private int SmallImageSize=80;
        private const int PIECECOUNT = 3;//16;
        private PictureBox[] Viewer = new PictureBox[PIECECOUNT * PIECECOUNT];
        private int OffSetX=100;
        private int OffSetY=75;
        private Rectangle ImageRect;
        private Button Shuffle;
        private Button MoveLeft;
        private Button MoveRight;
        private Button MoveTop;
        private Button MoveBottom;
        private Button Reset;
        private int EmptyElementIndex = PIECECOUNT * PIECECOUNT + 1;//- 1;
        private ToolTip HelpText = new ToolTip();
        private void frmPuzzle_Load(object sender, EventArgs e)
        {
           // InitializeComponent();
            bordura(5);
            /*FileMenu = new MenuItem();
            FileMenu.Text = "&File";

            FileOpen = new MenuItem();
            FileOpen.Text = "&Open...";
            FileOpen.Click += new EventHandler(Menu_Click);

            FileExit = new MenuItem();
            FileExit.Text = "E&xit";
            FileExit.Click += new EventHandler(Menu_Click);

            FileMenu.MenuItems.Add(FileOpen);
            FileMenu.MenuItems.Add("-");
            FileMenu.MenuItems.Add(FileExit);
            

            ImageMenu = new MainMenu(new MenuItem[] { FileMenu });
            this.Menu = ImageMenu;
            this.AutoScroll = true;*/

           /* Shuffle = new Button();
            Shuffle.Text = "Amesteca";
            Shuffle.Location = new Point(160, 15);
            Shuffle.Enabled = false;
            Shuffle.Font = label1.Font;
            Shuffle.Size = new Size(80,40);
            Shuffle.Click += new EventHandler(Shuffle_Click);
            Shuffle.BackgroundImage = new Bitmap("imagini/redd.jpg");
           //Shuffle.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(Shuffle);
            

            MoveTop = new Button();
            MoveTop.Text = "T";
            MoveTop.Enabled = false;
            MoveTop.Location = new Point(Shuffle.Left + Shuffle.Width + 50, 0);
            MoveTop.Click += new EventHandler(Direction_Click);
            MoveTop.Size = new Size(24, 24);
            this.Controls.Add(MoveTop);
            MoveTop.Visible = false;

            MoveBottom = new Button();
            MoveBottom.Text = "B";
            MoveBottom.Enabled = false;
            MoveBottom.Location = new Point(MoveTop.Left, MoveTop.Top + MoveTop.Height * 2 + 5);
            MoveBottom.Click += new EventHandler(Direction_Click);
            MoveBottom.Size = new Size(24, 24);
            this.Controls.Add(MoveBottom);
            MoveBottom.Visible = false;


            MoveLeft = new Button();
            MoveLeft.Text = "L";
            MoveLeft.Enabled = false;
            MoveLeft.Location = new Point(MoveTop.Left - MoveTop.Width, MoveTop.Top + MoveTop.Height + 3);
            MoveLeft.Click += new EventHandler(Direction_Click);
            MoveLeft.Size = new Size(24, 24);
            this.Controls.Add(MoveLeft);
            MoveLeft.Visible = false;


            MoveRight = new Button();
            MoveRight.Text = "R";
            MoveRight.Enabled = false;
            MoveRight.Location = new Point(MoveTop.Left + MoveTop.Width, MoveLeft.Top);
            MoveRight.Size = new Size(24, 24);
            MoveRight.Click += new EventHandler(Direction_Click);
            this.Controls.Add(MoveRight);
            MoveRight.Visible = false;


            Reset = new Button();
            Reset.Text = "&Reset";
            Reset.Location = new Point(MoveRight.Left + MoveRight.Width + 15, Shuffle.Top);
            Reset.Click += new EventHandler(Reset_Click);
            Reset.Enabled = false;
            Reset.BackgroundImage = new Bitmap("imagini/green.jpg");
            this.Controls.Add(Reset);
            Reset.Size = new Size(80, 40);
            Reset.Font = label1.Font;
            */
            OffSetX = 0;
            OffSetY = 75;

            for (int i = 0; i < Viewer.Length; i++)
            {
                Viewer[i] = new PictureBox();
                Viewer[i].Tag = i.ToString();
                this.Controls.Add(Viewer[i]);
                pozitii[i] = i;
                Viewer[i].Click += new System.EventHandler(img_Click);
            }

            fisiere = Directory.GetFiles(Application.StartupPath + "/img/puzzle");
            nrFisiere = fisiere.Length;
            if (nrFisiere == 0)
                return;

            pb1.Image = new Bitmap(fisiere[0]);
            pb2.Image = new Bitmap(fisiere[1]);
            pb3.Image = new Bitmap(fisiere[2]);
            primul = 0;
            ultimul = 2;
            pb1_Click(null, null);
          //  pb1.BringToFront();
        //    pb2.BringToFront();
          //  pb3.BringToFront();



        }
        private void img_Click(object sender, EventArgs e)
        {
            int poz = Convert.ToInt16(((PictureBox)(sender)).Tag);
        
            if (prim == -1)
            {
                prim = poz;
  
            }
            else
                if (ultim == -1)
                {
                    ultim = poz;
                    schimba(prim, ultim);
       
                    //int aux = pozitii[prim]; pozitii[prim] = pozitii[ultim]; pozitii[ultim] = aux;
                    schimb_int(prim, ultim);
                    mutari += (prim != ultim ? 1 : 0);
                    prim = ultim = -1;
                    // pune();
                    castiga();
                }
        }

        private void castiga()
        {
            int ok = 1, i;
            for (i = 0; i < Viewer.Length && ok == 1; i++)
                if (pozitii[i] != i)
                    ok = 0;
            if (ok == 1)
            {
                MessageBox.Show("Ai terminat!", "Din " + mutari + " mutari", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                for (i = 0; i < Viewer.Length ; i++)
                    pozitii[i] = i;
                mutari = 0; 

            }

        }

        void schimba(int i, int j)
        {
            Image aux = Viewer[i].Image;
            Viewer[i].Image = Viewer[j].Image;
            Viewer[j].Image = aux;
        }
        public void ImageGame()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.RestoreDirectory = true;
            dlgOpen.Filter = "Bitmap  JPEG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif| Files(*.bmp)|*.bmp";
            dlgOpen.FilterIndex = 1;
            dlgOpen.InitialDirectory = Application.StartupPath;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                Shuffle.Enabled = true;
                Reset.Enabled = true;
                ImageFile = new Bitmap(dlgOpen.FileName);
                ImageSize = (ImageFile.Width < ImageFile.Height) ? ImageFile.Width : ImageFile.Height;
                ImageSize = ImageSize - ImageSize % PIECECOUNT;
                SmallImageSize = ImageSize / PIECECOUNT;
                Reset_Click(null, null);
            }
        }

       /* public void Menu_Click(object sender, EventArgs e)
        {
            if (sender == FileOpen)
            {
                OpenFileDialog dlgOpen = new OpenFileDialog();
                dlgOpen.RestoreDirectory = true;
                dlgOpen.Filter = "Bitmap  JPEG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif| Files(*.bmp)|*.bmp";
                dlgOpen.FilterIndex = 1;
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    Shuffle.Enabled = true;
                    Reset.Enabled = true;
                    ImageFile = new Bitmap(dlgOpen.FileName);
                    ImageSize = (ImageFile.Width < ImageFile.Height) ? ImageFile.Width : ImageFile.Height;
                    ImageSize = ImageSize - ImageSize % PIECECOUNT;
                    SmallImageSize = ImageSize / PIECECOUNT;
                    Reset_Click(null, null);
                }
            }
            if (sender == FileExit)
            {
                this.Dispose();
                Application.Exit();
            }
        }*/

        public void incarca()
        {
            
              //  Shuffle.Enabled = true;
              //  Reset.Enabled = true;
              //  ImageFile = new Bitmap(dlgOpen.FileName);
                ImageSize = (ImageFile.Width < ImageFile.Height) ? ImageFile.Width : ImageFile.Height;
                ImageSize = ImageSize - ImageSize % PIECECOUNT;
                SmallImageSize = ImageSize / PIECECOUNT;
                Reset_Click(null, null);
        }
        public void Reset_Click(object sender, EventArgs e)
        {
            prim = ultim = -1;
            if (ImageFile != null)
            {
                int ElementIndex = 0;
                for (int j = 0; j < PIECECOUNT; j++)
                {
                    for (int i = 0; i < PIECECOUNT; i++)
                    {
                        try
                        {
                            ImageRect = new Rectangle(i * SmallImageSize, j * SmallImageSize, SmallImageSize, SmallImageSize);
                            Viewer[ElementIndex].Image = null;
                            if (ElementIndex != Viewer.Length)//- 1)
                                Viewer[ElementIndex].Image = ImageFile.Clone(ImageRect, PixelFormat.DontCare);
                            Viewer[ElementIndex].Location = new Point(OffSetX + i * SmallImageSize+200, OffSetY + j * SmallImageSize + 1);
                            Viewer[ElementIndex].Size = new Size(SmallImageSize + 1, SmallImageSize + 1);
                            Viewer[ElementIndex].Tag = ElementIndex.ToString();

                            HelpText.SetToolTip(Viewer[ElementIndex], ElementIndex.ToString());
                            ElementIndex++;
                            this.Invalidate();

                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
           // Shuffle.Enabled = true;
            EmptyElementIndex = PIECECOUNT * PIECECOUNT + 1;// -1;
            for (int i = 0; i < Viewer.Length; i++)
                pozitii[i] = i;
            mutari = 0;
        }
        public void schimb_int(int i, int j)
        {
            int aux = pozitii[i];
            pozitii[i] = pozitii[j];
            pozitii[j] = aux;
        }

        public void Shuffle_Click(object sender, EventArgs e)
        {
            /*MoveLeft.Enabled = true;
            MoveRight.Enabled = true;
            MoveTop.Enabled = true;
            MoveBottom.Enabled = true;
            Shuffle.Enabled = false;
            Reset.Enabled = true;*/
            Bitmap temp;
            string temptag;
            int aux1, aux2;
            for (int j = 0; j < PIECECOUNT; j++)
            {
                for (int i = j + 1; i < PIECECOUNT; i++)
                {
                    try
                    {
                        temp = (Bitmap)Viewer[j * PIECECOUNT + i].Image;
                        temptag = Viewer[j * PIECECOUNT + i].Tag.ToString();
                        Viewer[j * PIECECOUNT + i].Image = Viewer[i * PIECECOUNT + j].Image;
                        aux1 = j * PIECECOUNT + i;

                        HelpText.SetToolTip(Viewer[j * PIECECOUNT + i], Viewer[j * PIECECOUNT + i].Tag.ToString());
                        Viewer[i * PIECECOUNT + j].Image = temp;
                        aux2 = i * PIECECOUNT + j;
                        // Viewer[i * PIECECOUNT + j].Tag = temptag;
                        schimb_int(aux1, aux2);
                        HelpText.SetToolTip(Viewer[i * PIECECOUNT + j], Viewer[i * PIECECOUNT + j].Tag.ToString());
                        this.Invalidate();
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        public void Direction_Click(object sender, EventArgs e)
        {
            Bitmap temp;
            string temptag;
            int IndexToSwap = -1;

            if (sender == MoveLeft)
            {
                if (IsMoveValid("L"))
                {
                    IndexToSwap = EmptyElementIndex - 1;
                }
            }
            if (sender == MoveRight)
            {
                if (IsMoveValid("R"))
                {
                    IndexToSwap = EmptyElementIndex + 1;
                }
            }
            if (sender == MoveTop)
            {
                if (IsMoveValid("T"))
                {
                    IndexToSwap = EmptyElementIndex - PIECECOUNT;
                }
            }
            if (sender == MoveBottom)
            {
                if (IsMoveValid("B"))
                {
                    IndexToSwap = EmptyElementIndex + PIECECOUNT;
                }
            }
            if (IndexToSwap != -1)
            {
                try
                {
                    temp = (Bitmap)Viewer[IndexToSwap].Image;
                    temptag = Viewer[IndexToSwap].Tag.ToString();
                    Viewer[IndexToSwap].Image = Viewer[EmptyElementIndex].Image;
                    Viewer[IndexToSwap].Tag = Viewer[EmptyElementIndex].Tag;
                    HelpText.SetToolTip(Viewer[IndexToSwap], Viewer[IndexToSwap].Tag.ToString());
                    Viewer[EmptyElementIndex].Image = temp;
                    Viewer[EmptyElementIndex].Tag = temptag;
                    HelpText.SetToolTip(Viewer[EmptyElementIndex], Viewer[EmptyElementIndex].Tag.ToString());
                    EmptyElementIndex = IndexToSwap;
                    this.Invalidate();
                }
                catch (Exception)
                {
                }
            }
            if (IsWon)
            {
                MessageBox.Show("You Won the Game....");
            }
        }

        public bool IsMoveValid(string Direction)
        {
            bool IsValid = false;
            switch (Direction)
            {
                case "L":
                    IsValid = (EmptyElementIndex % PIECECOUNT != 0);
                    break;
                case "R":
                    IsValid = (EmptyElementIndex % PIECECOUNT != (PIECECOUNT - 1));
                    break;
                case "T":
                    IsValid = (EmptyElementIndex > PIECECOUNT - 1);
                    break;
                case "B":
                    IsValid = (EmptyElementIndex < PIECECOUNT * PIECECOUNT - PIECECOUNT);
                    break;
            }
            return IsValid;
        }

        public bool IsWon
        {
            get
            {
                for (int i = 0; i < Viewer.Length; i++)
                {
                    if (Viewer[i].Tag.ToString() != i.ToString())
                        return false;
                }
                return true;
            }
        }

        private void lblx_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void pb1_Click(object sender, EventArgs e)
        {
            ImageFile = (pb1.Image as Bitmap);
            incarca();
            Shuffle_Click(null, null);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            ImageFile = (pb2.Image as Bitmap);
            incarca();
            Shuffle_Click(null, null);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            ImageFile = (pb3.Image as Bitmap);
            incarca();
            Shuffle_Click(null, null);
        }

       

        private void lblx_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDreapta_Click(object sender, EventArgs e)
        {
            if (primul == 0)
                return;
            ultimul--;
            primul--;
            pb3.Image = pb2.Image;
            pb2.Image = pb1.Image;
            pb1.Image = new Bitmap(fisiere[primul]);
            pb1.BringToFront();
            pb2.BringToFront();
            pb3.BringToFront();

        }

        private void btnStanga_Click(object sender, EventArgs e)
        {
            if (ultimul == nrFisiere - 1)
                return;
            ultimul++;
            primul++;
            pb1.Image = pb2.Image;
            pb2.Image = pb3.Image;
            pb3.Image = new Bitmap(fisiere[ultimul]);
            pb1.BringToFront();
            pb2.BringToFront();
            pb3.BringToFront();




        }

    }
}
