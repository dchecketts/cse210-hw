using System;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"You have {goalManager.GetUserPoints()} points. \n");
            Console.Write("Menu Options: \n 1. Create a new goal \n 2. List goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit \n \nSelect a choice from the menu: ");
            
            string choice = Console.ReadLine();

            // Create Goal
            if (choice == "1")
            {
                goalManager.CreateGoal();
            }
            
            // Display Goals
            else if (choice == "2")
            {
                goalManager.DisplayGoals();
                Console.Write("\nPush Enter to continue... ");
                Console.ReadLine();
            }
            
            // Save Goals
            else if (choice == "3")
            {
                goalManager.SaveGoals();
                Console.Write("\nPush Enter to continue... ");
                Console.ReadLine();
            }
            
            // Load Goals
            else if (choice == "4")
            {
                goalManager.LoadGoals();
                Console.Write("\nPush Enter to continue... ");
                Console.ReadLine();
            }
            
            // Goal Event (Report Goal Completion)
            else if (choice == "5")
            {
                goalManager.GoalEvent();
                Console.Write("\nPush Enter to continue... ");
                Console.ReadLine();
            }
            
            // Quit
            else if (choice == "6")
            {
                break;
            }
        }
    }
}