using System;

namespace assignment5.tasks
{
    public partial record Tasks
    {
        /*
         * class for select task from main EP
         * working as a model
         */

        public static void DisplayMenu()
        {
            Console.WriteLine("Main Menu" +
                              "\n1) Calculate Sum" +
                              "\n2) Calculate Average" +
                              "\n3) Display Numbers" +
                              "\n4) Display Poem" +
                              "\n5) Create Numbers Array" +
                              "\n0) To Exit");
        }

        public static void Invoke()
        {
            Invoke(TaskNumber);
        }
    }
}