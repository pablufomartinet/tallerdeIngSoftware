﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FactuXd
{
    public partial class FormBase : Form
    {
        public FormBase(){ InitializeComponent();}

        private void btnSalir_Click(object sender, EventArgs e)
        { if (MessageBox.Show("Desea Salir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 )== DialogResult.Yes) {
          this.Close();}}
        public virtual void Eliminar()      { }
        public virtual void Nuevo()         { }
        public virtual void Consultar()     { }
        public virtual Boolean Guardar()    { return false; }
    }
}
