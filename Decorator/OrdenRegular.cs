using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Decorator
{
    

    public class OrdenRegular : OrdenBase
    {
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine(" Calculo del Precio total de un pedido normal");
            return artículos.Sum(x => x.Precio);
        }
    }
}