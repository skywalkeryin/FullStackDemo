using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMS.Models;
using OMS.Models.Models;

namespace OMS.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new ClientID())
            {
                Student stud = new Student() { StudentName = "New Student2" };
                client.Students.Add(stud);
                client.SaveChanges();
                Console.ReadKey();
               
            }
        }
    }
}
