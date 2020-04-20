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
    public partial class frmPuzzle : Form
    {
        public frmPuzzle()
        {
            InitializeComponent();
        }

        int nrFisiere = 0, primul, ultimul;
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
    }
}
