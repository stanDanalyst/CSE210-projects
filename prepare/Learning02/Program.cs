using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._company = "Adobe";
       job1._jobTitle = "Data Analyst";
       job1._startYear = 2015;
       job1._endYear = 2022;

       Job job2 = new Job();
       job2._company = "Amazon";
       job2._jobTitle = "Software Engineer";
       job2._startYear = 2021;
       job2._endYear = 2023;

       job1.DisplayJobDetails();
       job2.DisplayJobDetails();

       Resume myResume = new Resume();
       myResume._name = "Damian Ahamba";

       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

       myResume.DisplayJobDetails();



    }
}