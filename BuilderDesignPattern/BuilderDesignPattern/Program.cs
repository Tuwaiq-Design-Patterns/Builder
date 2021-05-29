using System;
using System.Collections.Generic;

namespace BuilderDesignPattern
{
    class Program
    {
        public interface IPizzaBuilder
        {
            void Reset();
            void BuildDough();
            void BuildSauce();
            void BuildTopping();
            void BuildCheese();
            void BuildDoubleCheese();
        }

        public class WheatPizzaBuilder : IPizzaBuilder
        {
            private Pizza pizza = new Pizza();

            public void Reset()
            {
                this.pizza = new Pizza();
            }

            public void BuildDough() 
            {
                this.pizza.Add("Add wheat dough");
            }

            public void BuildSauce() 
            {
                this.pizza.Add("Add sauce");
            }

            public void BuildTopping() 
            {
                this.pizza.Add("Add topping");
            }

            public void BuildCheese()
            {
                this.pizza.Add("Add cheese");
            }

            public void BuildDoubleCheese()
            {
                this.pizza.Add("Add double cheese");
            }

            public Pizza GetPizza()
            {
                Pizza result = this.pizza;
                this.Reset();
                return result;
            }

        }

        public class WhitePizzaBuilder : IPizzaBuilder
        {
            private Pizza pizza = new Pizza();

            public void Reset()
            {
                this.pizza = new Pizza();
            }

            public void BuildDough()
            {
                this.pizza.Add("Add white dough");
            }

            public void BuildSauce()
            {
                this.pizza.Add("Add sauce");
            }

            public void BuildTopping()
            {
                this.pizza.Add("Add topping");
            }

            public void BuildCheese()
            {
                this.pizza.Add("Add cheese");
            }

            public void BuildDoubleCheese()
            {
                this.pizza.Add("Add double cheese");
            }

            public Pizza GetPizza()
            {
                Pizza result = this.pizza;
                this.Reset();
                return result;
            }
        }

        public class Pizza
        {
            private List<object> parts = new List<object>();

            public void Add(string part)
            {
                this.parts.Add(part);
            }

            public string ListParts()
            {
                string str = "";
                for (int i = 0; i < this.parts.Count; i++)
                {
                    str += this.parts[i] + ",";
                }

                return "Pizza parts: " + str;
            }
        }

        public class Director
        {
            private IPizzaBuilder pizzaBuilder;

            public IPizzaBuilder Builder
            {
                set
                {
                    this.pizzaBuilder = value;
                }
            }

            // minimalist pizza
            public void BuildMinPizza()
            {
                this.pizzaBuilder.BuildDough();
                this.pizzaBuilder.BuildSauce();
            }

            // fancy pizza with less cheese
            public void BuildFancyPizza()
            {
                this.pizzaBuilder.BuildDough();
                this.pizzaBuilder.BuildSauce();
                this.pizzaBuilder.BuildTopping();
                this.pizzaBuilder.BuildCheese();
            }

            // fancy pizza with more cheese
            public void BuildFancyPizzaDoubleCheese()
            {
                this.pizzaBuilder.BuildDough();
                this.pizzaBuilder.BuildSauce();
                this.pizzaBuilder.BuildTopping();
                this.pizzaBuilder.BuildDoubleCheese();
            }
        }

        static void Main(string[] args)
        {
            var director = new Director();

            var wheatPizzaBuilder = new WheatPizzaBuilder();
            var whitePizzaBuilder = new WhitePizzaBuilder();

            director.Builder = wheatPizzaBuilder;

            // build a fancy wheat pizza with less cheese using the director
            director.BuildFancyPizza();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().ListParts());

            // build a fancy wheat pizza with more cheese using the director
            director.BuildFancyPizzaDoubleCheese();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().ListParts());

            // build a minimalist wheat pizza using the director
            director.BuildMinPizza();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().ListParts());

            director.Builder = whitePizzaBuilder;

            // build a fancy white pizza with less cheese using the director
            director.BuildFancyPizza();
            Console.WriteLine(whitePizzaBuilder.GetPizza().ListParts());

            // build a fancy white pizza with more cheese using the director
            director.BuildFancyPizzaDoubleCheese();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().ListParts());

            // build a minimalist white pizza using the director
            director.BuildMinPizza();
            Console.WriteLine(whitePizzaBuilder.GetPizza().ListParts());

            // build customized wheat pizza using the client directly
            wheatPizzaBuilder.BuildDough();
            wheatPizzaBuilder.BuildSauce();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().ListParts());


            // build customized white pizza using the client directly
            whitePizzaBuilder.BuildDough();
            whitePizzaBuilder.BuildSauce();
            Console.WriteLine(whitePizzaBuilder.GetPizza().ListParts());



        }
    }
}
