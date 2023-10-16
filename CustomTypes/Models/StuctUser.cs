using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes.Models
{
    public struct StuctUser
    {
        public string Name;
        public int Age;

        public StuctUser(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
