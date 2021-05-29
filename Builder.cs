using System;
using System.Collections.Generic;

namespace Builder
{
    public interface IPizzaBuilder
    {   
        public void Reset();
        public void BuildDough(string? userInput);
        public void BuildSauce(string? userInput);
        public void BuildTopping(string? userInput);

    }
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza Pizza = new WheatPizza();
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.Pizza = new WheatPizza();
        }
        public void BuildDough(string userInput = null)
        {
            if (userInput == null || userInput.Trim().Length < 1)
            {
                this.Pizza.Add("Wheat Dough");
            }
            else
            {
                this.Pizza.Add(userInput);
            }
        }
        public void BuildSauce(string userInput = null)
        {
            if (userInput == null || userInput.Trim().Length < 1)
            {
                this.Pizza.Add("Tomato Sauce");
            }
            else
            {
                this.Pizza.Add(userInput);
            }
        }
        public void BuildTopping(string userInput = null)
        {
            if (userInput == null || userInput.Trim().Length < 1)
            {
                this.Pizza.Add("Extra Cheese Topping");
            }
            else
            {
                this.Pizza.Add(userInput);
            }
        }
        public WheatPizza GetPizza()
        {
            WheatPizza result = this.Pizza;
            this.Reset();
            return result;
        }
    }

    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza Pizza = new WhitePizza();
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.Pizza = new WhitePizza();
        }
        public void BuildDough(string userInput = null)
        {
            if(userInput == null || userInput.Trim().Length < 1)
            {
                this.Pizza.Add("White Dough");
            }
            else
            {
                this.Pizza.Add(userInput);
            }
        }
        public void BuildSauce(string userInput = null)
        {
            if (userInput == null || userInput.Trim().Length < 1)
            {
                this.Pizza.Add("BBQ Sauce");
            }
            else
            {
                this.Pizza.Add(userInput);
            }
        }
        public void BuildTopping(string userInput = null)
        {
            if (userInput == null || userInput.Trim().Length < 1)
            {
                this.Pizza.Add("Mushroom Topping");
            }
            else
            {
                this.Pizza.Add(userInput);
            }
        }
        public WhitePizza GetPizza()
        {
            WhitePizza result = this.Pizza;
            this.Reset();
            return result;
        }
    }

    public class WheatPizza
    {
        private List<object> components = new List<object>();
        public void Add(string part)
        {
            this.components.Add(part);
        }
        public string listComponents()
        {
            string str = "";
            for (int i = 0; i < this.components.Count; i++)
            {
                str += this.components[i] + ", ";
            }
            str = str[0..(str.Length-2)];
            return "Pizza Components:" + str;
        }
    }

    public class WhitePizza
    {
        private List<object> components = new List<object>();
        public void Add(string part)
        {
            this.components.Add(part);
        }
        public string listComponents()
        {
            string str = "";
            for (int i = 0; i < this.components.Count; i++)
            {
                str += this.components[i] + ", ";
            }
            str = str[0..(str.Length - 2)];
            return "Pizza Components:" + str;
        }
    }

    public class Director
    {
        private IPizzaBuilder pizzaBuilder;
        public IPizzaBuilder Builder
        {
            set { this.pizzaBuilder = value; }
        }
        public void makePizza()
        {
            Console.WriteLine("Enter The dough you wish for. Leave empty for defualt dough");
            this.pizzaBuilder.BuildDough(Console.ReadLine());
            Console.WriteLine("Enter The topping you wish for. Leave empty for defualt topping");
            this.pizzaBuilder.BuildTopping(Console.ReadLine());
            Console.WriteLine("Enter The sauce you wish for. Leave empty for defualt sauce");
            this.pizzaBuilder.BuildSauce(Console.ReadLine());
        }
    }
}