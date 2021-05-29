using static System.Console;
using System.Collections.Generic;

namespace builder
{
    public interface IPizzaBuilder
    {
        void BuildDough(string doughType);
        void BuildSauce(string sauceType);
        void BuildTopping(string toppingType);
        void Reset(); 
    }
    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza _product = new();
        public WhitePizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new WhitePizza();
        }
        public void BuildDough(string doughType = null )
        {
            if(doughType == null || string.IsNullOrEmpty(doughType) )
            {
                this._product.Add("White Dough");
            }
            else
            {
                this._product.Add(doughType);
            }
        }

        public void BuildSauce(string sauceType = null)
        {
            if(sauceType == null || string.IsNullOrEmpty(sauceType))
            {
                this._product.Add("tomato Sauce");
            }
            else
            {
                this._product.Add(sauceType);
            }
        }
        public void BuildTopping(string toppingType= null)
        {
            if(toppingType == null || string.IsNullOrEmpty(toppingType))
            {
                this._product.Add("Cheese Topping");
            }
            else
            {
                this._product.Add(toppingType);
            }
        }
        public WhitePizza GetPizza()
        {
            WhitePizza result = this._product;
            this.Reset();
            return result;
        }
    }
    public class WhitePizza
    {
        private List<object> parts = new List<object>();
        public void Add(string part)
        {
            this.parts.Add(part);
        }
        public string ListParts()
        {
            return "White Pizza: " + string.Join(",", this.parts);
        }
    }
    
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza _product = new();
        public WheatPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new WheatPizza();
        }
        public void BuildDough(string doughType=null)
        {
            if(doughType == null ||string.IsNullOrEmpty(doughType) )
            {
                this._product.Add("Wheat Dough");
            }
            else
            {
                this._product.Add(doughType);
            }
        }
        public void BuildSauce(string sauceType=null)
        {
            if(sauceType == null ||  string.IsNullOrEmpty(sauceType))
            {
                this._product.Add("Italian Sauce");
            }
            else
            {
                this._product.Add(sauceType);
            }
        }
        public void BuildTopping(string toppingType=null)
        {
            if(toppingType == null ||  string.IsNullOrEmpty(toppingType))
            {
                this._product.Add("Cheese Marai Topping");
            }
            else
            {
                this._product.Add(toppingType);
            }
        }
        public WheatPizza GetPizza()
        {
            WheatPizza result = this._product;
            this.Reset();
            return result;
        }
    }
    public class WheatPizza
    {
        private List<object> parts = new List<object>();
        public void Add(string part)
        {
            this.parts.Add(part);
        }
        public string ListParts()
        {
            return "Wheat Pizaa: " + string.Join(",", this.parts);
        }
    }
    public class Director
    {
        private IPizzaBuilder _builder;

        public Director(IPizzaBuilder pizzaBuilder)
        {
            this._builder = pizzaBuilder;
        }
        public void MakePizza()
        {
            WriteLine("Dough ? : Or tra Default");
            this._builder.BuildDough( ReadLine());
            WriteLine("Sauce ? : Or tra Default");
            this._builder.BuildSauce( ReadLine());
            WriteLine("Topping ?: Or tra Default ");
            this._builder.BuildTopping( ReadLine());
        }
    }
    class Program
    {
        static void Main()
        {
            //client
            WhitePizzaBuilder whitePizzaBuilder = new();
            Director director = new(whitePizzaBuilder);
            // Bonus Two user prompt 
            director.MakePizza();
            WriteLine("------------------------------------");
            WriteLine("Here IS your White Pizza ");
            WriteLine("------------------------------------");
            WriteLine(whitePizzaBuilder.GetPizza().ListParts());
            WriteLine("------------------------------------");
            
            WheatPizzaBuilder wheatPizzaBuilder = new();
            director = new(wheatPizzaBuilder);
            director.MakePizza();
            WriteLine("------------------------------------");
            WriteLine("Here IS your Brown Pizza");
            WriteLine("------------------------------------");
            WriteLine(wheatPizzaBuilder.GetPizza().ListParts());
            WriteLine("------------------------------------");
            
             // Bonus One 
             WriteLine("====================================");
             WriteLine("Created Without Director");
             WriteLine("------------------------------------");
             whitePizzaBuilder.BuildSauce("Green Paper Sauce");
             whitePizzaBuilder.BuildTopping("Jalapeno");
             whitePizzaBuilder.BuildDough("Honey White");
             WriteLine(whitePizzaBuilder.GetPizza().ListParts());
             WriteLine("------------------------------------");
        }
    }
}