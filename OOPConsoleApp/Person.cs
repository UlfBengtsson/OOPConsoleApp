using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConsoleApp
{
    class Person
    {

        public static int createdInstances = 0;

        //fiealds
        string firstName;
        string lastName;
        Gender gender;
        public int age;//defualt assigned 0

        public string FirstName 
        {
            get 
            {
                return firstName;
            } 
            set
            {
                firstName = value;
            }
        }

        public Person()
        {
            firstName = "John";
            lastName = "Doe";
            gender = Gender.Other;
            
            createdInstances++;
        }
        public Person(string firstName, string lastName, int age, Gender gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;

            createdInstances++;
        }

        public string Info()
        {
            return $"Name: {firstName} {lastName}\nGender: {gender}\nAge: {age}";
        }

        public override string ToString()
        {
            return $"Person: {firstName} {lastName} : {gender} : {age}";
        }
        
    }

    enum Gender
    {
        Man,
        Woman,
        Other
    }
}
