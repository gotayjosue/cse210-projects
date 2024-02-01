public class ReflectionActivity : Activity
{
  public List<string> reflections = new List<string>{"Think of a time when you stood up for someone else","Think of a time when you did something really difficult.",
  "Think of a time when you helped someone in need","Think of a time when you did something truly selfless"};

  public List<string> reflectQuestions = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?",
  "How did you get started?","What is your favorite thing about this experience?","What did you learn about yourself through this experience?"};

  public ReflectionActivity(string startingMessage, string endingMessage) : base(startingMessage, endingMessage) {
      

  }

  public ReflectionActivity(int duration) : base(duration) {
    
  }
}