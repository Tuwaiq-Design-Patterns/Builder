using System;
using System.Collections.Generic;

namespace PizzaBuilder
{
    public interface IPizzaBuilder
    {
        void Reset();
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }
    public class ConcreteWhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza _whitePizza = new WhitePizza();
     
        public ConcreteWhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._whitePizza = new WhitePizza();
        }
        public void BuildDough()
        {
            this._whitePizza.Add("White dough");
        }
        public void BuildSauce()
        {
            this._whitePizza.Add("White Sauce");
        }
        public void BuildTopping()
        {
            this._whitePizza.Add("Cheese");
        }
        public WhitePizza GetPizza()
        {
            WhitePizza result = this._whitePizza;
            this.Reset();
            return result;
        }
    }

    public class WhitePizza
    {
        private List<object> _parts = new List<object>();
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }
            str = str.Remove(str.Length - 2); 
            return "Pizza parts: " + str + "\n";
        }
    }
    
    public class ConcreteWheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza _wheatPizza = new WheatPizza();
     
        public ConcreteWheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._wheatPizza = new WheatPizza();
        }
        public void BuildDough()
        {
            this._wheatPizza.Add("Wheat dough");
        }
        public void BuildSauce()
        {
            this._wheatPizza.Add("Tomato");
        }
        public void BuildTopping()
        {
            this._wheatPizza.Add("Jalapeno");
        }
        public WheatPizza GetPizza()
        {
            WheatPizza result = this._wheatPizza;
            this.Reset();
            return result;
        }
    }

    public class WheatPizza
    {
        private List<object> _parts = new List<object>();
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }
            str = str.Remove(str.Length - 2); 
            return "Pizza parts: " + str + "\n";
        }
    }
    public class Director
    {
        private IPizzaBuilder _pizzaBuilder;
        public IPizzaBuilder PizzaBuilder
        {
            set => _pizzaBuilder = value;
        }
        public void BuildPizzaWithTopping()
        {
            this._pizzaBuilder.BuildDough();
            this._pizzaBuilder.BuildTopping();
        }
        public void BuildFullPizza()
        {
            this._pizzaBuilder.BuildDough();
            this._pizzaBuilder.BuildSauce();
            this._pizzaBuilder.BuildTopping();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var whitePizzaBuilder = new ConcreteWhitePizzaBuilder();
            var wheatPizzaBuilder = new ConcreteWheatPizzaBuilder();
            director.PizzaBuilder = whitePizzaBuilder;
            
            //White Pizza
            Console.WriteLine("Standard white Pizza:");
            director.BuildPizzaWithTopping();
            Console.WriteLine(whitePizzaBuilder.GetPizza().ListParts());
            
            Console.WriteLine("Full white Pizza:");
            director.BuildFullPizza();
            Console.WriteLine(whitePizzaBuilder.GetPizza().ListParts());
            
            //wheat Pizza
            director.PizzaBuilder = wheatPizzaBuilder;
            Console.WriteLine("Standard wheat Pizza:");
            director.BuildPizzaWithTopping();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().ListParts());
            
            Console.WriteLine("Full wheat Pizza:");
            director.BuildFullPizza();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().ListParts());
            
            //Custom white Pizza
            Console.WriteLine("Custom white Pizza:");
            whitePizzaBuilder.BuildDough();
            whitePizzaBuilder.BuildTopping();
            Console.Write(whitePizzaBuilder.GetPizza().ListParts()+"\n");
           
            //Custom wheat Pizza
            Console.WriteLine("Custom wheat Pizza:");
            wheatPizzaBuilder.BuildDough();
            wheatPizzaBuilder.BuildTopping();
            Console.Write(wheatPizzaBuilder.GetPizza().ListParts());
        }
    }
}