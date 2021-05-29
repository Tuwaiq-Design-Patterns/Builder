using System;
using System.Collections.Generic;
namespace Builder
{

    public interface IPizzaBuilder
    {
       public void BuildDough();
       public void BuildTopping();
       public void BuildSauce();
       public void Reset();
    }
    public class whitePizzaBuilder : IPizzaBuilder
    {
        private Pizza _Pizza = new Pizza();
        public whitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._Pizza = new Pizza();
        }
        public void BuildSauce()
        {
            this._Pizza.Add("sauce");
        }
        public void BuildTopping()
        {
            this._Pizza.Add("Topping");
        }
        public void BuildDough()
        {
            this._Pizza.Add("white dough");
        }
        public Pizza getPizza()
        {
            Pizza result = this._Pizza;
            this.Reset();
            return result;
        }
    }
    public class WheatePizzaBuilder : IPizzaBuilder
    {
        private Pizza _Pizza = new Pizza();
        public WheatePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._Pizza = new Pizza();
        }
        public void BuildSauce()
        {
            this._Pizza.Add(" sauce");
        }
        public void BuildTopping()
        {
            this._Pizza.Add(" Topping");
        }
        public void BuildDough()
        {
            this._Pizza.Add("wheat Dough ");
        }
        public Pizza getPizza()
        {
            Pizza result = this._Pizza;
            this.Reset();
            return result;
        }
    }

    public class Pizza
    {
        private List<object> P = new List<object>();
        public void Add(string Pizza)
        {
            this.P.Add(Pizza);
        }
        public string PizzaParts()
        {
            string str = "";
            for (int i = 0; i < this.P.Count; i++)
            {
                str += this.P[i] + ",";
            }
            return "Pizza :" + str;
        }
    }
    public class Director
    {
        private IPizzaBuilder _builder;
        public IPizzaBuilder Builder
        {
            set { this._builder = value; }
        }
        public void MakePizza()
        {
            this._builder.BuildDough();
            this._builder.BuildTopping();
            this._builder.BuildTopping();
        }
        public void MakePizzaWithOutSauce()
        { 
            this._builder.BuildDough();
            this._builder.BuildTopping();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         
            var director = new Director();
            var builder = new whitePizzaBuilder();
            director.Builder = builder;
            
            director.MakePizzaWithOutSauce();
            Console.WriteLine(builder.getPizza().PizzaParts());
          
            director.MakePizza();
            Console.WriteLine(builder.getPizza().PizzaParts());
            //Client Do the with out Director
            builder.BuildTopping();
            builder.BuildDough();
            Console.WriteLine(builder.getPizza().PizzaParts());
        }
    }
}