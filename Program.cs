namespace coderefactor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();
            var result = class1.Calculate(1000, 2, 5);

            System.Console.WriteLine(result);
        }
    }
}
