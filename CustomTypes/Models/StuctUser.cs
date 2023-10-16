using CustomTypes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes.Models
{
    public struct StuctUser : IUser
    {
        public string Name;
        public int Age;

        public StuctUser(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void WriteMessage()
        {
            Console.WriteLine($"\nUser name: {Name}\nUser age: {Age}");
        }
    }
}
