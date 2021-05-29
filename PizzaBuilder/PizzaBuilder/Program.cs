using System;
using System.Collections.Generic;

namespace PizzaBuilder
{
    class Program
    {

        public interface IPizzaBuilder
        {
            void Reset();
            void BuildDough();
            void BuildSauce(string s = "Tomato");
            void BuildTopping(string t = "Cheese");

        }

        public class WhitePizzaBuilder : IPizzaBuilder
        {
            private Pizza pizza = new Pizza();

            public WhitePizzaBuilder()
            {
                this.Reset();
            }

            public void BuildDough()
            {
                this.pizza.addIngredient("The Best white Dough");
            }

            public void BuildSauce(string s = "Tomato")
            {
                this.pizza.addIngredient($"{s} Sauce");
            }

            public void BuildTopping(string t = "Cheese")
            {
                this.pizza.addIngredient($"{t} Toppings");
            }

            public void Reset()
            {
                this.pizza = new Pizza();
            }

            public Pizza getPizza()
            {
                Pizza cookedPizza = this.pizza;
                this.Reset();
                return cookedPizza;
            }

        }

        public class WheatPizzaBuilder : IPizzaBuilder
        {
            private Pizza pizza = new Pizza();

            public WheatPizzaBuilder()
            {
                this.Reset();
            }

            public void BuildDough()
            {
                this.pizza.addIngredient("The Best wheat Dough");
            }

            public void BuildSauce(string s = "Tomato")
            {
                this.pizza.addIngredient($"{s} Sauce");
            }

            public void BuildTopping(string t = "Cheese")
            {
                this.pizza.addIngredient($"{t} Toppings");
            }

            public void Reset()
            {
                this.pizza = new Pizza();
            }

            public Pizza getPizza()
            {
                Pizza cookedPizza = this.pizza;
                this.Reset();
                return cookedPizza;
            }

        }


        public class Pizza
        {
            private List<object> pizza_ingredients = new List<object>();

            public void addIngredient(string ingredient)
            {
                this.pizza_ingredients.Add(ingredient);
            }

            public string listIngredients()
            {
                string str = "";

                for (int i = 0; i < this.pizza_ingredients.Count; i++)
                {
                    str += this.pizza_ingredients[i] + ", ";
                }

                return "Pizza is ready! it has: \t" + str;
            }

        }


        public class Director
        {
            private IPizzaBuilder pizzaBuilder;
            public IPizzaBuilder Builder
            {
                set { this.pizzaBuilder = value; }
            }
            public void MakePizzaWithSauce()
            {
                this.pizzaBuilder.BuildDough();
                this.pizzaBuilder.BuildSauce();
            }
            public void MakePizzaWithTopping()
            {
                this.pizzaBuilder.BuildDough();
                this.pizzaBuilder.BuildTopping();
            }
            public void MakePizzaFull()
            {
                this.pizzaBuilder.BuildDough();
                this.pizzaBuilder.BuildSauce();
                this.pizzaBuilder.BuildTopping();
            }
            public void MakePizzaCustom(string s, string t)
            {
                this.pizzaBuilder.BuildDough();
                this.pizzaBuilder.BuildSauce(s);
                this.pizzaBuilder.BuildTopping(t);
            }




        }



        static void Main(string[] args)
        {




            var director = new Director();
            var whitePizza = new WhitePizzaBuilder();
            var wheatPizza = new WheatPizzaBuilder();

            director.Builder = whitePizza;
            director.MakePizzaWithSauce();
            Console.WriteLine(whitePizza.getPizza().listIngredients());

            Console.WriteLine("=======================");

            director.Builder = wheatPizza;
            director.MakePizzaFull();
            Console.WriteLine(wheatPizza.getPizza().listIngredients());

            Console.WriteLine("=======================");

            //BONUS 1
            //pizza without dough....
            wheatPizza.BuildSauce();
            wheatPizza.BuildTopping();
            Console.WriteLine(wheatPizza.getPizza().listIngredients());

            Console.WriteLine("=======================");

            //BONUS 2
            Console.WriteLine("Don't like what's in the menu? make your own custom pizza!");
            Console.WriteLine("Dough? (we only have white and wheat)...");
            string doughInput = Console.ReadLine();
            Console.WriteLine("Sauce?");
            string sauceInput = Console.ReadLine();
            Console.WriteLine("Toppings?");
            string toppingInput = Console.ReadLine();

            director.Builder = doughInput == "white" ? whitePizza : wheatPizza;

            director.MakePizzaCustom(sauceInput, toppingInput);
            Console.WriteLine(wheatPizza.getPizza().listIngredients());
        }



    }
}
