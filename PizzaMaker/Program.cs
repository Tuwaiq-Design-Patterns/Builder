using System;
using PizzaMaker.Builders;

namespace PizzaMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //client
            Director director = new Director();
            NeapolitanPizzaBuilder builder = new NeapolitanPizzaBuilder();
            director.PizzaBuilder = builder;

            // Pepperoni Pizza
            director.BuildPepperoni();
            builder.GetPizza();

            //  Veggie Pizza
            director.BuildVeggie();
            builder.GetPizza();

            // Custom Pizza
            builder.SetDough(null);
            builder.SetCheese(null);
            builder.SetSauce(null); // sauce over cheese!!
            builder.GetPizza();

        }
    }
}
