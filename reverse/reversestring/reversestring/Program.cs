using System;
namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// program start. The user enters a string, the program mirrors the word along the string
        /// </summary>
        static void Main(string[] args) /// <param> name="args">Command line arguments input.</param>
        {
            Console.WriteLine("Enter ur text"); /// message to user
            string str = Convert.ToString(Console.ReadLine()); /// string entered by the user
            char[] s = str.ToCharArray(); /// array 
            Array.Reverse(s); Array.Reverse(s); /// mirroring method
            Console.WriteLine(s); /// output to the user
            Console.ReadKey(); /// exit from the program
        }
    }
}

