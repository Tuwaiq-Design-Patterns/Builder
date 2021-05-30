namespace builder_
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

        public void makePizza(string dough, string sauce, bool hasTopping)
        {
            PizzaBuilder
            .BuildDough(dough)
            .BuildSauce(sauce)
            .BuildTopping(hasTopping);
        }
    }
}