using System.Configuration;

namespace ParcialCorteFinal.Datos.Conexion
{
    public class ConexionMaestra
    {
        public static string CadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ToString();
    }
}
