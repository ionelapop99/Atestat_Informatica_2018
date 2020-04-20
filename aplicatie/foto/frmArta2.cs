using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace foto
{
    public partial class frmArta2 : Form
    {
        public frmArta2()
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
        int nrFisiere = 0,primul,ultimul;
        public void afiseaza(string cale)
        {
            StreamReader r = File.OpenText(Application.StartupPath+cale);
            string folder = r.ReadLine();
            string descriere = "";
            while(!r.EndOfStream)
            {
                descriere += "      " + r.ReadLine() + Environment.NewLine;
            }
            r.Close();
            lblDescriere.Text = descriere;
            fisiere = Directory.GetFiles(Application.StartupPath + folder);
            nrFisiere = fisiere.Length;
            if (nrFisiere == 0)
                return;
            pbMare.Image = new Bitmap(fisiere[0]);
            pb1.Image= new Bitmap(fisiere[0]);
            pb2.Image = new Bitmap(fisiere[1]);
            pb3.Image = new Bitmap(fisiere[2]);
            primul = 0;
            ultimul = 2;

        }


        private void label2_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/5.Carol_Pop.txt");
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


        }

        private void pb1_Click(object sender, EventArgs e)
        {
            pbMare.Image = (sender as PictureBox).Image;
        }

        private void pbMare_Click(object sender, EventArgs e)
        {
            
        }

        private void pbMare_MouseClick(object sender, MouseEventArgs e)
        {
            Color c = (pbMare.Image as Bitmap).GetPixel(e.Y, e.X);
            MessageBox.Show(c.A + " " + c.B + " " + c.G);
        }

        private void frmArta2_Click(object sender, EventArgs e)
        {

        }

        private void lblP1_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/5.Carol_Pop.txt");
        }

        private void lblP2_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/52.txt");
        }

        private void lblP3_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/53.txt");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/54.txt");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/5.Roger_Fenton.txt");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/5AP_Costica_Acsinte.txt");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/5-AP_Ernest_Brooks.txt");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/5AP_Joshep_Rosendhal.txt");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/5AP_Mathew_Brady.txt");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/5AP_Walter_Kleinfeldt.txt");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/5-AP-Faye_Schulman.txt");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/5-AP-Robert_Capa.txt");
        }

        private void lblDescriere_Click(object sender, EventArgs e)
        {

        }

        private void frmArta2_Load(object sender, EventArgs e)
        {
            afiseaza("/surse/5.Carol_Pop.txt");
            bordura(5);
        }


    }
}
