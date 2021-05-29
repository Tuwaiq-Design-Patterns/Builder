using System;
namespace Pizza
{
    public interface PizzaBuilder
    {
        public void reset();
        public void BuildDough();
        public void BuildSauce();
        public void BuildTopping();
    }
}
