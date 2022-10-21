using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VentaVehiculos.Models;

namespace VentaVehiculos.Clases
{
    public class clsServicio
    {
        public Servicio servicio;
        public ventaVehiculosEntities dbServicio;

        public String GrabarServicio()
        {
            try
            {
                dbServicio.Servicios.Add(servicio);
                dbServicio.SaveChanges();
                return "Servicio Guardado exitosamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}