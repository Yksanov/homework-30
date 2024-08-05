using System.Collections;

namespace OPP_lesson30;

public class MyEmployeeEnumerator : IEnumerator<Employee>
{
    private int _index = -1;
    public MyEmployee _myEmployee;

    public MyEmployeeEnumerator(MyEmployee myEmployee)
    {
        _myEmployee = myEmployee;
    }

    public bool MoveNext()
    {
        return ++_index < _myEmployee.Employees.Length;
    }

    public void Reset()
    {
        _index = -1;
    }

    public Employee Current => _myEmployee.Employees[_index];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        Console.WriteLine("Done Employee!");
    }
}