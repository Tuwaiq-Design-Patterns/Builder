using System;
using System.Collections.Generic;
namespace PizzaBuilder
{
    public interface IPizzaBuilder
    {
        void buildDough();
        void buildSauce();
        void buildTopping();
        void reset();
    }

    public class Director
    {
        private IPizzaBuilder _pizzaBuilder;

        public IPizzaBuilder PizzaBuilder
        {
            set
            {
                this._pizzaBuilder = value;
            }
        }

        public void makePizza()
        {
            this._pizzaBuilder.buildDough();
            this._pizzaBuilder.buildSauce();
            this._pizzaBuilder.buildTopping();
        }

        public void makePizzaNoSauce()
        {
            this._pizzaBuilder.buildDough();
            this._pizzaBuilder.buildTopping();
        }
    }

    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza _whitePizza = new WhitePizza();

        public WhitePizzaBuilder()
        {
            this.reset();
        }

        public void buildDough()
        {
            this._whitePizza.Add("White Dough");
        }
        public void buildSauce()
        {
            this._whitePizza.Add("Sauce");
        }
        public void buildTopping()
        {
            this._whitePizza.Add("Topping");
        }
        public void reset()
        {
            this._whitePizza = new WhitePizza();
        }

        public WhitePizza GetProduct()
        {
            WhitePizza result = this._whitePizza;
            this.reset();
            return result;
        }

    }

    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza _WheatPizza = new WheatPizza();

        public WheatPizzaBuilder()
        {
            this.reset();
        }

        public void buildDough()
        {
            this._WheatPizza.Add("Wheat Dough");
        }
        public void buildSauce()
        {
            this._WheatPizza.Add("Sauce");
        }
        public void buildTopping()
        {
            this._WheatPizza.Add("Topping");
        }
        public void reset()
        {
            this._WheatPizza = new WheatPizza();
        }

        public WheatPizza GetProduct()
        {
            WheatPizza result = this._WheatPizza;
            this.reset();
            return result;
        }
    }

    public class WhitePizza
    {
        private List<object> whitePizza = new List<object>();
        public void Add(string part)
        {
            this.whitePizza.Add(part);
        }
        public string WhitePizzalistParts()
        {
            string str = "";
            for (int i = 0; i < this.whitePizza.Count; i++)
            {
                str += this.whitePizza[i] + ",";
            }
            return "white Pizza parts: " + str;
        }
    }

    public class WheatPizza
    {
        private List<object> wheatPizza = new List<object>();
        public void Add(string part)
        {
            this.wheatPizza.Add(part);
        }
        public string wheatPizzalistParts()
        {
            string str = "";
            for (int i = 0; i < this.wheatPizza.Count; i++)
            {
                str += this.wheatPizza[i] + ",";
            }
            return "wheat Pizza parts: " + str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Director dir = new Director();
            WhitePizzaBuilder builder = new WhitePizzaBuilder();
            WheatPizzaBuilder wPBuilder = new WheatPizzaBuilder();

            dir.PizzaBuilder = builder;
            dir.makePizza();
            Console.WriteLine(builder.GetProduct().WhitePizzalistParts());

            dir.PizzaBuilder = wPBuilder;
            dir.makePizzaNoSauce();
            Console.WriteLine(wPBuilder.GetProduct().wheatPizzalistParts());

            //Bonus 1
            wPBuilder.buildDough();
            wPBuilder.buildSauce();
            Console.WriteLine(wPBuilder.GetProduct().wheatPizzalistParts());

            Console.WriteLine("Choose Dough: ");
            string dough = Console.ReadLine();

            Console.WriteLine("Choose Sauce: ");
            string Sauce = Console.ReadLine();

            Console.WriteLine("Choose Topping: ");
            string Topping = Console.ReadLine();

            Console.WriteLine(wPBuilder.GetProduct().wheatPizzalistParts() + dough+" "+ Sauce + " " + Topping);
        }
    }
}
