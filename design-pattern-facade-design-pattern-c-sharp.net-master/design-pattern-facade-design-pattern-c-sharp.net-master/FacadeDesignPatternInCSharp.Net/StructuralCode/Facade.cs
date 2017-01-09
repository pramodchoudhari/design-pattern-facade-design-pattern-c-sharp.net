using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatternInCSharp.Net.StructuralCode
{
    public class Facade
    {
        SubsystemA systemA;
        SubsystemB systemB;
        SubsystemC systemC;
        public Facade()
        {
            systemA = new SubsystemA();
            systemB = new SubsystemB();
            systemC = new SubsystemC();
        }

        public void BuildSystem()
        {
            Console.WriteLine("Building Complex System ");
            systemA.BuildSystemA();
            systemB.BuildSystemB();
            systemC.BuildSystemC();
            Console.WriteLine("Built Complex System");
        }
    }
}
