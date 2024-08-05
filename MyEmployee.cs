using System.Collections;

namespace OPP_lesson30;

public class MyEmployee : IEnumerable<Employee>
{
    public Employee[] Employees { get; set; }

    public MyEmployee(Employee[] employees)
    {
        Employees = employees;
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        for (int i = 0; i < Employees.Length; i++)
        {
            yield return Employees[i]; // used yield
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}