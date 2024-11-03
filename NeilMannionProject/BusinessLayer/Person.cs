using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    //Created a person class with the main properties
    public abstract class Person
    {
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty;

        //default constructor
        public Person() { }


        //overloaded constructor
        public Person(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }


        //override the ToString method so i can concatinate other messages to it
        public override string? ToString()
        {
            return $"{FName} {LName} ";
        }
    }
}
