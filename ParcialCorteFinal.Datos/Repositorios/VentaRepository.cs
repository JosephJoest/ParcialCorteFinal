using ParcialCorteFinal.Datos.Interfaces;
using ParcialCorteFinal.Entidad;
using System.Collections.Generic;
using System.IO;

namespace ParcialCorteFinal.Datos.Repositorios
{
    public class VentaRepository : IVentaRepository
    {
        public List<Venta> ObtenerVentasPorSede(string rutaArchivo, string codigoSedeSeleccionada)
        {
            List<Venta> ventas = new List<Venta>();
            string[] lineasArchivo = File.ReadAllLines(rutaArchivo);

            foreach (string linea in lineasArchivo)
            {
                string[] datosVenta = linea.Split(';');

                if (datosVenta.Length == 3)
                {
                    string codigoSede = datosVenta[0];

                    if (codigoSede == codigoSedeSeleccionada)
                    {
                        string codigoProducto = datosVenta[1];
                        decimal valorVenta = decimal.Parse(datosVenta[2]);

                        Venta venta = new Venta
                        {
                            CodigoSede = codigoSede,
                            CodigoProducto = codigoProducto,
                            Valor = valorVenta
                        };

                        ventas.Add(venta);
                    }
                }
            }

            return ventas;
        }
    }
}
