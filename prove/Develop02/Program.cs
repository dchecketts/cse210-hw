using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        JournalEntry journalEntry = new JournalEntry();
        journalEntry.CreateJournalEntry();
        journalEntry.DisplayJournalEntry();
    }
}