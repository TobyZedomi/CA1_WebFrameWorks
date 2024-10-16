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

          //  writeHorse("horseFile.txt");

            
        /*
            List<Horse> horse1 = new List<Horse>();
            horse1.Add(new Horse("Horse1",DateTime.Now));

            List<Horse> horse2 = new List<Horse>();
            horse2.Add(new Horse("Horse2", DateTime.Now));

            List<Horse> horse3 = new List<Horse>();
            horse3.Add(new Horse("Horse3", DateTime.Now));
        */


            EventSchedule comp = new EventSchedule();

           

            comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", DateTime.Now, getHorse("horseFileEndure.txt"), "Royal Ascot", "Ireland", 5, 25, DateTime.Now, 50));
            comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", DateTime.Now, getHorse("horseFileEndure.txt"), "Dubai World Cup", "Dubai", 7, 8, DateTime.Now, 100));
            comp.addEvent(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", DateTime.Now, getHorse("horseFileEndure.txt"), "Grand National", "England", 3, 40, DateTime.Now, 300));

            comp.addEvent(new HarnessRacing("Race Bikes", "Trot", getHorse("horseFileHarness.txt"), "Dubai World Cup", "Dubai", 5, 1.5, DateTime.Now, 70));
            comp.addEvent(new HarnessRacing("Jog Carts", "Walk", getHorse("horseFileHarness.txt"), "Royal Ascot", "Ireland", 10, 1.5, DateTime.Now, 30));
            comp.addEvent(new HarnessRacing("Speed Carts", "Gallop", getHorse("horseFileHarness.txt"), "Grand National", "England", 4, 1, DateTime.Now, 50));

            comp.addEvent(new JumpRacing("High Hurdle", "Hurdle", 0.5, getHorse("horseFileJump.txt"), "Dubai World Cup", "Dubai", 15, 2.5, DateTime.Now, 40));
            comp.addEvent(new JumpRacing("Drop Fence", "Fence", 3, getHorse("horseFileJump.txt"), "Royal Ascot", "Ireland", 3, 4, DateTime.Now, 55));
            comp.addEvent(new JumpRacing("Standard Water Jump", "Water", 1, getHorse("horseFileJump.txt"), "Grand National", "England", 6, 3.5, DateTime.Now, 120));

            int num = 0;

            Boolean result = false;

            while (!result)
            {
                string[] array = new string[6];

                array[0] = "1. Get All Events";
                array[1] = "2. Get All Events From Name";
                array[2] = "3. Get All Horses From Event Name for particular Race";
                array[3] = "4. Get All Races From Race Name";
                array[4] = "5. Add a horse to the list";
                array[5] = "6. To Exit";
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
                            else if (raceName1.Equals("Jump Racing"))
                            {


                                Console.WriteLine("Enter Event Name: ");
                                string eventName = Console.ReadLine();

                                List<Horse> horse = comp.getHorseFromEventNameInJumpRacing(eventName);

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

                       

                        Boolean repeat = false;

                        while (!repeat)
                        {

                            Console.WriteLine("Enter horse file: ");
                            string horseFile = Console.ReadLine();

                            Console.WriteLine("Enter which race you want the horse to be added to ");
                            string race = Console.ReadLine();
                            
                                if (race.Equals("Endurance Racing"))
                                {
                                    writeHorse(horseFile);
                                    repeat = true;
                                }
                                else if (race.Equals("Jump Racing"))
                                {
                                    writeHorse(horseFile);
                                    repeat = true;
                                }
                                else if (race.Equals("Harness Racing"))
                                {
                                    writeHorse(horseFile);
                                    repeat = true;
                                }
                                else
                                {
                                    Console.Write("The only races available are Endurace, Jumping and Harness Racing, Enter Again please");
                                    repeat = false;
                                }
                            
                        }
                        
                        break;
                    case 6:
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

        // add Horse
        public static void writeHorse(string fileName)
        {
            //StreamReader sr = new StreamReader(@"C:\Users\tobyz\source\repos\CA1_WebFrameWorks\CA1_WebFrameWorks\horseFile.txt");

            string filePath = @"C:\Users\tobyz\source\repos\CA1_WebFrameWorks\CA1_WebFrameWorks\" + fileName;

            StreamWriter write = File.AppendText(filePath);
           // List<string> list = new List<string>();
           // List<Horse> h1 = new List<Horse>();

                Console.WriteLine("Enter horse name");
                string name = Console.ReadLine();


                Console.WriteLine("Enter month: ");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a day: ");
                int day = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a year: ");
                int year = int.Parse(Console.ReadLine());

                DateTime birth = new DateTime(year, month, day);

            //Horse horse = new Horse(name, birth);
            //    h1.Add(horse);

          

            write.WriteLine(name + " " +birth);
                write.Close();
        }


    }
}

