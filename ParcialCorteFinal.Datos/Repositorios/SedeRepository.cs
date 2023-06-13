using ParcialCorteFinal.Datos.Interfaces;
using ParcialCorteFinal.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace ParcialCorteFinal.Datos.Repositorios
{
    public class SedeRepository : ISedesRepository
    {
        public List<Sede> ListarSedes()
        {
            List<Sede> sedes = new List<Sede>();

            using (SqlConnection connection = new SqlConnection(Conexion.ConexionMaestra.CadenaConexion))
            {
                try
                {
                    StringBuilder consulta = new StringBuilder();
                    consulta.Append("SELECT CodigoSede, Nombre FROM Sede;;");

                    SqlCommand command = new SqlCommand(consulta.ToString(), connection)
                    {
                        CommandType = CommandType.Text
                    };

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sedes.Add(new Sede()
                            {
                                Codigo = Convert.ToString(reader["CodigoSede"]),
                                Nombre = reader["Nombre"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    sedes = new List<Sede>();
                    connection.Close();
                    throw ex;
                }
            }

            return sedes;
        }
    }
}
