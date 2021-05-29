using System;
using System.Collections.Generic;
namespace Builder
{
    public interface IPizzaBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }
    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._pizza = new Pizza();
        }
        public void BuildDough()
        {
            this._pizza.Add("Dough");
        }
        public void BuildSauce()
        {
            this._pizza.Add("Sausce");
        }
        public void BuildTopping()
        {
            this._pizza.Add("Topping");
        }
        public Pizza getPizza()
        {
            Pizza result = this._pizza;
            this.Reset();
            return result;
        }
    }
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._pizza = new Pizza();
        }
        public void BuildDough()
        {
            this._pizza.Add("Dough");
        }
        public void BuildSauce()
        {
            this._pizza.Add("Sausce");
        }
        public void BuildTopping()
        {
            this._pizza.Add("Topping");
        }
        public Pizza getPizza()
        {
            Pizza result = this._pizza;
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
        public string listParts()
        {
            string str = "";
            for (int i = 0; i < this.parts.Count; i++)
            {
                str += this.parts[i] + ",";
            }
            return "pizza parts:" + str;
        }
    }
    public class Director
    {
        private IPizzaBuilder _PizzaBuilder;
        public Director(IPizzaBuilder pizzaBuilder) {
            this._PizzaBuilder = pizzaBuilder;
        }

        public void makePizza()
        {
            this._PizzaBuilder.BuildTopping();
            this._PizzaBuilder.BuildDough();
            this._PizzaBuilder.BuildSauce();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("White Pizza Builder");
            //client
            WhitePizzaBuilder WhiteBuilder = new WhitePizzaBuilder();
            Director directorA = new Director(WhiteBuilder);
            //Make Pizza
            directorA.makePizza();
            Console.WriteLine(WhiteBuilder.getPizza().listParts());
            //Custom Pizza
            WhiteBuilder.BuildSauce();
            WhiteBuilder.BuildTopping();
            Console.WriteLine(WhiteBuilder.getPizza().listParts());

            Console.WriteLine("Wheat Pizza Builder");

            //client
            WheatPizzaBuilder wheatBuilder = new WheatPizzaBuilder();
            Director directorB = new Director(wheatBuilder);
            //Make Pizza
            directorB.makePizza();
            Console.WriteLine(wheatBuilder.getPizza().listParts());
            //Custom Pizza
            wheatBuilder.BuildSauce();
            wheatBuilder.BuildDough();
            Console.WriteLine(wheatBuilder.getPizza().listParts());

        }
    }
}