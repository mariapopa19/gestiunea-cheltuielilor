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
    public partial class Cheltuieli : Form
    {
        public Cheltuieli()
        {
            InitializeComponent();
        }

        private void Cheltuieli_Load(object sender, EventArgs e)
        {
            refreshGrid();
            filtreazaDetaliu();
        }

        private void refreshGrid()
        {
            cheltuieliTableAdapter.Fill(this.dataSet1.Cheltuieli);
            cheltuieliContinutTableAdapter.Fill(this.dataSet1.CheltuieliContinut);
        }
        private void filtreazaDetaliu()                                     
        {
            try
            {
                cheltuieliContinutBindingSource.Filter = "IdCheltuiala=" + txtIdCheltuiala.Text;
            }
            catch { }
        }

        private void cheltuieliBindingSource_PositionChanged(object sender, EventArgs e)
        {
            filtreazaDetaliu();
        }

        private void btnCheltuialaNoua_Click(object sender, EventArgs e)
        {
            FCheltuialaAct f = new FCheltuialaAct();
            f.completeazaTitlu("CHELTUIALA NOUA");
            f.ShowDialog();
            refreshGrid();

        }

        private void btnModificareCheltuiala_Click(object sender, EventArgs e)
        {
            FCheltuialaAct f = new FCheltuialaAct();
            f.completeazaTitlu("MODIFICARE CHELTUIALA");
            f.bs1 = cheltuieliBindingSource;
            f.bs2 = cheltuieliContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
        }

        private void btnStergereCheltuiala_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = cheltuieliTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut comanda
            cmd.CommandText = "Delete From CheltuieliContinut Where IdCheltuiala = " + txtIdCheltuiala.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            // Sterg comanda
            cmd.CommandText = "Delete From Cheltuieli Where IdCheltuiala = " + txtIdCheltuiala.Text;
            //MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();

            con.Close();

            // Refresh grid-uri
            refreshGrid();
            filtreazaDetaliu();
        }

    }
}
