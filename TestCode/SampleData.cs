using System.Collections.Generic;
using System.Linq;
using TestCode.Models;

namespace TestCode
{
    public static class SampleData
    {
        private static IQueryable<Driver> _drivers;
        public static IQueryable<Team> Teams;

        static SampleData()
        {
            AddEntities();
        }

        private static void AddEntities()
        {
            _drivers = new List<Driver>
                           {
                               new Driver
                                   {
                                       Name = "Jenson Button",
                                       TeamId = McLaren,
                                       CarNumber = 1,
                                       Championships = 1,
                                       Races = 184,
                                       Wins = 9,
                                       Podiums = 29,
                                       Poles = 7,
                                       FastestLaps = 3
                                   },
                               new Driver
                                   {
                                       Name = "Lewis Hamilton",
                                       TeamId = McLaren,
                                       CarNumber = 2,
                                       Championships = 1,
                                       Races = 64,
                                       Wins = 13,
                                       Podiums = 33,
                                       Poles = 18,
                                       FastestLaps = 5
                                   },
                               new TestDriver
                                   {
                                       Name = "Gary Paffett",
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new Driver
                                   {
                                       Name = "Michael Schumacher",
                                       CarNumber = 3,
                                       Championships = 7,
                                       Races = 262,
                                       Wins = 91,
                                       Podiums = 154,
                                       Poles = 68,
                                       FastestLaps = 76
                                   },
                               new Driver
                                   {
                                       Name = "Nico Rosberg",
                                       CarNumber = 4,
                                       Championships = 0,
                                       Races = 82,
                                       Wins = 0,
                                       Podiums = 5,
                                       Poles = 0,
                                       FastestLaps = 2
                                   },
                               new TestDriver
                                   {
                                       Name = "Nick Heidfeld",
                                       TeamId = Mercedes,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 169,
                                       Wins = 0,
                                       Podiums = 12,
                                       Poles = 1,
                                       FastestLaps = 2
                                   },
                               new Driver
                                   {
                                       Name = "Sebastian Vettel",
                                       TeamId = RedBull,
                                       CarNumber = 5,
                                       Championships = 0,
                                       Races = 55,
                                       Wins = 7,
                                       Podiums = 15,
                                       Poles = 12,
                                       FastestLaps = 6
                                   },
                               new Driver
                                   {
                                       Name = "Mark Webber",
                                       TeamId = RedBull,
                                       CarNumber = 6,
                                       Championships = 0,
                                       Races = 152,
                                       Wins = 6,
                                       Podiums = 16,
                                       Poles = 5,
                                       FastestLaps = 5
                                   },
                               new TestDriver
                                   {
                                       Name = "Brendon Hartley",
                                       TeamId = RedBull,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Daniel Ricciardo",
                                       TeamId = RedBull,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "David Coulthard",
                                       TeamId = RedBull,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 247,
                                       Wins = 13,
                                       Podiums = 62,
                                       Poles = 12,
                                       FastestLaps = 18
                                   },
                               new Driver
                                   {
                                       Name = "Felipe Massa",
                                       TeamId = Ferrari,
                                       CarNumber = 7,
                                       Championships = 0,
                                       Races = 128,
                                       Wins = 11,
                                       Podiums = 31,
                                       Poles = 15,
                                       FastestLaps = 12
                                   },
                               new Driver
                                   {
                                       Name = "Fernando Alonso",
                                       TeamId = Ferrari,
                                       CarNumber = 8,
                                       Championships = 2,
                                       Races = 152,
                                       Wins = 23,
                                       Podiums = 58,
                                       Poles = 18,
                                       FastestLaps = 15
                                   },
                               new TestDriver
                                   {
                                       Name = "Giancarlo Fisichella",
                                       TeamId = Ferrari,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 231,
                                       Wins = 3,
                                       Podiums = 19,
                                       Poles = 4,
                                       FastestLaps = 2
                                   },
                               new TestDriver
                                   {
                                       Name = "Luca Badoer",
                                       TeamId = Ferrari,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 58,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Marc Gené",
                                       TeamId = Ferrari,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 36,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new Driver
                                   {
                                       Name = "Rubens Barrichello",
                                       TeamId = Williams,
                                       CarNumber = 9,
                                       Championships = 0,
                                       Races = 300,
                                       Wins = 11,
                                       Podiums = 68,
                                       Poles = 14,
                                       FastestLaps = 17
                                   },
                               new Driver
                                   {
                                       Name = "Nico Hülkenberg",
                                       TeamId = Williams,
                                       CarNumber = 10,
                                       Championships = 0,
                                       Races = 12,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Valtteri Bottas",
                                       TeamId = Williams,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new Driver
                                   {
                                       Name = "Robert Kubica",
                                       TeamId = Renault,
                                       CarNumber = 11,
                                       Championships = 0,
                                       Races = 69,
                                       Wins = 1,
                                       Podiums = 11,
                                       Poles = 1,
                                       FastestLaps = 1
                                   },
                               new Driver
                                   {
                                       Name = "Vitaly Petrov",
                                       TeamId = Renault,
                                       CarNumber = 12,
                                       Championships = 0,
                                       Races = 12,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 1
                                   },
                               new TestDriver
                                   {
                                       Name = "Ho-Pin Tung",
                                       TeamId = Renault,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Jérôme d'Ambrosio",
                                       TeamId = Renault,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Jan Charouz",
                                       TeamId = Renault,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new Driver
                                   {
                                       Name = "Adrian Sutil",
                                       TeamId = ForceIndia,
                                       CarNumber = 14,
                                       Championships = 0,
                                       Races = 64,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 1
                                   },
                               new Driver
                                   {
                                       Name = "Vitantonio Liuzzi",
                                       TeamId = ForceIndia,
                                       CarNumber = 15,
                                       Championships = 0,
                                       Races = 56,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Paul di Resta",
                                       TeamId = ForceIndia,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new Driver
                                   {
                                       Name = "Sébastien Buemi",
                                       TeamId = ToroRosso,
                                       CarNumber = 16,
                                       Championships = 0,
                                       Races = 29,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new Driver
                                   {
                                       Name = "Jaime Alguersuari",
                                       TeamId = ToroRosso,
                                       CarNumber = 17,
                                       Championships = 0,
                                       Races = 20,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Brendon Hartley",
                                       TeamId = ToroRosso,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Daniel Ricciardo",
                                       TeamId = ToroRosso,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new Driver
                                   {
                                       Name = "Jarno Trulli",
                                       TeamId = Lotus,
                                       CarNumber = 18,
                                       Championships = 0,
                                       Races = 231,
                                       Wins = 1,
                                       Podiums = 11,
                                       Poles = 4,
                                       FastestLaps = 1
                                   },
                               new Driver
                                   {
                                       Name = "Heikki Kovalainen",
                                       TeamId = Lotus,
                                       CarNumber = 19,
                                       Championships = 0,
                                       Races = 64,
                                       Wins = 1,
                                       Podiums = 4,
                                       Poles = 1,
                                       FastestLaps = 2
                                   },
                               new TestDriver
                                   {
                                       Name = "Fairuz Fauzy",
                                       TeamId = Lotus,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new Driver
                                   {
                                       Name = "Karun Chandhok",
                                       TeamId = Hispania,
                                       CarNumber = 20,
                                       Championships = 0,
                                       Races = 10,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new Driver
                                   {
                                       Name = "Bruno Senna",
                                       TeamId = Hispania,
                                       CarNumber = 21,
                                       Championships = 0,
                                       Races = 11,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Christian Klien",
                                       TeamId = Hispania,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 48,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Sakon Yamamoto",
                                       TeamId = Hispania,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 17,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new Driver
                                   {
                                       Name = "Timo Glock",
                                       TeamId = Virgin,
                                       CarNumber = 24,
                                       Championships = 0,
                                       Races = 48,
                                       Wins = 0,
                                       Podiums = 3,
                                       Poles = 0,
                                       FastestLaps = 1
                                   },
                               new Driver
                                   {
                                       Name = "Lucas di Grassi",
                                       TeamId = Virgin,
                                       CarNumber = 25,
                                       Championships = 0,
                                       Races = 12,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Andy Soucek",
                                       TeamId = Virgin,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   },
                               new TestDriver
                                   {
                                       Name = "Luiz Razia",
                                       TeamId = Virgin,
                                       CarNumber = null,
                                       Championships = 0,
                                       Races = 0,
                                       Wins = 0,
                                       Podiums = 0,
                                       Poles = 0,
                                       FastestLaps = 0
                                   }
                           }.AsQueryable();

            var teamList = new List<Team>
                               {
                                   new Team
                                       {
                                           Id = McLaren,
                                           Name = "Vodafone McLaren Mercedes",
                                           Constructor = "McLaren",
                                           Tire = "Bridgestone",
                                           Principal = "Martin Whitmarsh",
                                           ConstructorsChampionships = 8,
                                           DriversChampionships = 12,
                                           Races = 678,
                                           Victories = 168,
                                           Poles = 146,
                                           FastestLaps = 140
                                       },
                                   new Team
                                       {
                                           Id = Mercedes,
                                           Name = "Mercedes GP Petronas F1 Team",
                                           Constructor = "Mercedes",
                                           Tire = "Bridgestone",
                                           Principal = "Ross Brawn",
                                           ConstructorsChampionships = 0,
                                           DriversChampionships = 2,
                                           Races = 24,
                                           Victories = 9,
                                           Poles = 8,
                                           FastestLaps = 9
                                       },
                                   new Team
                                       {
                                           Id = RedBull,
                                           Name = "Red Bull Racing",
                                           Constructor = "Red Bull",
                                           Tire = "Bridgestone",
                                           Principal = "Christian Horner",
                                           ConstructorsChampionships = 0,
                                           DriversChampionships = 0,
                                           Races = 101,
                                           Victories = 12,
                                           Poles = 16,
                                           FastestLaps = 11
                                       },
                                   new Team
                                       {
                                           Id = Ferrari,
                                           Name = "Scuderia Ferrari Marlboro",
                                           Constructor = "Ferrari",
                                           Tire = "Bridgestone",
                                           Principal = "Stefano Domenicali",
                                           ConstructorsChampionships = 16,
                                           DriversChampionships = 15,
                                           Races = 805,
                                           Victories = 212,
                                           Poles = 203,
                                           FastestLaps = 221
                                       },
                                   new Team
                                       {
                                           Id = Williams,
                                           Name = "AT&T Williams",
                                           Constructor = "Williams",
                                           Tire = "Bridgestone",
                                           Principal = "Frank Williams/Patrick Head",
                                           ConstructorsChampionships = 9,
                                           DriversChampionships = 7,
                                           Races = 532,
                                           Victories = 113,
                                           Poles = 125,
                                           FastestLaps = 130
                                       },
                                   new Team
                                       {
                                           Id = Renault,
                                           Name = "Renault F1 Team",
                                           Constructor = "Renault",
                                           Tire = "Bridgestone",
                                           Principal = "Eric Boullier",
                                           ConstructorsChampionships = 2,
                                           DriversChampionships = 2,
                                           Races = 278,
                                           Victories = 35,
                                           Poles = 51,
                                           FastestLaps = 31
                                       },
                                   new Team
                                       {
                                           Id = ForceIndia,
                                           Name = "Force India F1 Team",
                                           Constructor = "Force India",
                                           Tire = "Bridgestone",
                                           Principal = "Vijay Mallya",
                                           ConstructorsChampionships = 0,
                                           DriversChampionships = 0,
                                           Races = 47,
                                           Victories = 0,
                                           Poles = 1,
                                           FastestLaps = 1
                                       },
                                   new Team
                                       {
                                           Id = ToroRosso,
                                           Name = "Scuderia Toro Rosso",
                                           Constructor = "Toro Rosso",
                                           Tire = "Bridgestone",
                                           Principal = "Franz Tost",
                                           ConstructorsChampionships = 0,
                                           DriversChampionships = 0,
                                           Races = 82,
                                           Victories = 1,
                                           Poles = 1,
                                           FastestLaps = 0
                                       },
                                   new Team
                                       {
                                           Id = Lotus,
                                           Name = "Lotus Racing",
                                           Constructor = "Lotus",
                                           Tire = "Bridgestone",
                                           Principal = "Tony Fernandes",
                                           ConstructorsChampionships = 7,
                                           DriversChampionships = 6,
                                           Races = 503,
                                           Victories = 73,
                                           Poles = 102,
                                           FastestLaps = 65
                                       },
                                   new Team
                                       {
                                           Id = Hispania,
                                           Name = "Hispania Racing F1 Team (HRT)",
                                           Constructor = "HRT",
                                           Tire = "Bridgestone",
                                           Principal = "Colin Kolles",
                                           ConstructorsChampionships = 0,
                                           DriversChampionships = 0,
                                           Races = 12,
                                           Victories = 0,
                                           Poles = 0,
                                           FastestLaps = 0
                                       },
                                   new Team
                                       {
                                           Id = Sauber,
                                           Name = "BMW Sauber F1 Team",
                                           Constructor = "Sauber",
                                           Tire = "Bridgestone",
                                           Principal = "Peter Sauber",
                                           ConstructorsChampionships = 0,
                                           DriversChampionships = 0,
                                           Races = 288,
                                           Victories = 1,
                                           Poles = 1,
                                           FastestLaps = 2
                                       },
                                   new Team
                                       {
                                           Id = Virgin,
                                           Name = "Virgin Racing",
                                           Constructor = "Virgin",
                                           Tire = "Bridgestone",
                                           Principal = "John Booth",
                                           ConstructorsChampionships = 0,
                                           DriversChampionships = 0,
                                           Races = 12,
                                           Victories = 0,
                                           Poles = 0,
                                           FastestLaps = 0
                                       }
                               };

            teamList.ForEach(t => t.AddDrivers(_drivers.Where(d => d.TeamId == t.Id).ToList()));

            Teams = teamList.AsQueryable();
        }

        private const int McLaren = 1;
        private const int Mercedes = 2;
        private const int RedBull = 3;
        private const int Ferrari = 4;
        private const int Williams = 5;
        private const int Renault = 6;
        private const int ForceIndia = 7;
        private const int ToroRosso = 8;
        private const int Lotus = 9;
        private const int Hispania = 10;
        private const int Sauber = 11;
        private const int Virgin = 12;
    }
}