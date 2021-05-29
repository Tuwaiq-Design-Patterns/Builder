using System;
using System.Collections.Generic;

namespace Pizza_Builder
{
    public interface PizzaBuilder
    {

        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }
    public class WhitePizzaBuilder : PizzaBuilder
    {
        private WhitePizza product = new WhitePizza();
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.product = new WhitePizza();
        }
        public void BuildDough()
        {
            this.product.Add("White Dough");
        }
        public void BuildSauce()
        {
            this.product.Add("Buffalo Sauce");
        }
        public void BuildTopping()
        {
            this.product.Add("Extra Cheese");
        }
        public WhitePizza GetProduct()
        {
            WhitePizza result = this.product;
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
        private WheatPizza product = new WheatPizza();
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.product = new WheatPizza();
        }
        public void BuildDough()
        {
            this.product.Add("Wheat Dough");
        }
        public void BuildSauce()
        {
            this.product.Add("Garlic Ranch Sauce");
        }
        public void BuildTopping()
        {
            this.product.Add("Mushrooms");
        }
        public WheatPizza GetProduct()
        {
            WheatPizza result = this.product;
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
            director.makePizza();
            Console.WriteLine(builder.GetProduct().listParts());

            var builder1 = new WheatPizzaBuilder();
            director.Builder = builder1;
            director.makePizza();
            Console.WriteLine(builder1.GetProduct().listParts());

        }


    }
}