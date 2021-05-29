using System;
using System.Collections.Generic;

namespace RefactoringGuru.DesignPatterns.Builder.Conceptual
{

    public interface IPizzaBuilder
    {
        void BuildDough();

        void BuildSouce();

        void BuildTopping();
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


        public void BuildDough() 
        {
            this._pizza.Add("Thin Crust");
        }

        public void BuildSouce()
        {
            this._pizza.Add("White Garlic Sauce");
        }

        public void BuildTopping()
        {
            this._pizza.Add("Broccoli");
        }


        public WhitePizza GetPizza()
        {
            WhitePizza result = this._pizza;

            this.Reset();

            return result;
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

        public void BuildDough()
        {
            this._pizza.Add("Italian dough");
        }

        public void BuildSouce()
        {
            this._pizza.Add("Buffalo Sauce");
        }

        public void BuildTopping()
        {
            this._pizza.Add("Mushroom");
        }


        public WheatPizza GetPizza()
        {
            WheatPizza result = this._pizza;

            this.Reset();

            return result;
        }
    }

 
    public class WhitePizza
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); 

            return "Pizza specifications: " + str + "\n";
        }
    }




    public class WheatPizza
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); 

            return "Pizza specifications: " + str + "\n";
        }
    }

    public class Pizza
    {
        private List<object> Piz = new List<object>();
        public void Add(string Pizza)
        {
            this.Piz.Add(Pizza);
        }
        public string PizzaParts()
        {
            string str = "";
            for (int i = 0; i < this.Piz.Count; i++)
            {
                str += this.Piz[i] + ",";
            }
            return "Pizza :" + str;
        }
    }


    public class Director
    {
        private IPizzaBuilder _pizzaBuilder;

        public IPizzaBuilder Builder
        {
            set { _pizzaBuilder = value; }
        }

    
        public void makepizzaWithoutTopping() 
        {
            this._pizzaBuilder.BuildDough();
            this._pizzaBuilder.BuildSouce();
        }

        public void makePizza() //withsouse
        {
            this._pizzaBuilder.BuildDough();
            this._pizzaBuilder.BuildSouce();
            this._pizzaBuilder.BuildTopping();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          
            var director = new Director();
            var WhiteBuilder = new WhitePizzaBuilder();
            var WheteBuilder = new WheatPizzaBuilder();
         
            director.Builder = WhiteBuilder;
          

            Console.WriteLine("White Pizza Without Topping:");
            director.makepizzaWithoutTopping();
            Console.WriteLine(WhiteBuilder.GetPizza().ListParts());

            Console.WriteLine("White Pizza Without preferences:");
            director.makePizza();
            Console.WriteLine(WhiteBuilder.GetPizza().ListParts());



            //bounus 1
            Console.WriteLine("Custom Pizza - from director- :");
            WhiteBuilder.BuildDough();
            WhiteBuilder.BuildTopping();
            Console.Write(WhiteBuilder.GetPizza().ListParts());

            WheteBuilder.BuildDough();
            WheteBuilder.BuildTopping();
            Console.Write(WheteBuilder.GetPizza().ListParts());
        }
    }
}