using System;
using System.Linq;

namespace builder
{
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        public Pizza Pizza { get; set; }

        public WheatPizzaBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            Pizza = new Pizza();
        }
        public IPizzaBuilder BuildDough(string dough = "Wheat")
        {
            Pizza.Dough = dough;
            return this;
        }
        public IPizzaBuilder BuildSauce(string sauce = "Ranch")
        {
            Pizza.Sauce = sauce;
            return this;
        }
        public IPizzaBuilder BuildTopping()
        {
            Pizza.Topping = new string[] { "Diced onions", "Green Peppers", "Italian Sausage", "Tartar sauce" };
            return this;
        }

        public IPizzaBuilder BuildTopping(string[] topping)
        {
            Pizza.Topping = topping;
            return this;
        }

        public Pizza GetPizza()
        {
            return Pizza;
        }
    }
}