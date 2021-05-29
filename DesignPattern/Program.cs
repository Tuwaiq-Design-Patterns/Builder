using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WheatPizza wheatPizza;
            WhitePizza whitePizza;

            WheatPizzaBuilder wheatPizzaBuilder = new WheatPizzaBuilder();
            WhitePizzaBuilder whitePizzaBuilder = new WhitePizzaBuilder();

            Director wheatPizzaDirector = new Director(wheatPizzaBuilder);
            Director whitePizzaDirector = new Director(whitePizzaBuilder);
            
            wheatPizzaDirector.MakePizza();
            whitePizzaDirector.MakePizza();

            wheatPizza = wheatPizzaBuilder.Build();
            whitePizza = whitePizzaBuilder.Build();

            Console.WriteLine(wheatPizza.GetPizzaDetails());
            Console.WriteLine(whitePizza.GetPizzaDetails());
        }
    }
}