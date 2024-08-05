namespace OPP_lesson30;

public class EmployeeSalary : IComparer<EmployeeSalary>
{
    public double _Salary;

    public EmployeeSalary(double salary)
    {
        _Salary = salary;
    }

    public int Compare(EmployeeSalary? x, EmployeeSalary? y)
    {
        if (x._Salary > y._Salary)
            return 1;
        if (x._Salary == y._Salary)
            return 0;
        return -1;
    }
}