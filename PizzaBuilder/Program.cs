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
        private WhitePizza freshPizza = new WhitePizza();
        public WhitePizzaBuilder() => this.Reset();
        public void Reset() 	   => this.freshPizza = new WhitePizza();
        public void BuildDough()   => this.freshPizza.Add("White Dough");
        public void BuildSauce()   => this.freshPizza.Add("Ranch Sauce");
        public void BuildTopping() => this.freshPizza.Add("Chedder chesse");
        public WhitePizza GetPizza()
        {
            WhitePizza result = this.freshPizza;
            this.Reset();
            return result;
        }
    }
    public class WhitePizza
    {
        private List<object> parts = new List<object>();
        public void Add(string part) => this.parts.Add(part);
        public string collectParts() => $"Order : {string.Join(", ", this.parts)}";
    }
    public class WheatPizzaBuilder : PizzaBuilder
    {
        private WheatPizza freshPizza = new WheatPizza();
        public WheatPizzaBuilder() => this.Reset();
        public void Reset()        => this.freshPizza = new WheatPizza();
        public void BuildDough()   => this.freshPizza.Add("Wheat Dough");
        public void BuildSauce()   => this.freshPizza.Add("Spicy Sauce");
        public void BuildTopping() => this.freshPizza.Add("Pepperoni");
        public WheatPizza GetPizza()
        {
            WheatPizza result = this.freshPizza;
            this.Reset();
            return result;
        }
    }
    public class WheatPizza
    {
        private List<object> parts = new List<object>();
        public void Add(string part) => this.parts.Add(part);
        public string collectParts() => $"Order : {string.Join(", ", this.parts)}";
    }
    public class Director
    {
        private PizzaBuilder builder;
        public PizzaBuilder Builder
        {
            set { this.builder = value; }
        }

        public void makePizza()
        {
            this.builder.BuildTopping();
            this.builder.BuildDough();
            this.builder.BuildSauce();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var WhiteBuilder = new WhitePizzaBuilder();
            director.Builder = WhiteBuilder;
            director.makePizza();
            Console.WriteLine(WhiteBuilder.GetPizza().collectParts());
            var Wheatbuilder = new WheatPizzaBuilder();
            director.Builder = Wheatbuilder;
            director.makePizza();
            Console.WriteLine(Wheatbuilder.GetPizza().collectParts());

        }
    }
}
