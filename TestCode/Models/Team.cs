using System.Collections.Generic;

namespace TestCode.Models
{
    public class Team
    {
        private readonly List<Driver> _drivers = new List<Driver>();

        public int Id { get; set; }

        public string Name { get; set; }

        public string Constructor { get; set; }

        public string Tire { get; set; }

        public string Principal { get; set; }

        public int ConstructorsChampionships { get; set; }

        public int DriversChampionships { get; set; }

        public int Races { get; set; }

        public int Victories { get; set; }

        public int Poles { get; set; }

        public int FastestLaps { get; set; }

        public virtual ICollection<Driver> Drivers
        {
            get { return _drivers; }
        }

        internal void AddDrivers(List<Driver> drivers)
        {
            _drivers.AddRange(drivers);
        }
    }
}