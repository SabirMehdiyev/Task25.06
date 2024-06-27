using Task25_06;

namespace Task25._06;

public class Program
{
    static void Main(string[] args)
    {
        Department department = new("IT",1);

        Employee employee = new("Sabir",20,8000);
        Employee employee2 = new("Ferid",18,7000);

        try
        {
           department.AddEmployee(employee);
           department.AddEmployee(employee2);
        }
        catch(CapacityLimitException e) 
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine(department[0]);

        foreach (var item in department.employees)
        {
            Console.WriteLine(item.ShowInfo());
        }

    }
}
