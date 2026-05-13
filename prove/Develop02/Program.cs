using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry journalEntry = new JournalEntry();
        journalEntry.CreateJournalEntry();
        
        // Testing JournalEntry Class
        // journalEntry.DisplayJournalEntry();
        // Console.WriteLine(journalEntry.CreateFileSystemString());
        
        JournalEntry journalEntry2 = new JournalEntry();
        journalEntry2.CreateJournalEntry();
        
        Journal journal = new Journal();
        journal.AddJournalEntry(journalEntry);
        journal.AddJournalEntry(journalEntry2);
        journal.DisplayJournal();
    }
}