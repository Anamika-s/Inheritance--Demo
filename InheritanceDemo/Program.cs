namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STUDENT CLASS ");
            Student student = new Student();
            student.GetDetails();
            student.DisplayDetails();

            Console.WriteLine("PARTTIME ");
            PartTimeStudent part = new PartTimeStudent();
            part.GetDetails();
            //part.GetPartTimeStudentDetails();
            part.DisplayDetails();
            //part.DisplayPartTimeStudentDetails();

            Console.WriteLine("FullTimeStudent" );
            FullTimeStudent full = new FullTimeStudent();
            full.GetDetails();
            full.DisplayDetails();

        }
    }
}
