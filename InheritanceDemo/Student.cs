using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Student
    {
        int rn;
        string name;
        string address;
        public void GetDetails()
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter address");
            address = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Rn is {rn}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Address is {address}");
        }
        public Student() { }
        public Student(int rn, string name, string address)
        {
            this.rn = rn;
            this.name = name;
            this.address = address;
        }
    }
}