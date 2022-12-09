using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl
{
    public class Libro
    {
        public static string  Add (ML.Libro libro) 
        { 
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context= new SqlConnection(DL.Conexion.ConnectionString()))
                {
                    using(SqlCommand command = new SqlCommand())
                    {
                        command.CommandText = "AddLibro";
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Connection= context;

                        SqlParameter[] colletion = new SqlParameter[7];
                        colletion[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        colletion[0].Value = libro.Nombre; 
                        colletion[1] = new SqlParameter("@NumeroDePaginas", System.Data.SqlDbType.Int);
                        colletion[1].Value = libro.NumeroDePaginas; 
                        colletion[2] = new SqlParameter("@FechaPublicacion", System.Data.SqlDbType.Int);
                        colletion[2].Value = libro.FechaPublicacion; 
                        colletion[3] = new SqlParameter("@Edicion", System.Data.SqlDbType.Int);
                        colletion[3].Value = libro.Edicion; 
                        colletion[4] = new SqlParameter("@IdAutor", System.Data.SqlDbType.Int);
                        colletion[4].Value = libro.IdAutor; 
                        colletion[5] = new SqlParameter("@IdEditorial", System.Data.SqlDbType.Int);
                        colletion[5].Value = libro.IdEditorial; 
                        colletion[6] = new SqlParameter("@IdGenero", System.Data.SqlDbType.Int);
                        colletion[6].Value = libro.IdGenero;
                        command.Parameters.AddRange(colletion);

                        command.Connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct 
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
                
            }
         catch(Exception ex)
            {

            }
            return result.Correct;
        }
    }
}
