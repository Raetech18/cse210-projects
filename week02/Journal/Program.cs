using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
    Console.WriteLine();
    Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = 0;
            }

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    journal.AddEntry(new Entry(date, prompt, response));
                    Console.WriteLine();
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("What is the filename? ");
                    string loadName = Console.ReadLine();
                    try
                    {
                        journal.LoadFromFile(loadName);
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("That file was not found.\n");
                    }
                    break;
                case 4:
                    Console.Write("What is the filename? ");
                    string saveName = Console.ReadLine();
                    journal.SaveToFile(saveName);
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please enter a number from 1 to 5.\n");
                    break;
            }
        }
    }
}