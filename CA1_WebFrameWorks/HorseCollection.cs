using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_WebFrameWorks
{
    public class HorseCollection
    {
        private List<Horse> horses;

        public HorseCollection(List<Horse> horses)
        {
            this.horses = horses;
        }

        public HorseCollection() {

        horses = new List<Horse>();
        
        }


        // read from file

        public void add()
        {
            //StreamReader sr = new StreamReader(@"C:\Users\tobyz\source\repos\CA1_WebFrameWorks\CA1_WebFrameWorks\horseFile.txt");

            string filePath = @"C:\Users\tobyz\source\repos\CA1_WebFrameWorks\CA1_WebFrameWorks\horseFile.txt";

           List<string> list = new List<string>();
            List<Horse> h1 = new List<Horse>();

            list = File.ReadAllLines(filePath).ToList();

            foreach (string line in list)
            {

                string[] horses = line.Split(' ');
                Horse horse = new Horse(horses[0], DateTime.Parse(horses[1]) );
                h1.Add(horse);
            }

            foreach(Horse h in h1)
            {
                Console.WriteLine(h);
            }
            
           
        }


    }
}
