using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз6
{
    public class Product
    {
        public decimal Cost { get; set; }
        public string Name { get; set; }
        public decimal Count { get; set; }
        public decimal FinalCost { get; set; }

        public Product() { }
        public Product(string name, decimal cost, decimal count)
        {
            Cost = cost;
            Name = name;
            Count = count;
            FinalCost = Cost * Count;
        }
        public override string ToString()
        {
            return $"{Name}, {Count}, {FinalCost}";
        }
    }
}
