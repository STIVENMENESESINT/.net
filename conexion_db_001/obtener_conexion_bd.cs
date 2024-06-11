using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se agrega las librerias
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace conexion_db_001
{
    internal class obtener_conexion_bd
    {

        //Conexiones Sql

        static string servidor = " Server = localm; ";
        static string nom_db = " Database = agricultura_db; ";
        static string usuario = "UID = localm; ";
        static string clave = " Password = 1002970326; ";

        public MySqlConnection conectar_con_db = new MySqlConnection(servidor + nom_db + usuario + clave);

        public void conectar()
        {
            try
            { 
                conectar_con_db.Open();
            } catch (Exception err) 
            { 
                MessageBox.Show("Mensaje de C#", "ERROR al conectar a la BD..." +  err);
            }
            
        }

        public void desconectar()
        {
            try
            {
                conectar_con_db.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Mensaje de C#", "ERROR al desconectar a la BD..." + err);
            }
        }
    }
}
