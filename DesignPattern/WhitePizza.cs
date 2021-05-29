using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern
{
    public class WhitePizza
    {
        private List<object> parts = new List<object>();
        
        public void Add(string part)
        {
            this.parts.Add(part);
        }
        
        public string GetPizzaDetails()
        {
            return "WhitePizza parts:" + string.Join(',', this.parts);
        }
    }
}