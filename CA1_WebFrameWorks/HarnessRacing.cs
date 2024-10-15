using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_WebFrameWorks
{
    public class HarnessRacing : Event
    {
        private string sulkyType;
        private string gaitType;
        private List<Horse> horseList;

        public HarnessRacing(string sulkyType, string gaitType, List<Horse> horseList, string name, string location, double numberOfRaces, double distance, DateTime startTime, double winningBetPrice) : base(name, location, numberOfRaces, distance, startTime, winningBetPrice)
        {
            this.sulkyType = sulkyType;
            this.gaitType = gaitType;
            this.horseList = horseList;
        }

        // default constructor

        public HarnessRacing()
        {
            this.sulkyType = "Standard Sulky";
            this.gaitType = "Pace";
            horseList = new List<Horse>();
        }


        public string SulkyType { get => sulkyType; set => sulkyType = value; }
        public string GaitType { get => gaitType; set => gaitType = value; }
        public List<Horse> HorseList { get => horseList; set => horseList = value; }

        public override string ToString()
        {
            return $"{{{nameof(SulkyType)}={SulkyType}, {nameof(GaitType)}={GaitType}, {nameof(HorseList)}={HorseList}, {nameof(Name)}={Name}, {nameof(Location)}={Location}, {nameof(NumberOfRaces)}={NumberOfRaces.ToString()}, {nameof(Distance)}={Distance.ToString()}, {nameof(StartTime)}={StartTime.ToString()}, {nameof(WinningBetPrice)}={WinningBetPrice.ToString()}}}";
        }
    }
}
