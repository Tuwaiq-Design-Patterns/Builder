using System;
using System.Collections.Generic;

namespace BuilderTest
{
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
    public interface IPizzaBuilder
    {
        void BuildDough();
        void BuildSauce(string sausce = "Tomato Sausce");
        void BuildTopping(string topping = "Topping");
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
            this._pizza.Add("White Dough");
        }
        public void BuildSauce(string sausce = "Tomato Sausce")
        {
            this._pizza.Add(sausce);
        }
        public void BuildTopping(string topping ="Topping")
        {
            this._pizza.Add(topping);
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
            this._pizza.Add("Wheat Dough");
        }
        public void BuildSauce(string sausce = "Tomato Sausce")
        {
            this._pizza.Add(sausce);
        }
        public void BuildTopping(string topping = "Topping")
        {
            this._pizza.Add(topping);
        }
        public Pizza getPizza()
        {
            Pizza result = this._pizza;
            this.Reset();
            return result;
        }
    }
   
    public class Director
    {
        private IPizzaBuilder _PizzaBuilder;
        public Director(IPizzaBuilder pizzaBuilder)
        {
            this._PizzaBuilder = pizzaBuilder;
        }

        public void makePizza()
        {
            this._PizzaBuilder.BuildDough();
            this._PizzaBuilder.BuildTopping();
            this._PizzaBuilder.BuildSauce();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________");
            //client
            WhitePizzaBuilder WhiteBuilder = new WhitePizzaBuilder();
            Director directorA = new Director(WhiteBuilder);

            //Defult White Pizza
            directorA.makePizza();
            Console.WriteLine(WhiteBuilder.getPizza().listParts());
            Console.WriteLine("______________________________");

            //Custom White Pizza
            WhiteBuilder.BuildDough();
            WhiteBuilder.BuildSauce();
            WhiteBuilder.BuildTopping("Tomato, Onin, olive");
            // to print the pizza
            Console.WriteLine(WhiteBuilder.getPizza().listParts());
            Console.WriteLine("______________________________");


            //client
            WheatPizzaBuilder wheatBuilder = new WheatPizzaBuilder();
            Director directorB = new Director(wheatBuilder);

            //Defult Wheat Pizza
            directorB.makePizza();
            Console.WriteLine(wheatBuilder.getPizza().listParts());
            Console.WriteLine("______________________________");

            //Custom Wheat Pizza
            wheatBuilder.BuildDough();
            wheatBuilder.BuildSauce("Ranch Sousce");
            Console.WriteLine(wheatBuilder.getPizza().listParts());

        }
    }
}
