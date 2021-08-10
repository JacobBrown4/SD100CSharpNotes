using _08_StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public class ProgramUI
    {
        private readonly StreamingRepository _repo = new StreamingRepository();

        public void Run()
        {
            SeedContent();
            Menu();
        }

        public void SeedContent()
        {
            Console.WriteLine("Seeding contents...");
        }

        public void Menu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();

                // \n = new line = CR + LF
                // CR = Carriage Return
                // LF = Line Feed
                Console.WriteLine("Menu:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Remove streaming content\n" +
                    "5. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        // Show all content
                        break;
                    case "2":
                        // Find by title
                        break;
                    case "3":
                        // Add new content
                        AddNewContent();
                        break;
                    case "4":
                        // Remove content
                        break;
                    case "exit":
                    case "EXIT":
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid selection\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Goodbye!");
            Thread.Sleep(2000);

            // returns a ConsoleKeyInfo:
            // var key = Console.ReadKey();
            // returns a string:
            // Console.ReadLine();
        }

        public void AddNewContent()
        {
            Console.Clear();
        }
    }
}
