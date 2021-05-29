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
        public void BuildCheese();
    }
    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza Pizza = new WhitePizza();
        public WhitePizzaBuilder()
        {
            this.reset();
        }

        public void BuildDough()
        {
            this.Pizza.add("white dough");
        }

        public void BuildSous()
        {
            this.Pizza.add(", sous");
        }

        public void BuildTopping()
        {
            this.Pizza.add(", topping");
        }

        public void BuildCheese()
        {
            this.Pizza.add(", cheese");
        }

        public void reset()
        {
            this.Pizza = new WhitePizza();
        }
        public WhitePizza GetPizza()
        {
            WhitePizza result = this.Pizza;
            this.reset();
            return result;
        }
    }
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza Pizza = new WheatPizza();
        public WheatPizzaBuilder()
        {
            this.reset();
        }

        public void BuildDough()
        {
            this.Pizza.add("wheat Dough");
        }

        public void BuildSous()
        {
            this.Pizza.add(", sous");
        }

        public void BuildTopping()
        {
            this.Pizza.add(", topping");
        }

        public void BuildCheese()
        {
            this.Pizza.add(", cheese");
        }

        public void reset()
        {
            this.Pizza = new WheatPizza();
        }
        public WheatPizza GetPizza()
        {
            WheatPizza result = this.Pizza;
            this.reset();
            return result;
        }
    }
    public class WheatPizza
    {
        private List<object> FPizza = new List<object>();
        public void add(string component)
        {
            this.FPizza.Add(component);
        }
        public string FinalPizza()
        {
            string str = "";
            for (int i = 0; i < this.FPizza.Count; i++)
            {
                str += this.FPizza[i] + " ";
            }
            return "your pizza : " + str;
        }
    }
    public class WhitePizza
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
            this.pizzaBuilder.BuildCheese();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            var whitePizza = new WhitePizzaBuilder();

            var wheatPizza = new WheatPizzaBuilder();

            //make pizza with white dough
            director.Builder = whitePizza;
            director.makeFullPizza();
            Console.WriteLine(whitePizza.GetPizza().FinalPizza());

            //make pizza with wheat dough
            director.Builder = wheatPizza;
            director.makeFullPizza();
            Console.WriteLine(wheatPizza.GetPizza().FinalPizza());

            //bonus Part
            whitePizza.BuildDough();
            whitePizza.BuildSous();
            whitePizza.BuildCheese();
            Console.WriteLine(whitePizza.GetPizza().FinalPizza());
        }
    }
}
