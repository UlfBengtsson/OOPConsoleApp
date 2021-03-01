using System;
using System.Collections.Generic;
using System.Text;

namespace OOPConsoleApp
{
    class Person
    {
        //fiealds
        string firstName;
        string lastName;
        Gender gender;
        public int age;//defualt assigned 0

        public Person()
        {
            firstName = "John";
            lastName = "Doe";
            gender = Gender.Other;
        }
        public Person(string firstName, string lastName, int age, Gender gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
        }

        public string Info()
        {
            return $"Name: {firstName} {lastName}\nGender: {gender}\nAge: {age}";
        }

    }

    enum Gender
    {
        Man,
        Woman,
        Other
    }
}
