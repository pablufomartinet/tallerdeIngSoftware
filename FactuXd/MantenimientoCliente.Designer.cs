namespace FactuXd
{
    partial class MantenimientoCliente
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
            this.lblApeCli = new System.Windows.Forms.Label();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtIdCli = new MiLibreria.ErrorTxtBox();
            this.txtNomCli = new MiLibreria.ErrorTxtBox();
            this.txtApeCli = new MiLibreria.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 47);
            this.button1.Size = new System.Drawing.Size(111, 30);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 83);
            this.button2.Size = new System.Drawing.Size(111, 30);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 119);
            this.button3.Size = new System.Drawing.Size(111, 30);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(353, 155);
            this.button4.Size = new System.Drawing.Size(111, 30);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(353, 191);
            this.btnSalir.Size = new System.Drawing.Size(111, 30);
            // 
            // lblApeCli
            // 
            this.lblApeCli.AutoSize = true;
            this.lblApeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeCli.Location = new System.Drawing.Point(36, 146);
            this.lblApeCli.Name = "lblApeCli";
            this.lblApeCli.Size = new System.Drawing.Size(70, 16);
            this.lblApeCli.TabIndex = 16;
            this.lblApeCli.Text = "Apellido:";
            this.lblApeCli.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCli.Location = new System.Drawing.Point(35, 100);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(71, 16);
            this.lblNomCli.TabIndex = 15;
            this.lblNomCli.Text = "Nombre :";
            this.lblNomCli.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(23, 57);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(83, 16);
            this.lblIdCliente.TabIndex = 14;
            this.lblIdCliente.Text = "ID_Cliente:";
            this.lblIdCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdCli
            // 
            this.txtIdCli.Location = new System.Drawing.Point(126, 56);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(198, 20);
            this.txtIdCli.Solonumeros = true;
            this.txtIdCli.TabIndex = 17;
            this.txtIdCli.Validar = true;
            // 
            // txtNomCli
            // 
            this.txtNomCli.Location = new System.Drawing.Point(126, 99);
            this.txtNomCli.Name = "txtNomCli";
            this.txtNomCli.Size = new System.Drawing.Size(198, 20);
            this.txtNomCli.Solonumeros = false;
            this.txtNomCli.TabIndex = 18;
            this.txtNomCli.Validar = true;
            // 
            // txtApeCli
            // 
            this.txtApeCli.Location = new System.Drawing.Point(126, 145);
            this.txtApeCli.Name = "txtApeCli";
            this.txtApeCli.Size = new System.Drawing.Size(198, 20);
            this.txtApeCli.Solonumeros = false;
            this.txtApeCli.TabIndex = 19;
            this.txtApeCli.Validar = true;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 262);
            this.Controls.Add(this.txtApeCli);
            this.Controls.Add(this.txtNomCli);
            this.Controls.Add(this.txtIdCli);
            this.Controls.Add(this.lblApeCli);
            this.Controls.Add(this.lblNomCli);
            this.Controls.Add(this.lblIdCliente);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Load += new System.EventHandler(this.MantenimientoCliente_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.lblIdCliente, 0);
            this.Controls.SetChildIndex(this.lblNomCli, 0);
            this.Controls.SetChildIndex(this.lblApeCli, 0);
            this.Controls.SetChildIndex(this.txtIdCli, 0);
            this.Controls.SetChildIndex(this.txtNomCli, 0);
            this.Controls.SetChildIndex(this.txtApeCli, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApeCli;
        private System.Windows.Forms.Label lblNomCli;
        private System.Windows.Forms.Label lblIdCliente;
        private MiLibreria.ErrorTxtBox txtIdCli;
        private MiLibreria.ErrorTxtBox txtNomCli;
        private MiLibreria.ErrorTxtBox txtApeCli;
    }
}