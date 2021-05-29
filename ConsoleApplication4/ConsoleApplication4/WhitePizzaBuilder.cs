using System;

namespace ConsoleApplication4
{
    class WhitePizzaBuilder:IPizzaBuilder
    {
        private WhitePizza whitepizza;
        public WhitePizzaBuilder()
        {
            this.reset();
        }
        public void reset()
        {
            this.whitepizza = new WhitePizza();

        }
        public void BuildDough()
        {
            whitepizza.Add("White Dough + ");
        }

        public void BuildSauce()
        {
            whitepizza.Add("Sauce + ");
        }

        public void BuildTopping()
        {
            whitepizza.Add("Topping ");
        }

        public WhitePizza getPizza()
        {
            WhitePizza result = this.whitepizza;
            this.reset();
            return result;
        }
    }
}