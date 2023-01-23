using System;

class Program
{
    static void Main(string[] args)
    {
        Job jobs1= new Job();
        jobs1._company="Tesla.SA";
        jobs1._jobTitle="Sealing Manager";
        jobs1._startYear=2002;
        jobs1._endYear=2022;
        
        Job jobs2 = new Job();
        jobs2._company="Coca Cola.SA";
        jobs2._jobTitle="junios sealer";
        jobs2._startYear=2000;
        jobs2._endYear=2002;

        Resume myResume= new Resume();
        myResume._name= "Juleo Manson";
        myResume._jobs.Add(jobs1);
        myResume._jobs.Add(jobs2);

        myResume.DispayResume();
    }
}

