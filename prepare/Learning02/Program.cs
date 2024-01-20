using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sofware engineer (Google) 1998 - 2018";
        job1._jobTitle2 = "CEO (Apple) 2019 - 2024";

        Resume resume = new Resume();
        resume._name = "Jason Clark";
        resume.jobs.Add(job1);
        
        resume.DisplayResume();
    }

    
}

