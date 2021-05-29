using System;
using System.Collections.Generic;

namespace PizzaDesignPattren
{

    public interface IPizzaBuilder
    {
        // This is the basis for building any pizza
        public void BuildDough();
        public void BuildSauce();
        public void BuildTopping();
        public void Reset(); // to reset after make pizza
    }
    public class ThinPizzeBuilder : IPizzaBuilder
    {
        private ThinPizza _thin = new ThinPizza();

        public ThinPizzeBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._thin = new ThinPizza();
        }
        public void BuildDough()
        {
            this._thin.PreparePizza("Preparing the dough ..white");
        }
        public void BuildSauce()
        {
            this._thin.PreparePizza("Add souce ..white souce");
        }
        public void BuildTopping()
        {
            this._thin.PreparePizza("Add favorite topping .. cheese");
        }
        public ThinPizza GetPizza()
        {
            ThinPizza final = this._thin;
            this.Reset();
            return final;
        }
    }
    public class ThickPizzaBuilder : IPizzaBuilder
    {
        private ThickPizza _thick = new ThickPizza();

        public ThickPizzaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._thick = new ThickPizza();
        }
        public void BuildDough()
        {

            this._thick.PreparePizza("Preparing the dough ..wheat");
        }
        public void BuildSauce()
        {
            this._thick.PreparePizza("Add souce ..without");
        }
        public void BuildTopping()
        {
            this._thick.PreparePizza("Add favorite topping ..vegetables + cheese");
        }
        public ThickPizza GetPizza()
        {
            ThickPizza final = this._thick;
            this.Reset();
            return final;
        }
    }
    public class ThinPizza
    {
        private List<object> _pizza = new List<object>();

        public void PreparePizza(string pizza)
        { //determine type of dough ,souce,topping
            this._pizza.Add(pizza);
        }
        public string PizzaOrder()
        {
            string str = "";
            for (int i = 0; i < this._pizza.Count; i++)
            {
                str += this._pizza[i] + "\n";
            }
            return "Thin Pizza order : \n" + str;
        }
    }

    public class ThickPizza
    {
        private List<string> _pizza = new List<string>();

        public void PreparePizza(string pizza)
        { //determine type of dough ,souce,topping
            this._pizza.Add(pizza);
        }
        public string PizzaOrder()
        {
            string str = "";
            for (int i = 0; i < this._pizza.Count; i++)
            {
                str += this._pizza[i] + "\n";
            }
            return "Thick Pizza order : \n" + str;
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
        public void makePizzaWithoutSauce()
        {
            this._pizzaBuilder.BuildDough();
            this._pizzaBuilder.BuildTopping();
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            ThickPizzaBuilder thick = new ThickPizzaBuilder();
            ThinPizzeBuilder thin = new ThinPizzeBuilder();
            ThinPizzeBuilder thin2 = new ThinPizzeBuilder();


            director.PizzaBuilder = thin;
            // director make order of pizza with souce Ranch and topping cheese
            director.makePizza();
            Console.WriteLine(thin.GetPizza().PizzaOrder());


            director.PizzaBuilder = thick;
            // director make another order of pizza with souce Ranch and topping cheese
            director.makePizza();
            Console.WriteLine(thick.GetPizza().PizzaOrder());

            director.PizzaBuilder = thin2;
            //director make another order without souce
            director.makePizzaWithoutSauce();
            Console.WriteLine(thin2.GetPizza().PizzaOrder());

            //Bouns 1 make pizza order without director 
            ThinPizzeBuilder pizza = new ThinPizzeBuilder();
            pizza.BuildDough();
            pizza.BuildSauce();
            pizza.BuildTopping();
            Console.WriteLine(pizza.GetPizza().PizzaOrder());



            /*  //Bouns 2 user enter his order !
             *      public interface IPizzaBuilder
    {
        // This is the basis for building any pizza
        public void BuildDough(string d);
        public void BuildSauce(string s);
        public void BuildTopping(string t);
     
    }
              Console.WriteLine("What is the favorite type of dough (thin / thick)?");
              string choice = Console.ReadLine();

              string dough;
              string souce;
              string topping;
              switch (choice)
              {

                  case "thin":
                      director.PizzaBuilder = thin;
                      Console.WriteLine("Enter your favorite dough :(white / wheat)? ");
                      dough = Console.ReadLine();
                      Console.WriteLine("Enter your favorite souce : ");
                      souce = Console.ReadLine();
                      Console.WriteLine("Enter you favorite topping?");
                      topping = Console.ReadLine();
                      thin.makepizza(dough,souce,topping);
                      Console.WriteLine(thin.GetPizza().PizzaOrder());
                      Console.WriteLine("Enjoy .. :)");
                      break;

                  case "thick":
                      director.PizzaBuilder = thick;
                      Console.WriteLine("Enter your favorite dough :(white / wheat)? ");
                      dough = Console.ReadLine();
                      Console.WriteLine("Enter your favorite souce : ");
                      souce = Console.ReadLine();
                      Console.WriteLine("Enter you favorite topping?");
                      topping = Console.ReadLine();
                      director.makePizza(dough,souce,topping);
                      Console.WriteLine(thick.GetPizza().PizzaOrder());
                      Console.WriteLine("Enjoy .. :)");
                      break;

                  default:
                      Console.WriteLine("invalid choice");
                      break;
              }*/
        }
    }
}
    




