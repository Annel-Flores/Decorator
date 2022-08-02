using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Decorator
{
    public class PreOrden : OrdenBase
    {
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("Calculo del precio total en una PreOrden");
            return artículos.Sum(x => x.Precio) * 0.9;
        }
    }
}