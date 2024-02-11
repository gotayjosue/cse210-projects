public class Goal
{
    private string _fileName = "main.txt";
    private string _dataFile = "main2.txt";

    private string _scoreFile = "score.txt";

    private string _shortName = "";
    private string _description = "";
    private int _points = 0;

    /* Getters */

    public string GetShortName() {

        return _shortName;
    }

    public string GetDescription() {

        return _description;
    }

    public int GetPoints() {

        return _points;
    }

    public string GetFileName() {

        return _fileName;
    }

    public string GetDataFile() {

        return _dataFile;
    }

    public string GetScoreFile() {

        return _scoreFile;
    }
    /* Setters */

    public void SetShortName(string shortName) {

        _shortName = shortName;
    }

    public void SetDescription(string description) {

        _description = description;
    }

    public void SetPoints(int points) {

        _points += points;
    }
}