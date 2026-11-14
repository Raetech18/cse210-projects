using System;
using System.Collections.Generic;

// Holds a library of scriptures and returns a random one.
public class ScriptureLibrary
{
    private List<(Reference reference, string text)> _entries = new List<(Reference, string)>();
    private Random _random = new Random();

    public ScriptureLibrary()
    {
        _entries.Add((new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));

        _entries.Add((new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));

        _entries.Add((new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be; and men are, that they might have joy."));

        _entries.Add((new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me."));
    }

    // Builds a fresh Scripture (nothing hidden) from a randomly chosen entry.
    public Scripture GetRandomScripture()
    {
        var entry = _entries[_random.Next(_entries.Count)];
        return new Scripture(entry.reference, entry.text);
    }
}