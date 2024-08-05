using System.Collections;
using System.Runtime.InteropServices.ComTypes;

namespace OPP_lesson30;

class Program
{
    static void Main(string[] args)
    {
         List<Employee> employees = new List<Employee>() 
             {
                 new Employee("Eldos", "Yksanov", 2002, 200000), 
                 new Employee("Dastan", "Nasirdinov", 2001, 302550), 
                 new Employee("Bayel", "Zerickov", 1985, 120050), 
                 new Employee("Ruslan", "Rahmatov", 2005, 205220)
             };
         Console.WriteLine("========== Sorted by Name ==========");
         employees.Sort((x,y) => x.Name.CompareTo(y.Name));
         employees.ForEach(i => Console.WriteLine(string.Format(" {0, -6} | {1, -10} | {2,5} | {3,5}", i.Name, i.LastName, i.Birth, i.Salary)));
         Console.WriteLine("\n========== Sorted by LastName ==========");
         employees.Sort((x,y) => x.LastName.CompareTo(y.LastName));
         employees.ForEach(i => Console.WriteLine(string.Format(" {0, -6} | {1, -10} | {2,5} | {3,5}", i.Name, i.LastName, i.Birth, i.Salary)));
         Console.WriteLine("\n========== Sorted by Birth ==========");
         employees.Sort((x,y) => x.Birth.CompareTo(y.Birth));
         employees.ForEach(i => Console.WriteLine(string.Format(" {0, -6} | {1, -10} | {2,5} | {3,5}", i.Name, i.LastName, i.Birth, i.Salary)));
         Console.WriteLine("\n========== Sorted by Salary ==========");
         employees.Sort((x,y) => x.Salary.CompareTo(y.Salary));
         employees.ForEach(i => Console.WriteLine(string.Format(" {0, -6} | {1, -10} | {2,5} | {3,5}", i.Name, i.LastName, i.Birth, i.Salary)));
        
        Console.WriteLine("\n========== MyEmployee Collection ==========");  //task#2
        MyEmployee myEmployee = new MyEmployee(employees.ToArray());
        foreach (var i in myEmployee)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\n===== MyEmployee Collection with IEnumerator =====");
        IEnumerator<Employee> emp = myEmployee.GetEnumerator();
        while (emp.MoveNext())
        {
            Console.WriteLine(emp.Current);
        }
    }
}