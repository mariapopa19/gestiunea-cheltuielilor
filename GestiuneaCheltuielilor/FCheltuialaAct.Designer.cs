namespace GestiuneaCheltuielilor
{
    partial class FCheltuialaAct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNrCheltuiala = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GestiuneaCheltuielilor.DataSet1();
            this.cheltuialaContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCheluialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produseTableAdapter = new GestiuneaCheltuielilor.DataSet1TableAdapters.ProduseTableAdapter();
            this.denumireProdusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idProdusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuialaContinutManevraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. Cheltuiala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data";
            // 
            // txtNrCheltuiala
            // 
            this.txtNrCheltuiala.Location = new System.Drawing.Point(124, 40);
            this.txtNrCheltuiala.Name = "txtNrCheltuiala";
            this.txtNrCheltuiala.Size = new System.Drawing.Size(94, 20);
            this.txtNrCheltuiala.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 28, 18, 46, 56, 0);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(307, 40);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(586, 40);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(51, 16);
            this.lblOp.TabIndex = 8;
            this.lblOp.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(642, 89);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireProdusDataGridViewTextBoxColumn1,
            this.idProdusDataGridViewTextBoxColumn1,
            this.pretOfertaDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn1,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cheltuialaContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(971, 286);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cheltuialaContinutManevraBindingSource
            // 
            this.cheltuialaContinutManevraBindingSource.DataMember = "CheltuialaContinutManevra";
            this.cheltuialaContinutManevraBindingSource.DataSource = this.dataSet1;
            this.cheltuialaContinutManevraBindingSource.CurrentChanged += new System.EventHandler(this.cheltuialaContinutManevraBindingSource_CurrentChanged);
            // 
            // idCheluialaDataGridViewTextBoxColumn
            // 
            this.idCheluialaDataGridViewTextBoxColumn.DataPropertyName = "IdCheluiala";
            this.idCheluialaDataGridViewTextBoxColumn.HeaderText = "IdCheluiala";
            this.idCheluialaDataGridViewTextBoxColumn.Name = "idCheluialaDataGridViewTextBoxColumn";
            this.idCheluialaDataGridViewTextBoxColumn.Width = 133;
            // 
            // denumireProdusDataGridViewTextBoxColumn
            // 
            this.denumireProdusDataGridViewTextBoxColumn.DataPropertyName = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.denumireProdusDataGridViewTextBoxColumn.HeaderText = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.Name = "denumireProdusDataGridViewTextBoxColumn";
            this.denumireProdusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.denumireProdusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.denumireProdusDataGridViewTextBoxColumn.Width = 132;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.Width = 133;
            // 
            // umDataGridViewTextBoxColumn
            // 
            this.umDataGridViewTextBoxColumn.DataPropertyName = "Um";
            this.umDataGridViewTextBoxColumn.HeaderText = "Um";
            this.umDataGridViewTextBoxColumn.Name = "umDataGridViewTextBoxColumn";
            this.umDataGridViewTextBoxColumn.Width = 132;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // denumireProdusDataGridViewTextBoxColumn1
            // 
            this.denumireProdusDataGridViewTextBoxColumn1.DataPropertyName = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn1.DataSource = this.produseBindingSource;
            this.denumireProdusDataGridViewTextBoxColumn1.DisplayMember = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn1.DisplayStyleForCurrentCellOnly = true;
            this.denumireProdusDataGridViewTextBoxColumn1.HeaderText = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn1.Name = "denumireProdusDataGridViewTextBoxColumn1";
            this.denumireProdusDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.denumireProdusDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idProdusDataGridViewTextBoxColumn1
            // 
            this.idProdusDataGridViewTextBoxColumn1.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn1.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn1.Name = "idProdusDataGridViewTextBoxColumn1";
            this.idProdusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // pretOfertaDataGridViewTextBoxColumn
            // 
            this.pretOfertaDataGridViewTextBoxColumn.DataPropertyName = "PretOferta";
            this.pretOfertaDataGridViewTextBoxColumn.HeaderText = "PretOferta";
            this.pretOfertaDataGridViewTextBoxColumn.Name = "pretOfertaDataGridViewTextBoxColumn";
            // 
            // uMDataGridViewTextBoxColumn1
            // 
            this.uMDataGridViewTextBoxColumn1.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn1.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn1.Name = "uMDataGridViewTextBoxColumn1";
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            // 
            // pretTotalDataGridViewTextBoxColumn
            // 
            this.pretTotalDataGridViewTextBoxColumn.DataPropertyName = "PretTotal";
            this.pretTotalDataGridViewTextBoxColumn.HeaderText = "PretTotal";
            this.pretTotalDataGridViewTextBoxColumn.Name = "pretTotalDataGridViewTextBoxColumn";
            this.pretTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FCheltuialaAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNrCheltuiala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FCheltuialaAct";
            this.Text = "FCheltuialaAct";
            this.Load += new System.EventHandler(this.FCheltuialaAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuialaContinutManevraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNrCheltuiala;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCheluialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn denumireProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn umDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cheltuialaContinutManevraBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private DataSet1TableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn denumireProdusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretTotalDataGridViewTextBoxColumn;
    }
}