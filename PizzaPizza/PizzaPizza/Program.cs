using System;
using System.Collections.Generic;
namespace PizzaPizza
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
            this._Pizza.Add("White Sauce");
        }
        public void BuildTopping()
        {
            this._Pizza.Add("Olive");
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
        private PizzaWheat _Pizza = new PizzaWheat();
        public WheatePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._Pizza = new PizzaWheat();
        }
        public void BuildSauce()
        {
            this._Pizza.Add("red sauce");
        }
        public void BuildTopping()
        {
            this._Pizza.Add("cheese");
        }
        public void BuildDough()
        {
            this._Pizza.Add("Wheat Dough ");
        }
        public PizzaWheat getPizza()
        {
            PizzaWheat result = this._Pizza;
            this.Reset();
            return result;
        }
    }

    public class PizzaWheat
    {
        private List<object> ingredients = new List<object>();
        public void Add(string Pizza)
        {
            this.ingredients.Add(Pizza);
        }
        public string PizzaHas()
        {
            string str = "";
            for (int i = 0; i < this.ingredients.Count; i++)
            {
                str += this.ingredients[i] + ",";
            }
            return "Pizza ingredients are :" + str;
        }
    }
    public class PizzaWhite
    {
        private List<object> ingredients1 = new List<object>();
        public void Add(string Pizza)
        {
            this.ingredients1.Add(Pizza);
        }
        public string PizzaParts()
        {
            string str = "";
            for (int i = 0; i < this.ingredients1.Count; i++)
            {
                str += this.ingredients1[i] + ",";
            }
            return "Pizza ingredients are :" + str;
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
            var Wheat = new WheatePizzaBuilder();
            director.Builder = White;
            //white
            director.MakePizzaWithOutSauce();
            Console.WriteLine(White.getPizza().PizzaParts());
            director.MakePizza();
            Console.WriteLine(White.getPizza().PizzaParts());
            //wheat
            director.MakePizza();
            Console.WriteLine(Wheat.getPizza().PizzaHas());

        }
    }
}