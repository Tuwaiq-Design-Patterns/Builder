using System;
using System.Collections.Generic;

namespace PizzaBuilder
{
    public interface IPizzaBuilder
    {
        abstract void Reset();
        void BuildSauce();
        void BuildDough();
        void BuildTopping(string topping);
    }

    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza _pizza = new WhitePizza();
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
            this._pizza.Add("Sauce");
        }

        public void BuildTopping(string topping)
        {
            this._pizza.Add(topping);
        }

    }

    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza _pizza = new WheatPizza();
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
            this._pizza.Add("Sauce");
        }

        public void BuildTopping(string topping)
        {
            this._pizza.Add(topping);
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
                str += this.parts[i] + ",";
            }
            return "Pizza ingredients are :" + str;
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
            string pizza = "";
            for (int i = 0; i < this.parts.Count; i++)
            {
                pizza += this.parts[i] + ",";
            }
            return "Pizza ingredients are :" + pizza;
        }
    }

    public class Director
    {
        private IPizzaBuilder _builder;
        public IPizzaBuilder Builder
        {
            set { this._builder = value; }
        }

        public void MakeMeatPizza()
        {
            this._builder.BuildDough();
            this._builder.BuildSauce();
            this._builder.BuildTopping("Pepperoni");
            this._builder.BuildTopping("Meat");
            this._builder.BuildTopping("Cheese");
        }
        public void MakeMargaritaPizza()
        {
            this._builder.BuildDough();
            this._builder.BuildSauce();
            this._builder.BuildTopping("Cheese");
        }
    }

}
