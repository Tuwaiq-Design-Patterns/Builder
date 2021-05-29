namespace DesignPattern
{
    public interface IPizzaBuilder
    {
        public void Reset();
        public IPizzaBuilder BuildDough();
        public IPizzaBuilder BuildSauce();
        public IPizzaBuilder BuildTopping();
    }
}