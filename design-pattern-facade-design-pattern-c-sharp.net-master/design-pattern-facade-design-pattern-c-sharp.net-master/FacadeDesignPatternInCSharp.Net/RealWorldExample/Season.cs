using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternInCSharp.Net.RealWorldExample
{
    public class Season
    {

        public void SetSummer()
        {
            Console.WriteLine("Added Summer");
        }
        public void SetRainy()
        {
            Console.WriteLine("Added Rainy");
        }
        public void SetWinter()
        {
            Console.WriteLine("Added Winter");
        }
        public void SetSpring()
        {
            Console.WriteLine("Added Sping");
        }
    }
}
