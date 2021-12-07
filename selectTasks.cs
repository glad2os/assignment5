using System;

namespace assignment5
{
    public partial record Tasks
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Main Menu"+
            "\n1) Calculate Sum" + 
            "\n2) Calculate Average" +
            "\n3) Display Numbers" +
            "\n4) Display Poem" +
            "\n5) Create Numbers Array" +
            "\n0) To Exit");
        }
    }
}