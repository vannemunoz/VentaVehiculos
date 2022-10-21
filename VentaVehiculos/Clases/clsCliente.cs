using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VentaVehiculos.Models;

namespace VentaVehiculos.Clases
{
    public class clsCliente
    {
        public Cliente cliente;
        public ventaVehiculosEntities dbCliente = new ventaVehiculosEntities();

        public String GrabarCliente()
        {
            try
            {
                dbCliente.Clientes.Add(cliente);
                dbCliente.SaveChanges();
                return "Cliente guardado exitosamente";
            }
            catch(Exception e)
            {
                return e.Message;
            }
           
        }

    }
}