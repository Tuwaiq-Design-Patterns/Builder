namespace BuilderDesign
{
    class MargheritaPizzaBuilder : IPizzaBuilder
    {
        private MargheritaPizza _margheritaPizza = new();

        public IPizzaBuilder Reset()
        {
            this._margheritaPizza = new();
            return this;
        }

        public MargheritaPizzaBuilder()
        {
            this.Reset();
        }

        public IPizzaBuilder BuildDough()
        {
            this._margheritaPizza.AddTopping("Dough");
            return this;
        }

        public IPizzaBuilder BuildSauce()
        {
            this._margheritaPizza.AddTopping("Tomato Sauce");
            return this;
        }

        public IPizzaBuilder BuildCheese()
        {
            this._margheritaPizza.AddTopping("Cheese");
            return this;
        }

        public IPizzaBuilder BuildPepperoni()
        {
            return this;
        }

        public IPizzaBuilder BuildJalapeno()
        {
            this._margheritaPizza.AddTopping("Jalapeno");
            return this;
        }


        public MargheritaPizza GetMargaritaPizza()
        {
            MargheritaPizza pizza = this._margheritaPizza;

            this.Reset();

            return pizza;
        }
    }

}