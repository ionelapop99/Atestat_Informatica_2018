using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace foto
{
    public partial class frmTest : Form
    {
        string cale = Path.GetDirectoryName(Application.ExecutablePath)/* + "\\"*/;

        public frmTest()
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

        string[] intrebari = new string[10];
        string[] a = new string[10];
        string[] b = new string[10];
        string[] c = new string[10];
        string[] corect = new string[10];
        string[] ales = new string[10];
        string[] explicatii = new string[10];
        int intrebare = 0;
        string faza = "testare";


        private void frmTest_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + cale + "\\Soft.accdb");
            con.Open();

            string qs = "select top 9 * from intrebari order by rnd(id)";
            OleDbCommand com = new OleDbCommand(qs, con);
            OleDbDataReader r = com.ExecuteReader();
            int i = 0;
            while (r.Read())
            {
                intrebari[i] = r["intrebare"].ToString();
                a[i] = r["a"].ToString();
                b[i] = r["b"].ToString();
                c[i] = r["c"].ToString();
                corect[i] = r["corect"].ToString();
                ales[i] = "d";
                i++;
            }
            intrebare = 0;
            scrie_intrebare(0);
            this.Font = new Font("Microsoft Sans Serif", (float)8.25);
            bordura(5);

        }

        public void scrie_intrebare(int poz)
        {

            //lblCare.Text = (poz + 1).ToString();
            lblIntrebare.Text = (poz + 1).ToString() + ". " + intrebari[poz];
            rba.Text = a[poz];
            rbb.Text = b[poz];
            rbc.Text = c[poz];

            (gbTest.Controls["rb" + ales[poz]] as RadioButton).Checked = true;
            if (faza == "corectare")
            {
                if (corect[poz] == ales[poz])
                {
                    pbCorect.Image = new Bitmap("design/1.png");
                    lblExplicatie.Text = "Corect";
                }
                else
                {
                    if (ales[poz] != "d")
                    {
                        pbCorect.Image = new Bitmap("design/0.png");
                        lblExplicatie.Text = explicatii[poz];
                    }
                    else
                    {
                        pbCorect.Image = new Bitmap("design/2.png");
                        lblExplicatie.Text = "Fara raspuns.";
                    }

                }
            }
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            intrebare = Convert.ToInt16((sender as Label).Name.Substring(3)) - 1;
            scrie_intrebare(intrebare);

        }

        private void rba_Click(object sender, EventArgs e)
        {
            ales[intrebare] = "a";
        }
        private void rbb_Click(object sender, EventArgs e)
        {
            ales[intrebare] = "b";
        }

        private void rbc_Click(object sender, EventArgs e)
        {
            ales[intrebare] = "c";
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int puncte = 1, i;
            for (i = 0; i < 9; i++)
            {
                if (corect[i] == ales[i])
                {
                    puncte++;
                }
            }
            lblRezultat.Text = "Ai obtinut nota " + puncte + ".";
            rba.Enabled = rbb.Enabled = rbc.Enabled = false;
            faza = "corectare";
            scrie_intrebare(intrebare);
        }

       
    }
}
