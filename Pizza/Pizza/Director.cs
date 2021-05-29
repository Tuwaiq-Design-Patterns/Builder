using System;
namespace Pizza
{
    public class Director
    {

        private PizzaBuilder pizzaBuilder;
        public PizzaBuilder Builder
        {
            set { this.pizzaBuilder = value; }
        }

        public void StandardPizza()
        {
            this.pizzaBuilder.BuildDough();
            this.pizzaBuilder.BuildSauce();
            this.pizzaBuilder.BuildTopping();
        }
    }
}
