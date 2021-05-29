using System.Collections.Generic;

namespace ConsoleApplication4
{
    public class WheatPizza
    {
        private List<object> parts = new List<object>();

        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public string listParts()
        {
            string result = "";
            foreach (var part in parts)
            {
                result += part;
            }

            return result;
        }
    }
}