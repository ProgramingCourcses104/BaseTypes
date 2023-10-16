using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTypes.Models
{
    public class ExtendedUser : User
    {
        DateTime CreateDate;

        public ExtendedUser() 
        { 
            CreateDate = DateTime.Now; 
        }

        public ExtendedUser(string name , int age, DateTime createDate) : base (name , age)
        {
            CreateDate = createDate;
        }

        public override void WriteMessage()
        {
            base.WriteMessage();
            Console.WriteLine($"Create date : {CreateDate}");
        }
    }
}
