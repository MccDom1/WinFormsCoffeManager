using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public abstract class Beverage
    {
        public string Name { get; set; } = "";
        public string Size { get; set; } = "";          // e.g., Small/Medium/Large
        public decimal Price { get; set; }              // base property
        public bool IsIced { get; set; }                // base property
    }
}

