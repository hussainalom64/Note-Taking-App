using System;
using System.Collections.Generic;

namespace NoteTakingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is where we create our dictionary to store our notes
            Dictionary<string, string> notes = new Dictionary<string, string>();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Hello, welcome to MyNotes!");
                Console.WriteLine("What would you like to do ? Please input 1,2,3,4");
                Console.WriteLine("1. Create a new note");
                Console.WriteLine("2. View all of your notes");
                Console.WriteLine("3. View a specific note");
                Console.WriteLine("4. Delete a note");
                Console.WriteLine("5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Create our notes
                        Console.WriteLine("Enter the title of the note:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter the text of the note:");
                        string text = Console.ReadLine();
                        notes[title] = text;
                        Console.WriteLine("Note saved successfully!");
                        break;

                    case 2:
                        //Views all the titles of your notes
                        Console.WriteLine("Here is a list of all your notes.");
                        foreach (string titles in notes.Keys)
                        {
                            Console.WriteLine(titles);
                        }
                        break;

                    case 3:
                        //View a specific note
                        Console.WriteLine("Please enter the title of the note you would like to view: ");
                        string viewTitle = Console.ReadLine();
                        if (notes.ContainsKey(viewTitle))
                        {
                            Console.WriteLine(notes[viewTitle]);
                        }
                        else
                        {
                            Console.WriteLine("Incorrect title, note not found.");
                        }
                        break;

                    case 4:
                        //Delete a specific note
                        Console.WriteLine("Please enter the title of the note you would like to delete: ");
                        string deleteTitle = Console.ReadLine();
                        if (notes.ContainsKey(deleteTitle))
                        {
                            notes.Remove(deleteTitle);
                            Console.WriteLine("This note has successfully been deleted.");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect title, note not found.");
                        }
                        break;

                    case 5:
                        //Exit the program
                        exit = true;
                        break;
                    default:
                        //Default if the user inputs an invalid number
                        Console.WriteLine("Invalid input, please enter 1, 2, 3, 4!");
                        break;
                }
            }
        }
    }
}