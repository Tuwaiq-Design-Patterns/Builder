using System;
using System.Collections.Generic;

namespace PizzaBuilder
{
    public interface IPizzaBuilder
    {
       public void BuildDough();
       public void BuildSauce();
       public void BuildTopping();
       public void reset();
    }

    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private whitePizza WhitePizza = new whitePizza();

        public WhitePizzaBuilder()
        {
            this.reset();
        }
        public void BuildDough()
        {
            this.WhitePizza.Add("White Dough");
        }

        public void BuildSauce()
        {
            this.WhitePizza.Add("Sauce");
        }

        public void BuildTopping()
        {
            this.WhitePizza.Add("Topping");
        }

        public void reset()
        {
            this.WhitePizza = new whitePizza();
        }

        public whitePizza GetPizza()
        {
            whitePizza result = this.WhitePizza;
            this.reset();
            return result;
        }
    }
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private wheatPizza wheatPizza = new wheatPizza();

        public WheatPizzaBuilder()
        {
            this.reset();
        }
        public void BuildDough()
        {
            this.wheatPizza.Add("Wheat Dough");
        }

        public void BuildSauce()
        {
            this.wheatPizza.Add("Sauce");
        }

        public void BuildTopping()
        {
            this.wheatPizza.Add("Topping");
        }

        public void reset()
        {
            this.wheatPizza = new wheatPizza();
        }

        public wheatPizza GetPizza()
        {
            wheatPizza result = this.wheatPizza;
            this.reset();
            return result;
        }
    }

    public class whitePizza
    {
        private List<object> ingredients = new List<object>();
        public void Add(string ingredient)
        {
            this.ingredients.Add(ingredient);
        }
        public string listIngredients()
        {
            string str = "";
            for (int i = 0; i < this.ingredients.Count; i++)
            {
                str += this.ingredients[i] + ",";
            }
            return "White Pizza ingredientsts:" + str;
        }

    }
    public class wheatPizza
    {
        private List<object> ingredients = new List<object>();
        public void Add(string ingredient)
        {
            this.ingredients.Add(ingredient);
        }
        public string listIngredients()
        {
            string str = "";
            for (int i = 0; i < this.ingredients.Count; i++)
            {
                str += this.ingredients[i] + ",";
            }
            return "Wheat Pizza ingredientsts:" + str;
        }

    }


    public class Director
    {

        private IPizzaBuilder _PizzaBuilder;
        public IPizzaBuilder Builder
        {
            set { this._PizzaBuilder = value; }
        }
        public void makePizza()
        {
            this._PizzaBuilder.BuildDough();
            this._PizzaBuilder.BuildSauce();
            this._PizzaBuilder.BuildTopping();
        }
        public void makePizzaWithoutTopping()
        {
            this._PizzaBuilder.BuildDough();
            this._PizzaBuilder.BuildSauce();
       
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            //builder White
            var builderWhite = new WhitePizzaBuilder();
            director.Builder = builderWhite;
            director.makePizza();
            Console.WriteLine(builderWhite.GetPizza().listIngredients());

            //builder Wheat
            var builderWheat = new WheatPizzaBuilder();
            director.Builder = builderWheat;            
            director.makePizza();
            Console.WriteLine(builderWheat.GetPizza().listIngredients());

            //builder Wheat without topping
            director.makePizzaWithoutTopping();
            Console.WriteLine(builderWheat.GetPizza().listIngredients());


            //custem

            builderWhite.BuildDough();
            builderWhite.BuildSauce();

            builderWheat.BuildDough();
            builderWheat.BuildTopping();

            Console.WriteLine(builderWhite.GetPizza().listIngredients());
            Console.WriteLine(builderWheat.GetPizza().listIngredients());

        }
    }
}
