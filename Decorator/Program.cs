using System;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var OrdenRegular = new OrdenRegular();
            Console.WriteLine(OrdenRegular.CalculoTotalPrecio());
            Console.WriteLine();

            var preOrden = new PreOrden();
            Console.WriteLine(preOrden.CalculoTotalPrecio());
            Console.WriteLine();

            var OrdenPremium = new OrdenPremium(preOrden);
            Console.WriteLine(OrdenPremium.CalculoTotalPrecio());
            Console.WriteLine();
        }
    }
}