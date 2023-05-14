namespace GestiuneaCheltuielilor
{
    partial class Cheltuieli
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCheltuialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheltuieliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new GestiuneaCheltuielilor.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idCheltuialaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheltuieliContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdCheltuiala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheltuialaNoua = new System.Windows.Forms.Button();
            this.btnModificareCheltuiala = new System.Windows.Forms.Button();
            this.btnStergereCheltuiala = new System.Windows.Forms.Button();
            this.cheltuieliTableAdapter = new GestiuneaCheltuielilor.DataSet1TableAdapters.CheltuieliTableAdapter();
            this.cheltuieliContinutTableAdapter = new GestiuneaCheltuielilor.DataSet1TableAdapters.CheltuieliContinutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCheltuialaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cheltuieliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(582, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // idCheltuialaDataGridViewTextBoxColumn
            // 
            this.idCheltuialaDataGridViewTextBoxColumn.DataPropertyName = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn.HeaderText = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn.Name = "idCheltuialaDataGridViewTextBoxColumn";
            this.idCheltuialaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCheltuialaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cheltuieliBindingSource
            // 
            this.cheltuieliBindingSource.DataMember = "Cheltuieli";
            this.cheltuieliBindingSource.DataSource = this.dataSet1;
            this.cheltuieliBindingSource.PositionChanged += new System.EventHandler(this.cheltuieliBindingSource_PositionChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCheltuialaDataGridViewTextBoxColumn1,
            this.idProdusDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.denumireProdusDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretTotalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.cheltuieliContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(776, 218);
            this.dataGridView2.TabIndex = 1;
            // 
            // idCheltuialaDataGridViewTextBoxColumn1
            // 
            this.idCheltuialaDataGridViewTextBoxColumn1.DataPropertyName = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn1.HeaderText = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn1.Name = "idCheltuialaDataGridViewTextBoxColumn1";
            this.idCheltuialaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idCheltuialaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdusDataGridViewTextBoxColumn.Visible = false;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denumireProdusDataGridViewTextBoxColumn
            // 
            this.denumireProdusDataGridViewTextBoxColumn.DataPropertyName = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.HeaderText = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.Name = "denumireProdusDataGridViewTextBoxColumn";
            this.denumireProdusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretTotalDataGridViewTextBoxColumn
            // 
            this.pretTotalDataGridViewTextBoxColumn.DataPropertyName = "PretTotal";
            this.pretTotalDataGridViewTextBoxColumn.HeaderText = "PretTotal";
            this.pretTotalDataGridViewTextBoxColumn.Name = "pretTotalDataGridViewTextBoxColumn";
            this.pretTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cheltuieliContinutBindingSource
            // 
            this.cheltuieliContinutBindingSource.DataMember = "CheltuieliContinut";
            this.cheltuieliContinutBindingSource.DataSource = this.dataSet1;
            // 
            // txtIdCheltuiala
            // 
            this.txtIdCheltuiala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheltuieliBindingSource, "IdCheltuiala", true));
            this.txtIdCheltuiala.Location = new System.Drawing.Point(688, 12);
            this.txtIdCheltuiala.Name = "txtIdCheltuiala";
            this.txtIdCheltuiala.Size = new System.Drawing.Size(100, 20);
            this.txtIdCheltuiala.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Cheltuiala";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCheltuialaNoua
            // 
            this.btnCheltuialaNoua.AutoSize = true;
            this.btnCheltuialaNoua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheltuialaNoua.Location = new System.Drawing.Point(603, 55);
            this.btnCheltuialaNoua.Name = "btnCheltuialaNoua";
            this.btnCheltuialaNoua.Size = new System.Drawing.Size(125, 26);
            this.btnCheltuialaNoua.TabIndex = 4;
            this.btnCheltuialaNoua.Text = "Cheltuiala noua";
            this.btnCheltuialaNoua.UseVisualStyleBackColor = true;
            this.btnCheltuialaNoua.Click += new System.EventHandler(this.btnCheltuialaNoua_Click);
            // 
            // btnModificareCheltuiala
            // 
            this.btnModificareCheltuiala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificareCheltuiala.AutoSize = true;
            this.btnModificareCheltuiala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificareCheltuiala.Location = new System.Drawing.Point(603, 110);
            this.btnModificareCheltuiala.Name = "btnModificareCheltuiala";
            this.btnModificareCheltuiala.Size = new System.Drawing.Size(162, 26);
            this.btnModificareCheltuiala.TabIndex = 5;
            this.btnModificareCheltuiala.Text = "Modificare cheltuiala";
            this.btnModificareCheltuiala.UseVisualStyleBackColor = true;
            this.btnModificareCheltuiala.Click += new System.EventHandler(this.btnModificareCheltuiala_Click);
            // 
            // btnStergereCheltuiala
            // 
            this.btnStergereCheltuiala.AutoSize = true;
            this.btnStergereCheltuiala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergereCheltuiala.Location = new System.Drawing.Point(603, 168);
            this.btnStergereCheltuiala.Name = "btnStergereCheltuiala";
            this.btnStergereCheltuiala.Size = new System.Drawing.Size(149, 26);
            this.btnStergereCheltuiala.TabIndex = 6;
            this.btnStergereCheltuiala.Text = "Stergere cheltuiala";
            this.btnStergereCheltuiala.UseVisualStyleBackColor = true;
            this.btnStergereCheltuiala.Click += new System.EventHandler(this.btnStergereCheltuiala_Click);
            // 
            // cheltuieliTableAdapter
            // 
            this.cheltuieliTableAdapter.ClearBeforeFill = true;
            // 
            // cheltuieliContinutTableAdapter
            // 
            this.cheltuieliContinutTableAdapter.ClearBeforeFill = true;
            // 
            // Cheltuieli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStergereCheltuiala);
            this.Controls.Add(this.btnModificareCheltuiala);
            this.Controls.Add(this.btnCheltuialaNoua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdCheltuiala);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cheltuieli";
            this.Text = "Cheltuieli";
            this.Load += new System.EventHandler(this.Cheltuieli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtIdCheltuiala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheltuialaNoua;
        private System.Windows.Forms.Button btnModificareCheltuiala;
        private System.Windows.Forms.Button btnStergereCheltuiala;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cheltuieliBindingSource;
        private DataSet1TableAdapters.CheltuieliTableAdapter cheltuieliTableAdapter;
        private System.Windows.Forms.BindingSource cheltuieliContinutBindingSource;
        private DataSet1TableAdapters.CheltuieliContinutTableAdapter cheltuieliContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCheltuialaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCheltuialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}