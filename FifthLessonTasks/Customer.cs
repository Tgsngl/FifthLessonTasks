using System;
using System.Collections.Generic;
using System.Text;

namespace FifthLessonTasks
{
    class Customer
    {
        public int Id { get; set; }// Burada property(özellik) tanımlıyoruz.

        //encapsulation
        private string _firstName;
        public string FirstName 
        {
            get { return "Mr." + _firstName; }
            set { _firstName = value; } 
        }  
        public string LastName { get; set; }//public string FirstName {get; set;} -> burada Field(alan) tanımlıyoruz.
        public string City { get; set; }

    }
}
