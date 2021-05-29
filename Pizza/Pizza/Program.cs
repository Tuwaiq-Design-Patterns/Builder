using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            //client
            var director = new Director();
            var builder = new WheatPizzaBuilder();
            director.Builder = builder;

            // WheatPizzaBuilder
            director.StandardPizza();
            Console.WriteLine(builder.getPizza().Pizza_info());


            // WhitePizzaBuilder
           var builder1 = new WhitePizzaBuilder();
            director.Builder = builder1;
            director.StandardPizza();
            Console.WriteLine(builder1.getPizza().Pizza_info());
        }
    }
}
