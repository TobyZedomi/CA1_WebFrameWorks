using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_WebFrameWorks
{
    public class JumpRacing : Event
    {

        private string typeOfJump;
        private string obstacle;
        private double obstacleHeight;
        private List<Horse> horseList;

        // parametrized constructor

        public JumpRacing(string typeOfJump, string obstacle, double obstacleHeight, List<Horse> horseList, string name, string location, double numberOfRaces, double distance, DateTime startTime, double priceWin) : base(name, location, numberOfRaces, distance, startTime, priceWin)
        {
            this.typeOfJump = typeOfJump;
            this.obstacle = obstacle;
            this.obstacleHeight = obstacleHeight;
            this.horseList = horseList;
        }

        // default constructor

        public JumpRacing() : base()
        {
            this.typeOfJump = "Steeplechase";
            this.obstacle = "Water Jumps";
            this.obstacleHeight = 5;
            horseList = new List<Horse>();
        }

        public string TypeOfJump { get => typeOfJump; set => typeOfJump = value; }
        public string Obstacle { get => obstacle; set => obstacle = value; }
        public double ObstacleHeight { get => obstacleHeight; set => obstacleHeight = value; }
        public List<Horse> HorseList { get => horseList; set => horseList = value; }

        public override string ToString()
        {
            return $"{{{nameof(TypeOfJump)}={TypeOfJump}, {nameof(Obstacle)}={Obstacle}, {nameof(ObstacleHeight)}={ObstacleHeight.ToString()}, {nameof(HorseList)}={HorseList}, {nameof(Name)}={Name}, {nameof(Location)}={Location}, {nameof(NumberOfRaces)}={NumberOfRaces.ToString()}, {nameof(Distance)}={Distance.ToString()}, {nameof(StartTime)}={StartTime.ToString()}, {nameof(WinningBetPrice)}={WinningBetPrice.ToString()}}}";
        }
    }
}
