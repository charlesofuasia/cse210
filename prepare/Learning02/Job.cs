using System;
//declare a new class Job
public class Job

{
    //the attributes or variables that Job class will require to perform its roles
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

// function declaration or task performed by the Job class.
    public void DisplayFullDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear} - {_endYear}");
    }

}