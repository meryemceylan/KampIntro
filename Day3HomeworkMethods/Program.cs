using System;

namespace Day3HomeworkMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            var result = Add2(1,5);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
    }
}
