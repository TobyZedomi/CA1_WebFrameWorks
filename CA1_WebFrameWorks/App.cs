using static CA1_WebFrameWorks.EnduranceRacing;

namespace CA1_WebFrameWorks
{
    public class Program
    {
        static void Main(string[] args)
        {
                EventSchedule comp = new EventSchedule();

            List<Horse> horses = new List<Horse>();
            horses.Add(new Horse("Horse1",DateTime.Now));

            comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", DateTime.Now, horses, "Toby", "Ireland", 5, 5, DateTime.Now, 5));
            comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Water", DateTime.Now, horses, "John", "Ireland", 5, 5, DateTime.Now, 5));
            comp.addEvent(new HarnessRacing("r", "five", horses, "John", "Ireland", 5, 5, DateTime.Now, 5));
            comp.addEvent(new JumpRacing("High", "Hurdle", 5,horses, "John", "Ireland", 5, 5, DateTime.Now, 5));


            
            // get races from spefici event type

            List <Event> events = comp.getRacesFromEvent(typeof(JumpRacing));

            foreach (Event e in events)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            // get races from spefic event Name

            events = comp.getRacesFromEventName("Toby");

            foreach (Event e in events)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine() ;

            /// getHorses in jumpracing
            /// 

            List<Horse> horse = comp.getHorseFromEventNameInEnduranceRacing("Toby");

            foreach(Horse h in horse)
            {
                Console.WriteLine(h);
            }


        }
    }
}