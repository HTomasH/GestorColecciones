﻿namespace GestorColecciones
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
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.tbxDescricion = new System.Windows.Forms.TextBox();
            this.dtpLectura = new System.Windows.Forms.DateTimePicker();
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.pbxPortada = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(80, 27);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(100, 20);
            this.tbxTitulo.TabIndex = 0;
            // 
            // tbxDescricion
            // 
            this.tbxDescricion.Location = new System.Drawing.Point(80, 80);
            this.tbxDescricion.Name = "tbxDescricion";
            this.tbxDescricion.Size = new System.Drawing.Size(100, 20);
            this.tbxDescricion.TabIndex = 1;
            // 
            // dtpLectura
            // 
            this.dtpLectura.Location = new System.Drawing.Point(80, 124);
            this.dtpLectura.Name = "dtpLectura";
            this.dtpLectura.Size = new System.Drawing.Size(200, 20);
            this.dtpLectura.TabIndex = 2;
            // 
            // dtpCompra
            // 
            this.dtpCompra.Location = new System.Drawing.Point(80, 180);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.ShowCheckBox = true;
            this.dtpCompra.Size = new System.Drawing.Size(200, 20);
            this.dtpCompra.TabIndex = 3;
            // 
            // pbxPortada
            // 
            this.pbxPortada.Location = new System.Drawing.Point(379, 27);
            this.pbxPortada.Name = "pbxPortada";
            this.pbxPortada.Size = new System.Drawing.Size(182, 192);
            this.pbxPortada.TabIndex = 4;
            this.pbxPortada.TabStop = false;
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
            // frmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxPortada);
            this.Controls.Add(this.dtpCompra);
            this.Controls.Add(this.dtpLectura);
            this.Controls.Add(this.tbxDescricion);
            this.Controls.Add(this.tbxTitulo);
            this.Name = "frmEdicion";
            this.Text = "frmEdicion";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.TextBox tbxDescricion;
        private System.Windows.Forms.DateTimePicker dtpLectura;
        private System.Windows.Forms.DateTimePicker dtpCompra;
        private System.Windows.Forms.PictureBox pbxPortada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}