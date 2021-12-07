using System;

namespace assignment5
{
    public class BaseException : Exception
    {
        public static readonly BaseException IsNotAnInteger = new("is not an integer");
        public static readonly BaseException QuestionNotFound = new("question does not found");
        public static readonly BaseException IsNotADouble = new("The number should be double");
        public static readonly BaseException LessThanNeeded = new("The number should be more than 5.65");
        public static readonly BaseException WeekDay = new("The week day is not found");

        public static readonly BaseException ValueLessGreater =
            new("The number should grate or equals 5.65 and less or equals than 49.99");

        private BaseException(string message) : base(message)
        {
        }
    }
}