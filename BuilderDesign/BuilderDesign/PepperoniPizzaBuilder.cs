namespace BuilderDesign
{
    class PepperoniPizzaBuilder : IPizzaBuilder
    {
        private PepperoniPizza _pepperoniPizza = new();

        public IPizzaBuilder Reset()
        {
            this._pepperoniPizza = new();
            return this;
        }
        
        public PepperoniPizzaBuilder()
        {
            this.Reset();
        }

        public IPizzaBuilder BuildDough()
        {
            this._pepperoniPizza.AddTopping("Dough");
            return this;
        }

        public IPizzaBuilder BuildSauce()
        {
            this._pepperoniPizza.AddTopping("Tomato Sauce");
            return this;
        }

        public IPizzaBuilder BuildCheese()
        {
            this._pepperoniPizza.AddTopping("Cheese");
            return this;
        }

        public IPizzaBuilder BuildPepperoni()
        {
            this._pepperoniPizza.AddTopping("Pepperoni");
            return this;
        }
        public IPizzaBuilder BuildJalapeno()
        {
            this._pepperoniPizza.AddTopping("Jalapeno");
            return this;
        }

        public PepperoniPizza GetPepperoniPizza()
        {
            PepperoniPizza pizza = this._pepperoniPizza;

            this.Reset();

            return pizza;
        }
        
    }

}