using FacadeDesignPatternInCSharp.Net.RealWorldExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPatternInCSharp.Net.RealWorldExample
{
    public class HolidayPackage
    {
        Days days;
        Season season;
        Flights flights;
        Hotels hotels;
        public double Budget;
        public HolidayPackage()
        {
            days = new Days();
            season = new Season();
            flights = new Flights();
            hotels = new Hotels();
        }

        public void BuildHolidayPackage()
        {
            if (Budget > 100000)
            {
                season.SetSummer();
                flights.AddInternational();
                hotels.AddThreeStar();
                days.SetFiveSixDay();

            }
            else if (Budget > 50000 && Budget < 100000)
            {
                flights.AddInternational();
                season.SetWinter();
                hotels.AddFiveStar();
                days.SetFourDays();
            }
            else if (Budget > 25000 && Budget < 50000)
            {

                season.SetSpring();
                hotels.AddFiveStar();
                days.SetEightNineDays();
            }
            else if (Budget > 10000 && Budget < 25000)
            {
                season.SetRainy();
                hotels.AddThreeStar();
                days.SetFourDays();
            }
        }


    }
}
