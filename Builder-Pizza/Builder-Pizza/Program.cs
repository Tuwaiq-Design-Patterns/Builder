using System;
using System.Collections.Generic;

namespace Builder_Pizza
{
    public interface IBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }
    public class WhitePizzaBuilder : IBuilder
    {
        private WhitePizza white_pizza = new WhitePizza();
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.white_pizza = new WhitePizza();
        }

        public void BuildDough()
        {
            this.white_pizza.Add("Creating the dough");
        }
        public void BuildSauce()
        {
            this.white_pizza.Add("Adding sauce");
        }
        public void BuildTopping()
        {
            this.white_pizza.Add("Adding topping");
        }

        public WhitePizza GetWhitePizza() 
        {
            WhitePizza result = this.white_pizza;
            this.Reset();
            return result;
        }
    }
    public class WheatPizzaBuilder : IBuilder
    {
        private WheatPizza wheat_pizza = new WheatPizza();
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.wheat_pizza = new WheatPizza();
        }
        public void BuildDough()
        {
            this.wheat_pizza.Add("Creating the dough");
        }
        public void BuildSauce()
        {
            this.wheat_pizza.Add("Adding sauce");
        }
        public void BuildTopping()
        {
            this.wheat_pizza.Add("Adding topping");
        }

        public WheatPizza GetWheatPizza()
        {
            WheatPizza result = this.wheat_pizza;
            this.Reset();
            return result;
        }
    }
    public class WhitePizza
    {
        private List<object> Whitepizza = new List<object>();

        public void Add(string p)
        {
            this.Whitepizza.Add(p);
        }
        public string listWhitepizza()
        {
            string str = "";
            for (int i = 0; i < this.Whitepizza.Count; i++)
            {
                str += this.Whitepizza[i] + ", \n";
            }
            return "White pizza ingredients: \n" + str;
        }
    }
    public class WheatPizza
    {
        private List<object> Wheatpizza = new List<object>();

        public void Add(string p)
        {
            this.Wheatpizza.Add(p);
        }
        public string listWheatpizza()
        {
            string str = "";
            for (int i = 0; i < this.Wheatpizza.Count; i++)
            {
                str += this.Wheatpizza[i] + ", \n";
            }
            return "\nWheat pizza ingredients: \n" + str;
        }
    }
    public class Director
    {
        private IBuilder _builder;
        public IBuilder PizzaBuilder
        {
            set { this._builder = value; }
        }
        public void BuildWhitePizza()
        {
            this._builder.BuildDough();
            this._builder.BuildSauce();
            this._builder.BuildTopping();
        }
        public void BuildWheatPizza()
        {
            this._builder.BuildDough();
            this._builder.BuildSauce();
            this._builder.BuildTopping();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create director
            var director = new Director();
            // Create Builder
            var Whitebuilder = new WhitePizzaBuilder();
            var Wheatbuilder = new WheatPizzaBuilder();


            director.PizzaBuilder = Whitebuilder;

            director.BuildWhitePizza();
            Console.WriteLine(Whitebuilder.GetWhitePizza().listWhitepizza());
            Console.WriteLine("------------------------------------------------------------------");

            director.PizzaBuilder = Wheatbuilder;

            director.BuildWheatPizza();
            Console.WriteLine(Wheatbuilder.GetWheatPizza().listWheatpizza());

            Console.ReadKey();

        }
    }
}
