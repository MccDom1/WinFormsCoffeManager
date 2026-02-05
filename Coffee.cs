using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace WinFormsApp2
{
    public class Coffee : Beverage
    {
        public string Roast { get; set; } = "";         // Light/Medium/Dark
        public int Shots { get; set; }                  // espresso shots
        public bool HasMilk { get; set; }               // specific coffee property
        public string Notes => $"{Roast} roast, {Shots} shot(s)";
    }
}

