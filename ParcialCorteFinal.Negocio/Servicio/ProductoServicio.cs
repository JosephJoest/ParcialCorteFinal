using ParcialCorteFinal.Datos.Repositorios;
using ParcialCorteFinal.Entidad;

namespace ParcialCorteFinal.Negocio.Servicio
{
    public class ProductoServicio
    {
        private readonly ProductoRepository productoRepository = new ProductoRepository();

        public Producto ObtenerProductoPorCodigo(string codigoProducto)
        {
            return productoRepository.ObtenerProductoPorCodigo(codigoProducto);
        }
    }
}
