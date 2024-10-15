using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_WebFrameWorks
{
    public abstract class Event
    {
        private string name;
        private string location;
        private double numberOfRaces;
        private double distance;
        private DateTime startTime;
        private double winningBetPrice;

        public Event(string name, string location, double numberOfRaces, double distance, DateTime startTime, double winningBetPrice)
        {
            this.name = name;
            this.location = location;
            this.numberOfRaces = numberOfRaces;
            this.distance = distance;
            this.startTime = startTime;
            this.winningBetPrice = winningBetPrice;
        }

        public Event()
        {
            name = "World Championship";
            location = "Ireland";
            numberOfRaces = 5;
            distance = 5;
            startTime = new DateTime(2023, 12, 3);
            winningBetPrice = 40;
        }


        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public double NumberOfRaces { get => numberOfRaces; set => numberOfRaces = value; }
        public double Distance { get => distance; set => distance = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public double WinningBetPrice { get => winningBetPrice; set => winningBetPrice = value; }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Location)}={Location}, {nameof(NumberOfRaces)}={NumberOfRaces.ToString()}, {nameof(Distance)}={Distance.ToString()}, {nameof(StartTime)}={StartTime.ToString()}, {nameof(WinningBetPrice)}={WinningBetPrice.ToString()}}}";
        }
    }
}
