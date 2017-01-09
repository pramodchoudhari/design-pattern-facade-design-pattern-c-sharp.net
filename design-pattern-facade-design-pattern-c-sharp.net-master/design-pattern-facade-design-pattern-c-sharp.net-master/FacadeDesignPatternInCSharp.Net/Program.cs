using PrototypeDesignPatternInCSharp.Net.RealWorldExample;
using PrototypeDesignPatternInCSharp.Net.StructuralCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatternInCSharp.Net
{
    class Program
    {
        static void Main(string[] args)
        {

            Facade facade = new Facade();
            facade.BuildSystem();

            Console.WriteLine("Real World Example");
            HolidayPackage package = new HolidayPackage();
            package.Budget = 80000;
            package.BuildHolidayPackage();
            Console.ReadKey();
        }
    }
}
