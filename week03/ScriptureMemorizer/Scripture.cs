using System;
using System.Collections.Generic;

// Holds a Reference and the list of Words that make up the verse text.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
    }

    public void HideRandomWords(int numberToHide)
    {
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}