using System;

namespace ConsoleApplication4
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class main
    {
        public static void Main()
        {
            WhitePizzaBuilder p = new WhitePizzaBuilder();
            Director d = new Director(p);
            d.make();
            Console.WriteLine(p.getPizza().listParts());
        }
    }
}