using System;
using System.Collections.Generic;

namespace assignment5.tasks
{
    /*
     * Main Model
     * List of all classes
     */

    public partial record Tasks
    {
        private static string? TaskNumber { get; set; }

        private static readonly Dictionary<string, Action> Questions = new()
        {
            {"1", Question1},
            {"2", Question2},
            {"3", Question3},
            {"4", Question4},
            {"5", Question5},
        };

        private static void Question1()
        {
            Methods.CalculateSum(5);
        }

        private static void Question2()
        {
            Methods.CalculateAverage(5);
        }

        private static void Question3()
        {
            var numbers = new[] {0, 1, 2, 3};
            Methods.DisplayIntArray(numbers);

            numbers = new[] {0, 1, 2, 3, 4};
            Methods.DisplayIntArray(numbers);
        }

        private static void Question4()
        {
            var poem = new[] {"a", "c", "c", "b", "f", "e"};
            Methods.DisplayStringArray(poem);
            
            Array.Sort(poem);
            Methods.DisplayStringArray(poem);
        }

        private static void Question5()
        {
            var array = Methods.CreateIntArray();
            Methods.DisplayIntArray(array);
        }

        public static void SetTaskNumber(string? taskNumber)
        {
            TaskNumber = taskNumber;
        }

        public static int GetInteger(string? text)
        {
            if (!int.TryParse(text, out var variable))
                throw BaseException.IsNotAnInteger;
            return variable;
        }

        private static void Invoke(string? taskNumber)
        {
            // Debug.Assert(taskNumber != null, nameof(taskNumber) + " != null");

            if (taskNumber == null)
                throw BaseException.QuestionNotFound;

            if (!Questions.TryGetValue(taskNumber, out var action))
                throw BaseException.QuestionNotFound;

            Console.WriteLine($"You entered: {taskNumber}");
            Console.WriteLine("------------");
            action.Invoke();
        }
    }
}