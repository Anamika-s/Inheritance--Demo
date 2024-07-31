using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultilevelInheritance
{
    internal class Student
    {
        int rn;
        string name;
        string address;
        public   void GetDetails()
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter address");
            address = Console.ReadLine();
        }
        public   void DisplayDetails()
        {
            Console.WriteLine($"Rn is {rn}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Address is {address}");
        }

    }

    class Sports : Student
    {
        string sportsName;
        protected int score;
        public   void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter sportsName");
            sportsName = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());
        }
        public   void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"sportsName is {sportsName}");
           
            Console.WriteLine($"score is {score}");
        }


    }

    class Test : Sports
    { 
        int[] marks = [90,89,78,67, 78];
        protected int totalMarks;
        public void CalculateTotalMarks()
        {
            foreach (int mark in marks)
            {
                totalMarks += mark;
            }
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("totalMarks are " + totalMarks);
        }
    }

    class Result : Test
    {
        int totalScore;
        public void CalculateTotalScore()
        {
            totalScore = score + totalMarks; 

        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("totalScore are " + totalScore);
        }
    }


}
