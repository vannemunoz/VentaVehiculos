using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VentaVehiculos.Models;

namespace VentaVehiculos.Clases
{
    public class clsVehiculo
    {

        public Vehiculo vehiculo { get; set; }
        private ventaVehiculosEntities dbVehiculos = new ventaVehiculosEntities();
        public string GrabarVehiculo()
        {
            try
            {
                dbVehiculos.Vehiculoes.Add(vehiculo);
                dbVehiculos.SaveChanges();
                return "Vehiculo guardado exitosamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}