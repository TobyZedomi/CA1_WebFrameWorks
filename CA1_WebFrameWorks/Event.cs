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
        private string distance;
        private DateTime startTime;
        private double winningBetPrice;
        private List<Horse> horseList;

        public Event(string name, string location, double numberOfRaces, string distance, DateTime startTime, double winningBetPrice, List<Horse> horseList)
        {
            this.name = name;
            this.location = location;
            this.numberOfRaces = numberOfRaces;
            this.distance = distance;
            this.startTime = startTime;
            this.winningBetPrice = winningBetPrice;
            this.horseList = horseList;
        }

        public Event()
        {
            name = "World Championship";
            location = "Ireland";
            numberOfRaces = 5;
            distance = "50 metres";
            startTime = new DateTime(2023, 12, 3);
            winningBetPrice = 40;
            horseList = new List<Horse>();
        }


        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public double NumberOfRaces 
        { get => numberOfRaces; 
          
            private set
            {
                if (numberOfRaces <= 0)
                {
                    throw new ArithmeticException("Number of races cant be less than 0");
                }
                numberOfRaces = value;
            }
        
        }
        public string Distance { get => distance; set => distance = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public double WinningBetPrice 
        { get => winningBetPrice;
            private set
            {
                if (winningBetPrice <= 0)
                {
                    throw new ArithmeticException("Winning bet price cant be less than 0");
                }
                winningBetPrice = value;
            }
        }

        public List<Horse> HorseList { get => horseList; set => horseList = value; }

        public abstract double calcWinningPrice();

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Location)}={Location}, {nameof(NumberOfRaces)}={NumberOfRaces.ToString()}, {nameof(Distance)}={Distance.ToString()}, {nameof(StartTime)}={StartTime.ToString()}, {nameof(WinningBetPrice)}={WinningBetPrice.ToString()}}}";
        }

        
    }
}
