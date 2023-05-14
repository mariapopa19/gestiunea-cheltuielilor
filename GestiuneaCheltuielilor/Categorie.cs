using GestiuneaCheltuielilor.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiuneaCheltuielilor
{
    public partial class Categorie : Form
    {
        const int IdCategorieIndex = 0;
        const int DenumireCategorieIndex = 1;

        public Categorie()
        {
            InitializeComponent();
        }

        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            //Protectie coloane
            dataGridView1.Columns[DenumireCategorieIndex].ReadOnly = v;

            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }
        private void refresh()
        {
            categorieTableAdapter.Fill(dataSet1.Categorie);
        }
        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dataSet1.Categorie)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DenumireCategorie"] == DBNull.Value)
                {
                    MessageBox.Show("Completati DenumireCategorie la linia cu Id " + r["IdCategorie"]);
                    raspuns = false;
                }
            }
            return raspuns;
        }


        private void Categorie_Load(object sender, EventArgs e)
        {
            config(true);
            refresh();
            dataGridView1.Columns[IdCategorieIndex].ReadOnly = true;
        }
        private void btnActualizare_Click(object sender, EventArgs e)
        {
            //A2
            config(false);
        }
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            try
            {
                categorieTableAdapter.Update(dataSet1.Categorie);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            //A3
            config(true);
            refresh();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                //A3
                config(true);
                refresh();

                return;
            }
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnActualizare.Enabled) return;

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

    }
}
