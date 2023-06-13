using ParcialCorteFinal.Datos.Conexion;
using ParcialCorteFinal.Datos.Interfaces;
using ParcialCorteFinal.Entidad;
using System.Data.SqlClient;

namespace ParcialCorteFinal.Datos.Repositorios
{
    public class ProductoRepository : IProductoRepository
    {
        public Producto ObtenerProductoPorCodigo(string codigoProducto)
        {
            Producto producto = null;

            using (SqlConnection connection = new SqlConnection(ConexionMaestra.CadenaConexion))
            {
                string query = "SELECT CodigoProducto, Nombre, Valor FROM Producto WHERE CodigoProducto = @CodigoProducto";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    producto = new Producto
                    {
                        Codigo = reader.GetString(0),
                        Nombre = reader.GetString(1),
                        Valor = reader.GetDecimal(2)
                    };
                }

                reader.Close();
            }

            return producto;
        }
    }
}
