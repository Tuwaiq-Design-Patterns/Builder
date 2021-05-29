using System;
using System.Collections.Generic;

namespace Builder_
{
    public interface IPizzaBuilder
    {
        public void reset();
        public void BuildDough();
        public void BuildSauce();
        public void BuildTopping();
    }
    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private PizzaWhite _WhitePizza = new PizzaWhite();
        public WhitePizzaBuilder()
        {
            this.reset();
        }
        public void BuildDough()
        {
            this._WhitePizza.Add("White Dough");
        }

        public void BuildSauce()
        {
            this._WhitePizza.Add("Sauce");
        }

        public void BuildTopping()
        {
            this._WhitePizza.Add("Topping");
        }

        public void reset()
        {
            this._WhitePizza = new PizzaWhite();
        }
        public PizzaWhite GetProduct()
        {
            PizzaWhite result = this._WhitePizza;
            this.reset();
            return result;
        }
    }
    public class WheatePizzaBuilder : IPizzaBuilder
    {
        private PizzaWheate _WheatePizza = new PizzaWheate();
        public WheatePizzaBuilder()
        {
            this.reset();
        }
        public void BuildDough()
        {
            this._WheatePizza.Add("Wheate Dough");
        }

        public void BuildSauce()
        {
            this._WheatePizza.Add("Sauce");
        }

        public void BuildTopping()
        {
            this._WheatePizza.Add("Topping");
        }

        public void reset()
        {
            this._WheatePizza = new PizzaWheate();
        }

        public PizzaWheate GetProduct()
        {
            PizzaWheate result = this._WheatePizza;
            this.reset();
            return result;
        }
    }

    public class PizzaWheate
    {
        private List<object> pizza = new List<object>();
        public void Add(string recipe)
        {
            this.pizza.Add(recipe);
        }
        public string compaltePizza()
        {
            string str = "";
            for (int i = 0; i < this.pizza.Count; i++)
            {
                if (i< this.pizza.Count-1)
                {
                    str += this.pizza[i] + ",";
                }
                else
                {
                    str += this.pizza[i] + ".";
                }
                
            }
            return "pizza: " + str;
        }
    }

    public class PizzaWhite
    {
        private List<object> pizza = new List<object>();
        public void Add(string recipe)
        {
            this.pizza.Add(recipe);
        }
        public string compaltePizza()
        {
            string str = "";
            for (int i = 0; i < this.pizza.Count; i++)
            {
                if (i < this.pizza.Count - 1)
                {
                    str += this.pizza[i] + ",";
                }
                else
                {
                    str += this.pizza[i] + ".";
                }

            }
            return "pizza: " + str;
        }
    }
    public class Director
    {
        private IPizzaBuilder pizzaBuilder;
        public IPizzaBuilder Builder
        {
            set { this.pizzaBuilder = value; }
        }
        public void MakePizza()
        {
            this.pizzaBuilder.BuildDough();
            this.pizzaBuilder.BuildSauce();
            this.pizzaBuilder.BuildTopping();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var _WhitePizza = new WhitePizzaBuilder();
            director.Builder = _WhitePizza;
            director.MakePizza();
            Console.WriteLine(_WhitePizza.GetProduct().compaltePizza());

            var _WheatePizza = new WheatePizzaBuilder();
            director.Builder = _WheatePizza;
            director.MakePizza();
            Console.WriteLine(_WheatePizza.GetProduct().compaltePizza());

            //Bonus 1
            _WheatePizza.BuildTopping();
            Console.WriteLine(_WheatePizza.GetProduct().compaltePizza());
        }
    }
}
