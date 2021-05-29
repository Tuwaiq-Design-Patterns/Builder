namespace BuilderDesign
{
    public interface IPizzaBuilder
    {
        IPizzaBuilder Reset();
        IPizzaBuilder BuildDough();
        IPizzaBuilder BuildSauce();
        IPizzaBuilder BuildCheese();
        IPizzaBuilder BuildPepperoni();
        IPizzaBuilder BuildJalapeno();
    }
}