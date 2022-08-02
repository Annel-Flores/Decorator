using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class OrdenPremium : DecoratorAnnel
    {
        public OrdenPremium(OrdenBase orden) : base(orden)
        {

        }
        public override double CalculoTotalPrecio()
        {

            Console.WriteLine("Calculo total del precio OrdenPremium");
            var preOrdenPrecio = base.CalculoTotalPrecio();
            return preOrdenPrecio * 0.9;
        }
    }
}