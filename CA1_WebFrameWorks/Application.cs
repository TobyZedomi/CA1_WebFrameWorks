using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CA1_WebFrameWorks.EnduranceRacing;

namespace CA1_WebFrameWorks
{
    public class Application
    {

        static void Main(string[] args)
        { 

          //  HorseCollection horse4 = new HorseCollection();
          //  horse4.add();

           
            
         //   Console.WriteLine("");


            
        
            List<Horse> horse1 = new List<Horse>();
            horse1.Add(new Horse("Horse1",DateTime.Now));

            List<Horse> horse2 = new List<Horse>();
            horse2.Add(new Horse("Horse2", DateTime.Now));

            List<Horse> horse3 = new List<Horse>();
            horse3.Add(new Horse("Horse3", DateTime.Now));


            EventSchedule comp = new EventSchedule();

           

            comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", DateTime.Now, horse1, "Royal Ascot", "Ireland", 5, 5, DateTime.Now, 5));
            comp.addEvent(new HarnessRacing("r", "five", getHorse("horseFile.txt"), "Dubai World Cup", "Ireland", 5, 5, DateTime.Now, 5));
            comp.addEvent(new JumpRacing("High", "Hurdle", 5, horse3, "Ebor Festival", "Ireland", 5, 5, DateTime.Now, 5));

            int num = 0;

            Boolean result = false;

            while (!result)
            {
                string[] array = new string[5];

                array[0] = "1. Get All Events";
                array[1] = "2. Get All Events From Name";
                array[2] = "3. Get All Horses From Event Name for particular Race";
                array[3] = "4. Get All Races From Race Name";
                array[4] = "5. To Exit";
                Console.WriteLine("");


                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }

                Console.WriteLine("Enter Number");
                num = Convert.ToInt32(Console.ReadLine());

                switch(num)
                {

                    case 1:

                        List<Event> events = comp.getAllEvents();

                        foreach(Event e in events){
                            Console.WriteLine(e);
                        }

                        break; 
                    
                    case 2:

                        Console.WriteLine("Enter name of Event: ");
                        string name = Console.ReadLine();

                        List<Event> events1 = comp.getRacesFromEventName(name);

                        foreach (Event e in events1)
                        {
                            Console.WriteLine(e);
                        }


                        break;

                    case 3:


                        Boolean result1 = false;

                        while (!result1)
                        {
                            

                            Console.WriteLine("Enter Race Name you want to attend: ");
                            string raceName1 = Console.ReadLine();

                            if (raceName1.Equals("Endurance Raing"))
                            {
                                Console.WriteLine("Enter Event Name: ");
                                string eventName2 = Console.ReadLine();

                                List<Horse> horse22 = comp.getHorseFromEventNameInEnduranceRacing(eventName2);

                                foreach (Horse h in horse22)
                                {
                                    Console.WriteLine(h);
                                }

                                result1 = true;

                            }
                            else if (raceName1.Equals("Harness Racing"))
                            {

                                Console.WriteLine("Enter Event Name: ");
                                string eventName1 = Console.ReadLine();

                                List<Horse> horse11 = comp.getHorseFromEventNameInHarnessRacing(eventName1);

                                foreach (Horse h in horse11)
                                {
                                    Console.WriteLine(h);
                                }
                                result1 = true;
                            }
                            else if (raceName1.Equals("Endurance Racing"))
                            {


                                Console.WriteLine("Enter Event Name: ");
                                string eventName = Console.ReadLine();

                                List<Horse> horse = comp.getHorseFromEventNameInEnduranceRacing(eventName);

                                foreach (Horse h in horse)
                                {
                                    Console.WriteLine(h);
                                }
                                result1 = true;
                            }
                            else
                            {
                                Console.WriteLine("The only races available are Endurace, Jumping and Harness Racing, Enter Again please ");
                                result1 = false;
                            }

                                    
                            }

                        break;

                    case 4:
                        Console.WriteLine("Enter race name: ");
                        Type raceName = comp.GetType();

                        List<Event> events11 = comp.getRacesFromEvent(raceName);

                        foreach (Event e in events11)
                        {
                            Console.WriteLine(e);
                        }
                        Console.WriteLine();

                        break;

                    case 5:
                        break;
                }


            }

            



        }

        // Refernece for this 
        public static List<Horse> getHorse(string fileName)
        {
            //StreamReader sr = new StreamReader(@"C:\Users\tobyz\source\repos\CA1_WebFrameWorks\CA1_WebFrameWorks\horseFile.txt");

            string filePath = @"C:\Users\tobyz\source\repos\CA1_WebFrameWorks\CA1_WebFrameWorks\" +fileName;

            List<string> list = new List<string>();
            List<Horse> h1 = new List<Horse>();

            list = File.ReadAllLines(filePath).ToList();

            foreach (string line in list)
            {

                string[] horses = line.Split(' ');
                Horse horse = new Horse(horses[0], DateTime.Parse(horses[1]));
                h1.Add(horse);
            }

            return h1;


        }

    }
}

