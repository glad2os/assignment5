using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment5.tasks
{
    public static class Methods
    {
        public static int CalculateSum(int n)
        {
            var result = 0;
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter a number: ");
                result += Tasks.GetInteger(Console.ReadLine());
            }

            return result;
        }

        public static double CalculateAverage(int n)
        {
            var result = 0;
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter a number: ");
                result += Tasks.GetInteger(Console.ReadLine());
            }

            return result / n;
        }

        public static void DisplayIntArray(IEnumerable<int> n)
        {
            foreach (var i in n)
                Console.Write($" {i} ");
            //return Array.Empty<int>();
        }

        public static void DisplayStringArray(IEnumerable<string> n)
        {
            var sb = new System.Text.StringBuilder();

            foreach (var i in n)
                sb.Append($" {i} ");

            Console.WriteLine(sb.ToString());
            //return Array.Empty<int>();
        }

        public static int[] CreateIntArray()
        {
            Console.Write("please input array lenght");
            var n = Tasks.GetInteger(Console.ReadLine());
            var result = new int[n];
            
            foreach (var i in result)
            {
                Console.Write($"please {i} array elem: ");
                result[i] = Tasks.GetInteger(Console.ReadLine());
            }

            return result;
        }
    }
}