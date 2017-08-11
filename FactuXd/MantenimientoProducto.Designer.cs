namespace FactuXd
{
    partial class MantenimientoProducto
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
            this.lblidPro = new System.Windows.Forms.Label();
            this.lblNomPro = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtIdPro = new MiLibreria.ErrorTxtBox();
            this.txtNomPro = new MiLibreria.ErrorTxtBox();
            this.txtPrecio = new MiLibreria.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 49);
            this.button1.Size = new System.Drawing.Size(113, 29);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 84);
            this.button2.Size = new System.Drawing.Size(113, 29);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 119);
            this.button3.Size = new System.Drawing.Size(113, 29);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(314, 154);
            this.button4.Size = new System.Drawing.Size(113, 29);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(314, 189);
            this.btnSalir.Size = new System.Drawing.Size(113, 29);
            // 
            // lblidPro
            // 
            this.lblidPro.AutoSize = true;
            this.lblidPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidPro.Location = new System.Drawing.Point(13, 65);
            this.lblidPro.Name = "lblidPro";
            this.lblidPro.Size = new System.Drawing.Size(97, 16);
            this.lblidPro.TabIndex = 8;
            this.lblidPro.Text = "ID_Producto:";
            // 
            // lblNomPro
            // 
            this.lblNomPro.AutoSize = true;
            this.lblNomPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPro.Location = new System.Drawing.Point(13, 108);
            this.lblNomPro.Name = "lblNomPro";
            this.lblNomPro.Size = new System.Drawing.Size(99, 16);
            this.lblNomPro.TabIndex = 9;
            this.lblNomPro.Text = "Descripcion :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(53, 154);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 16);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtIdPro
            // 
            this.txtIdPro.Location = new System.Drawing.Point(118, 64);
            this.txtIdPro.Name = "txtIdPro";
            this.txtIdPro.Size = new System.Drawing.Size(167, 20);
            this.txtIdPro.Solonumeros = true;
            this.txtIdPro.TabIndex = 11;
            this.txtIdPro.Validar = true;
            this.txtIdPro.TextChanged += new System.EventHandler(this.txtIdPro_TextChanged);
            // 
            // txtNomPro
            // 
            this.txtNomPro.Location = new System.Drawing.Point(118, 107);
            this.txtNomPro.Name = "txtNomPro";
            this.txtNomPro.Size = new System.Drawing.Size(167, 20);
            this.txtNomPro.Solonumeros = false;
            this.txtNomPro.TabIndex = 12;
            this.txtNomPro.Validar = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(118, 150);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(167, 20);
            this.txtPrecio.Solonumeros = true;
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.Validar = true;
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 262);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNomPro);
            this.Controls.Add(this.txtIdPro);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNomPro);
            this.Controls.Add(this.lblidPro);
            this.Name = "MantenimientoProducto";
            this.Text = "MantenimientoProducto";
            this.Load += new System.EventHandler(this.MantenimientoProducto_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.lblidPro, 0);
            this.Controls.SetChildIndex(this.lblNomPro, 0);
            this.Controls.SetChildIndex(this.lblPrecio, 0);
            this.Controls.SetChildIndex(this.txtIdPro, 0);
            this.Controls.SetChildIndex(this.txtNomPro, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblidPro;
        private System.Windows.Forms.Label lblNomPro;
        private System.Windows.Forms.Label lblPrecio;
        private MiLibreria.ErrorTxtBox txtIdPro;
        private MiLibreria.ErrorTxtBox txtNomPro;
        private MiLibreria.ErrorTxtBox txtPrecio;
    }
}