using ParcialCorteFinal.Datos.Repositorios;
using ParcialCorteFinal.Entidad;
using System.Collections.Generic;

namespace ParcialCorteFinal.Negocio.Servicio
{
    public class SedeServicio 
    {
        private readonly SedeRepository sedeRepositorio = new SedeRepository();

        public List<Sede> ListarSedes()
        {
            return sedeRepositorio.ListarSedes();
        } 
    }
}
