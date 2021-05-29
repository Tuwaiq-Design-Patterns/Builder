using System;

namespace PizzaBuilder
{
    class Program
    {

        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new WhitePizzaBuilder();
            director.Builder = builder;

            
            director.MakeMeatLoverPizza();

            Console.WriteLine(builder.GetPizza().listParts());
            
            director.MakeMargaritaPizza();
            Console.WriteLine(builder.GetPizza().listParts());

            
            var customBuilder = new WheatPizzaBuilder();
            customBuilder.BuildDough();
            customBuilder.BuildSauce();
            customBuilder.BuildTopping("Meat");
            customBuilder.BuildTopping("Cheese");
            Console.WriteLine(customBuilder.GetPizza().listParts());
        }
    }
    
}
