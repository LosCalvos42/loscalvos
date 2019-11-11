using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Datos
{
    public class CDEmpleado
    {
       private ClsManejador conexion = new ClsManejador();
       private SqlDataReader leer;
       private String Email, Nombres, Contraseña;
       private String Mensaje;
       private SqlCommand Comando = new SqlCommand();

       public String RecuperarContraseña(string dni) {
           Comando.Connection = conexion.Conectar();
           Comando.CommandText = "Select *from usuarios where dni="+dni;
           leer = Comando.ExecuteReader();
           if (leer.Read() == true)
           {
               Email = leer["Email"].ToString();
               Nombres = leer["Nombres"].ToString() + ", " + leer["Apellidos"].ToString();
               Contraseña = leer["Contraseña"].ToString();
               //EMAIL
               EnviarEmail();

               Mensaje = "Estimado " + Nombres + " , Se ha enviado su contraseña a su correo: " + Email + ": Verifique su bandeja de entrada";
               leer.Close();
           }
           else
           {
               Mensaje = "no existe datos ...";
           }
           return Mensaje;

       }

       public void EnviarEmail() { 
       //CORREO
           MailMessage Correo = new MailMessage();
           Correo.From = new MailAddress("ronetonline@gmail.com");
           Correo.To.Add(Email);
           Correo.Subject=("RECUPERAR CONTRASEÑA SYSTEM");
           Correo.Body = "hOLA, "+Nombres+" Usted solicito recuperar contraseña\n Su contraseña es: "+Contraseña+" ";
           Correo.Priority = MailPriority.Normal;
      // SMPT
           SmtpClient ServerMail = new SmtpClient();
           ServerMail.Credentials = new NetworkCredential("ronetonline@gmail.com", "@admin123");
           ServerMail.Host = "smtp.gmail.com";
           ServerMail.Port = 587;
           ServerMail.EnableSsl = true;
           try
           {
               ServerMail.Send(Correo);
           }
           catch (Exception ex) { 
           
           }
           Correo.Dispose();
       }
       


       public SqlDataReader iniciarSesion(string user, string pass)
       {
           SqlCommand command = new SqlCommand("SpLogin", conexion.Conectar());
           command.CommandType = CommandType.StoredProcedure;
           command.Parameters.AddWithValue("@USR_USER", user);
           command.Parameters.AddWithValue("@USR_PASS", pass);
           leer = command.ExecuteReader();
          
           return leer;
         
       }

     

    }
}