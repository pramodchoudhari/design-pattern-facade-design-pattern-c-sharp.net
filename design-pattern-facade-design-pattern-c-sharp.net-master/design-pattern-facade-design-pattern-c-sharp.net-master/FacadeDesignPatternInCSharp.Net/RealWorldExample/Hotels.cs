using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternInCSharp.Net.RealWorldExample
{
    public class Hotels
    {

        public void AddBudget()
        {
            Console.WriteLine("Added Budget Hotel");
        }
        public void AddThreeStar()
        {
            Console.WriteLine("Added Three Start Hotel");
        }
        public void AddFiveStar()
        {
            Console.WriteLine("Added Five star Flight");
        }
    }
}
