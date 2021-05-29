using System;
using System.Collections.Generic;

namespace PizzaBuilder
{


    public interface PizzaBuilder
    {
        void reset();
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }
    
    public class WheatPizzaBuilder : PizzaBuilder
    {
        private WheatPizza _product = new WheatPizza();
        public WheatPizzaBuilder()
        {
            this.reset();
        }
        public void reset()
        {
            this._product = new WheatPizza();
        }
        public void BuildDough()
        {
            this._product.Add("Wheat Dough");
        }
        public void BuildSauce()
        {
            this._product.Add("Ketchup Sauce");
        }
        public void BuildTopping()
        {
            this._product.Add("Pepperoni");
        }
        public WheatPizza GetProduct()
        {
            WheatPizza result = this._product;
            this.reset();
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

            return "pizza details : " + string.Join(", ", this.parts.ToArray()); 
        }
    }


    public class WhitePizzaBuilder : PizzaBuilder
    {
        private WhitePizza _product = new WhitePizza();
        public WhitePizzaBuilder()
        {
            this.reset();
        }
        public void reset()
        {
            this._product = new WhitePizza();
        }
        public void BuildDough()
        {
            this._product.Add("White Dough");
        }
        public void BuildSauce()
        {
            this._product.Add("garlic Sauce");
        }
        public void BuildTopping()
        {
            this._product.Add("chicken ");
        }
        public WhitePizza GetProduct()
        {
            WhitePizza result = this._product;
            this.reset();
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
            return "pizza details : " + string.Join(", ", this.parts.ToArray());
        }
    }
    public class Director
    {
        private PizzaBuilder  _PizzaBuilder;
        public PizzaBuilder Builder
        {
            set { this._PizzaBuilder = value; }
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
            var director = new Director();
            var builder = new WhitePizzaBuilder();

            //Full Product WhitePizzaBuilder
            director.Builder = builder;
            director.makePizza();
            Console.WriteLine(builder.GetProduct().listParts());
            
            //Full Product WheatPizzaBuilder
            var builder1 = new WheatPizzaBuilder();
            director.Builder = builder1;
            director.makePizza();
            Console.WriteLine(builder1.GetProduct().listParts());
        }
    }

}
