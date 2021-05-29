using System;
using System.Collections.Generic;

namespace PizzaBuilder
{
    public interface IPizzaBuilder
    {
        abstract void Reset();
        void BuildDough();
        void BuildSauce();
        void BuildTopping(string topping);
    }

    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza _product = new WhitePizza();
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new WhitePizza();
        }
    
        public WhitePizza GetPizza()
        {
            WhitePizza result = this._product;
            this.Reset();
            return result;
        }

        public void BuildDough()
        {
            this._product.Add("White Dough");
        }

        public void BuildSauce()
        {
            this._product.Add("Sauce");
        }

        public void BuildTopping(string topping)
        {
            this._product.Add(topping);
        }

    }

    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza _product = new WheatPizza();
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new WheatPizza();
        }

        public WheatPizza GetPizza()
        {
            WheatPizza result = this._product;
            this.Reset();
            return result;
        }

        public void BuildDough()
        {
            this._product.Add("Wheat Dough");
        }

        public void BuildSauce()
        {
            this._product.Add("Sauce");
        }

        public void BuildTopping(string topping)
        {
            this._product.Add(topping);
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
            string str = "";
            for (int i = 0; i < this.parts.Count; i++)
            {
                str += this.parts[i] + ",";
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

        public void MakeMeatLoverPizza()
        {
            this._builder.BuildDough();
            this._builder.BuildSauce();
            this._builder.BuildTopping("Pepperoni");
            this._builder.BuildTopping("Ground beef");
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
