using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiLibreria;

namespace FactuXd
{
    public partial class ConsultarClientes : Consultas
    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        private void ConsultarClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDataGV("Cliente").Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomB.Text.Trim()) == false)
            {
                try {
                    DataSet ds;
                    string cmd = "SELECT * FROM cliente WHERE Nom_cli LIKE('%" + txtNomB.Text.Trim() + "%')";
                    ds = Utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];
                    
                }
                catch(Exception error) {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }

            }
        }
    }
}
