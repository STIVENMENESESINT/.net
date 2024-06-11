using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Conexion a BD
using MySql.Data.MySqlClient;
//Administra los msg -> Alertas
using System.Windows.Forms;
// Herramientas para form
using Microsoft.VisualBasic;
//Manejo de BD
using System.Data.SqlClient;

namespace conexion_db_001
{
    public partial class login_frm : Form
    {
        obtener_conexion_bd obc = new obtener_conexion_bd();
        public login_frm()
        {
            InitializeComponent();
        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {
            obc.conectar();
            string Query = " SELECT numero identificación, contraseña " +
        " FROM usuario " +
        " WHERE numero_identificacion = ('" + txt_usu.Text + "')" +
        " AND contraseña  = ('" + txt_clave.Text + "');";

            MySqlCommand mycomando = new MySqlCommand(Query, obc.conectar_con_db);
            Int32 total_registros_encontrados = Convert.ToInt32(mycomando.ExecuteScalar());
            if (total_registros_encontrados > 0)
            {
                menu_dos_frm md = new menu_dos_frm();
                md.Show();
            }
        else
            {
                MessageBox.Show("Datos NO encontrados...", "Mensaje de C#");
                txt_clave.Clear();
                txt_usu.Clear();
            }
        obc.desconectar();
        }

        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            recuperar_frm nc = new recuperar_frm();
            nc.Show();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

        }

        private void txt_clave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
