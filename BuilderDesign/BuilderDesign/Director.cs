namespace BuilderDesign
{
    public class Director
    {
        private IPizzaBuilder _pizzaBuilder;

        public IPizzaBuilder PizzaBuilder
        {
            set { _pizzaBuilder = value; }
        }

        public void MakeMinimalPizza()
        {
            this._pizzaBuilder.BuildDough().BuildSauce().BuildCheese();
        }

        public void MakeFullPizza()
        {
            this._pizzaBuilder.BuildDough().BuildSauce().BuildCheese().BuildPepperoni().BuildJalapeno();
        } 
    }
}