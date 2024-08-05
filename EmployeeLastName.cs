namespace OPP_lesson30;

public class EmployeeLastName : IComparer<EmployeeLastName>
{
    public string _LastName;

    public EmployeeLastName(string lastName)
    {
        _LastName = lastName;
    }

    public int Compare(EmployeeLastName? x, EmployeeLastName? y)
    {
        return string.Compare(x._LastName, y._LastName);
    }
}