//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VentaVehiculos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        public int id { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public Nullable<double> precio { get; set; }
        public Nullable<int> idCliente { get; set; }


        public virtual Cliente Cliente { get; set; }


    }
}
