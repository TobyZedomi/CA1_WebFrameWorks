using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_WebFrameWorks
{
    public class EnduranceRacing : Event
    {

        public enum raceGroup
        {
            PleasureRides,
            NonCompetitiveTrailRides,
            CompetetiveTrailRides,
            ProgressiveTrailRides,
            EduranceRides
        }
        private raceGroup _raceGroup;
        private Boolean passFitnessTest;
        private string obstacle;
        private DateTime timeOfCompletion;
        

        // constructor
        public EnduranceRacing(raceGroup newRaceGroup, Boolean passFitnessTest, string obstacle, DateTime timeOfCompletion, string name, string location, double numberOfRaces, string distance, DateTime startTime, double winningBetPrice, List<Horse> horseList) : base(name, location, numberOfRaces, distance, startTime, winningBetPrice, horseList)
        {
            RaceGroup = newRaceGroup;
            this.passFitnessTest = passFitnessTest;
            this.obstacle = obstacle;
            this.timeOfCompletion = timeOfCompletion;
            
        }

        // default constructor
        public EnduranceRacing() : base()
        {
            RaceGroup = raceGroup.ProgressiveTrailRides;
            this.passFitnessTest = true;
            this.obstacle = "Hurdles";
            this.timeOfCompletion = new DateTime(0, 0, 0);
            
        }



        // getters and setters
        public raceGroup RaceGroup { get => _raceGroup; set => _raceGroup = value; }
        public bool PassFitnessTest { get => passFitnessTest; set => passFitnessTest = value; }
        public string Obstacle { get => obstacle; set => obstacle = value; }
        public DateTime TimeOfCompletion { get => timeOfCompletion; set => timeOfCompletion = value; }

        // toString
        public override string ToString()
        {
            return $"{{{nameof(RaceGroup)}={RaceGroup.ToString()}, {nameof(PassFitnessTest)}={PassFitnessTest.ToString()}, {nameof(Obstacle)}={Obstacle}, {nameof(TimeOfCompletion)}={TimeOfCompletion.ToString()}, {nameof(Name)}={Name}, {nameof(Location)}={Location}, {nameof(NumberOfRaces)}={NumberOfRaces.ToString()}, {nameof(Distance)}={Distance}, {nameof(StartTime)}={StartTime.ToString()}, {nameof(WinningBetPrice)}={WinningBetPrice.ToString()}, {nameof(HorseList)}={HorseList}}}";
        }


       

    }
}
