using System;
using System.Collections.Generic;
namespace PizzaBuilder
{
    public interface IBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }
    public class WhitePizzaBuilder : IBuilder
    {
        private WhitePizza _whitepizza = new WhitePizza();
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._whitepizza = new WhitePizza();
        }
        public void BuildDough()
        {
            this._whitepizza.Add("Prepare the dough");
        }
        public void BuildSauce()
        {
            this._whitepizza.Add(" ، Add the sauce");
        }
        public void BuildTopping()
        {
            this._whitepizza.Add(" ، Add Topping .");
        }
        public WhitePizza GetWhitePizza()
        {
            WhitePizza result = this._whitepizza;
            this.Reset();
            return result;
        }
    }
    public class WheatPizzaBuilder : IBuilder
    {
        private WheatPizza _wheatpizza = new WheatPizza();
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._wheatpizza = new WheatPizza();
        }
        public void BuildDough()
        {
            this._wheatpizza.Add("Prepare the dough");
        }
        public void BuildSauce()
        {
            this._wheatpizza.Add(" ، Add the sauce");
        }
        public void BuildTopping()
        {
            this._wheatpizza.Add(" ، Add Topping .");
        }
        public WheatPizza GetWheatPizza()
        {
            WheatPizza result = this._wheatpizza;
            this.Reset();
            return result;
        }
    }

    public class WhitePizza
    {
        private List<object> pizza = new List<object>();
        public void Add(string part)
        {
            this.pizza.Add(part);
        }
        public string ReadyPizza()
        {
            string str = "";
            for (int i = 0; i < this.pizza.Count; i++)
            {
                str += this.pizza[i];
            }
            return "White Pizza ingredients : " + str;
        }

    }

    public class WheatPizza
    {
        private List<object> pizza = new List<object>();
        public void Add(string part)
        {
            this.pizza.Add(part);
        }
        public string ReadyPizza()
        {
            string str = "";
            for (int i = 0; i < this.pizza.Count; i++)
            {
                str += this.pizza[i];
            }
            return "Wheat Pizza ingredients : " + str;
        }

    }


    public class Director
    {
        private IBuilder _whitepizza;
        public IBuilder whitepizzaBuilder
        {
            set { this._whitepizza = value; }
        }

        public void BuildMin_white()
        {
            this._whitepizza.BuildDough();
            this._whitepizza.BuildSauce();
        }
        public void BuildFull_white()
        {
            this._whitepizza.BuildDough();
            this._whitepizza.BuildSauce();
            this._whitepizza.BuildTopping();
        }

        private IBuilder _wheatpizza;
        public IBuilder wheatpizzaBuilder
        {
            set { this._wheatpizza = value; }
        }
        public void BuildMin_wheat()
        {
            this._wheatpizza.BuildDough();
            this._wheatpizza.BuildSauce();
        }
        public void BuildFull_wheat()
        {
            _wheatpizza.BuildDough();
            this._wheatpizza.BuildSauce();
            this._wheatpizza.BuildTopping();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-*-*- white Yummy pizza -*-*-");
            //client
            var director_1 = new Director();
            var whitepizza_builder = new WhitePizzaBuilder();
            director_1.whitepizzaBuilder = whitepizza_builder;
            //Full Product
            director_1.BuildFull_white();
            Console.WriteLine(whitepizza_builder.GetWhitePizza().ReadyPizza());
            //Min Product
            director_1.BuildMin_white();
            Console.WriteLine(whitepizza_builder.GetWhitePizza().ReadyPizza());
            //Custom Product
            whitepizza_builder.BuildDough();
            whitepizza_builder.BuildTopping();
            Console.WriteLine(whitepizza_builder.GetWhitePizza().ReadyPizza());

            Console.WriteLine("-*-*- wheat Yummy pizza -*-*-");
            //client
            var director_2 = new Director();
            var Wheatpizza_builder = new WheatPizzaBuilder();
            director_2.wheatpizzaBuilder = Wheatpizza_builder;
            //Full Product
            director_2.BuildFull_wheat();
            Console.WriteLine(Wheatpizza_builder.GetWheatPizza().ReadyPizza());
            //Min Product
            director_2.BuildMin_wheat();
            Console.WriteLine(Wheatpizza_builder.GetWheatPizza().ReadyPizza());
            //Custom Product
            Wheatpizza_builder.BuildDough();
            Wheatpizza_builder.BuildTopping();
            Console.WriteLine(Wheatpizza_builder.GetWheatPizza().ReadyPizza());
        }
    }
}


