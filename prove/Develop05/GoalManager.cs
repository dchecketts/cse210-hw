namespace Develop05;

public class GoalManager
{
    private int _userPoints;
    private List<Goal> _goals = new();

    public int GetUserPoints()
    {
        return _userPoints;
    }
    
    public void CreateGoal()
    {
        Console.Clear();
        Console.Write("The types of goals are: \n 1. Simple goal (One and done) \n 2. Eternal goal (Infinitely repeatable) \n 3. Checklist goal (Repeat a specified amount of times) \n \nWhich type of goal would you like to create? ");
        string secondChoice = Console.ReadLine();
        
        // Simple Goal
        if (secondChoice == "1")
        {
                Console.Clear();
                    
                Console.Write("What is the name of the goal? ");
                string goalName = Console.ReadLine();
                    
                Console.Write("Write a short description of the goal: ");
                string goalDescription = Console.ReadLine();
                    
                Console.Write("How many points do you want to get when you complete this goal? ");
                string tempInput = Console.ReadLine();
                int goalPoints = 0;

                if (!string.IsNullOrWhiteSpace(tempInput))
                {
                    goalPoints = int.Parse(tempInput);
                }
                    
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                _goals.Add(simpleGoal);
        }
        
        // Eternal Goal
        else if (secondChoice == "2")
        {
            Console.Clear();
            
            Console.Write("What is the name of the goal? ");
            string goalName = Console.ReadLine();
            
            Console.Write("Write a short description of the goal: ");
            string goalDescription = Console.ReadLine();
            
            Console.Write("How many points do you want to get when you do this goal? ");
            string tempInput = Console.ReadLine();
            
            int goalPoints = 0;
            if (!string.IsNullOrWhiteSpace(tempInput))
            {
                goalPoints = int.Parse(tempInput);
            }
            
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternalGoal);
        }
        
        // Checklist Goal
        else if (secondChoice == "3")
        {
            Console.Clear();
            
            Console.Write("What is the name of the goal? ");
            string goalName = Console.ReadLine();
            
            Console.Write("Write a short description of the goal: ");
            string goalDescription = Console.ReadLine();
            
            Console.Write("How many points do you want to get each time you do this goal? ");
            string tempInput = Console.ReadLine();
            
            int repeatPoints = 0;
            if (!string.IsNullOrWhiteSpace(tempInput))
            {
                repeatPoints = int.Parse(tempInput);
            }
            
            Console.Write("How many times do you need to do this goal? ");
            string tempInput2 = Console.ReadLine();
            
            int maxRepetitions = 0;
            if (!string.IsNullOrWhiteSpace(tempInput2))
            {
                maxRepetitions = int.Parse(tempInput2);
            }
            
            Console.Write($"How many points do you want to get after completing this goal {maxRepetitions} times? ");
            string tempInput3 = Console.ReadLine();
            
            int bonusPoints = 0;
            if (!string.IsNullOrWhiteSpace(tempInput3))
            {
                bonusPoints = int.Parse(tempInput3);
            }
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, repeatPoints, bonusPoints, maxRepetitions);
            _goals.Add(checklistGoal);
        }
    }

    public void SaveGoals()
    {
        Console.Clear();
        Console.Write("What is the name of the file you want to save your goals to? (Saved as .txt) ");
        string fileName = Console.ReadLine();
        
        
        if (!string.IsNullOrWhiteSpace(fileName))
        {
            if (fileName.Contains('.'))
            {
                string[] parts = fileName.Split(new char[] {'.'}, 2);
                if (parts[0].Length == 0)
                {
                    fileName = "goals.txt";
                }
                else
                {
                    fileName = $"{parts[0]}.txt";
                }
            }
            else
            {
                fileName = $"{fileName}.txt";
            }
        }
        else
        {
            fileName = "goals.txt";
        }
                
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFullGoalDetails());
            }
        }
        
        Console.WriteLine($"Saving goals to {fileName}...");
    }

    public void LoadGoals()
    {
        Console.Clear();
        Console.Write("What is the name of your goal file? (Saved as .txt) ");
        string fileName = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(fileName))
        {
            if (fileName.Contains('.'))
            {
                string[] parts = fileName.Split(new char[] {'.'}, 2);
                if (parts[0].Length == 0)
                {
                    fileName = "goals.txt";
                }
                else
                {
                    fileName = $"{parts[0]}.txt";
                }
            }
            else
            {
                fileName = $"{fileName}.txt";
            }
        }
        else
        {
            fileName = "goals.txt";
        }
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(':');
            string[] components = parts[1].Split(',');

            if (parts[0] == "SimpleGoal")
            {
                string goalName = components[0];
                string goalDescription = components[1];
                int goalPoints = int.Parse(components[2]);
                bool isComplete;

                if (components[3] == "False")
                {
                    isComplete = false;
                }
                else
                {
                    isComplete = true;
                }
                
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, isComplete);
                _goals.Add(simpleGoal);
            }

            else if (parts[0] == "EternalGoal")
            {
                string goalName = components[0];
                string goalDescription = components[1];
                int goalPoints = int.Parse(components[2]);
                
                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string goalName = components[0];
                string goalDescription = components[1];
                int repeatPoints = int.Parse(components[2]);
                int bonusPoints = int.Parse(components[3]);
                int maxRepetitions = int.Parse(components[4]);
                int currentRepetitions = int.Parse(components[5]);

                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, repeatPoints, bonusPoints,
                    maxRepetitions, currentRepetitions);
                _goals.Add(checklistGoal);
            }
        }
        
        Console.WriteLine($"Loading goals from {fileName}...");
    }

    public void DisplayGoals()
    {
        Console.Clear();
        Console.WriteLine($"You have {_goals.Count} goals: ");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetGoalDetails());
        }
    }
    public void GoalEvent()
    {
        Console.Clear();
        Console.WriteLine($"You have {_goals.Count} goals: ");
        int index = 1;
        
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetGoalName()}");
            index++;
        }
        
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = 0;
        string userChoice = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(userChoice))
        {
            goalIndex = int.Parse(userChoice);
        }

        if (goalIndex > 0 && goalIndex <= _goals.Count)
        {
            Goal completedGoal = _goals[goalIndex - 1];

            int points = completedGoal.RecordEvent();
            _userPoints += points;
            
            Console.Write($"\nCongratulations! You have earned {points} points! \n \nYou now have {_userPoints} points.");
        }
        else
        {
            Console.WriteLine("Please enter a number that is in the list.");
        }

    }
}