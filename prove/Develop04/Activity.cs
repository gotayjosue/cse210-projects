public class Activity 
{
    private string _startingMessage = "";
    private string _endingMessage = "";
    private int _duration;


    public Activity(string startingMessage, string endingMessage) {

        _startingMessage = startingMessage;
        _endingMessage = endingMessage;

    }

    public Activity(int duration){
        _duration = duration;
    }


    public string GetStartingMessage() {

        return $"{_startingMessage}";
    }

    public string GetEndingMessage() {
        return $"{_endingMessage}";
    }

    public int GetDuration() {

        return _duration;
    }

    public void Dots(int sec) {
            for (int i = sec; i > 0; i--) {
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(" ");
            }
        }

}