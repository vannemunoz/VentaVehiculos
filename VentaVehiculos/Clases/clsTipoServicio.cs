using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VentaVehiculos.Models;

namespace VentaVehiculos.Clases
{

    public class clsTipoServicio
    {

        public ventaVehiculosEntities dbtipoServicio = new ventaVehiculosEntities();

        public List<TipoServicioCombo> ConsultaTipoServicio()
        {
            return dbtipoServicio.TipoServicios
                .Select(p => new TipoServicioCombo { Valor = p.id.ToString(), Texto = p.tipoServicio1 })
                .OrderBy(p => p.Texto)
                .ToList();

        }
    }
}

