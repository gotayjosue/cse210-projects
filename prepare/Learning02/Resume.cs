public class Resume 
{
    public string _name = "";

    public List<Job> jobs = new List<Job>();


    public void DisplayResume() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        Console.WriteLine(jobs[0]._jobTitle);
        Console.WriteLine(jobs[0]._jobTitle2);

            
        
        
    }
}