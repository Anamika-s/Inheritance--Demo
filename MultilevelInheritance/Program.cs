namespace MultilevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Result result = new Result();
            result.GetDetails();
            result.CalculateTotalMarks();
            result.CalculateTotalScore();
            result.DisplayDetails();
            //result.totalMarks
        }
    }
}
