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
        private static int idCount = 1000;


        // Parameterized Constructor

        public Horse(string name, DateTime dateOfBirth)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;

            horseID = idCount;
            idCount++;
        }

        // Deafult Constuctor

        public Horse()
        {
            this.name = "Toby";
            this.dateOfBirth = new DateTime(2003, 4, 5);

            horseID = idCount;
            idCount++;
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
