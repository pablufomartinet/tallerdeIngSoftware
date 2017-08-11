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
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            String cmd = "SELECT * FROM Usuarios WHERE id_usuario= "+VentanaLogin.Codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNomAd.Text= DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUsAdmin.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblCodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            String url = DS.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal conP = new ContenedorPrincipal();
            this.Hide();
            conP.Show();
        }
    }
}
