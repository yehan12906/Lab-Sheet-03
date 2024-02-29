using System;

public class Employee
{
    // Properties
    public int EmployeeID { get; }
    public string FullName { get; set; }
    public double Salary { get; private set; }

    // Constructor
    public Employee(int employeeID, string fullName, double salary)
    {
        EmployeeID = employeeID;
        FullName = fullName;
        Salary = salary;
    }

    // Method to display employee information
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Salary: ${Salary}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Employee
        Employee emp = new Employee(101, "John Doe", 50000);

        // Display employee ID using the read-only property
        Console.WriteLine($"Employee ID: {emp.EmployeeID}");

        // Update full name using the read-write property
        emp.FullName = "Jane Smith";
        Console.WriteLine($"Updated Full Name: {emp.FullName}");

        // Attempt to modify the salary directly from external code
        // This will result in a compilation error because Salary has a private set
        // emp.Salary = 60000; // Uncommenting this line will result in a compilation error

        // Display employee information
        emp.DisplayEmployeeInfo();
    }
}