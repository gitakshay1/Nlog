using SampleNlog;

public class Program
{
    static void Main(string[] args)
    {
        AddNumber addNumber=new AddNumber();
        int Result = addNumber.Sum(12, 13);
        Console.WriteLine(Result);
    }
}
