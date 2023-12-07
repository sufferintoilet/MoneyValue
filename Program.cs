using System;
namespace MoneyValue
{
internal class Program
{
    private static void Main(string[] args)
    {
        int VND;
        int USD;

        Console.WriteLine("Enter USD: 1");
        USD = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter VND: 23000");
        VND = int.Parse(Console.ReadLine());
        Console.WriteLine("amount of VND for 1 USD is: " + USD*VND);

    }
}
}