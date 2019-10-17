namespace GestorColecciones
{
    partial class frmEdicion
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
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.tbxDescricion = new System.Windows.Forms.TextBox();
            this.pbxPortada = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coleccionesDS = new GestorColecciones.ColeccionesDS();
            this.lIBROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIBROSTableAdapter = new GestorColecciones.ColeccionesDSTableAdapters.LIBROSTableAdapter();
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.dtpLectura = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPortada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coleccionesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBROSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.AllowDrop = true;
            this.tbxTitulo.Location = new System.Drawing.Point(80, 27);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(253, 20);
            this.tbxTitulo.TabIndex = 0;
            // 
            // tbxDescricion
            // 
            this.tbxDescricion.Location = new System.Drawing.Point(80, 80);
            this.tbxDescricion.Name = "tbxDescricion";
            this.tbxDescricion.Size = new System.Drawing.Size(253, 20);
            this.tbxDescricion.TabIndex = 1;
            // 
            // pbxPortada
            // 
            this.pbxPortada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPortada.Location = new System.Drawing.Point(379, 27);
            this.pbxPortada.Name = "pbxPortada";
            this.pbxPortada.Size = new System.Drawing.Size(182, 192);
            this.pbxPortada.TabIndex = 4;
            this.pbxPortada.TabStop = false;
            this.pbxPortada.DoubleClick += new System.EventHandler(this.pbxPortada_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lectura";
            // 
            // coleccionesDS
            // 
            this.coleccionesDS.DataSetName = "ColeccionesDS";
            this.coleccionesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lIBROSBindingSource
            // 
            this.lIBROSBindingSource.DataMember = "LIBROS";
            this.lIBROSBindingSource.DataSource = this.coleccionesDS;
            // 
            // lIBROSTableAdapter
            // 
            this.lIBROSTableAdapter.ClearBeforeFill = true;
            // 
            // dtpCompra
            // 
            this.dtpCompra.Location = new System.Drawing.Point(80, 123);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.Size = new System.Drawing.Size(253, 20);
            this.dtpCompra.TabIndex = 9;
            // 
            // dtpLectura
            // 
            this.dtpLectura.Location = new System.Drawing.Point(80, 180);
            this.dtpLectura.Name = "dtpLectura";
            this.dtpLectura.ShowCheckBox = true;
            this.dtpLectura.Size = new System.Drawing.Size(253, 20);
            this.dtpLectura.TabIndex = 10;
            // 
            // frmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 309);
            this.Controls.Add(this.dtpLectura);
            this.Controls.Add(this.dtpCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxPortada);
            this.Controls.Add(this.tbxDescricion);
            this.Controls.Add(this.tbxTitulo);
            this.Name = "frmEdicion";
            this.Text = "frmEdicion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEdicion_FormClosing);
            this.Load += new System.EventHandler(this.frmEdicion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPortada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coleccionesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBROSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.TextBox tbxDescricion;
        private System.Windows.Forms.PictureBox pbxPortada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ColeccionesDS coleccionesDS;
        private System.Windows.Forms.BindingSource lIBROSBindingSource;
        private ColeccionesDSTableAdapters.LIBROSTableAdapter lIBROSTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpCompra;
        private System.Windows.Forms.DateTimePicker dtpLectura;
    }
}