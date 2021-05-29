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
            void BuildSauce();
            void BuildTopping();

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

            public void BuildSauce()
            {
                this.pizza.addIngredient("Adding Tomato Sauce");
            }

            public void BuildTopping()
            {
                this.pizza.addIngredient("Adding Delicious Toppings");
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

            public void BuildSauce()
            {
                this.pizza.addIngredient("Tomato Sauce");
            }

            public void BuildTopping()
            {
                this.pizza.addIngredient("Delicious Toppings");
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

            public void addIngredient(string ing)
            {
                this.pizza_ingredients.Add(ing);
            }

            public string listIngredients()
            {
                string str = "";

                for (int i = 0; i < this.pizza_ingredients.Count; i++)
                {
                    str += this.pizza_ingredients[i] + ", ";
                }

                return "Pizza is ready! it has: \n" + str;
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

        }



        static void Main(string[] args)
        {




            var director = new Director();
            var whitePizza = new WhitePizzaBuilder();
            var wheatPizza = new WhitePizzaBuilder();

            director.Builder = whitePizza;
            director.MakePizzaWithSauce();
            Console.WriteLine(whitePizza.getPizza().listIngredients());

            Console.WriteLine("=======================");

            director.Builder = wheatPizza;
            director.MakePizzaFull();
            Console.WriteLine(wheatPizza.getPizza().listIngredients());




        }



    }
}
