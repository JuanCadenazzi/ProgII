using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;

namespace CarreraApp
{
    internal class AccesoDatos
    {

        private static AccesoDatos instancia;

        private SqlConnection cnn;

        SqlConnection coneccion;
        SqlCommand comando;
        string cadenaConexio;

        private AccesoDatos()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString);
        }
        public static AccesoDatos ObtenerInstancia()
        {
            if (instancia == null)
            { 
            instancia = new AccesoDatos();
            }
            return instancia;
        }

        //public AccesoDatos()
        //{
        //    cadenaConexio = @"Data Source=JUAN-NB\SQLEXPRESS;Initial Catalog=universidad;Integrated Security=True";
        //    coneccion = new SqlConnection(cadenaConexio);
        //    comando = new SqlCommand();
        //}
        private void conectar()
        {
            coneccion.Open();
            comando.Connection = coneccion;

        }
        public void desconectar()
        {
            coneccion.Close();
        }
        public bool confirmarCarerra(Carrera Ocarrera)
        {
            bool ok = true;

            SqlCommand cmd = new SqlCommand();
            SqlTransaction trs = null;
            try
            {
                coneccion.Open();
                trs = coneccion.BeginTransaction();
                cmd.Transaction = trs;
                cmd.Connection = coneccion;
                cmd.CommandText = "SP_INSERTAR_MAESTRO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod_carrera", Ocarrera.pCodigo);
                cmd.Parameters.AddWithValue("@carrera", Ocarrera.pNombre);
                cmd.Parameters.AddWithValue("@titulo", Ocarrera.pTitulo);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@cod_carrera_salida";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int cod_carrera_salida = (int)pOut.Value;

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (DetalleCarrera item in Ocarrera.Detalles)
                {
                    cmdDetalle = new SqlCommand();
                    cmdDetalle.Transaction = trs;
                    cmdDetalle.Connection = coneccion;
                    cmdDetalle.CommandText = "SP_INSERTAR_DETALLE";
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@cod_carrera_salida", cod_carrera_salida);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@asignatura", item.pAsigantura);
                    cmdDetalle.Parameters.AddWithValue("@anioCursado", item.pAnioCursado);
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestre", item.pCustrismestre);
                    cmd.ExecuteNonQuery();

                    detalleNro++;



                }

                trs.Commit();




            }
            catch (Exception)
            {

                trs.Rollback();
                ok = false;
            }
            finally
            {
                if (coneccion.State == ConnectionState.Open)
                {
                    coneccion.Close();
                }
            }
            return ok;

        }

        public int bajaCarrera(string SP, Carrera nvCarrera)
        {
            int filas = 0;
            conectar();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod_carrera", nvCarrera.pCodigo);
            return filas;

        }
        public DataTable selectSQL(string SP)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public DataTable selectSQL2(string SP, int parm)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.CommandText = SP;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cod_carrera", parm);
            tabla.Load(comando.ExecuteReader());
            desconectar();
            return tabla;
        }
        public bool UpdateDetalle(Carrera unaCarrera, string SPDelete, string SPInsert)
        {
            bool correcto = true;
            SqlTransaction trs = null;
            try
            {
                conectar();
                trs = coneccion.BeginTransaction();
                comando.Transaction = trs;
                comando.CommandText = SPDelete;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@cod_carrera", unaCarrera.pCodigo);
                comando.ExecuteNonQuery();
                comando.CommandText = SPInsert;
                comando.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < unaCarrera.Detalles.Count; i++)
                {
                    comando.Parameters.AddWithValue("@anio_cursado", unaCarrera.Detalles[i].pAnioCursado);
                    comando.Parameters.AddWithValue("@cuatrimestre", unaCarrera.Detalles[i].pCustrismestre);
                    comando.Parameters.AddWithValue("@cod_materia", unaCarrera.Detalles[i].pAsigantura.pCodigo);
                    comando.Parameters.AddWithValue("@cod_carrera_salida", unaCarrera.pCodigo);
                    comando.ExecuteNonQuery();
                }
                trs.Commit();
            }
            catch (Exception)
            {
                trs.Rollback();
                correcto = false;
            }
            finally
            {
                if (coneccion.State == ConnectionState.Open)
                    coneccion.Close();
            }
            return correcto;
        }


    }
}
