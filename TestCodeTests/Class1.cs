using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCode;

namespace TestCodeTests
{
    class Class1
    {
        static void Main()
        {
            F1StatsTests tests = new F1StatsTests();

            try
            {
                tests.TestDriverByCarNoReturns5();
                tests.TestDriverByCarNoWithNegativeValue();
                tests.TestTeamWinPercentageEmptyList();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
