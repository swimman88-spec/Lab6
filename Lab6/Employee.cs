using System;

namespace ConsoleApp;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Salary { get; set; }


    public Employee(int id, string name, string gender, int salary)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Salary = salary;
    }
}