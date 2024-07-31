using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class PartTimeStudent : Student
    {
        string slot;
        string duration;
            public override void GetDetails()
        //public void GetPartTimeStudentDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter slot");
            slot = Console.ReadLine();
            Console.WriteLine("enter duration");
            duration = Console.ReadLine();
        }
        public  override void DisplayDetails()
        //public void DisplayPartTimeStudentDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Slot is {slot}");
            Console.WriteLine($"Duration is {duration}");
        }

        public PartTimeStudent() : base() { }

        public PartTimeStudent(int rn, string name, string address, string slot, string duration)
        : base(rn, name, address)
        
            {
                this.slot = slot;
                this.duration = duration;
            }
        
    }
}
