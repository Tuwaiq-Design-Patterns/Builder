using System;
using System.Collections.Generic;

namespace Builder
{
    public interface IPizzaBuilder
    {
         void Reset();
         void BuildDough();
         void BuildSauce();
         void BuildTopping(string topping);
    }
    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza _whitePizza = new WhitePizza();
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._whitePizza = new WhitePizza();
        }
        public void BuildDough()
        {
            this._whitePizza.AddPart("White flour dough");
        }
        public void BuildSauce()
        {
            this._whitePizza.AddPart("Sauce");
        }
        public void BuildTopping(string topping)
        {
            this._whitePizza.AddPart(topping);
        }
        public WhitePizza GetPizza()
        {
            WhitePizza result = this._whitePizza;
            this.Reset();
            return result;
        }
    }

    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza _wheatPizza = new WheatPizza();

        public WheatPizzaBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._wheatPizza = new WheatPizza();
        }

        public void BuildDough()
        {
            this._wheatPizza.AddPart("Brown flour dough");
        }

        public void BuildSauce()
        {
            this._wheatPizza.AddPart("Sauce");
        }

        public void BuildTopping( string topping)
        {
            this._wheatPizza.AddPart(topping);
        }

        public WheatPizza GetPizza()
        {
            WheatPizza result = this._wheatPizza;
            this.Reset();
            return result;
        }
    }
    
    public class WhitePizza
    {
        private List<object> _parts = new List<object>();
        public void AddPart(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
            string str = "";
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ",";
            }
            return "Pizza choices:" + str;
        }
    }

    public class WheatPizza
    {
        private List<object> _parts = new List<object>();

        public void AddPart(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = "";
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ",";
            }

            return "Pizza choices:" + str;
        }
    }
    
    public class Director
    {
        private IPizzaBuilder _builder;
        public IPizzaBuilder PizzaBuilder
        {
            set { this._builder = value; }
        }
        public void MakeRegularPizza()
        {
            this._builder.BuildDough();
            this._builder.BuildSauce();
            this._builder.BuildTopping("Cheese");
        }
        
        public void MakeVegetablesPizza()
        {
            this._builder.BuildDough();
            this._builder.BuildSauce();
            this._builder.BuildTopping("Vegetables mix");
        }

        public void MakePizzaWithoutToppings()
        {
            this._builder.BuildDough();
            this._builder.BuildSauce();
        }
    }
    class Program
    {
        static void Main(string [] args)
        {
            var director = new Director();
            var whitePizzaBuilder = new WhitePizzaBuilder();
            var wheatPizzaBuilder = new WheatPizzaBuilder();
            director.PizzaBuilder = whitePizzaBuilder;

            director.MakeRegularPizza();
            Console.WriteLine(whitePizzaBuilder.GetPizza().ListParts());

            director.PizzaBuilder = wheatPizzaBuilder;
            director.MakeVegetablesPizza();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().ListParts());

            director.PizzaBuilder = whitePizzaBuilder;
            director.MakePizzaWithoutToppings();
            Console.WriteLine(whitePizzaBuilder.GetPizza().ListParts());
            
            // custom pizza 
            var customPizzaBuilder = new WhitePizzaBuilder();
            customPizzaBuilder.BuildDough();
            customPizzaBuilder.BuildSauce();
            customPizzaBuilder.BuildTopping("Cheese");
            customPizzaBuilder.BuildTopping("Pepperoni");
            Console.WriteLine(customPizzaBuilder.GetPizza().ListParts());
        }
    }
}
