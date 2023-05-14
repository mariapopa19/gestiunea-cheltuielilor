using System;
using System.Data;
using System.Data.OleDb;
using System.Net;
using System.Windows.Forms;

namespace GestiuneaCheltuielilor
{
    public partial class FCheltuialaAct : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        public BindingSource bs1;
        public BindingSource bs2;

        public FCheltuialaAct()
        {
            InitializeComponent();
        }

        private void FCheltuialaAct_Load(object sender, EventArgs e)
        {
            A1();
        }
        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }
        private void completeazaCheltuiala()
        {
            DataRowView current = (DataRowView)bs1.Current;

            idCda = (int)current["IdCheltuiala"];
            txtNrCheltuiala.Text = Convert.ToString(current["IdCheltuiala"]);

            txtTotal.Text = current["Total"].ToString();


            dateTimePicker1.Value = Convert.ToDateTime(current["Data"]);

            bs2.MoveFirst();

            dataSet1.CheltuialaContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                DataSet1.CheltuialaContinutManevraRow r = dataSet1.CheltuialaContinutManevra.NewCheltuialaContinutManevraRow();
                r.DenumireProdus = Convert.ToString(current["DenumireProdus"]);
                r.IdProdus = Convert.ToInt32(current["IdProdus"]);
                r.PretOferta = Convert.ToDecimal(current["Pret"]);
                r.UM = Convert.ToString(current["UM"]);
                r.Cantitate = Convert.ToDecimal(current["Cantitate"]);
                r.PretTotal = Convert.ToDecimal(current["PretTotal"]);

                dataSet1.CheltuialaContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }

        private void A1()
        {
            //Incarcare DataTable Produse
            produseTableAdapter.Fill(dataSet1.Produse);
            //Incarcare DataTable Clienti

            // Protectie la modificare
            txtNrCheltuiala.ReadOnly = true;
            txtTotal.ReadOnly = true;
            idCheluialaDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn1.ReadOnly = true;
            pretOfertaDataGridViewTextBoxColumn.ReadOnly = true;
            idProdusDataGridViewTextBoxColumn.ReadOnly = true;


            if (lblOp.Text == "MODIFICARE CHELTUIALA") completeazaCheltuiala();
            //else if (lblOp.Text == "COMANDA NOUA") cmbClient.SelectedIndex = -1;
        }
        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE CHELTUIALA")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariComenziContinut();
                this.Close();
            }
            else if (lblOp.Text == "CHELTUIALA NOUA")
            {
                generez_nr_cda();
                adaugaInregistrareComenzi();
                cautaInregistrare();
                adaugaInregistrariComenziContinut();
                golireCampuri();
            }
        }

        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)cheltuialaContinutManevraBindingSource.Current;
            try { current["IdCheltuiala"] = cheltuialaContinutManevraBindingSource.Position + 1; }
            catch { }
        }

        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 0)
                {
                    DataRowView current = (DataRowView)produseBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[3].Value = current["UM"];
                    dataGridView1.CurrentRow.Cells[2].Value = current["Pret"];
                    dataGridView1.CurrentRow.Cells[1].Value = current["IdProdus"];
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    cheltuialaContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
            }
            catch { }
        }

        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void cheltuialaContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }
        private void calcTotal()
        {
            decimal t = 0;
            foreach (DataRow r in dataSet1.CheltuialaContinutManevra)
            {
                if (r["PretTotal"] != DBNull.Value)
                    t += (decimal)r["PretTotal"];
            }
            txtTotal.Text = Convert.ToString(t);
        }

        private void generez_nr_cda()
        {
            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Cheltuieli.IdCheltuiala) AS NrMax FROM Cheltuieli";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            txtNrCheltuiala.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            rdr.Close();
            con.Close();
        }

        private bool validareCampuriObligatorii()
        {
            // Validare completare continut
            if (cheltuialaContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut cheltuiala !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }
        private void adaugaInregistrareComenzi()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            listaCampuri = "IdCheltuiala ,Data, Total";
            listaValori = "'"+ txtNrCheltuiala.Text + "', " + 
                           "#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#,"
                               + "'"  + txtTotal.Text + "'";
            cmd.CommandText = "Insert into Cheltuieli(" + listaCampuri + ") " +
                              "Select " + listaValori;

            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT IdCheltuiala From Cheltuieli Where IdCheltuiala = " + txtNrCheltuiala.Text;

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }


        private void adaugaInregistrariComenziContinut()
        {
            string listaCampuri = "IdCheltuiala, IdProdus, DenumireProdus, Pret, UM, Cantitate, PretTotal";
            string listaValori;

            con.Open();
            foreach (DataRow r in dataSet1.CheltuialaContinutManevra)
            {
                listaValori = idCda + ","  + r["IdProdus"] + ",'" + r["DenumireProdus"] + "'," + r["PretOferta"] + ",'" + r["UM"] + "'," + r["Cantitate"] + "," + r["PretTotal"];

                cmd.CommandText = "Insert into CheltuieliContinut (" + listaCampuri + ") " + "Select " + listaValori;

                //MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        private void golireCampuri()
        {
            txtNrCheltuiala.Text = "";
            txtTotal.Text = "";
            dataSet1.CheltuialaContinutManevra.Clear();
        }
        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            string clauzaWhere = " Where IdCheltuiala = " + idCda;

            string clauzaSet = "Set Data = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#," +
                               "Total = " + txtTotal.Text;

            cmd.CommandText = "Update Cheltuieli " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from CheltuieliContinut Where IdCheltuiala = " + idCda;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }


    }
}
