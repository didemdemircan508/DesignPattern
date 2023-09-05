// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person person = new("didem", "dd", Department.C, 100, 10);

Person person1 = person.Clone();
person1.Name = "ayse";

//Person person1 = new("ayse", "dd", Department.C, 100, 10);

interface IPersonCloneable
{ 

    Person Clone();
}


class Person:IPersonCloneable
{
    public Person(string name, string surname, Department department, int salary, int premium)
    {
        Name = name;
        Surname = surname;
        Department = department;
        Salary = salary;
        Premium = premium;
        Console.WriteLine($"Person Nesnesi Oluşturuuld");
    }

    public string Name { get; set; }

    public string Surname { get; set; }

    public Department Department { get; set; }

    public int Salary { get; set; }

    public int Premium { get; set; }

    public Person Clone()
    {
        return  (Person)base.MemberwiseClone();
    }
}

enum Department
{ 

    A,B,C 
}


