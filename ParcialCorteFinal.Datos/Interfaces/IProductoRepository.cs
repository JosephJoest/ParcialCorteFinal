using ParcialCorteFinal.Entidad;

namespace ParcialCorteFinal.Datos.Interfaces
{
    public interface IProductoRepository
    {
        Producto ObtenerProductoPorCodigo(string codigoProducto);
    }
}
