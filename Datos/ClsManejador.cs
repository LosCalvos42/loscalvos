using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;

namespace Datos
{
    public class ClsManejador
    {
        public static string ip;
        public static string database;
        public static string contra;
        public static string admin;


                SqlConnection conexion = new SqlConnection("Server=" + ip + ";DataBase=" + database + "; user id = sa; password =" + contra);



        public  SqlConnection Conectar()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public void Desconectar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        public void Ejecutarquery(String query)
        {
            SqlCommand cmd;
            try
            {
                Conectar();
                cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
        }

        public void EjecutarSP(String NombreSP, ref List<ClsParametros> lst)
        {
            SqlCommand cmd;
            try
            {
                Conectar();
                cmd = new SqlCommand(NombreSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        if (lst[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
        } 


        public DataTable lisquery (string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                Conectar();
                da = new SqlDataAdapter(query, conexion);
                da.SelectCommand.CommandType = CommandType.Text;
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
            return dt;
        }


        public DataTable Listado(String NombreSP, List<ClsParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                Conectar();
                da = new SqlDataAdapter(NombreSP, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
            return dt;
        }
        public void ExecuteSqlTransaction(String NombreSP, List<ClsParametros> lstCabecera)
        {
            SqlCommand cmd;
            SqlTransaction transaction;

            Conectar();
            cmd = new SqlCommand(NombreSP, conexion);
            transaction = conexion.BeginTransaction("SampleTransaction");
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (lstCabecera != null)
                {
                    for (int i = 0; i < lstCabecera.Count; i++)
                    {
                        if (lstCabecera[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lstCabecera[i].Nombre, lstCabecera[i].Valor);
                        if (lstCabecera[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lstCabecera[i].Nombre, lstCabecera[i].TipoDato, lstCabecera[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.Transaction = transaction;
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < lstCabecera.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lstCabecera[i].Valor = cmd.Parameters[i].Value;
                    }
                    transaction.Commit();
                }
                Desconectar();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
                throw ex;
            }
        }
                    
    }
}

    

