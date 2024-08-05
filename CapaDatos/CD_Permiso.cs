using CapaEntidadd;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int idUsuario)
        {

            List<Permiso> permisos = new List<Permiso>();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    conn.Open();
                    string query = "select p.IdRol, p.NombreMenu from Permiso p\r\ninner join Rol r on p.IdRol = r.IdRol\r\ninner join Usuario u on r.IdRol= u.IdRol\r\nwhere u.IdUsuario = @IdUsuario";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            permisos.Add(new Permiso()
                            {
                                oRol = new Rol() { IdRol = Convert.ToInt32(reader["IdRol"]) },
                                NombreMenu = reader["NombreMenu"].ToString()
                            }) ;

                        }

                    }
                }
                catch (Exception ex)
                {

                    permisos = new List<Permiso>();
                }


            }

            return permisos;

        }
    }
}
