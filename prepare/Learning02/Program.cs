using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); //new job job1 is created by calling the job class.
        job1._companyName = "Microsoft";  //name attribute assigned to job1
        job1._jobTitle = "Software Engineer"; // job title attribute created for job1
        job1._startYear = 2019; //start year attribute assigned
        job1._endYear = 2022; // end year attribute assigned for job1

        Job job2 = new Job();// another job created job2 and similar attributes as job1 assigned
        job2._companyName = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Resume myResume = new Resume();   //a new resume object is created
        myResume._name = "Allison Rose";
        myResume._jobs.Add(job1);  // job1 added to the _job list
        myResume._jobs.Add(job2); // job2 also added.

        myResume.ShowJobs();


        
    }
}