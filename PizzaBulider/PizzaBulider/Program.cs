using System;
using System.Collections.Generic;

namespace PizzaBulider
{
    public interface PizzaBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }
    public class WhitePizzaBuilder : PizzaBuilder
    {
        private WhitePizza _product = new WhitePizza();
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new WhitePizza();
        }
        public void BuildDough()
        {
            this._product.Add("White Dough");
        }
        public void BuildSauce()
        {
            this._product.Add("Ranch Sauce");
        }
        public void BuildTopping()
        {
            this._product.Add("Chedder chesse");
        }
        public WhitePizza GetProduct()
        {
            WhitePizza result = this._product;
            this.Reset();
            return result;
        }
    }
    public class WhitePizza
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
            return "Order : " + str;
        }
    }
    public class WheatPizzaBuilder : PizzaBuilder
    {
        private WheatPizza _product = new WheatPizza();
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new WheatPizza();
        }
        public void BuildDough()
        {
            this._product.Add("Wheat Dough");
        }
        public void BuildSauce()
        {
            this._product.Add("Spicy Sauce");
        }
        public void BuildTopping()
        {
            this._product.Add("Pepperoni");
        }
        public WheatPizza GetProduct()
        {
            WheatPizza result = this._product;
            this.Reset();
            return result;
        }
    }
    public class WheatPizza
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
            return "Order : " + str;
        }
    }
    public class Director
    {
        private PizzaBuilder _builder;
        public PizzaBuilder Builder
        {
            set { this._builder = value; }
        }
        
        public void makePizza()
        {
            this._builder.BuildTopping();
            this._builder.BuildDough();
            this._builder.BuildSauce();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new WhitePizzaBuilder();
            director.Builder = builder;
            //Full Product
            director.makePizza();
            Console.WriteLine(builder.GetProduct().listParts());


            
            var builder1 = new WheatPizzaBuilder();
            director.Builder = builder1;
            //Full Product
            director.makePizza();
            Console.WriteLine(builder1.GetProduct().listParts());

        }


    }
}
