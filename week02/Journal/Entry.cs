using System;

// Represents one journal entry: the date, the prompt shown, and the user's response.
public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine();
    }

    // One CSV line (Date,Prompt,Response) with correct quoting.
    public string ToCsvLine()
    {
        return $"{CsvHelper.Escape(_date)},{CsvHelper.Escape(_prompt)},{CsvHelper.Escape(_response)}";
    }
}