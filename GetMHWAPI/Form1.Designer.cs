namespace GetMHWAPI
{
    partial class FormAPI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLlamar = new System.Windows.Forms.Button();
            this.labelAPI = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSourceItems = new System.Windows.Forms.BindingSource(this.components);
            this.aPIMHWDataSet = new GetMHWAPI.APIMHWDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new GetMHWAPI.APIMHWDataSetTableAdapters.ItemsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rarityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carryLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIMHWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLlamar
            // 
            this.buttonLlamar.Location = new System.Drawing.Point(307, 386);
            this.buttonLlamar.Name = "buttonLlamar";
            this.buttonLlamar.Size = new System.Drawing.Size(172, 52);
            this.buttonLlamar.TabIndex = 0;
            this.buttonLlamar.Text = "Llamar API";
            this.buttonLlamar.UseVisualStyleBackColor = true;
            this.buttonLlamar.Click += new System.EventHandler(this.buttonLlamar_Click);
            // 
            // labelAPI
            // 
            this.labelAPI.AutoSize = true;
            this.labelAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelAPI.Location = new System.Drawing.Point(311, 19);
            this.labelAPI.Name = "labelAPI";
            this.labelAPI.Size = new System.Drawing.Size(157, 37);
            this.labelAPI.TabIndex = 1;
            this.labelAPI.Text = "API MHW";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.rarityDataGridViewTextBoxColumn,
            this.carryLimitDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 314);
            this.dataGridView1.TabIndex = 2;
            // 
            // bindingSourceItems
            // 
            this.bindingSourceItems.DataSource = this.aPIMHWDataSet;
            this.bindingSourceItems.Position = 0;
            this.bindingSourceItems.CurrentChanged += new System.EventHandler(this.bindingSourceItems_CurrentChanged);
            // 
            // aPIMHWDataSet
            // 
            this.aPIMHWDataSet.DataSetName = "APIMHWDataSet";
            this.aPIMHWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.bindingSourceItems;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 160;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 175;
            // 
            // rarityDataGridViewTextBoxColumn
            // 
            this.rarityDataGridViewTextBoxColumn.DataPropertyName = "rarity";
            this.rarityDataGridViewTextBoxColumn.HeaderText = "rarity";
            this.rarityDataGridViewTextBoxColumn.Name = "rarityDataGridViewTextBoxColumn";
            this.rarityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carryLimitDataGridViewTextBoxColumn
            // 
            this.carryLimitDataGridViewTextBoxColumn.DataPropertyName = "carryLimit";
            this.carryLimitDataGridViewTextBoxColumn.HeaderText = "carryLimit";
            this.carryLimitDataGridViewTextBoxColumn.Name = "carryLimitDataGridViewTextBoxColumn";
            this.carryLimitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelAPI);
            this.Controls.Add(this.buttonLlamar);
            this.Name = "FormAPI";
            this.Text = "APIMHW";
            this.Load += new System.EventHandler(this.FormAPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPIMHWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLlamar;
        private System.Windows.Forms.Label labelAPI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceItems;
        private APIMHWDataSet aPIMHWDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private APIMHWDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rarityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carryLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}

