using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class FullTimeStudent : Student
    {
        string batch;
        string course;
            public void GetDetails()
        //public void GetPartTimeStudentDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter batch");
            batch = Console.ReadLine();
            Console.WriteLine("enter duration");
            course = Console.ReadLine();
        }
        public void DisplayDetails()
        //public void DisplayPartTimeStudentDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"batch is {batch}");
            Console.WriteLine($"course is {course}");
        }

        public FullTimeStudent() : base() { }

        public FullTimeStudent(int rn, string name, string address, string batch, string course)
        : base(rn, name, address)
        
            {
                this.batch = batch;
                this.course = course;
            }
        
    }
}
