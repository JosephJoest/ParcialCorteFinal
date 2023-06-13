using ParcialCorteFinal.Datos.Repositorios;
using ParcialCorteFinal.Entidad;
using System.Collections.Generic;

namespace ParcialCorteFinal.Negocio.Servicio
{
    public class VentaServicio
    {
        private readonly VentaRepository ventaRepository = new VentaRepository();

        public List<Venta> ObtenerVentasPorSede(string rutaArchivo, string codigoSedeSeleccionada)
        {
            return ventaRepository.ObtenerVentasPorSede(rutaArchivo, codigoSedeSeleccionada);
        }
    }
}
