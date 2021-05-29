using System;
using PizzaMaker.Pizze;
using PizzaMaker.Ingredients;

namespace PizzaMaker.Builders
{
    public class NeapolitanPizzaBuilder : IPizzaBuilder
    {
        private NeapolitanPizza Pizza;

        public NeapolitanPizzaBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            Pizza = new NeapolitanPizza();
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

        public NeapolitanPizza GetPizza()
        {
            NeapolitanPizza result = Pizza;
            Reset();
            return result;
        }
    }
}
