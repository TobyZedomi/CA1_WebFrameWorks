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

         
            List<User> users = new List<User>();   

            users.Add(new User("Toby","toby@gmail.com","abc",1));
            users.Add(new User("George", "george@gmail.com", "abc", 2));
            users.Add(new User("Sean", "sean@gmail.com", "abc", 1));
            
            Boolean result2 = false;

            
            while (!result2)
            {

                Console.WriteLine("Enter Login to login and register to register");
                string login = Console.ReadLine();


                if (login.Equals("Register", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Enter name: ");
                    string nameUser = Console.ReadLine();

                    Console.WriteLine("Enter email: ");
                    string emailOfUser = Console.ReadLine();

                    Console.WriteLine("Enter password: ");
                    string passwordForUser = Console.ReadLine();

                    Console.WriteLine("Enter userId: ");
                    int userId = Convert.ToInt32(Console.ReadLine());

                    users.Add(new User(nameUser, emailOfUser, passwordForUser, userId));

                    result2 = false;

                }
                else if (login.Equals("Login", StringComparison.InvariantCultureIgnoreCase))
                {
                    Boolean repeat3 = false;

                    while (!repeat3)
                    {

                        Console.WriteLine("Enter the name of the user: ");
                        string nameOfUser = Console.ReadLine();

                        Console.WriteLine("Enter the password: ");
                        string passwordUser = Console.ReadLine();


                        
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].Name.Equals(nameOfUser, StringComparison.InvariantCultureIgnoreCase) && users[i].Password.Equals(passwordUser))
                            {
                                Console.WriteLine("Login was successful");
                                repeat3 = true;
                            }
                            else
                            {
                               
                            }
                        }
                        
                    }

                    result2 = true;
                }
            }
            

            EventSchedule comp = new EventSchedule();

           

            comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", DateTime.Now, "Royal Ascot", "Ireland", 5, "25 miles", DateTime.Now, 50, getHorse("horseFileEndure.txt")));
            comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", DateTime.Now, "Dubai World Cup", "Dubai", 7, "8 miles", DateTime.Now, 100, getHorse("horseFileEndure.txt")));
            comp.addEvent(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", DateTime.Now, "Grand National", "England", 3, "40 miles", DateTime.Now, 300, getHorse("horseFileEndure.txt")));

            comp.addEvent(new HarnessRacing("Race Bikes", "Trot", "Dubai World Cup", "Dubai", 5, "1.5 miles", DateTime.Now, 70, getHorse("horseFileHarness.txt")));
            comp.addEvent(new HarnessRacing("Jog Carts", "Walk", "Royal Ascot", "Ireland", 10, "1.5 miles", DateTime.Now, 30, getHorse("horseFileHarness.txt")));
            comp.addEvent(new HarnessRacing("Speed Carts", "Gallop", "Grand National", "England", 4, "1 mile", DateTime.Now, 50, getHorse("horseFileHarness.txt")));

            comp.addEvent(new JumpRacing("High Hurdle", "Hurdle", 0.5, "Dubai World Cup", "Dubai", 15, "2.5 miles", DateTime.Now, 40, getHorse("horseFileJump.txt")));
            comp.addEvent(new JumpRacing("Drop Fence", "Fence", 3, "Royal Ascot", "Ireland", 3, "4 miles", DateTime.Now, 55, getHorse("horseFileJump.txt")));
            comp.addEvent(new JumpRacing("Standard Water Jump", "Water", 1, "Grand National", "England", 6, "3.5 miles", DateTime.Now, 120, getHorse("horseFileJump.txt")));

            int num = 0;

            Boolean result = false;

            while (!result)
            {
                string[] array = new string[7];

                array[0] = "1. Get All Events";
                array[1] = "2. Get All Events From Event Name";
                array[2] = "3. Get All Horses From Event Name for particular Race";
                array[3] = "4. Get All Races From Race Name";
                array[4] = "5. Add a horse to the list";
                array[5] = "6. Add an event for a race";
                array[6] = "7. To Exit";
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

                            if (raceName1.Equals("Endurance Racing", StringComparison.InvariantCultureIgnoreCase))
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
                            else if (raceName1.Equals("Harness Racing", StringComparison.InvariantCultureIgnoreCase))
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
                            else if (raceName1.Equals("Jump Racing", StringComparison.InvariantCultureIgnoreCase))
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
                        

                        Boolean repeat6 = false;

                        while (!repeat6)
                        {

                            Console.WriteLine("Enter which race you want to attend: ");
                            string race = Console.ReadLine();

                            if (race.Equals("Endurance Racing", StringComparison.InvariantCultureIgnoreCase))
                            {
                                List<Event> events11 = comp.getRacesFromEvent(typeof(EnduranceRacing));

                                foreach (Event e in events11)
                                {
                                    Console.WriteLine(e);
                                }

                                repeat6 = true;
                            }
                            else if (race.Equals("Jump Racing", StringComparison.InvariantCultureIgnoreCase))
                            {
                                List<Event> events11 = comp.getRacesFromEvent(typeof(JumpRacing));

                                foreach (Event e in events11)
                                {
                                    Console.WriteLine(e);
                                }
                                repeat6 = true;
                            }
                            else if (race.Equals("Harness Racing", StringComparison.InvariantCultureIgnoreCase))
                            {
                                List<Event> events11 = comp.getRacesFromEvent(typeof(HarnessRacing));

                                foreach (Event e in events11)
                                {
                                    Console.WriteLine(e);
                                }
                                repeat6 = true;
                            }
                            else
                            {
                                Console.Write("The only races available are Endurace, Jumping and Harness Racing, Enter Again please");
                                repeat6 = false;
                            }

                        }
                        Console.WriteLine();

                        break;

                    case 5:

                       

                        Boolean repeat = false;

                        while (!repeat)
                        {

                           

                            Console.WriteLine("Enter which race you want the horse to be added to: Endurance Racing, Harness Racing or Jump Racing ");
                            string race = Console.ReadLine();
                            
                                if (race.Equals("Endurance Racing", StringComparison.InvariantCultureIgnoreCase))
                                {

                                    writeHorse("horseFileEndure.txt");
                                    repeat = true;
                                }
                                else if (race.Equals("Jump Racing", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    writeHorse("horseFileJump.txt");
                                    repeat = true;
                                }
                                else if (race.Equals("Harness Racing", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    writeHorse("horseFileHarness.txt");
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

                        Boolean repeat4 = false;

                        while (!repeat4)
                        {



                            Console.WriteLine("Enter which race you want the horse to be added to ");
                            string race = Console.ReadLine();

                            if (race.Equals("Endurance Racing", StringComparison.InvariantCultureIgnoreCase))
                            {

                                Boolean repeat9 = false;
                                while (!repeat9)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter raceGroup: ");
                                        string group = Console.ReadLine();

                                        Console.WriteLine("Enter true if passed fitness test or false if not: ");
                                        Boolean pass = Console.ReadLine() == "true";

                                        Console.WriteLine("Enter obstacle: ");
                                        string obstacle = Console.ReadLine();

                                        Console.WriteLine("Enter month for timeOfCompletion: ");
                                        int month1 = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter a day for timeOfCompletion: ");
                                        int day1 = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter a year for timeOfCompletion: ");
                                        int year1 = int.Parse(Console.ReadLine());

                                        DateTime completeTime = new DateTime(year1, month1, day1);

                                        Console.WriteLine("Enter name of event: ");
                                        string eventName = Console.ReadLine();

                                        Console.WriteLine("Eneter location of event: ");
                                        string location = Console.ReadLine();

                                        Console.WriteLine("Enter number of races: ");
                                        double numOfRaces = Convert.ToDouble(Console.ReadLine());

                                        Console.WriteLine("Enter distance in miles: ");
                                        string distance = Console.ReadLine();

                                        Console.WriteLine("Enter month for startTime: ");
                                        int month = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter a day for startTime: ");
                                        int day = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter a year for startTime: ");
                                        int year = int.Parse(Console.ReadLine());

                                        DateTime startTime = new DateTime(year, month, day);

                                        Console.WriteLine("Eneter winning prize for bets: ");
                                        double prize = Convert.ToDouble(Console.ReadLine());

                                        comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, pass, obstacle, completeTime, eventName, location, numOfRaces, distance, startTime, prize, getHorse("horseFileEndure.txt")));
                                        repeat9 = true;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.Write("Enter numbers only for prize");
                                        Console.WriteLine("");
                                        repeat9 = false;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Wrong format for completeTime or startTime. dd/mm/yyyy ");
                                        Console.WriteLine("");
                                        repeat9 = false;
                                    }
                                }
                                repeat4 = true;
                            }
                            else if (race.Equals("Jump Racing", StringComparison.InvariantCultureIgnoreCase))
                            {
                                Boolean repeat9 = false;

                                while (!repeat9)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enetr type of jump: ");
                                        string typeJump = Console.ReadLine();

                                        Console.WriteLine("Eneter obstacle: ");
                                        string obstacle = Console.ReadLine();

                                        Console.WriteLine("Enter obstacle height: ");
                                        double height = Convert.ToDouble(Console.ReadLine());

                                        Console.WriteLine("Enter name of event: ");
                                        string eventName = Console.ReadLine();

                                        Console.WriteLine("Eneter location of event: ");
                                        string location = Console.ReadLine();

                                        Console.WriteLine("Enter number of races: ");
                                        double numOfRaces = Convert.ToDouble(Console.ReadLine());

                                        Console.WriteLine("Enter distance in miles: ");
                                        string distance = Console.ReadLine();

                                        Console.WriteLine("Enter month for startTime: ");
                                        int month = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter a day for startTime: ");
                                        int day = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter a year for startTime: ");
                                        int year = int.Parse(Console.ReadLine());

                                        DateTime startTime = new DateTime(year, month, day);

                                        Console.WriteLine("Enter winning prize for bets: ");
                                        double prize = Convert.ToDouble(Console.ReadLine());


                                        comp.addEvent(new JumpRacing(typeJump, obstacle, height, eventName, location, numOfRaces, distance, startTime, prize, getHorse("horseFileHarness.txt")));
                                        repeat9 = true;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.Write("Enter numbers only for height and prize");
                                        Console.WriteLine("");
                                        repeat9 = false;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.Write("Wrong format for startTime. dd/mm/yyyy ");
                                        Console.WriteLine("");
                                        repeat9 = false;
                                    }

                                }

                                repeat4 = true;
                            }
                            else if (race.Equals("Harness Racing", StringComparison.InvariantCultureIgnoreCase))
                            {

                                Boolean repeat9 = false;

                                while (!repeat9)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter sulky type: ");
                                        string sulky = Console.ReadLine();

                                        Console.WriteLine("Enter gait type: ");
                                        string gait = Console.ReadLine();

                                        Console.WriteLine("Enter name of event: ");
                                        string eventName = Console.ReadLine();

                                        Console.WriteLine("Eneter location of event: ");
                                        string location = Console.ReadLine();

                                        Console.WriteLine("Enter number of races: ");
                                        double numOfRaces = Convert.ToDouble(Console.ReadLine());

                                        Console.WriteLine("Enter distance in miles: ");
                                        string distance = Console.ReadLine();

                                        Console.WriteLine("Enter month for startTime: ");
                                        int month = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter a day for startTime: ");
                                        int day = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Enter a year for startTime: ");
                                        int year = int.Parse(Console.ReadLine());

                                        DateTime startTime = new DateTime(year,month,day);

                                        Console.WriteLine("Enter winning prize for bets: ");
                                        double prize = Convert.ToDouble(Console.ReadLine());


                                        comp.addEvent(new HarnessRacing(sulky, gait, eventName, location, numOfRaces, distance, startTime, prize, getHorse("horseFileJump.txt")));
                                        repeat9 = true;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.Write("Enter numbers only for the number of races and prize");
                                        Console.WriteLine("");
                                        repeat9 = false;
                                    }catch (Exception e)
                                    {
                                        Console.Write("Wrong format for startTime. dd/mm/yyyy ");
                                        Console.WriteLine("");
                                        repeat9 = false;
                                    }

                                }

                               
                                repeat4 = true;
                            }
                            else
                            {
                                Console.Write("The only races available are Endurace, Jumping and Harness Racing, Enter Again please");
                                repeat4 = false;
                            }

                        }



                        break;
                        case 7:

                        result = true;
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
            

            Boolean repeat12 = false;

            while (!repeat12)
            {
                try
                {
                    Console.WriteLine("Enter horse name");
                    string name = Console.ReadLine();


                    Console.WriteLine("Enter month: ");
                    int month = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter a day: ");
                    int day = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter a year: ");
                    int year = int.Parse(Console.ReadLine());

                    DateTime birth = new DateTime(year, month, day);
                    

                    write.WriteLine(name + " " + birth);
                    write.Close();

                    repeat12 = true;
                }
                catch (Exception e)
                {
                    Console.Write("Wrong format for startTime. dd/mm/yyyy ");
                    Console.WriteLine("");
                    repeat12 = false;
                }
            }

          

        }


    }
}

