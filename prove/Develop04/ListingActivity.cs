public class ListingActivity : Activity 
{
   public List<string> listingQuestions = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?",
   "Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};

   public ListingActivity(string startingMessage, string endingMessage) : base(startingMessage, endingMessage) {
      

   }

     public ListingActivity(int duration) : base(duration) {
    
  }
    
}