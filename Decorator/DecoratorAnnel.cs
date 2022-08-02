using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class DecoratorAnnel : OrdenBase
    {
        protected OrdenBase orden;
        public DecoratorAnnel(OrdenBase orden)
        {
            this.orden = orden;
        }
        public override double CalculoTotalPrecio()
        {
            Console.WriteLine("CALCULO DEL PRECIO TOTAL DESDE LA CLASER DECORADOR");
            return orden.CalculoTotalPrecio();
        }
    }

}