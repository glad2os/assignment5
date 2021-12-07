// Main Controller

using System;
using assignment5;
using assignment5.tasks;

Tasks unused = new();

Console.WriteLine("Hello, World!");
Tasks.DisplayMenu();

while (true)
{
    try
    {
        var userChoice = Console.ReadLine();

        if (userChoice == "0") break;

        Tasks.SetTaskNumber(userChoice);
        Tasks.Invoke();
        Tasks.DisplayMenu();
    }
    catch (BaseException e)
    {
        Console.WriteLine(e.Message);
    }
}