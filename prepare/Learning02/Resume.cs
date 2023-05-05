using System;

public class Resume    // New class Resume created.
{
  // attributes or variables which are required for Resume class perform its tasks
  public string _name;  //string variable for user's name
  public List<Job> _jobs = new List<Job>(); // list variable of type Job created. This means that
                                            // the Job class created in Job.cs is a data type contained
                                            // in the variable/attribute, _job 
  
  // function or declaration of task for Resume class
  public void ShowJobs()
  {
    Console.WriteLine($"Name: {_name}");
    Console.WriteLine("");
    Console.WriteLine("Jobs: ");
    foreach(Job job in _jobs)
    {
        job.DisplayFullDetails();
    }
  }
}