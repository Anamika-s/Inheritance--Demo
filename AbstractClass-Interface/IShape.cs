using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    internal interface IShape
    {
        public void GetDimensions();
        public void CalculateArea();
        public void DisplayArea();
    }


    public class Square : IShape
    {
        int side, area;
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayArea()
        {
            throw new NotImplementedException();
        }

        public void GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    class Reactangle : IShape
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayArea()
        {
            throw new NotImplementedException();
        }

        public void GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    interface I1
    {
        public void GetA();
        public void GetB();
        public void GetC();
    }

    interface I2
    {
        public void GetA();
        public void GetD();
        public void GetE();
    }

    // multiple inheritance
    class Demo : I1, I2
    {
        public void GetA()
        {
            throw new NotImplementedException();
        }

        public void GetB()
        {
            throw new NotImplementedException();
        }

        public void GetC()
        {
            throw new NotImplementedException();
        }

        public void GetD()
        {
            throw new NotImplementedException();
        }

        public void GetE()
        {
            throw new NotImplementedException();
        }
    }


    class Demo2 : I1, I2
    {
        void I1.GetA()
        {
            throw new NotImplementedException();
        }

        void I2.GetA()
        {
            throw new NotImplementedException();
        }

        void I1.GetB()
        {
            throw new NotImplementedException();
        }

        void I1.GetC()
        {
            throw new NotImplementedException();
        }

        void I2.GetD()
        {
            throw new NotImplementedException();
        }

        void I2.GetE()
        {
            throw new NotImplementedException();
        }
    }

}