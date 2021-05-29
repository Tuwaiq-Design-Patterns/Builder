using System;
using System.Collections.Generic;

namespace BuilderDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            
            // Margherita Pizza Builder
            var margheritaPizza = new MargheritaPizzaBuilder();
            
            director.PizzaBuilder = margheritaPizza;
            
            director.MakeMinimalPizza();
            Console.WriteLine(margheritaPizza.GetMargaritaPizza().PizzaToppings());
            director.MakeFullPizza();
            Console.WriteLine(margheritaPizza.GetMargaritaPizza().PizzaToppings());

            // Pepperoni Pizza Builder
            var pepperoniPizza = new PepperoniPizzaBuilder();
            
            director.PizzaBuilder = pepperoniPizza;
            
            director.MakeMinimalPizza();
            Console.WriteLine(pepperoniPizza.GetPepperoniPizza().PizzaToppings());
            director.MakeFullPizza();
            Console.WriteLine(pepperoniPizza.GetPepperoniPizza().PizzaToppings());

            
            // Custom Pizza

            margheritaPizza.BuildDough().BuildSauce().BuildCheese().BuildCheese().BuildJalapeno();
            Console.WriteLine(margheritaPizza.GetMargaritaPizza().PizzaToppings());

            pepperoniPizza.BuildDough().BuildSauce().BuildCheese().BuildCheese().BuildPepperoni().BuildPepperoni()
                .BuildJalapeno().BuildJalapeno();
            
            Console.WriteLine(pepperoniPizza.GetPepperoniPizza().PizzaToppings());

        }
    }



    
    

    
    
}