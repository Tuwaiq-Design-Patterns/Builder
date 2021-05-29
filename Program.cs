using System;

namespace Builder
{
   class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new WhitePizzaBuilder();
            director.Builder = builder;
            //Bonus 2 Director takes input from user
            director.makePizza();
            System.Console.WriteLine("With the director");
            Console.WriteLine(builder.GetPizza().listComponents());
            System.Console.WriteLine("\n******************\n");
            //Bonus 1 Custom Pizza without director
            builder.BuildDough();
            builder.BuildTopping();
            builder.BuildSauce();
            System.Console.WriteLine("Without the director");
            Console.WriteLine(builder.GetPizza().listComponents());
        }
    }
}
