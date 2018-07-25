using System.Collections.Generic;
using TestCode.Models;
using System.Linq;

namespace TestCode
{
    public class F1Stats
    {
        public IEnumerable<Team> TeamReferenceData { get; set; }
        public IF1StatsWeighting StatsWeighting { get; set; }

        public F1Stats(IEnumerable<Team> teamReferenceData, IF1StatsWeighting statsWeighting)
        {
            TeamReferenceData = teamReferenceData;
            StatsWeighting = statsWeighting;
        }

        // TODO: Return the driver for the specified car number, or null if not located.
        // The carNo parameter must be > 0. If it is not then return a null result.
        // Note
        //   Team.Drivers has the drivers for the team.
        //   Driver.CarNumber contains the car number
        public Driver DriverByCarNo(int carNo)
        {
            if (carNo <= 0) return null;

            var targetDriver = (from n in TeamReferenceData
                             from m in n.Drivers
                             where m.CarNumber == carNo
                             select m).FirstOrDefault();

            return targetDriver;
        }

        // TODO: For each team return their win % as well as their drivers win %, sorted by the team 'win %' highest to lowest.
        // If a teamId is specified then return data for only that team i.e. method result list will only a single entry
        // otherwise if the teamId=0 return item data for each team in TeamReferenceData supplied in the constructor
        // If a team is specified and cannot be located then return a empty list.
        // NB! If a driver has done 100 or more races then IF1StatsWeighting must be invoked with the required parameters
        //    ONLY make this call if the drivers races >= 100.
        //    The result must be stored in the DriverWeighting field of team value.
        //    If the driver has done less than 100 races the DriverWeighting must be set to 0.
        // Note
        //   Team Win % is Team.Victories over Team.Races
        //   Driver Win % is Driver.Wins over Driver.Races
        //   Only calculate win % for drivers. Exclude test drivers
        public IEnumerable<TeamValue> TeamWinPercentage(int teamId = 0)
        {
            List<TeamValue> results = new List<TeamValue>();
            if (teamId != 0)
            {
                var team = TeamReferenceData.FirstOrDefault(t => t.Id==teamId);
                if (team != null)
                {
                    return CalcTeamStats(team);
                }

                return new List<TeamValue>();
            }
            foreach (var team in TeamReferenceData)
            {
                var resultsForTeam = CalcTeamStats(team);
                results.AddRange(resultsForTeam);
            }

            return results.OrderByDescending(t => t.TeamWinsPercentage);
        }

        private List<TeamValue> CalcTeamStats(Team team)
        {
            List<TeamValue> results = new List<TeamValue>();
            double teamWinsPerc = (double)team.Victories / (double)team.Races * 100.0;
            foreach (var driver in team.Drivers.Where(d => !(d is TestDriver)))
            {
                TeamValue teamStats = new TeamValue();
                teamStats.DriverWinPercentage = (double)driver.Wins / (double)driver.Races * 100;
                teamStats.TeamWinsPercentage = teamWinsPerc;
                if (driver.Races >= 100)
                {
                    if (StatsWeighting != null)
                    {
                        teamStats.DriverWeighting = StatsWeighting.Apply(teamStats.DriverWinPercentage, driver.Races);
                    }
                }

                results.Add(teamStats);
            }

            return results;
        }

    }
}