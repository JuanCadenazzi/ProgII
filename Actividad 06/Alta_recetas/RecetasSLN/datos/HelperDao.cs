using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    internal class HelperDao
    {

      
 
        public DataTable consultaIngrediente()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=JUAN-NB\SQLEXPRESS;Initial Catalog=recetas_db;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_INGREDIENTES";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            return tabla;
        }

        public bool Insertar(Receta oReceta)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=JUAN-NB\SQLEXPRESS;Initial Catalog=recetas_db;Integrated Security=True";
           
            SqlTransaction transaction = null;
            bool ok = true;
            try
            {
                conexion.Open();
                transaction = conexion.BeginTransaction();
                SqlCommand cmdMa = new SqlCommand("SP_INSERTAR_RECETA", conexion, transaction);
                cmdMa.CommandType = CommandType.StoredProcedure;
                cmdMa.Parameters.AddWithValue("@nombre", oReceta.nombre);
                cmdMa.Parameters.AddWithValue("@chef", oReceta.chef);
                cmdMa.Parameters.AddWithValue("@tipo_receta", oReceta.tipoReceta);
                cmdMa.ExecuteNonQuery();
                int contar = 1;
                foreach (Detalle detalle in oReceta.detalles)
                {
                    SqlCommand cmdDeta = new SqlCommand("SP_INSERTAR_DETALLES", conexion, transaction);
                    cmdDeta.CommandType = CommandType.StoredProcedure;                    
                    cmdDeta.Parameters.AddWithValue("@id_receta", oReceta.RecetaNro);
                    cmdDeta.Parameters.AddWithValue(@"tipo_receta",oReceta.tipoReceta);
                    cmdDeta.Parameters.AddWithValue("@id_ingrediente", detalle.Ingrediente.ingredeinteID);
                    cmdDeta.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    contar++;
                    cmdDeta.ExecuteNonQuery();


                }
                transaction.Commit();
            }
            catch (Exception )
            {

                transaction.Rollback();
                ok=false;
            }
            finally
            {
                if (conexion.State==ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return ok;

        }

        public int proximo()
        {
            

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=JUAN-NB\SQLEXPRESS;Initial Catalog=recetas_db;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            SqlParameter paramet = new SqlParameter("@id_proximo", SqlDbType.Int);
            try
            {
                cmd.Parameters.Clear();
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PROXIMO_ID";
                paramet.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramet);
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(paramet.Value);

            }
            
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }



        }
    }    
}
