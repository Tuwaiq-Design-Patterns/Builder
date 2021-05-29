using System;

namespace PizzaBuilder
{
    class Program
    {

        static void Main(string[] args)
        {
            //client
            var director = new Director();
            var builder = new WhitePizzaBuilder();
            director.Builder = builder;

            //Meat Lover pizza 
            director.MakeMeatLoverPizza();

            Console.WriteLine(builder.GetPizza().listParts());
            //Min Product
            director.MakeMargaritaPizza();
            Console.WriteLine(builder.GetPizza().listParts());

            //Custom WheatPizza Product
            var customBuilder = new WheatPizzaBuilder();
            customBuilder.BuildDough();
            customBuilder.BuildSauce();
            customBuilder.BuildTopping("Chicken");
            customBuilder.BuildTopping("Cheese");
            Console.WriteLine(customBuilder.GetPizza().listParts());
        }
    }
    
}
