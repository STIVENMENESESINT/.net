using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;
using System.Net;

namespace conexion_db_001
{
    public partial class recuperar_frm : Form
    {
        public recuperar_frm()
        {
            InitializeComponent();
        }

        private void btn_nueva_cre_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage config_msj = new MailMessage(); // Declara y crea un nuevo objeto 

                config_msj.From = new MailAddress("monica.mosquera3@soy.sena.edu.co");
                //config_msj.To.Add("monica.mosquera3@soy.sena.edu.co"); // correo del destinatario

                config_msj.SubjectEncoding = System.Text.Encoding.UTF8; // Codificación UTF-8 Correctamente para el Asunto
                config_msj.Subject = ("Prueba de ENVIAR correo con C# Ñ"); // Establece el asunto del mensaje.
                config_msj.BodyEncoding = System.Text.Encoding.UTF8; // Establece la codificación UTF-8 para el cuerpo del mensaje.
                config_msj.Body = "Aqui debe ir la nueva clave asignada por el sistema"; // Establece el contenido del cuerpo del mensaje.
                config_msj.IsBodyHtml = true; // Indica si el cuerpo del mensaje contiene HTML.
                System.Net.Mail.SmtpClient config_dato = new System.Net.Mail.SmtpClient(); // Declara y crea un nuevo cliente SMTP.
                config_dato.Credentials = new System.Net.NetworkCredential("monica.mosquera3@soy.sena.edu.co", "Mon2693289"); // Establece las credenciales para el cliente SMTP.
                config_dato.Port = 587; // Establece el puerto del servidor SMTP.(Hotmail)
                config_dato.EnableSsl = true; // Habilita SSL para el cliente SMTP.
                config_dato.Host = "smtp.live.com"; // Establece el host del servidor SMTP.}

                config_msj.From = new MailAddress("monica.mosquera3@soy.sena.edu.co");
                //config_dato.Send(config_msj); // Envía el mensaje de correo electrónico.

                MessageBox.Show("CREDENCIAL ENVIADA AL CORREO CORRECTAMENTE", "Mensaje de C# "); // Muestra un mensaje de confirmación de que el correo se envió correctamente.

            }
            catch (Exception err)
            {
                MessageBox.Show("Error al enviar el mensaje"+ err,"Mensaje de C# ");
            }
        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
