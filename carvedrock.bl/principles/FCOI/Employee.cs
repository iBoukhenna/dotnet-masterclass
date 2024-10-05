﻿namespace carvedrock.bl.principles.FCOI
{
    class Employee
    {
        public int Salary { get; set; }
        public Person Person { get; set; }

        public Employee(Person person, int salary)
        {
            Salary = salary;
            Person = person;
        }
    }
}