using System;
using TestCode;

namespace TestCodeTests
{
    public class F1StatsWeightingStub : IF1StatsWeighting
    {
        // Sample implementation. Please read the instructions supplied with the test for the implementation required.
        public double Apply(double driverWinPercentage, int numberOfRaces)
        {
            if (numberOfRaces <= 100) throw new ArgumentException("Put exciting exception message here", "numberOfRaces");
            return 1.0;
        }
    }
}