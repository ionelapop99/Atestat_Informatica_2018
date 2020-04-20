using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foto
{
    public partial class frmMain : Form
    {

        Point start = new Point(150, 240);
        Size dim=new Size(540, 210);
        Color cul = Color.FromArgb(68, 68, 68);

        public frmTehnici fTehnici;
        public frmCeEste fCeEste;
        public frmCalitati fCalitati;

        public frm1900 f1900;
        public frm1994 f1994;
        public frm2000 f2000;

        public frmAparitia1 fAparitia1;
        public frmAparitia2 fAparitia2;

        public frmArta1 fArta1;
        public frmArta2 fArta2;
        public frmArta3 fArta3;
        public frmArta4 fArta4;


        public frmPuzzle fPuzzle;
        public frmCuriozitati fCuriozitati;
        public frmPixWord fPixWord;
        public frmTest fTeste;

        public frmBibliografie fBibliografie;


        public frmMain()
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

        public void afiseaza(Panel p)
        {
            foreach(object x in this.Controls )
            {
                   if (x.GetType().ToString() == "System.Windows.Forms.Panel")
                       (x as Panel).Visible = false;   
            }
            p.Visible = true;
            p.Location = start;
            p.Size = dim;
            p.BackColor = cul;
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            afiseaza(panIntroducere);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            afiseaza(panIstoric);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            fTehnici = new frmTehnici();
            fTehnici.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            fCalitati = new frmCalitati();
            fCalitati.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            fCeEste = new frmCeEste();
            fCeEste.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            afiseaza(panIntroducere);
            bordura(5);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            fCalitati = new frmCalitati();
            fCalitati.ShowDialog();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            afiseaza(panAparitia);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            f1900 = new frm1900();
            f1900.ShowDialog();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            f1994 = new frm1994();
            f1994.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            f2000 = new frm2000();
            f2000.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            fAparitia1 = new frmAparitia1();
            fAparitia1.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            fAparitia2 = new frmAparitia2();
            fAparitia2.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            afiseaza(panArta);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            afiseaza(panJoc);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            fArta1 = new frmArta1();
            fArta1.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            fArta2 = new frmArta2();
            fArta2.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            fArta3 = new frmArta3();
            fArta3.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            fArta4 = new frmArta4();
            fArta4.ShowDialog();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            fPuzzle = new frmPuzzle();
            fPuzzle.ShowDialog();
        }
      

        private void label21_Click(object sender, EventArgs e)
        {
            fCuriozitati = new frmCuriozitati();
            fCuriozitati.ShowDialog();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            fTeste = new frmTest();
            fTeste.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            fBibliografie = new frmBibliografie();
            fBibliografie.ShowDialog();
        }
    }
}
