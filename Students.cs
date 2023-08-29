using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student
    {
        public string Name { get; }
        public int age;
        private readonly string _city;
        public string status;

        public Student(string name, int age, string city)
        {
            Name = name;
            Age = age;
            _city = city;
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age < 18) status = "alapealine";
                else status = "täiskasvanud";
            }
        
        }


        public int Birth()
        {
            int currentData= DateTime.Now.Year;
            return currentData;
        }

        public string Status
        {
            get { return status; }
        }


        public string GetCity()
        {
            return _city;
        }

        public void ShowInfo()
        {

            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(GetCity());
            Console.WriteLine(Status);
            Console.WriteLine(Birth());


        }
    }
}


    

