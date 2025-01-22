public class Word
{
    private string _text;
    private bool _isHidden;

    // The constructor to initialize the word
    public Word(string text)
    {
        _text = text;
        _isHidden = false; 
    }

    // To hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // To reveal the word
    public void Show()
    {
        _isHidden = false;
    }

    // Returns whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
