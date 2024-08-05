namespace OPP_lesson30;

public class EmployeeName : IComparer<EmployeeName>
{
    public string _Name;

    public EmployeeName(string name)
    {
        _Name = name;
    }
    
    public int Compare(EmployeeName? x, EmployeeName? y)
    {
        return string.Compare(x._Name, y._Name);
    }
}