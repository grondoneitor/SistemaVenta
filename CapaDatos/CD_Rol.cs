using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidadd;
using System.Data;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> listandoRoles()
        {
            List<Rol> list = new List<Rol>();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"select IdRol, Descripcion from Rol ";

                    SqlDataReader dr = cmd.ExecuteReader();

                    try
                    {
                        while (dr.Read())
                        {
                            list.Add(new Rol()
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Descripcion = dr["Descripcion"].ToString()
                            });

                        }
                    }catch (Exception ex) 
                    {
                        list = new List<Rol>(); 
                    }


                }
            }
             return list;


        }

    }
}
