using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ImporteVehiculos.Classes
{
    class Conexion
    {
        public SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["ImporteVehiculos.Properties.Settings.Conexion"].ConnectionString);

        public void Conectar()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public void Desconectar()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable Listado(String NombreSP, List<clsParametros> lst)
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
            catch (SqlException ex)
            {
                throw ex;
            }
            Desconectar();
            return dt;
        }

        public void EjecutarSP(String NombreSP, ref List<clsParametros> lst)
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
            catch (SqlException ex)
            {
                throw ex;
            }
            Desconectar();
        }
    }
}
