using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace foto
{
    class variabile
    {
        static public string[] fisiere = new string[100];
        static public int nrFisiere = 0, primul, ultimul;
        public void afiseaza(string cale, Label lblDescriere, PictureBox pbMare, PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            StreamReader r = File.OpenText(Application.StartupPath + cale);
            string folder = r.ReadLine();
            string descriere = "";
            while (!r.EndOfStream)
            {
                descriere += r.ReadLine() + Environment.NewLine;
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


    }
}
