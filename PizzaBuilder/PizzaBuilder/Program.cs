using System;
using System.Collections.Generic;

namespace PizzaBuilder
{
    public interface IPizzaBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }

    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza _pizza;
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._pizza = new WhitePizza();
        }

        public WhitePizza GetPizza()
        {
            WhitePizza result = this._pizza;
            this.Reset();
            return result;
        }

        public void BuildDough()
        {
            this._pizza.Add("White Dough");
        }

        public void BuildSauce()
        {
            this._pizza.Add("Tomato Sauce");
        }

        public void BuildTopping()
        {
            this._pizza.Add("Cheese");
        }

    }


    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza _pizza;
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._pizza = new WheatPizza();
        }
        
        public WheatPizza GetPizza()
        {
            WheatPizza result = this._pizza;
            this.Reset();
            return result;
        }

        public void BuildDough()
        {
            this._pizza.Add("Wheat Dough");
        }

        public void BuildSauce()
        {
            this._pizza.Add("Tomato Sauce");
        }

        public void BuildTopping()
        {
            this._pizza.Add("Cheese");
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
                if (i < this.parts.Count - 1) str += this.parts[i] + ",";
                else str += this.parts[i] + ".";
            }
            return "Pizaa componenets:" + str;
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
                if (i < this.parts.Count - 1) str += this.parts[i] + ",";
                else str += this.parts[i] + ".";
            }
            return "Pizaa componenets:" + str;
        }
    }

    public class Director
    {
        private IPizzaBuilder _builder;
        public IPizzaBuilder Builder
        {
            set { this._builder = value; }
        }
        public void WithSuase()
        {
            this._builder.BuildDough();
            this._builder.BuildSauce();
            this._builder.BuildTopping();
        }
        public void WithoutSuase()
        {
            this._builder.BuildDough();
            this._builder.BuildSauce();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var wheatPizzaBuilder = new WheatPizzaBuilder();
            director.Builder = wheatPizzaBuilder;
            //Wheat Pizza With Suase
            director.WithSuase();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().listParts());
            //Wheat Pizza With Suase
            director.WithoutSuase();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().listParts());
            //Bonus 1 
            wheatPizzaBuilder.BuildDough();
            wheatPizzaBuilder.BuildTopping();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().listParts());


            var whitePizzaBuilder = new WhitePizzaBuilder();
            director.Builder = whitePizzaBuilder;
            //Wheat Pizza With Suase
            director.WithSuase();
            Console.WriteLine(whitePizzaBuilder.GetPizza().listParts());
            //Wheat Pizza With Suase
            director.WithoutSuase();
            Console.WriteLine(whitePizzaBuilder.GetPizza().listParts());
            //Bonus 1 
            whitePizzaBuilder.BuildDough();
            whitePizzaBuilder.BuildTopping();
            Console.WriteLine(whitePizzaBuilder.GetPizza().listParts());
        }
    }
}
