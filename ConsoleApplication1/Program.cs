using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WheatPizzaBuilder wheatPizzaBuilder = new WheatPizzaBuilder();
            Directer directer1 = new Directer(wheatPizzaBuilder);
            directer1.MakePizza();
            Console.WriteLine(wheatPizzaBuilder.GetPizza().ListComponents());
            
            WhitePizzaBuilder whitePizzaBuilder = new WhitePizzaBuilder();
            Directer directer2 = new Directer(whitePizzaBuilder);
            directer2.MakePizza();
            Console.WriteLine(whitePizzaBuilder.GetPizza().ListComponents());
        }
    }

    public interface IPizzaBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }

    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        
        public WhitePizzaBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pizza = new Pizza();
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
            this._pizza.Add("Mozzarella Cheese");
        }

        public Pizza GetPizza()
        {
            Pizza result = this._pizza;
            this.Reset();
            return result;
        }
    }
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        
        public WheatPizzaBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._pizza = new Pizza();
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
            this._pizza.Add("Mozzarella Cheese");
        }

        public Pizza GetPizza()
        {
            Pizza result = this._pizza;
            this.Reset();
            return result;
        }
    }

    public class Pizza
    {
        private List<Object> _components = new List<object>();

        public void Add(string component)
        {
            this._components.Add(component);
        }

        public string ListComponents()
        {
            string str = "";
            for (int i = 0; i < _components.Count; i++)
            {
                str += i + 1 != _components.Count ? $"{_components[i]}, " : _components[i];
            }

            return "Pizza Components = " + str;
        }
    }

    public class Directer
    {
        private IPizzaBuilder _pizzaBuilder;

        public Directer(IPizzaBuilder pizzaBuilder)
        {
            this._pizzaBuilder = pizzaBuilder;
        }

        public void MakePizza()
        {
            this._pizzaBuilder.BuildDough();
            this._pizzaBuilder.BuildSauce();
            this._pizzaBuilder.BuildTopping();
        }
    }
}