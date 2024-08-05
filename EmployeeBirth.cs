namespace OPP_lesson30;

public class EmployeeBirth : IComparer<EmployeeBirth>
{
    public int _Birth;

    public EmployeeBirth(int birth)
    {
        _Birth = birth;
    }

    public int Compare(EmployeeBirth? x, EmployeeBirth? y)
    {
        if (x._Birth > y._Birth)
            return 1;
        if (x._Birth == y._Birth)
            return 0;
        return -1;
    }
}