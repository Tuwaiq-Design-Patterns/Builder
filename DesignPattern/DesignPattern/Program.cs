using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern
{
    class Program
    {
        abstract class Pizza
        {
            
            public string Crust { get; set; }
            public string Sauce { get; set; }
            public List<string> Toppings { get; set; } = new List<string>();
            public abstract string Type { get; }


            public override string ToString()
            {
                List<string> pizza = new List<string>();

                string toppingStr= "";
                if (Toppings.Any())
                {
                    toppingStr = "Added toppings: ";
                    foreach (var t in Toppings)
                    {
                        toppingStr += t + ", ";
                        pizza.Add(toppingStr);
                    }
                    toppingStr = toppingStr.Remove(toppingStr.Length - 2, 2);
                }

                return "Pizza type: " + Type + "\nCrust type: " + Crust + " Crust" + "\nSauce type: " + Sauce + " sauce" + "\n" + toppingStr +"\n";
            }
        }

        class WhitePizza : Pizza
        {
            public override string Type => "White Pizza";
        }

        class WheatPizza : Pizza
        {
            public override string Type => "Wheat Pizza";
        }

       interface IPizzaBuilder
        {
            public void Reset();
            public void BuildDough(string Crust); //default White crust
            public void BuildSauce(string Sauce);  //default red sause
            public void BuildTopping(List<string> toppings = null);
        }

        class WhitePizzeBuilder : IPizzaBuilder
        {
            private WhitePizza pizza = new WhitePizza();

            public void Reset()
            {
                pizza = new WhitePizza();
            }

            public void BuildDough(string Crust)
            {
                pizza.Crust = Crust;
            }

            public void BuildSauce(string Sauce)
            {
                pizza.Sauce = Sauce;
            }

            public void BuildTopping(List<string> toppings = null)
            {
                if (toppings != null)
                {
                    foreach (var item in toppings)
                    {
                        pizza.Toppings.Add(item);
                    }
                }
            }

            public WhitePizza GetPizza()
            {
                WhitePizza whitePizza = new WhitePizza();
                whitePizza = pizza;
                this.Reset();
                return whitePizza;
            }

        }

        class WheatPizzaBuilder : IPizzaBuilder
        {
            private WheatPizza pizza = new WheatPizza();

            public void Reset()
            {
                pizza = new WheatPizza();
            }

            public void BuildDough(string Crust = "White")
            {
                pizza.Crust = Crust;
            }

            public void BuildSauce(string Sauce = "Red")
            {
                pizza.Sauce = Sauce;
            }

            public void BuildTopping(List<string> toppings = null)
            {
                if (toppings != null)
                {
                    foreach (var item in toppings)
                    {
                        pizza.Toppings.Add(item);
                    }
                }
            }

            public WheatPizza GetPizza()
            {
                WheatPizza wheatPizza = pizza;
                this.Reset();
                return wheatPizza;
            }
        }

        class Director
        {
            private IPizzaBuilder pizzaBuilder;
            public IPizzaBuilder PizzaBuilder { set => pizzaBuilder = value; }

            public Director(IPizzaBuilder pizzaBuilder)
            {
                this.pizzaBuilder = pizzaBuilder;
            }

            public void MakePizza(string Crust = "White", string Sauce = "Red", List<string> toppings = null)
            {
                pizzaBuilder.BuildDough(Crust);
                pizzaBuilder.BuildSauce(Sauce);
                pizzaBuilder.BuildTopping(toppings);
            }
        }
       
      
        static void Main(string[] args)
        {
            //requirements 
            IPizzaBuilder pizzaBuilder = new WhitePizzeBuilder();
            Director director = new Director(pizzaBuilder);

            //white pizza without toppings
            director.MakePizza();
            Pizza pizza = (pizzaBuilder as WhitePizzeBuilder).GetPizza();
            Console.WriteLine(pizza);

            //white pizza with toppings
            List<string> toppings = new List<string>() { "Cheese", "Olives", "Tomato"};
            director.MakePizza("White", "Red",toppings);
            //director.AddToppings();
            pizza = (pizzaBuilder as WhitePizzeBuilder).GetPizza();
            Console.WriteLine(pizza);

            //wheat pizza without toppings
            director.PizzaBuilder = (pizzaBuilder = new WheatPizzaBuilder());
            director.MakePizza();
            pizza = (pizzaBuilder as WheatPizzaBuilder).GetPizza();
            Console.WriteLine(pizza);

            //wheat pizza with toppings
            List<string> toppings2 = new List<string>() { "Cheese", "Onions", "çhicken" };

            director.MakePizza("White", "Red", toppings2);
            pizza = (pizzaBuilder as WheatPizzaBuilder).GetPizza();
            Console.WriteLine(pizza);


            // Bouns 1
            Console.WriteLine("\n" + "Pizzas made without dirctor");
            //white pizza without toppings
            pizzaBuilder = new WhitePizzeBuilder();
            pizzaBuilder.BuildDough("White");
            pizzaBuilder.BuildSauce("Red");
            pizzaBuilder.BuildTopping(null);
            pizza = (pizzaBuilder as WhitePizzeBuilder).GetPizza();
            Console.WriteLine(pizza);

            //white pizza with toppings
            pizzaBuilder.BuildDough("White");
            pizzaBuilder.BuildSauce("Red");
            List<string> toppings3 = new List<string>() { "Beef", "Onions", "Peopper" };
            pizzaBuilder.BuildTopping(toppings3);
            pizza = (pizzaBuilder as WhitePizzeBuilder).GetPizza();
            Console.WriteLine(pizza);

            //wheat pizza without toppings
            pizzaBuilder = new WheatPizzaBuilder();
            pizzaBuilder.BuildDough("wheat");
            pizzaBuilder.BuildSauce("White");
            pizza = (pizzaBuilder as WheatPizzaBuilder).GetPizza();
            Console.WriteLine(pizza);

            //wheat pizza with toppings
            pizzaBuilder.BuildDough("wheat");
            pizzaBuilder.BuildSauce("Red");
            List<string> toppings4 = new List<string>() { "Green Olives", "Tomato", "Chicken" };
            pizzaBuilder.BuildTopping(toppings4);
            pizza = (pizzaBuilder as WheatPizzaBuilder).GetPizza();
            Console.WriteLine(pizza);


            //Bouns 2
            Console.WriteLine( "\n" + "Make you own pizza?");
            List<string> UserTopping = new List<string>();
            Console.WriteLine("What kind of pizza would you like?");
            Console.WriteLine("1. White Pizza");
            Console.WriteLine("2. Wheat Pizza");
           
            pizzaBuilder = Console.ReadLine() switch
            {
                "1" => new WhitePizzeBuilder()
                ,
                "2" => new WheatPizzaBuilder()
                ,
                _ => throw new Exception("Invalid selection")
            };

            director = new Director(pizzaBuilder);
            string Crust = pizzaBuilder is WhitePizzeBuilder ? "White" : "Wheat";

            Console.WriteLine("What kind of sauce?");
            Console.WriteLine("1. Red sauce");
            Console.WriteLine("2. White sauce");

            // get sauce fron user
            string s = Console.ReadLine() switch
            {
                "1" => "Red"
                ,
                "2" => "White"
                ,
                _ => throw new Exception("Invalid selection")
            };
            string Sauce = s;


            // get toppings fron user
            Console.WriteLine("What about topping? (Enter item number)");
            Console.WriteLine("1. Cheese");
            Console.WriteLine("2. Chicken");
            Console.WriteLine("3. Beef");
            Console.WriteLine("4. Onions");
            Console.WriteLine("5. Pepperoni");
            Console.WriteLine("6. Black olives");
            Console.WriteLine("7. Green olives");
            Console.WriteLine("8. Done");

            string response;
            while ((response = Console.ReadLine()) != "8")
            {
                UserTopping.Add(
                    response switch
                    {
                        "1" => "Cheese"
                        ,
                        "2" => "Chicken"
                        ,
                        "3" => "Beef"
                        ,
                        "4" => "Onions"
                        ,
                        "5" => "Pepperoni"
                        ,
                        "6" => "Black olives"
                        ,
                        "7" => "Green olives"
                        ,
                        _ => throw new Exception("Invalid selection")
                    });
                Console.WriteLine("Select another topping or (8) if you are done");
            }

            pizzaBuilder.BuildDough(Crust);
            pizzaBuilder.BuildSauce(Sauce);
            director.MakePizza(Crust, Sauce, UserTopping);

            if (pizzaBuilder is WhitePizzeBuilder)
            {
                Pizza p = (pizzaBuilder as WhitePizzeBuilder).GetPizza();
                Console.WriteLine(p);
            }
            else if (pizzaBuilder is WheatPizzaBuilder)
            {
                Pizza p = (pizzaBuilder as WheatPizzaBuilder).GetPizza();
                Console.WriteLine(p);
            }
        }
    }
}
