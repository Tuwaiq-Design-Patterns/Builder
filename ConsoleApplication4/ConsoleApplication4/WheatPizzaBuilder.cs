using System;

namespace ConsoleApplication4
{
    class WheatPizzaBuilder:IPizzaBuilder
    {
        private WheatPizza wheatepizza;
        public WheatPizzaBuilder()
        {
            this.reset();
        }
        public void reset()
        {
            this.wheatepizza = new WheatPizza();

        }
        public void BuildDough()
        {
            wheatepizza.Add("Wheat Dough + ");
        }

        public void BuildSauce()
        {
            wheatepizza.Add("Sauce + ");
        }

        public void BuildTopping()
        {
            wheatepizza.Add("Topping");
        }

        public WheatPizza getPizza()
        {
            WheatPizza result = this.wheatepizza;
            this.reset();
            return result;
        }
    }
}