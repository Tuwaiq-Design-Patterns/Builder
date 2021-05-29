using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var whitePizzabuilder = new WhitePizzaBuilder();
            director.Builder = whitePizzabuilder;
            
            director.makePizzaFull();
            Console.WriteLine("BuildFull:");
            Console.WriteLine(whitePizzabuilder.GetPizza().PizzaPartsList()); 
            Console.WriteLine("");
            
            director.makePizzaMin();
            Console.WriteLine("BuildMin:");
            Console.WriteLine(whitePizzabuilder.GetPizza().PizzaPartsList());
            Console.WriteLine("");
            
            //Bonus 1
            var wheatPizzaBuilder = new WheatPizzaBuilder();
            wheatPizzaBuilder.BuildDough();
            wheatPizzaBuilder.BuildTopping();
            Console.WriteLine("Customize:");
            Console.WriteLine(wheatPizzaBuilder.GetPizza().PizzaPartsList());
            
            //Bonus 2
            Console.WriteLine("The Dough type (White or Wheat):");
            string order = Console.ReadLine() + ", ";
            Console.WriteLine("The Sauce type:");
            order += Console.ReadLine() + ", ";
            Console.WriteLine("The Topping type:");
            order += Console.ReadLine() + ", ";
            
            director.SetOrder(order);
        }
    }
}