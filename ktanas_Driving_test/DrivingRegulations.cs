using System;
using System.Collections.Generic;
using System.Text;

namespace ktanas_DrivingTest
{
    public class DrivingRegulations
    {

        private readonly Dictionary<string, int> drivingAges;

        public DrivingRegulations()
        {
            drivingAges = new Dictionary<string, int>
            {
                { "Poland", 17 },
                { "UnitedStates", 16 },
                { "Germany", 18 }
            };
        }

        public bool IsAllowedToDrive(Person person, string country)
        {
            return drivingAges[country] <= person.Age;
        }

    }
}
