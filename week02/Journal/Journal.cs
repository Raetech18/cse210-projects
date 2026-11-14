using System;
using System.Collections.Generic;
using System.IO;

// Manages the collection of entries and handles saving/loading.
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("Date,Prompt,Response");
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToCsvLine());
            }
        }
    }

    // Replaces any entries currently in the journal.
    public void LoadFromFile(string filename)
    {
        string text = File.ReadAllText(filename);
        List<List<string>> records = CsvHelper.Parse(text);

        _entries.Clear();

        for (int i = 1; i < records.Count; i++) // skip header row
        {
            List<string> f = records[i];
            if (f.Count >= 3)
            {
                _entries.Add(new Entry(f[0], f[1], f[2]));
            }
        }
    }
}