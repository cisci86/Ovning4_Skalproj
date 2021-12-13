﻿using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
            Console.Clear();
            string? userInput;
            char userChoice = ' ';
            List<string> theList = new List<string>();
            do
            {
                Console.WriteLine("Use the menu below to add or remove input to the list.");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("* Add input to the list: write '+' and the your input");
                Console.WriteLine("* Remove from the list: write '-' and then the input you would like to remove");
                Console.WriteLine("* Exit the application and go back to the main menu: 0");

                userInput = Console.ReadLine();
                userChoice = userInput[0];
                userInput = userInput.Remove(0, 1);
                userInput = userInput.Trim();
                switch (userChoice)
                {
                    case '+':
                        theList.Add(userInput);
                        Console.WriteLine(theList.Count());
                        Console.WriteLine(theList.Capacity);
                        break;
                    case '-':
                        int getIndex = theList.IndexOf(userInput);
                        if (getIndex >= 0)
                        {
                            theList.RemoveAt(getIndex);
                            Console.WriteLine(theList.Count());
                            Console.WriteLine(theList.Capacity);
                        }
                        else
                            Console.WriteLine("Please write an item that exist in the list");
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Please add a '+' or a '-' before the input depending on what you want to do!");
                        break;
                }
            } while (userChoice != '0');
            //2.Capacity ökar när count är påväg att bli större än vad capacity är alltså när listan blir större än det allocerad minnet.
            //3.Det ökar med 4 varje gång om man inte explecit ber den öka med något annat.
            //4.För att slippa gör en ny underliggande array varje gång vilket tar upp minne på heapen tills GB tar bort det.
            //5.Nej, kapasiteten kommer inte minska om man inte explicit säger åt den att göra det.
            //6.När du redan sen innan vet hur stor collection du ska ha. Då slipper du allocera mer minne än du ska använda.
            //och om du aldrig kommer ändra på storleken av kollektionen.

        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Console.Clear();
            int userChoice;
            Queue<string> theQueue = new Queue<string>();  
            do
            {
                Console.WriteLine("Use the menu below to add or remove people to and from the queue.");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("*1: Add person to the queue");
                Console.WriteLine("*2: Remove the first person from the queue");
                Console.WriteLine("*0: Exit the application and go back to the main menu\n");
                userChoice = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Who do you want to add to the queue?");
                        string personToAdd = (Console.ReadLine());
                        theQueue.Enqueue(personToAdd);
                        Console.WriteLine($"{personToAdd} was added to the queue!");
                        Console.WriteLine($"The queue is {theQueue.Count} persons long\n");
                        break;
                    case 2:
                        Console.WriteLine($"{theQueue.Dequeue()} was removed from the queue");
                        Console.WriteLine($"The queue is {theQueue.Count} persons long\n");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice from the menu!");
                        break;
                }

            } while (userChoice !=0);
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

