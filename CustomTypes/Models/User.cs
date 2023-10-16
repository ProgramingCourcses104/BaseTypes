using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes.Models
{
    public class User
    {
        public string Name;
        public int Age;

        public User() { }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
