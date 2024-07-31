namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call methods of objects thru parent class object only

            Student student;
            Console.WriteLine("PartTime");
            student = new PartTimeStudent();
            student.GetDetails();
            student.DisplayDetails();
        }
    }
}
