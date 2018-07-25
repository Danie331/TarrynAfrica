using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCode;

namespace TestCodeTests
{
    public class F1StatsTests
    {
        private readonly F1Stats f1stats;
        public F1StatsTests()
        {
            f1stats = new F1Stats(SampleData.Teams, new F1StatsWeightingStub());
        }

        public void TestDriverByCarNoWithNegativeValue()
        {
            var value = f1stats.DriverByCarNo(-1);
            if (value != null)
            {
                throw new Exception("TestDriverByCarNoWithNegativeValue() failed");
            }
        }

        public void TestDriverByCarNoReturns5()
        {
            var value = f1stats.DriverByCarNo(5);

            if (value != null && value.CarNumber != 5)
            {
                throw new Exception("TestDriverByCarNoReturns5() failed");
            }
        }

        public void TestTeamWinPercentageEmptyList()
        {
            var value = f1stats.TeamWinPercentage(-1);

            if (value != null && value.Count() == 0)
            {
                // pass
            }
            else
            {
                throw new Exception("TestTeamWinPercentageEmptyList() failed");
            }
        }
    }
}
