using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidadd;
using System.Configuration;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuarios> Listar()
        { 

            List<Usuarios> usuarios = new List<Usuarios>();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                try
                {
                    conn.Open();

                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.AppendLine("select u.IdUsuario, u.Documento, u.NombreCompleto,u.Correo,u.Clave,r.IdRol,r.Descripcion ,u.Estado from Usuario u\r\n");
                    stringBuilder.AppendLine("inner join Rol r on u.IdRol = r.IdRol");

                    SqlCommand cmd = new SqlCommand(stringBuilder.ToString(), conn);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            usuarios.Add(new Usuarios()
                            {
                                IdUsuarios = Convert.ToInt32(reader["IdUsuario"]),
                                Documento = reader["Documento"].ToString(),
                                nombreCompleto = reader["NombreCompleto"].ToString(),
                                Correo = reader["Correo"].ToString(),
                                Clave = reader["Clave"].ToString(),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                                oRol = new Rol() {IdRol= Convert.ToInt32(reader["IdRol"]), Descripcion = reader["Descripcion"].ToString() }
                            });

                        }

                    }
                }
                catch (Exception ex)
                {

                    usuarios = new List<Usuarios>();
                }


            }

            return usuarios;
        
        }

    
    }
}
