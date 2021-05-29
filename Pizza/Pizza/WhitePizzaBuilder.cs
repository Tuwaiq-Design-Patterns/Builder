using System;
namespace Pizza
{
    public class WhitePizzaBuilder : PizzaBuilder
    {
        private WhitePizza Pizza =new WhitePizza();

        public WhitePizzaBuilder()
        {
        }

        public void BuildDough() => Pizza.Add(" BuildDough: Thick ");

        public void BuildSauce() => Pizza.Add("With Tomato Sauce");

        public void BuildTopping() => Pizza.Add("Extra pepperoni");

        public void reset()
        {
            this.Pizza = new WhitePizza();
        }

        public WhitePizza getPizza()
        {
            WhitePizza p = this.Pizza;
            this.reset();
            return p;
        }
    }
}
