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
    public class ThinPizzaBuilder : PizzaBuilder
    {
        private ThinPizza pizza = new ThinPizza();
        public ThinPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.pizza = new ThinPizza();
        }
        public void BuildDough()
        {
            this.pizza.Add("Thin Dough");
        }
        public void BuildSauce()
        {
            this.pizza.Add("Marinara Sauce");
        }
        public void BuildTopping()
        {
            this.pizza.Add("Mozzarella cheese");
        }
        public ThinPizza GetProduct()
        {
            ThinPizza result = this.pizza;
            this.Reset();
            return result;
        }
    }
    public class ThinPizza
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
    public class ThickPizzaBuilder : PizzaBuilder
    {
        private ThickPizza pizza = new ThickPizza();
        public ThickPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.pizza = new ThickPizza();
        }
        public void BuildDough()
        {
            this.pizza.Add("Thick Dough");
        }
        public void BuildSauce()
        {
            this.pizza.Add("Marinara Sauce");
        }
        public void BuildTopping()
        {
            this.pizza.Add("Four cheeses");
        }
        public ThickPizza GetProduct()
        {
            ThickPizza result = this.pizza;
            this.Reset();
            return result;
        }
    }
    public class ThickPizza
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
            var builder = new ThinPizzaBuilder();
            director.Builder = builder;
            
            director.makePizza(); // first product
            Console.WriteLine(builder.GetProduct().listParts());
            var builder1 = new ThickPizzaBuilder();
            director.Builder = builder1;
            
            director.makePizza(); // second product
            Console.WriteLine(builder1.GetProduct().listParts());
        }
    }
}