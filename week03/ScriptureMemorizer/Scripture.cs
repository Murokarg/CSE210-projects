using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int count = 0;
        while (count < numberToHide && _words.Any(w => !w.IsHidden()))
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];
            if (!word.IsHidden())
            {
                word.Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));

        return $"{referenceText}\n{scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

}