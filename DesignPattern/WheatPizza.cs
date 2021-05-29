using System.Collections.Generic;

namespace DesignPattern
{
    public class WheatPizza
    {
        private List<object> parts = new List<object>();
        
        public void Add(string part)
        {
            this.parts.Add(part);
        }
        
        public string GetPizzaDetails()
        {
            return "WheatPizza parts:" + string.Join(',', this.parts);
        }
    }
}