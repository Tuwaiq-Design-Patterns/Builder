using System;

namespace ConsoleApplication4
{
    public interface IPizzaBuilder
    {
        void reset();
        void BuildDough();
        void BuildSauce();
        void BuildTopping();
    }
}