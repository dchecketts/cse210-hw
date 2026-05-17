using System.Text.RegularExpressions;

namespace Develop02;

public class Journal
{
    private List<JournalEntry> _journalEntries = new List<JournalEntry>();
    public void AddJournalEntry(JournalEntry journalEntry)
    {
        _journalEntries.Add(journalEntry);
    }

    public void DisplayJournal()
    {
        foreach (JournalEntry journalEntry in _journalEntries)
        {
            journalEntry.DisplayJournalEntry();
        }
    }

    public void LoadJournal()
    {
        string fileName;
        Console.Write("Enter a filename: ");
        string fileChoice = Console.ReadLine();

        if (fileChoice.Contains(@"\.[^.]*$"))
        {
            fileChoice = Regex.Replace(fileChoice, @"\.[^.]*$", "");
            fileName = fileChoice;
        }
        else
        {
            fileName = fileChoice;   
        }

        fileName += ".txt";
        
        string[] fileContent = System.IO.File.ReadAllLines(fileName);

        foreach (string line in fileContent)
        {
            string[] parts = line.Split("|");
            JournalEntry entry = new JournalEntry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            _journalEntries.Add(entry);
        }
    }

    public void SaveJournal()
    {
        string fileName;
        Console.Write("Enter a filename: ");
        string fileChoice = Console.ReadLine();

        if (fileChoice.Contains(@"\.[^.]*$"))
        {
            fileChoice = Regex.Replace(fileChoice, @"\.[^.]*$", "");
            fileName = fileChoice;
        }
        else
        {
            fileName = fileChoice;   
        }

        fileName += ".txt";
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in _journalEntries)
            {
                outputFile.WriteLine(entry.CreateFileSystemString());
            }
        }
    }

    public void DisplayMenu(out bool quit)
    {
        quit = false;
        do
        {
            Console.WriteLine(
                "Please select one of the following options: \n1. Write an Entry \n2. Display the Journal \n3. Load the Journal \n4. Save the Journal \n5. Quit");

            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                JournalEntry entry = new JournalEntry();
                entry.CreateJournalEntry();
                AddJournalEntry(entry);
            }
            else if (userChoice == 2)
            {
                DisplayJournal();
            }
            else if (userChoice == 3)
            {
                LoadJournal();
            }
            else if (userChoice == 4)
            {
                SaveJournal();
            }
            else if (userChoice == 5)
            {
                quit = true;
            }
        } while (!quit);
    }
}