using System;
using System.Collections.Generic;

namespace PizzaBuilder
{
    public interface IBuilder
    {
        void BulidDough();
        void BuildSauce();
        void BuildTopping();
    }
    public class WhitePizzaBulider : IBuilder
    {
        private WhitePizza _product = new WhitePizza();
        public WhitePizzaBulider()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new WhitePizza();
        }
        public void BulidDough()
        {
            this._product.Add("White Dough");
        }
        public void BuildSauce()
        {
            this._product.Add("Sauce");
        }
        public void BuildTopping()
        {
            this._product.Add("Topping");
        }
        public WhitePizza GetProduct()
        {
            WhitePizza result = this._product;
            this.Reset();
            return result;
        }
    }
    public class WheatPizzaBulider : IBuilder
    {
        private WheatPizza _product = new WheatPizza();
        public WheatPizzaBulider()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new WheatPizza();
        }
        public void BulidDough()
        {
            this._product.Add("Wheat Dough");
        }
        public void BuildSauce()
        {
            this._product.Add("Sauce");
        }
        public void BuildTopping()
        {
            this._product.Add("Topping");
        }
        public WheatPizza GetProduct()
        {
            WheatPizza result = this._product;
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
        public string listParts()
        {
            string str = "";
            for (int i = 0; i < this.parts.Count; i++)
            {
                str += this.parts[i] + ",";
            }
            return "product parts:" + str;
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
            return "product parts:" + str;
        }
    }
/*    public class Director
    {
        private IBuilder _builder;
        public IBuilder Builder
        {
            set { this._builder = value; }
        }
        public void BuildMin()
        {
            this._builder.BulidDough();
        }
        public void BuildFull()
        {
            this._builder.BuildTopping();
            this._builder.BulidDough();
            this._builder.BuildSauce();
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            //client
           // var director = new Director();
            var White = new WhitePizzaBulider();
            var Wheat = new WheatPizzaBulider();

           // director.Builder = White;
            //Full Product
            //director.BuildFull();
            Console.WriteLine(White.GetProduct().listParts());
            //Min Product
          //  director.BuildMin();
            Console.WriteLine(White.GetProduct().listParts());
            //Custom Product
            White.BulidDough();
            White.BuildSauce();
            Console.WriteLine(White.GetProduct().listParts());

           // director.Builder = Wheat;
            Console.WriteLine();

            //Full Product
           // director.BuildFull();
            Console.WriteLine(Wheat.GetProduct().listParts());
            //Min Product
            //director.BuildMin();
            Console.WriteLine(Wheat.GetProduct().listParts());
            //Custom Product
            Wheat.BulidDough();
            Wheat.BuildSauce();
            Console.WriteLine(Wheat.GetProduct().listParts());

            Console.WriteLine();

            Console.WriteLine("Enter Number Bulider or 0 to exit : ");
            Console.WriteLine("1- White.BulidDough()");
            Console.WriteLine("2- White.BuildSauce()");
            Console.WriteLine("3- White.BuildTopping()");
            Console.WriteLine("4- Wheat.BulidDough()");
            Console.WriteLine("5- Wheat.BuildSauce()");
            Console.WriteLine("6- Wheat.BuildTopping()");
            Console.WriteLine();
            int line = Convert.ToInt32(Console.ReadLine());
            while (line != 0)
            {
                if (line == 1)
                {
                    White.BulidDough();
                    Console.WriteLine(White.GetProduct().listParts());
                    Console.WriteLine("Enter Number Bulider or 0 to exit : ");
                    line = Convert.ToInt32(Console.ReadLine());
                }
                else if (line == 2)
                {
                    White.BuildSauce();
                    Console.WriteLine(White.GetProduct().listParts());
                    Console.WriteLine("Enter Number Bulider or 0 to exit : ");
                    line = Convert.ToInt32(Console.ReadLine());
                }
                else if (line == 3)
                {
                    White.BuildTopping();
                    Console.WriteLine(White.GetProduct().listParts());
                    Console.WriteLine("Enter Number Bulider or 0 to exit : ");
                    line = Convert.ToInt32(Console.ReadLine());
                }
                else if (line == 4)
                {
                    Wheat.BulidDough();
                    Console.WriteLine(Wheat.GetProduct().listParts());
                    Console.WriteLine("Enter Number Bulider or 0 to exit : ");
                    line = Convert.ToInt32(Console.ReadLine());
                }
                else if (line == 5)
                {
                    Wheat.BuildSauce();
                    Console.WriteLine(Wheat.GetProduct().listParts());
                    Console.WriteLine("Enter Number Bulider or 0 to exit : ");
                    line = Convert.ToInt32(Console.ReadLine());
                }
                else if (line == 6)
                {
                    Wheat.BuildTopping();
                    Console.WriteLine(Wheat.GetProduct().listParts());
                    Console.WriteLine("Enter Number Bulider or 0 to exit : ");
                    line = Convert.ToInt32(Console.ReadLine());
                }
                else if (line == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter number from 1 to 6 or 0 to exit");
                    Console.WriteLine("Enter Number Bulider or 0 to exit : ");
                    line = Convert.ToInt32(Console.ReadLine());

                }
            }

        }
    }
}
