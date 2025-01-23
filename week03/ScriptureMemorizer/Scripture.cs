using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Hides a specified number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var wordsToHide = _words
            .Where(word => !word.IsHidden()) 
            .OrderBy(_ => random.Next())
            .Take(numberToHide);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    // Returns the scripture as a string with the reference and the words
    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
