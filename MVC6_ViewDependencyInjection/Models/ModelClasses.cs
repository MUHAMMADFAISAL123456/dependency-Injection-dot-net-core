using System.Collections.Generic;

namespace MVC6_ViewDependencyInjection.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string Designation { get; set; }
    }

    public class EmployeeDatabase : List<Employee>
    {
        public EmployeeDatabase()
        {
            Add(new Employee() { EmpNo = 101, EmpName = "Ajay", Salary = 50000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 102, EmpName = "Akash", Salary = 20000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 103, EmpName = "Brijesh", Salary = 45000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 104, EmpName = "Bhairav", Salary = 23000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 105, EmpName = "Chinmay", Salary = 13000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 106, EmpName = "Chaitanya", Salary = 56000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 107, EmpName = "Deepak", Salary = 76000, Designation = "Manager" });
            Add(new Employee() { EmpNo = 108, EmpName = "Dinesh", Salary = 29000, Designation = "Lead" });
            Add(new Employee() { EmpNo = 109, EmpName = "Eshwar", Salary = 98000, Designation = "Clerk" });
            Add(new Employee() { EmpNo = 110, EmpName = "Eknath", Salary = 23000, Designation = "Manager" });
        }
    }
}