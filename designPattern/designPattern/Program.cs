using System;
using System.Collections.Generic;

namespace PizzaDesignPattern
{
    public interface IPizzaBuilder
    {
        public void reset();
        public void BuildDough();
        public void BuildSous();
        public void BuildTopping();
    }
    public class WhitePizza : IPizzaBuilder
    {
        private Pizza Pizza = new Pizza();
        public WhitePizza()
        {
            this.reset();
        }

        public void BuildDough()
        {
            this.Pizza.add("white dough");
        }

        public void BuildSous()
        {
            this.Pizza.add("sous");
        }

        public void BuildTopping()
        {
            this.Pizza.add("topping");
        }

        public void reset()
        {
            this.Pizza = new Pizza();
        }
        public Pizza GetPizza()
        {
            Pizza result = this.Pizza;
            this.reset();
            return result;
        }
    }
    public class WheatPizza : IPizzaBuilder
    {
        private Pizza Pizza = new Pizza();
        public WheatPizza()
        {
            this.reset();
        }

        public void BuildDough()
        {
            this.Pizza.add("wheat Dough");
        }

        public void BuildSous()
        {
            this.Pizza.add("sous");
        }

        public void BuildTopping()
        {
            this.Pizza.add("topping");
        }

        public void reset()
        {
            this.Pizza = new Pizza();
        }
        public Pizza GetPizza()
        {
            Pizza result = this.Pizza;
            this.reset();
            return result;
        }
    }
    public class Pizza
    {
        private List<object> FPizza = new List<object>();
        public void add(string component)
        {
            this.FPizza.Add(component);
        }
        public string FinalPizza()
        {
            string str = "";
            for (int i = 0; i < FPizza.Count; i++)
            {
                str += FPizza[i] + " ";
            }
            return "your pizza : " + str;
        }
    }
    public class Director
    {
        private IPizzaBuilder pizzaBuilder;
        public IPizzaBuilder Builder
        {
            set { this.pizzaBuilder = value; }
        }
        public void makeFullPizza()
        {
            this.pizzaBuilder.BuildDough();
            this.pizzaBuilder.BuildSous();
            this.pizzaBuilder.BuildTopping();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            var whitePizza = new WhitePizza();
            director.Builder = whitePizza;
            director.makeFullPizza();
            Console.WriteLine(whitePizza.GetPizza().FinalPizza());

            var wheatPizza = new WheatPizza();
            director.Builder = wheatPizza;
            director.makeFullPizza();
            Console.WriteLine(wheatPizza.GetPizza().FinalPizza());

            //bonus Part
            whitePizza.BuildDough();
            whitePizza.BuildSous();
            Console.WriteLine(whitePizza.GetPizza().FinalPizza());
        }
    }
}
