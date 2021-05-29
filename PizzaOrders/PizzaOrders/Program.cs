//Builder Example
using System;
using System.Collections.Generic;
namespace Builder
{
    public interface IBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }
    public class WhitePizzaBuilder : IBuilder
    {
        private WhitePizza pizza = new WhitePizza();
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.pizza = new WhitePizza();
        }
        public void BuildDough()
        {
            this.pizza.Add("White Dough");
        }
        public void BuildSauce()
        {
            this.pizza.Add("Tomato Sauce");
        }
        public void BuildTopping()
        {
            this.pizza.Add("Green Pepper");
        }
        public WhitePizza GetProduct()
        {
            WhitePizza result = this.pizza;
            this.Reset();
            return result;
        }
    }
    public class WhitePizza
    {
        private List<object> ingredients = new List<object>();
        public void Add(string part)
        {
            this.ingredients.Add(part);
        }
        public string listParts()
        {
            string str = "";
            for (int i = 0; i < this.ingredients.Count; i++)
            {
                str += this.ingredients[i] + ",";
            }
            return "pizza ingredients:" + str;
        }
    }

    public class WheatPizzaBuilder : IBuilder
    {
        private WheatPizza pizza = new WheatPizza();
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.pizza = new WheatPizza();
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
            this.pizza.Add("Black Olive");
        }
        public WheatPizza GetPizza()
        {
            WheatPizza result = this.pizza;
            this.Reset();
            return result;
        }
    }

    public class WheatPizza
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
                str += this.ingredients[i] + ",";
            }
            return "pizza ingredients:" + str;
        }
    }

    public class Director
    {
        private IBuilder builder;
        public IBuilder Builder
        {
            set { this.builder = value; }
        }
        public void plainPizza()
        {
            this.builder.BuildDough();
            this.builder.BuildSauce();
        }
        public void makePizza()
        {
            this.builder.BuildDough();
            this.builder.BuildSauce();
            this.builder.BuildTopping();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //WHITE PIZZA:
            //client
            var director = new Director();
            var white = new WhitePizzaBuilder();
            director.Builder = white;
            //Full Product
            director.makePizza();
            Console.WriteLine(white.GetProduct().listParts());
            //Min Product
            director.plainPizza();
            Console.WriteLine(white.GetProduct().listParts());
            //Custom Product
            white.BuildSauce();
            white.BuildTopping();
            Console.WriteLine(white.GetProduct().listParts());

            Console.WriteLine("\n");

            //WHEAT PIZZA:
            //client
            var wheat = new WheatPizzaBuilder();
            director.Builder = wheat;
            //Full Product
            director.makePizza();
            Console.WriteLine(wheat.GetPizza().listIngredients());
            //Min Product
            director.plainPizza();
            Console.WriteLine(wheat.GetPizza().listIngredients());
            //Custom Product
            wheat.BuildSauce();
            wheat.BuildTopping();
            Console.WriteLine(wheat.GetPizza().listIngredients());
        }
    }
}