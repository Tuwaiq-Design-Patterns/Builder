using System;
using System.Collections.Generic;

namespace PizzaBulider
{
    public interface IPizzaBuilder
    {
        public void Reset();
        public void BuildDough();
        public void BuildSauce();
        public void BuildTopping();

    }
    public class WhitePizzeBuilder : IPizzaBuilder
    {
        private WhitePizze WhitePizze = new WhitePizze();

        public WhitePizzeBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.WhitePizze = new WhitePizze();
        }
        public void BuildDough()
        {
            this.WhitePizze.AddIngredient("Thick Dough");
        }
        public void BuildSauce()
        {
            this.WhitePizze.AddIngredient("Little Sauce");
        }
        public void BuildTopping()
        {
            this.WhitePizze.AddIngredient("Extra Topping");
        }
        public WhitePizze GetPizza()
        {
            WhitePizze result = this.WhitePizze;
            this.Reset();
            return result;
        }
    }
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza WheatPizza = new WheatPizza();

        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.WheatPizza = new WheatPizza();
        }
        public void BuildDough()
        {
            this.WheatPizza.AddIngredient("Crunchy Dough");
        }
        public void BuildSauce()
        {
            this.WheatPizza.AddIngredient("Extra Sauce");
        }
        public void BuildTopping()
        {
            this.WheatPizza.AddIngredient("Little Toppings");
        }
        public WheatPizza GetPizza()
        {
            WheatPizza final = this.WheatPizza;
            this.Reset();
            return final;
        }
    }
    public class WhitePizze
    {
        private List<object> Ingredients = new List<object>();
        public void AddIngredient(object Ingredient)
        {
            Ingredients.Add(Ingredient);
        }
        public string ListIngredients()
        {
            string str = "";
            for (int i = 0; i < this.Ingredients.Count; i++)
            {
                str += this.Ingredients[i] + "\n";
            }
            return "White Pizza order : \n" + str;
        }
    }
    public class WheatPizza
    {
        private List<object> Ingredients = new List<object>();
        public void AddIngredient(object Ingredient)
        {
            Ingredients.Add(Ingredient);
        }
        public string ListIngredients()
        {
            string str = "";
            for (int i = 0; i < this.Ingredients.Count; i++)
            {
                str += this.Ingredients[i] + "\n";
            }
            return "Wheat Pizza order : \n" + str;
        }

    }

    public class Director
    {
        private IPizzaBuilder _pizzaBuilder;
        public IPizzaBuilder PizzaBuilder
        {
            set { this._pizzaBuilder = value; }
        }
        public void makePizza()
        {
            this._pizzaBuilder.BuildDough();
            this._pizzaBuilder.BuildSauce();
            this._pizzaBuilder.BuildTopping();
        }
        public void makePizzaWithoutToppings()
        {
            this._pizzaBuilder.BuildDough();
            this._pizzaBuilder.BuildSauce();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Main objectives
            Director director = new Director();
            WheatPizzaBuilder Wheat = new WheatPizzaBuilder();
            WhitePizzeBuilder white = new WhitePizzeBuilder();
            WhitePizzeBuilder white2 = new WhitePizzeBuilder();

            director.PizzaBuilder = white;
            director.makePizza();
            Console.WriteLine(white.GetPizza().ListIngredients());

            director.PizzaBuilder = Wheat;
            director.makePizza();
            Console.WriteLine(Wheat.GetPizza().ListIngredients());

            director.PizzaBuilder = white2;
            director.makePizzaWithoutToppings();
            Console.WriteLine(white2.GetPizza().ListIngredients());

            // Bonus 1 Objective
            WhitePizzeBuilder pizza = new WhitePizzeBuilder();
            pizza.BuildDough();
            pizza.BuildSauce();
            pizza.BuildTopping();
            Console.WriteLine(pizza.GetPizza().ListIngredients());

        }
    }
}
