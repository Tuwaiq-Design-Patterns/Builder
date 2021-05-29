namespace builder
{
    public class Director
    {
        public IPizzaBuilder PizzaBuilder { get; set; }

        public Director(IPizzaBuilder pizzaBuilder)
        {
            PizzaBuilder = pizzaBuilder;
        }

        public void makePizza()
        {
            PizzaBuilder
            .BuildDough()
            .BuildSauce()
            .BuildTopping();
        }

        public void makePizza(string dough, string sauce, string[] topping)
        {
            PizzaBuilder
            .BuildDough(dough)
            .BuildSauce(sauce)
            .BuildTopping(topping);
        }
    }
}