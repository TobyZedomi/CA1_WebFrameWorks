using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_WebFrameWorks
{
    public class HarnessRacing : Event, IEvent  
    {
        private string sulkyType;
        private string gaitType;
       

        public HarnessRacing(string sulkyType, string gaitType, string name, string location, double numberOfRaces, string distance, DateTime startDate, double winningBetPrice, List<Horse> horseList) : base(name, location, numberOfRaces, distance, startDate, winningBetPrice, horseList)
        {
            this.sulkyType = sulkyType;
            this.gaitType = gaitType;
           
        }

        // default constructor

        public HarnessRacing() : base()
        {
            this.sulkyType = "Standard Sulky";
            this.gaitType = "Pace";
            
        }


        public string SulkyType { get => sulkyType; set => sulkyType = value; }
        public string GaitType { get => gaitType; set => gaitType = value; }

        public override double calcWinningPrice()
        {
            return this.WinningBetPrice * 2;
        }

        public override string ToString()
        {
            return $"{{{nameof(SulkyType)}={SulkyType}, {nameof(GaitType)}={GaitType}, {nameof(Name)}={Name}, {nameof(Location)}={Location}, {nameof(NumberOfRaces)}={NumberOfRaces.ToString()}, {nameof(Distance)}={Distance}, {nameof(StartDate)}={StartDate.ToString()}, {nameof(WinningBetPrice)}={WinningBetPrice.ToString()}, {nameof(HorseList)}={HorseList}}}";
        }

        public double getStaduimCapacity()
        {
            double capacity = 1000000;

            return capacity;
        }
    }
}
