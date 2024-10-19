using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_WebFrameWorks
{
    public class User
    {
        private string name;
        private string email;
        private string password;
        private int id;

        // parameterized constructor
        public User(string name, string email, string password, int id)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.id = id;
        }

        public User() 
        {
            this.name = "Randy";
            this.email = "randy@gmail.com";
            this.password = "123";
            this.id=1;
        }

        // getters and setters
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

        // toString
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Email)}={Email}, {nameof(Password)}={Password}, {nameof(Id)}={Id.ToString()}}}";
        }

        // equals and hash
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
