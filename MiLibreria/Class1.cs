using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd) {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=caca;Integrated Security=True");
            con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd,con);
            DP.Fill(DS);
            con.Close();
            return DS;

        }
        //Validar Formulario  ERROR PROVIDER

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider) {
            Boolean HayErrores = false;

            foreach (Control Item in Objeto.Controls) {
                if (Item is ErrorTxtBox) {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;
                    if (Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(Obj, "No puede estar vacio");
                            HayErrores = true;
                        }
                    }

                    if (Obj.Solonumeros == true) {
                        int cont = 0, LetrasEncontradas = 0;

                        foreach (char letra in Obj.Text.Trim()) {
                            if (char.IsLetter(Obj.Text.Trim(), cont)) {
                                LetrasEncontradas++;
                            }
                            cont++;
                        }

                        if (LetrasEncontradas != 0)
                        {
                            HayErrores = true;
                            ErrorProvider.SetError(Obj, "Solo numeros");
                        }
                    }

                }
            }
            return HayErrores;

        }



    }
}
