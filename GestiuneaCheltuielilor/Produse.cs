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
    public partial class Produse : Form
    {
    
        public Produse()
        {
            InitializeComponent();
        }

        private void Produse_Load(object sender, EventArgs e)
        {
            A1();

        }
        private void A1()
        {
            produseTableAdapter.Fill(dataSet1.Produse);

            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtIdPersoana
            txtIdProdus.ReadOnly = true;

            A3();
        }

        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            txtDenumireProdus.Focus();

            // Golire campuri
            golireCampuri();
        }

        private void A3()
        {
            //Initializare lblOp
            lblOp.Text = "";

            //Çonfigurare(butoane)
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale
            legareControale(true);
        }
        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp
                txtDenumireProdus.Focus();
                refresh_grid(produseBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(produseBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }
        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            if (lblOp.Text == "ADAUGARE")
            {
                cmd.CommandText = "Select IdProdus From Produse where DenumireProdus= '" + txtDenumireProdus.Text + "'";
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Produs deja existent");
                    txtDenumireProdus.Focus();
                }
                con.Close();
            }

            else if (lblOp.Text == "MODIFICARE")
            {
                cmd.CommandText = "Select IdProdus From Produse where DenumireProdus= '" + txtDenumireProdus.Text + "'";
                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Produs deja existent");
                    txtDenumireProdus.Focus();
                }
                con.Close();
            }
        }
        private void A6()
        {
            if (lblOp.Text == "")
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSpPoza.Text = openFileDialog1.FileName;
                pb.ImageLocation = txtSpPoza.Text;
            }
        }

        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            txtDenumireProdus.Focus();
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Select IdProdus From CheltuieliContinut where IdProdus=" + txtIdProdus.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Produs referit in tabela CheltuieliContinut! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();

            cmd.CommandText = "Delete From Produse Where IdProdus = " + txtIdProdus.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(produseBindingSource.Position);

        }
        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
        }
        private void legareControale(bool v)
        {
            if (v)
            {
                txtDenumireProdus.DataBindings.Add("Text", produseBindingSource, "DenumireProdus");
                txtUM.DataBindings.Add("Text", produseBindingSource, "UM");
                txtPret.DataBindings.Add("Text", produseBindingSource, "Pret");
                txtSpPoza.DataBindings.Add("Text", produseBindingSource, "SpImagine");
                txtIdCategorie.DataBindings.Add("Text", produseBindingSource, "IdCategorie");
                txtIdProdus.DataBindings.Add("Text", produseBindingSource, "IdProdus");
                pb.DataBindings.Add("ImageLocation", produseBindingSource, "SpImagine");
            }
            else
            {
                txtDenumireProdus.DataBindings.Clear();
                txtUM.DataBindings.Clear();
                txtPret.DataBindings.Clear();
                txtSpPoza.DataBindings.Clear();
                txtIdCategorie.DataBindings.Clear();
                txtIdProdus.DataBindings.Clear();
                pb.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            txtDenumireProdus.ReadOnly = v;
            txtUM.ReadOnly = v;
            txtPret.ReadOnly = v;
            txtSpPoza.ReadOnly = v;
            txtIdCategorie.ReadOnly = v;
        }
        private void golireCampuri()
        {
            txtDenumireProdus.Text = "";
            txtIdProdus.Text = "";
            txtUM.Text = "";
            txtPret.Text = "";
            txtSpPoza.Text = "";
            txtIdCategorie.Text = "";
            pb.ImageLocation = "";
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtDenumireProdus.Text == "")
            {
                MessageBox.Show("Completati DenumireProdus !");
                txtDenumireProdus.Focus();
                return false;
            }
            if (txtUM.Text == "")
            {
                MessageBox.Show("Completati Unitate de masura !");
                txtUM.Focus();
                return false;
            }

            if (txtPret.Text == "")
            {
                MessageBox.Show("Completati Pret !");
                txtPret.Focus();
                return false;
            }

            if (txtIdCategorie.Text == "")
            {
                MessageBox.Show("Completati IdCategorie !");
                txtIdCategorie.Focus();
                return false;
            }
            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "DenumireProdus, UM, Pret, SpImagine, IdCategorie";
            listaValori = "'" + txtDenumireProdus.Text + "'" +
                          ",'" + txtUM.Text + "'" +
                          ",'" + txtPret.Text + "'" +
                          ",'" + txtSpPoza.Text + "'" +
                          ",'" + txtIdCategorie.Text + "'";

            cmd.CommandText = "Insert into Produse(" + listaCampuri + ") " +
                              "Select " + listaValori;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void refresh_grid(int p)
        {
            produseTableAdapter.Fill(dataSet1.Produse);
            produseBindingSource.Position = p;
        }
        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaSet ="DenumireProdus = " + "'" + txtDenumireProdus.Text + "'," +
                          "UM = " +  "'" + txtUM.Text + "'," +
                          "Pret = " + "'" + txtPret.Text + "'," +
                          "SpImagine = " + "'" + txtSpPoza.Text + "'," +
                          "IdCategorie = " + "'" + txtIdCategorie.Text + "'";

            cmd.CommandText = "Update Produse Set " + listaSet + " Where IdProdus=" + txtIdProdus.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }
        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }
        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }

        private void txtSpPoza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            A6();
        }

        private void txtDenumireProdus_Leave(object sender, EventArgs e)
        {
            A5(txtDenumireProdus);
        }

    }
}
