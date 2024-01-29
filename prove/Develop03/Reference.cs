public class Reference 
{
    private string _book;
    private string _chapter;
    private string _verse;

    public Reference(string book, string chapter, string verse) {

        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string verse) {
        _verse = verse;
    }

    public string GetBook () {
        return _book;
    }

    public string GetChapter() {
        return _chapter;
    }

    public string GetVerse() {
        return _verse;
    }

}