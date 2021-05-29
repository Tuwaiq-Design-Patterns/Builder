using System;
using PizzaMaker.Pizze;
using PizzaMaker.Ingredients;

namespace PizzaMaker.Builders
{
    public class GreekPizzaBuilder : IPizzaBuilder
    {
        private GreekPizza Pizza;

        public GreekPizzaBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            Pizza = new GreekPizza();
        }

        public void SetBakingTime(double hours)
        {
            throw new NotImplementedException();
        }

        public void SetDough(Dough dough)
        {
            throw new NotImplementedException();
        }

        public void SetSauce(Sauce sauce)
        {
            throw new NotImplementedException();
        }

        public void SetCheese(Cheese cheese)
        {
            throw new NotImplementedException();
        }

        public void SetToppings(Topping[] toppings)
        {
            throw new NotImplementedException();
        }

        public GreekPizza GetPizza()
        {
            GreekPizza result = Pizza;
            Reset();
            return result;
        }
    }
}
