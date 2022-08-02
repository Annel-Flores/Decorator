using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class OrdenBase
    {
        protected List<Artículo> artículos = new List<Artículo>
{
   new Artículo {Nombre= "Telefono Iphone 11", Precio= 800},
   new Artículo {Nombre= "Tablet Ipad ", Precio= 1000},
   new Artículo {Nombre= "PC Gamer", Precio= 1800},
};
        public abstract double CalculoTotalPrecio();
    }
}