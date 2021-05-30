using System;
using System.Linq;

namespace builder_
{
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        public Pizza pizza = new Pizza();

        public WheatPizzaBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            pizza = new Pizza();
        }
        public IPizzaBuilder BuildDough(string dough = "Wheat")
        {
            pizza.Dough = dough;
            return this;
        }
        public IPizzaBuilder BuildSauce(string sauce = "Tomato")
        {
            pizza.Sauce = sauce;
            return this;
        }
        public IPizzaBuilder BuildTopping(bool hasTopping = false)
        {
            if (hasTopping) { 

            pizza.Topping = new string[] { "Onions", "Olives", "Green Pepper", "Spinach" };
        }
            return this;
        }


        public Pizza GetPizza()
        {
            Pizza result = this.pizza;
            this.Reset();
            return result;
        }
    }
}