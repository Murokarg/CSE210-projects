using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
                writer.WriteLine("---"); // Separator between entries
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            _entries.Clear();
        }
    }


}