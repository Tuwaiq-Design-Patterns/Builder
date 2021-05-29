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
        private PizzaWhite _Pizza = new PizzaWhite();
        public whitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._Pizza = new PizzaWhite();
        }
        public void BuildSauce()
        {
            this._Pizza.Add("Sauce");
        }
        public void BuildTopping()
        {
            this._Pizza.Add("Topping");
        }
        public void BuildDough()
        {
            this._Pizza.Add("White dough");
        }
        public PizzaWhite getPizza()
        {
            PizzaWhite result = this._Pizza;
            this.Reset();
            return result;
        }
    }
    public class WheatePizzaBuilder : IPizzaBuilder
    {
        private PizzaWheet _Pizza = new PizzaWheet();
        public WheatePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._Pizza = new PizzaWheet();
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
            this._Pizza.Add("Wheat Dough ");
        }
        public PizzaWheet getPizza()
        {
            PizzaWheet result = this._Pizza;
            this.Reset();
            return result;
        }
    }

    public class PizzaWheet
    {
        private List<object> P = new List<object>();
        public void Add(string Pizza)
        {
            this.P.Add(Pizza);
        }
        public string PizzaContian()
        {
            string str = "";
            for (int i = 0; i < this.P.Count; i++)
            {
                str += this.P[i] + ",";
            }
            return "Pizza Wheet :" + str;
        }
    }
    public class PizzaWhite
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
            return "Pizza White :" + str;
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
            var White = new whitePizzaBuilder();
            var Wheet = new WheatePizzaBuilder();
            director.Builder = White;
            
            director.MakePizzaWithOutSauce();
            Console.WriteLine(White.getPizza().PizzaParts());

            director.MakePizza();
            Console.WriteLine(White.getPizza().PizzaParts());
            //Client Do the with out Director
            White.BuildTopping();
            White.BuildDough();
            Console.WriteLine(White.getPizza().PizzaParts());
        }
    }
}
