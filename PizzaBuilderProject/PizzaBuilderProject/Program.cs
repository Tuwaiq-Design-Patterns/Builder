using System;
using System.Collections.Generic;

namespace PizzaBuilderProject
{
    public interface IpizzaBuilder
    {
       public  void BuilderDough();
       public void BuildTopping();
       public void BuildSauce();
       public  void Reset();
    }

    public class whitePizzaBuilder : IpizzaBuilder
    {
        private WhitePizza _whitePizza = new WhitePizza();
        public whitePizzaBuilder()
        {
            this.Reset();
        }
        public void BuilderDough()
        {
            this._whitePizza.Add("white Dough");

        }

        public void BuildSauce()
        {
            this._whitePizza.Add("Souce");
        }

        public void BuildTopping()
        {
            this._whitePizza.Add("Topping");
        }

        public void Reset()
        {
            this._whitePizza = new WhitePizza();
        }
        public WhitePizza getPizza()
        {
            WhitePizza result = this._whitePizza;

            this.Reset();
            return result;
        }
    }

    public class WhitePizza
    {
        private List<object> ingredientPizzaWhite = new List<object>();
        public void Add(string part)
        {
            this.ingredientPizzaWhite.Add(part);
        }
        public string listPartsPizza()
        {
            string str = "";
            for (int i = 0; i < this.ingredientPizzaWhite.Count; i++)
            {

                if (i < this.ingredientPizzaWhite.Count - 1)
                {
                    str += ingredientPizzaWhite[i] + ",";
                }
                else
                {
                    str += ingredientPizzaWhite[i] + ".";

                }
            }
            return "* White Pizza ingredients:" + str;
        }
    }
    public class wheatPizzaBuilder : IpizzaBuilder
    {
        private WheatPizza _wheatPizza = new WheatPizza();
        public wheatPizzaBuilder()
        {
            this.Reset();
        }
        public void BuilderDough()
        {
            this._wheatPizza.Add("wheat Dough");

        }

        public void BuildSauce()
        {
            this._wheatPizza.Add("Souce");
        }

        public void BuildTopping()
        {
            this._wheatPizza.Add("Topping");
        }

        public void Reset()
        {
            this._wheatPizza = new WheatPizza();
        }
        public WheatPizza getPizza()
        {
            WheatPizza result = this._wheatPizza;

            this.Reset();
            return result;
        }
    }

    public class WheatPizza
    {
        private List<object> ingredientPizzaWeat= new List<object>();
        public void Add(string ingredient)
        {
            this.ingredientPizzaWeat.Add(ingredient);
        }
        public string listPartsPizza()
        {
            string str = "";
            for (int i = 0; i < this.ingredientPizzaWeat.Count; i++)

            {
                if (i < this.ingredientPizzaWeat.Count-1)
                {
                    str += ingredientPizzaWeat[i] + ",";
                }
                else
                {
                    str += ingredientPizzaWeat[i] + ".";

                }
            }
            return "* Wheat Pizza ingredients:" + str ;
        }
    }

    public class Director
    {
        private IpizzaBuilder _builder;
        public IpizzaBuilder Builder
        {
            set { this._builder = value; }
        }
        
        public void makePizza()
        {
            this._builder.BuilderDough();
            this._builder.BuildTopping();
            this._builder.BuildSauce();

        }
    }

class Program
{
    static void Main(string[] args)
    {
        //client
        var director = new Director();


        var whitePizza = new whitePizzaBuilder();
        director.Builder = whitePizza;
        director.makePizza();
        Console.WriteLine(whitePizza.getPizza().listPartsPizza());

        var wheatPizza = new wheatPizzaBuilder();
        director.Builder = wheatPizza;
        director.makePizza();
        Console.WriteLine(wheatPizza.getPizza().listPartsPizza());

            var builder = new wheatPizzaBuilder();
            builder.BuilderDough();
            builder.BuildSauce();
            Console.WriteLine(builder.getPizza().listPartsPizza());



        }
    }
}
