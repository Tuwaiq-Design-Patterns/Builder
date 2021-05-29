using System;
namespace Pizza
{
    public class WheatPizzaBuilder : PizzaBuilder
    {
       
        private WheatPizza Pizza = new WheatPizza();
        public void BuildDough()
        {
            Pizza.Add(" BuildDough: Thin ");
        }

        public void BuildSauce()
        {
            Pizza.Add("Without Tomato Sauce");
        }

        public void BuildTopping()
        {
            Pizza.Add("extra cheese");
        }

        public void reset()
        {
            this.Pizza = new WheatPizza();
        }

        public WheatPizza getPizza()
        {
            WheatPizza p = this.Pizza;
            this.reset();
            return p;
        }
    }
}
