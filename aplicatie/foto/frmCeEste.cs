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
    public partial class frmCeEste : Form
    {
        public frmCeEste()
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
        public void afiseaza(string cale)
        {
            StreamReader r = File.OpenText(Application.StartupPath + cale);
            string folder = r.ReadLine();
            string descriere = "";
            while (!r.EndOfStream)
            {
                descriere += "     "+r.ReadLine() + Environment.NewLine;
            }
            r.Close();
            lblDescriere.Text = descriere;
            fisiere = Directory.GetFiles(Application.StartupPath + folder);
            nrFisiere = fisiere.Length;
            if (nrFisiere == 0)
                return;
            pbMare.Image = new Bitmap(fisiere[0]);
            pb1.Image = new Bitmap(fisiere[0]);
            pb2.Image = new Bitmap(fisiere[1]);
            pb3.Image = new Bitmap(fisiere[2]);
            primul = 0;
            ultimul = 2;

        }
        private void label2_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/albnegru.txt");
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

        private void pb1_Click(object sender, EventArgs e)
        {
            pbMare.Image = (sender as PictureBox).Image;
        }

        private void lblP1_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/1.1.Ce_e_fotografia.txt");
        }

        private void lblP2_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/113.txt");
        }

        private void lblP3_Click(object sender, EventArgs e)
        {
            afiseaza("/surse/istoric3.txt");
        }

        private void lblDescriere_Click(object sender, EventArgs e)
        {

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
        private void frmCeEste_Load(object sender, EventArgs e)
        {
            afiseaza("/surse/1.1.Ce_e_fotografia.txt");
            bordura(5);
        }
    }
}
