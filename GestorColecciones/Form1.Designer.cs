namespace GestorColecciones
{
    partial class frmCatalogo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLecturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIBROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coleccionesDS = new GestorColecciones.ColeccionesDS();
            this.lIBROSTableAdapter = new GestorColecciones.ColeccionesDSTableAdapters.LIBROSTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmLIBRO = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPRESTAMO = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coleccionesDS)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLibro,
            this.tituloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.fechaLecturaDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.lIBROSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // IdLibro
            // 
            this.IdLibro.DataPropertyName = "IdLibro";
            this.IdLibro.HeaderText = "IdLibro";
            this.IdLibro.Name = "IdLibro";
            this.IdLibro.ReadOnly = true;
            this.IdLibro.Visible = false;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            // 
            // fechaLecturaDataGridViewTextBoxColumn
            // 
            this.fechaLecturaDataGridViewTextBoxColumn.DataPropertyName = "FechaLectura";
            this.fechaLecturaDataGridViewTextBoxColumn.HeaderText = "FechaLectura";
            this.fechaLecturaDataGridViewTextBoxColumn.Name = "fechaLecturaDataGridViewTextBoxColumn";
            // 
            // lIBROSBindingSource
            // 
            this.lIBROSBindingSource.DataMember = "LIBROS";
            this.lIBROSBindingSource.DataSource = this.coleccionesDS;
            // 
            // coleccionesDS
            // 
            this.coleccionesDS.DataSetName = "ColeccionesDS";
            this.coleccionesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIBROSTableAdapter
            // 
            this.lIBROSTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLIBRO,
            this.tsmPRESTAMO});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 70);
            // 
            // tsmLIBRO
            // 
            this.tsmLIBRO.Name = "tsmLIBRO";
            this.tsmLIBRO.Size = new System.Drawing.Size(157, 22);
            this.tsmLIBRO.Text = "Editar Libro";
            this.tsmLIBRO.Click += new System.EventHandler(this.tsmLIBRO_Click);
            // 
            // tsmPRESTAMO
            // 
            this.tsmPRESTAMO.Name = "tsmPRESTAMO";
            this.tsmPRESTAMO.Size = new System.Drawing.Size(157, 22);
            this.tsmPRESTAMO.Text = "Editar Préstamo";
            this.tsmPRESTAMO.Click += new System.EventHandler(this.tsmPRESTAMO_Click);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 271);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCatalogo";
            this.Text = "Libros en Biblioteca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCatalogo_FormClosing);
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coleccionesDS)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ColeccionesDS coleccionesDS;
        private System.Windows.Forms.BindingSource lIBROSBindingSource;
        private ColeccionesDSTableAdapters.LIBROSTableAdapter lIBROSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLecturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmLIBRO;
        private System.Windows.Forms.ToolStripMenuItem tsmPRESTAMO;
    }
}

