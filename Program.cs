using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client Code
            var whitePizzaBuilder = new WhitePizzaBuilder();
            var director = new Director(whitePizzaBuilder);
            director.makePizza();
            Console.WriteLine(whitePizzaBuilder.GetPizza().DescribePizza());

            //Bonus 1
            var wheatPizzaBuilder = new WheatPizzaBuilder();
            wheatPizzaBuilder
            .BuildDough()
            .BuildSauce()
            .BuildTopping();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().DescribePizza());

            //Bonus 2
            var whitePizzaBuilder2 = new WhitePizzaBuilder();
            director = new Director(whitePizzaBuilder2);
            director.makePizza("White Ultra thin", "Tartar", new string[] { "Confectionary sugar", "Cinnamon", "Essence of kitten", "Bottled rainbow" });
            Console.WriteLine(whitePizzaBuilder2.GetPizza().DescribePizza());

            //Output
            /*
                Pizza Description -> Dough: White Sauce: Tomato Topping: Olives Red Peppers Onions Paprika
                Pizza Description -> Dough: Wheat Sauce: Tomato Topping: Diced onions Green Peppers Italian Sausage Tartar sauce
                Pizza Description -> Dough: White Ultra thin Sauce: Tartar Topping: Confectionary sugar Cinnamon Essence of kitten Bottled rainbow
            */


        }
    }
}
