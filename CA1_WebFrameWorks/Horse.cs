using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_WebFrameWorks
{
    public class Horse
    {
        private string name;
        private DateTime dateOfBirth;
        private int horseID;
        private static List<int> idCount = new List<int>();


        // Parameterized Constructor

        public Horse(string name, DateTime dateOfBirth)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;

            Random rg = new Random();
            int num;
            do
            {
                num = (int)rg.NextInt64(0, int.MaxValue);
            } while (idCount.Contains(num));
            this.horseID = num;
            idCount.Add(num);
        }

        // Deafult Constuctor

        public Horse()
        {
            this.name = "Toby";
            this.dateOfBirth = new DateTime(2003, 4, 5);

            Random rg = new Random();
            int num;
            do
            {
                num = (int)rg.NextInt64(0, int.MaxValue);
            } while (idCount.Contains(num));
            this.horseID = num;
            idCount.Add(num);
        }

        // getters and setters
        public string Name { get => name; set => name = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int HorseID { get => horseID; set => horseID = value; }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(DateOfBirth)}={DateOfBirth.ToString()}, {nameof(HorseID)}={HorseID.ToString()}";
        }
    }
}
