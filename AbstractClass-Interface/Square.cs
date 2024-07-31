using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Interface
{
    internal class Square
    {   
        int side, area;
       public void GetDimensions()
        {
            Console.WriteLine("enter side ");
            side = byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = side * side;
        }
        public void DisplayArea()
        {
            Console.WriteLine("area is " + area);
        }
    }
    internal class Rectangle
    {
        int l,w, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter l ");
            l = byte.Parse(Console.ReadLine());

            Console.WriteLine("enter w ");
            w = byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = l * w;
        }
        public void DisplayArea()
        {
            Console.WriteLine("area is " + area);
        }
    }

    internal class Triangle
    {
        int Base, h, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter base ");
            Base = byte.Parse(Console.ReadLine());

            Console.WriteLine("enter h ");
            h = byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = (int).5 * Base * h;
        }
        public void DisplayArea()
        {
            Console.WriteLine("area is " + area);
        }
    }

}
