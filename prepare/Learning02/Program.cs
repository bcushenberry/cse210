using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Self-employed";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2021;
        job1._endYear = 2045;

        Job job2 = new Job();
        job2._company = "Keywords";
        job2._jobTitle = "Senior Project Manager";
        job2._startYear = 2012;
        job2._endYear = 2021;

        Resume resume = new Resume();
        resume._name = "Brandon Cushenberry";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();

    }
}

/*
Class: Job
Attributes:
_company: string
_jobTitle: string
_startYear: int
_endYear: int

Behaviors:
DisplayJobInfo(): void

Class: Resume
Attributes:
_name: string
_jobs: List<Job>

Behaviors:
DisplayResume(): void

*/