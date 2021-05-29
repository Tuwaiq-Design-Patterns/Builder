using System.Collections.Generic;

namespace Builder
{
    public interface IPizzaBuilder
    {
        void Reset();
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }
}