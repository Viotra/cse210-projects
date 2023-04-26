using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Fat Man";
        job1._company = "In A Tiny Coat";
        job1._startYear = 1964;
        job1._endYear = 1997;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Straight Man";
        job2._company = "Amature Comedy Duo";
        job2._startYear = 1999;
        job2._endYear = 1999;
        job2.Display();

        Job job3 = new Job();
        job3._jobTitle = "Delivery Boy";
        job3._company = "Mick's Pizza";
        job3._startYear = 1999;
        job3._endYear = 1999;

        Job job4 = new Job();
        job4._jobTitle = "Unemployed";
        job4._company = "Still looking for work";
        job4._startYear = 1999;
        job4._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "John Doe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);
        myResume._jobs.Add(job4);

        myResume.Display();
    }
}