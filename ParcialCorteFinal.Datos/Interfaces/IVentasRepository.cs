using ParcialCorteFinal.Entidad;
using System.Collections.Generic;

namespace ParcialCorteFinal.Datos.Interfaces
{
    public interface IVentaRepository
    {
        List<Venta> ObtenerVentasPorSede(string rutaArchivo, string codigoSedeSeleccionada);
    }
}
