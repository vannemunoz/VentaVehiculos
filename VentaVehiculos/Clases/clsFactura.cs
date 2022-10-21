using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VentaVehiculos.Models;

namespace VentaVehiculos.Clases
{
    public class clsFactura
    {
        public Factura factura;
        public ventaVehiculosEntities dbFactura = new ventaVehiculosEntities();
        
        public String GrabarFactura()
        {
            try
            {
                dbFactura.Facturas.Add(factura);
                dbFactura.SaveChanges();
                return "Factura guardada exitosamente";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}