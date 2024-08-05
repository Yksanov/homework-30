namespace OPP_lesson30;

public class Employee
{
    public string Name;
    public string LastName;
    public int Birth;
    public double Salary;

    public Employee(string name, string lastName, int birth, double salary)
    {
        Name = name;
        LastName = lastName;
        Birth = birth;
        Salary = salary;
    }

    public override string ToString()
    {
        return string.Format(" {0, -6} | {1, -10} | {2,5} | {3,5}", Name, LastName, Birth, Salary);
    }
}