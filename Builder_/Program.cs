using System;

namespace builder_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client Code
            var whitePizzaBuilder = new WhitePizzaBuilder();
            var director = new Director(whitePizzaBuilder);
            director.makePizza();
            Console.WriteLine(whitePizzaBuilder.GetPizza().DelieveredPizza());

            //Bonus 1: the client plays the Director role and interact with PizzaBuilder directly.
            var wheatPB = new WheatPizzaBuilder();
            wheatPB
            .BuildDough()
            .BuildTopping()
            .BuildSauce();
            Console.WriteLine(wheatPB.GetPizza().DelieveredPizza());

            //Bonus 2: Accept entres from client to choose how the pizza is going to be cooked
            var whitePB = new WhitePizzaBuilder();
            director = new Director(whitePB);
            director.makePizza("White Stiff Dough", "Hot Souce", true);
            Console.WriteLine(whitePB.GetPizza().DelieveredPizza());



        }
    }
}