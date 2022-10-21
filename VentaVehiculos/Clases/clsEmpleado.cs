using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VentaVehiculos.Models;

namespace VentaVehiculos.Clases
{
    public class clsEmpleado
    {
        public Empleado empleado;
        public ventaVehiculosEntities dbEmpleado = new ventaVehiculosEntities();

        public String GrabarEmpleado()
        {
            try
            {
                dbEmpleado.Empleadoes.Add(empleado);
                dbEmpleado.SaveChanges();
                return "empleado guardado exitosamente";
            }
            catch(Exception e)
            {
                return e.Message;
            }

        }

    }
}