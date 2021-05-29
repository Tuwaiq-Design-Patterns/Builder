namespace builder
{
    public interface IPizzaBuilder
    {
        public abstract void Reset();
        public abstract IPizzaBuilder BuildDough(string dough = "White");
        public abstract IPizzaBuilder BuildSauce(string sauce = "Tomato");
        public abstract IPizzaBuilder BuildTopping();
        public abstract IPizzaBuilder BuildTopping(string[] topping);
    }
}