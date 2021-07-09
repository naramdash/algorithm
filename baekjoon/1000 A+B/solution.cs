using System;
using System.Linq;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            var numbers = userInput.Split(" ").Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(numbers[0] + numbers[1]);
        }
    }
}

