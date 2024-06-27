namespace Task25_06;

public class Employee : IPerson
{
    private static int _id;
    public int Id { get; }
    public int Salary { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public string ShowInfo()
    {
        return $"Id:{Id} , Name:{Name} , Salary:{Salary}";
    }
    public Employee(string name, int age, int salary)
    {
        Id = ++_id;
        Name = name;
        Age = age;
        Salary = salary;
    }

    public override string ToString()
    {
        return ShowInfo();
    }

}
