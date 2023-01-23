using System;
 public class Resume
    {
        public string _name = "";
        public List<Job> _jobs = new List<Job>();
        public void DispayResume()
        {

            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs resume:");

            foreach(Job jobs1 in _jobs){
                jobs1.DispayJob();
            }
        }
           
    }