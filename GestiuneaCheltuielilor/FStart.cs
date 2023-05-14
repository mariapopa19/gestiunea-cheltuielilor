using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneaCheltuielilor
{
    public partial class FStart : Form
    {
        private OleDbConnection con = new OleDbConnection();                                    
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public FStart()
        {
            InitializeComponent();
        }
        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUtilizator.Visible = v;
            txtUtilizator.Visible = v;
            if (v) btnStart.Text = "Log In";
            else btnStart.Text = "Log Out";
        }
        private Boolean Logare_OK()
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return false;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return false;
            }

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=E:\\Facultate FMI\\An 3\\Tehnici avansate de programare\\Proiect\\DBproiect.mdb";

            cmd.Connection = con;
            cmd.CommandText = "Select IdUtilizator,Parola from Utilizatori " +
                              "where Nume='" + txtUtilizator.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUtilizator.Focus();
                con.Close();
                return false;
            }
        }

        private void FStart_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produse f = new Produse();
            f.ShowDialog();
        }

        private void cheltuieliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cheltuieli f = new Cheltuieli();
            f.ShowDialog();
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorie f = new Categorie();
            f.ShowDialog();
        }
    }
}
