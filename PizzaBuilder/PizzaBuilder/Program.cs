using System;
using System.Collections.Generic;

namespace PizzaBuilder
{
    public interface IPizzaBuilder
    {
        void Reset();
        void buildDough();
        void grabPan();
        void buildSauce();
        void buildToppings();

    }
    class DeepdishPizzaBuilder : IPizzaBuilder
    {
        private DeepdishPizza pizza = new DeepdishPizza();

        public DeepdishPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {

        }
        public void grabPan()
        {
            this.pizza.add("deep dish pan");
        }

        public void buildDough()
        {
            this.pizza.add("white flour");
        }

        public void buildSauce()
        {
            this.pizza.add("tomato herb sauce");
        }

        public void buildToppings()
        {
            this.pizza.add("cheese");
        }
        public DeepdishPizza getPizza()
        {
            DeepdishPizza box = this.pizza;
            this.Reset();
            return box;
        }
    }
    public class DeepdishPizza
    {
        private List<object> pizzaComponents = new List<object>();

        public void add(string components)
        {
            this.pizzaComponents.Add(components);
        }

        public string makePizza()
        {
            string str = "";
            for (int i = 0; i < this.pizzaComponents.Count; i++)
            {
                str += this.pizzaComponents[i] + ",";
            }
            return "pizza components:" + str;
        }
    }
    class ThincrustPizzaBuilder : IPizzaBuilder
    {
        private ThincrustPizza pizza = new ThincrustPizza();

        public ThincrustPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {

        }
        public void grabPan()
        {
            this.pizza.add("flat pan");
        }
        public void buildDough()
        {
            this.pizza.add("mixed flour");
        }

        public void buildSauce()
        {
            this.pizza.add("cheesy white sauce");
        }

        public void buildToppings()
        {
            this.pizza.add("vegetables");
        }
        public ThincrustPizza getPizza()
        {
            ThincrustPizza box = this.pizza;
            this.Reset();
            return box;
        }
    }
    public class ThincrustPizza
    {
            private List<object> pizzaComponents = new List<object>();

            public void add(string components)
            {
                this.pizzaComponents.Add(components);
            }

            public string makePizza()
            {
                string str = "";
                for (int i = 0; i < this.pizzaComponents.Count; i++)
                {
                    str += this.pizzaComponents[i] + ",";
                }
                return "pizza components:" + str;
            }
        }

        class Waiter
    {
        private IPizzaBuilder builder;
        public IPizzaBuilder Builder
        {
            set { this.builder = value; }
        }
        public void makePizza()
        {
            this.builder.buildDough();

            this.builder.grabPan();
           
            this.builder.buildSauce();

            this.builder.buildToppings();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                Waiter waiter = new Waiter();

            //First chef is tasked with making thin crust pizzas
                ThincrustPizzaBuilder chef = new ThincrustPizzaBuilder();
                waiter.Builder = chef;
                waiter.makePizza();
                Console.WriteLine(chef.getPizza().makePizza());

                Console.WriteLine("Enjoy your pizza!");

            //Sous chef is tasked with making deep dish pizzas
                DeepdishPizzaBuilder sousChef = new DeepdishPizzaBuilder();
                waiter.Builder = sousChef;

                waiter.makePizza();
                Console.WriteLine(sousChef.getPizza().makePizza());

                Console.WriteLine("Enjoy your pizza!");
           

        }
    }
}