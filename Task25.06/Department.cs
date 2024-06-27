namespace Task25_06;

internal class Department
{
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    public Employee[] employees;
    public Department(string name, int employeeLimit)
    {
        employees = new Employee[0];
        Name = name;
        EmployeeLimit = employeeLimit;
    }
    public Employee this[int index]
    {
        get => employees[index];
        set => employees[index] = value;
    }
    public void AddEmployee(Employee employee)
    {
        if (employees.Length == EmployeeLimit)
        {
            throw new CapacityLimitException("Department doludur");
        }
        else
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
        }
    }
}
