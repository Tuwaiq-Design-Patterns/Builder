namespace DesignPattern
{
    public class Director
    {
        private IPizzaBuilder PizzaBuilder { get; set; }

        public Director(IPizzaBuilder pizzaBuilder)
        {
            this.PizzaBuilder = pizzaBuilder;
        }

        public void MakePizza()
        {
            this.PizzaBuilder.BuildDough();
            this.PizzaBuilder.BuildSauce();
            this.PizzaBuilder.BuildTopping();
        }
    }
}