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
        

        // parametrized constructor

        public JumpRacing(string typeOfJump, string obstacle, double obstacleHeight, string name, string location, double numberOfRaces, string distance, DateTime startTime, double priceWin, List<Horse> horseList) : base(name, location, numberOfRaces, distance, startTime, priceWin, horseList)
        {
            this.typeOfJump = typeOfJump;
            this.obstacle = obstacle;
            this.obstacleHeight = obstacleHeight;
            
        }

        // default constructor

        public JumpRacing() : base()
        {
            this.typeOfJump = "Steeplechase";
            this.obstacle = "Water Jumps";
            this.obstacleHeight = 5;
           
        }

        public string TypeOfJump { get => typeOfJump; set => typeOfJump = value; }
        public string Obstacle { get => obstacle; set => obstacle = value; }
        public double ObstacleHeight { get => obstacleHeight; set => obstacleHeight = value; }


        public override double calcWinningPrice()
        {
            return this.WinningBetPrice * 4;
        }
        public override string ToString()
        {
            return $"{{{nameof(TypeOfJump)}={TypeOfJump}, {nameof(Obstacle)}={Obstacle}, {nameof(ObstacleHeight)}={ObstacleHeight.ToString()}, {nameof(Name)}={Name}, {nameof(Location)}={Location}, {nameof(NumberOfRaces)}={NumberOfRaces.ToString()}, {nameof(Distance)}={Distance}, {nameof(StartTime)}={StartTime.ToString()}, {nameof(WinningBetPrice)}={WinningBetPrice.ToString()}, {nameof(HorseList)}={HorseList}}}";
        }
    }
}
