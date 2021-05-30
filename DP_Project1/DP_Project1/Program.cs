/*using System;

namespace DP_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}*/



using System;
using System.Collections.Generic;
namespace DP_Project1
{


    public interface PizzaBuilder
    {
        void Reset();
        void BuildDough();
        void BuildSause();
        void BuildTopping();
    }


    public class WhiteBuilder : PizzaBuilder
    {
        private Product product = new Product();

        public WhiteBuilder() { }
       public  void Reset() {
            this.product = new Product();
        }
       public  void BuildDough() {
            this.product.Add("BuildDough");
        }
       public  void BuildSause() {
            this.product.Add("BuildSause");

        }
        public void BuildTopping() {
            this.product.Add("BuildTopping");

        }


        public Product getPizza()
        {
            Product result = this.product;
            this.Reset();
            return result;
        }

    }

    /// <summary>
    public class WheatBuilder : PizzaBuilder
    {
        private Product product = new Product();

        public WheatBuilder() { }
        public void Reset()
        {
            this.product = new Product();
        }
        public void BuildDough()
        {
            this.product.Add("BuildDough");
        }
        public void BuildSause()
        {
            this.product.Add("BuildSause");

        }
        public void BuildTopping()
        {
            this.product.Add("BuildTopping");

        }


        public Product getPizza()
        {
            Product result = this.product;
            this.Reset();
            return result;
        }

    }
    /// </summary>



















    public class Product {

        private List<object> parts = new List<object>();

        public void Add (string part)
        {
            this.parts.Add(part);

        }

        public string ListParts()
        {
            string str = "";
            for (int i = 0; i < this.parts.Count; i++)
            {
                str += this.parts[i] + ",";
            }
            return "Product: " + str;
        }

    }

    public class Director
    {
        private PizzaBuilder builder;
        public PizzaBuilder Builder
        {
            set
            {
                this.builder = value;

            }
        }
        // the client asked for minimum properities 
        public void BuildMin()
        {
            this.builder.BuildDough();

        }

        public void BuildFull()
        {
            this.builder.BuildDough();
            this.builder.BuildSause();
            this.builder.BuildTopping();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new WhiteBuilder();
            director.Builder = builder;
            director.BuildFull();
            Console.WriteLine(builder.getPizza().ListParts());
        }
    }
}
