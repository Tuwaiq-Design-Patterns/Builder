using System;
using System.Collections.Generic;

namespace PizzaBuilder
{
    public interface IPizzaBuilder
    {
        void Reset();
        void buildDough();
        void buildSauce();
        void buildTopping();
    }
    class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza pizza = new WhitePizza();

        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {

        }
        public void buildDough()
        {
            this.pizza.add("regular white dough");
        }

        public void buildSauce()
        {
            this.pizza.add("Tomato sauce");
        }

        public void buildTopping()
        {
            this.pizza.add("Pepperoni");
        }
        public WhitePizza getPizza()
        {
            WhitePizza p = this.pizza;
            this.Reset();
            return p;
        }
    }
    public class WhitePizza
    {
        private List<object> pizza = new List<object>();

        public void add(string ingredient)
        {
            this.pizza.Add(ingredient);
        }

        public string makePizza()
        {
            string str = "";
            for (int i = 0; i < this.pizza.Count; i++)
            {
                str += " "+ this.pizza[i] + ",";
            }
            str = str.Remove(str.Length - 1, 1) + ".";
            return "Pizza :" + str;
        }
    }
    class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza pizza = new WheatPizza();

        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {

        }
        public void buildDough()
        {
            this.pizza.add("thin wheat dough");
        }

        public void buildSauce()
        {
            this.pizza.add("Barbecue Sauce");
        }

        public void buildTopping()
        {
            this.pizza.add("vegies");
        }
        public WheatPizza getPizza()
        {
            WheatPizza p = this.pizza;
            this.Reset();
            return p;
        }
    }
    public class WheatPizza
    {
        private List<object> pizza = new List<object>();

        public void add(string ingredient)
        {
            this.pizza.Add(ingredient);
        }

        public string makePizza()
        {
            string str = "";
            for (int i = 0; i < this.pizza.Count; i++)
            {
                str += " " + this.pizza[i] + ",";
            }
            str = str.Remove(str.Length - 1, 1) + ".";
            return "Pizza :" + str;
        }
    }

    class Director
    {
        private IPizzaBuilder builder;
        public IPizzaBuilder Builder
        {
            set { this.builder = value; }
        }
        public void makePizza()
        {
            this.builder.buildDough();
            this.builder.buildSauce();
            this.builder.buildTopping();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var waitress = new Director();
            Console.WriteLine(@"Hi, I'm your waitress! what would you like to order?
1- classic pepporoni pizza? or
2- wheat dough veggies pizza?
===============================");
            int order = Convert.ToInt32(Console.ReadLine());
            if (order == 1)
            { 
                var chef = new WhitePizzaBuilder();
                waitress.Builder = chef;
                waitress.makePizza();
                Console.WriteLine(chef.getPizza().makePizza());
                Console.WriteLine("Enjoy!");
            } else if (order == 2)
            {
                var builder2 = new WheatPizzaBuilder();
                waitress.Builder = builder2;

                waitress.makePizza();
                Console.WriteLine(builder2.getPizza().makePizza());
                Console.WriteLine("Enjoy!");
            } else
            {
                Console.WriteLine("This order isn't avaliable!");
            }

        }
    }
}
