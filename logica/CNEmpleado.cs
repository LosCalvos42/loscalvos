using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;

namespace CapaLogicaNegocio
{
   public class CNEmpleado
    {   //CREAR OBJETO CAPA DATOS DE EMPLEADO.. INSTANCIA
        private CDEmpleado ObjDatos = new CDEmpleado();
       //VARIABLES...ENCAPSULAMIENTO
        private String _Usuario;
        private String _Contraseña;
        //METODOS SET 
        public String Usuario
        {
            set {
                    if (value=="Usuario" ) { _Usuario = "Por favor ingrese usuario"; }
                    else  { _Usuario = value; }
                }

           get {
                    return _Usuario;   
               }
        }
        public String Contraseña
        {
            set {
                if (value == "Contraseña" ) { _Contraseña = "No ha introducido su contraseña"; }
                else { _Contraseña = value; }
                }

            get { return _Contraseña; }
        }

        
        //CONTRUCTOR 
        public CNEmpleado() { 
        
        }
        //FUNCIONES
        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear=ObjDatos.iniciarSesion(_Usuario,_Contraseña);
            
            return Loguear;
        }

        public string RecuPass(string dni) {
            string mensaje;
            mensaje = ObjDatos.RecuperarContraseña(dni);
            return mensaje;
        }

      

    }
}
