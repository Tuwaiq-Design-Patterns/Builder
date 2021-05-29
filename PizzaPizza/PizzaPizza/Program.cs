using System;
using System.Collections.Generic;

namespace PizzaPizza
{
    public interface IPizzaBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }

    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza;
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            Pizza result = this.pizza;
            this.Reset();
            return result;
        }

        public void BuildDough()
        {
            this.pizza.Add("White Dough");
        }

        public void BuildSauce()
        {
            this.pizza.Add("white Sauce");
        }

        public void BuildTopping()
        {
            this.pizza.Add("olive");
        }

    }


    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza;
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            Pizza result = this.pizza;
            this.Reset();
            return result;
        }

        public void BuildDough()
        {
            this.pizza.Add("Wheat Dough");
        }

        public void BuildSauce()
        {
            this.pizza.Add("Tomato Sauce");
        }

        public void BuildTopping()
        {
            this.pizza.Add("Cheese");
        }

    }

    public class Pizza
    {
        private List<object> ingredients = new List<object>();
        public void Add(string part)
        {
            this.ingredients.Add(part);
        }
        public string listIngredients()
        {
            string str = "";
            for (int i = 0; i < this.ingredients.Count; i++)
            {
                if (i < this.ingredients.Count - 1) str += this.ingredients[i] + ",";
                else str += this.ingredients[i] + ".";
            }
            return "Pizaa ingredients are:" + str;
        }
    }


    public class Director
    {
        private IPizzaBuilder builder;
        public IPizzaBuilder Builder
        {
            set { this.builder = value; }
        }
        public void WithSuase()
        {
            this.builder.BuildDough();
            this.builder.BuildSauce();
            this.builder.BuildTopping();
        }
        public void WithoutSuase()
        {
            this.builder.BuildDough();
            this.builder.BuildSauce();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var wheatPizzaBuilder = new WheatPizzaBuilder();
            director.Builder = wheatPizzaBuilder;
            //Wheat Pizza With Suase
            director.WithSuase();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().listIngredients());
            //Wheat Pizza With Suase
            director.WithoutSuase();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().listIngredients());
          


            var whitePizzaBuilder = new WhitePizzaBuilder();
            director.Builder = whitePizzaBuilder;
            //Wheat Pizza With Suase
            director.WithSuase();
            Console.WriteLine(whitePizzaBuilder.GetPizza().listIngredients());
            //Wheat Pizza With Suase
            director.WithoutSuase();
            Console.WriteLine(whitePizzaBuilder.GetPizza().listIngredients());
        }
    }
}
