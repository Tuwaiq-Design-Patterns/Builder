namespace ConsoleApplication4
{
    public class Director
    {
        private IPizzaBuilder _builder;

        public Director(IPizzaBuilder b )
        {
            _builder = b;
        }

        public void make()
        {
            _builder.BuildDough();
            _builder.BuildSauce();
            _builder.BuildTopping();
            
        }
    }
}