namespace AbstractClassInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Square square = new Square();
            //square.GetDimensions();
            //square.CalculateArea();
            //square.DisplayArea();


            //Rectangle rectangle = new Rectangle();
            //rectangle.GetDimensions();
            //rectangle.CalculateArea();
            //rectangle.DisplayArea();

            //Triangle triangle = new Triangle();
            //triangle.GetDimensions();
            //triangle.CalculateArea();
            //triangle.DisplayArea();

            //Shape shape;
            //shape = new Square();
            //shape.GetDimensions();
            //shape.CalculateArea();
            //shape.CalculateArea();

            //shape = new Rectangle();
            //shape.GetDimensions();
            //shape.CalculateArea();
            //shape.CalculateArea();


            Shape shape=null;
            Console.WriteLine("which shape you need to enter");
            int ch = byte.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    {
                        shape = new Rectangle();
                        break;
                    }
                case 2:
                    {
                        shape = new Square();
                        break;
                    }
                case 3:
                    {
                        shape = new Triangle();
                        break;
                    }
            }
            shape.GetDimensions();
            shape.CalculateArea();
            shape.DisplayArea();



        }
    }
}
