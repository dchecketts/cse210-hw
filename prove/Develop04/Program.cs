using System;
using Develop04;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        while (true)
        {
            Console.Clear();
            Console.Write("Menu Options: \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Show Session Summary \n 5. Quit \n \nSelect a choice from the menu: ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathActivity activity = new BreathActivity("Breathing Activity", "This activity will help you to relax by focusing on consistent breathing. If you want, you can play some relaxing music quietly in the background.");
                activity.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectActivity activity = new ReflectActivity("Reflecting Activity", "This activity will help you to reflect on times in your life where you have endured or accomplished something. You have overcome things and can still do so now. You have completed things, and you can meet your current goals.");
                activity.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListActivity activity = new ListActivity("Listing Activity", "This activity will help you to reflect on good things in your life by having you list as many things you can think of.");
                activity.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine($"Session Summary: \nBreathing Activities Completed: {breathingCount} \nReflecting Activities Completed: {reflectingCount} \nListing Activities Completed: {listingCount} \n \nPress any key to return to the menu...");
                Console.ReadKey();
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}