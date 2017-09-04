namespace CompanyRoster
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    public class Startup
    {
        public static void Main()
        {
            var numberOfEmployees = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var employeeInfo = Console.ReadLine().Split(' ');
                var currentEmployee = new Employee(
                    employeeInfo[0],
                    decimal.Parse(employeeInfo[1]),
                    employeeInfo[2],
                    employeeInfo[3]);

                if (employeeInfo.Length > 5)
                {
                    currentEmployee.email = employeeInfo[4];
                    currentEmployee.age = int.Parse(employeeInfo[5]);
                }

                if (employeeInfo.Length == 5)
                {
                    if (employeeInfo[4].IndexOf("@") > -1) currentEmployee.email = employeeInfo[4];
                    else currentEmployee.age = int.Parse(employeeInfo[4]);
                }

                employees.Add(currentEmployee);
            }

            var result = employees.GroupBy(e => e.department).Select(e => new
            {
                Department = e.Key,
                AverageSalary = e.Average(emp => emp.salary),
                Employees = e.OrderByDescending(emp => emp.salary)
            })
            .OrderByDescending(e => e.AverageSalary)
            .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {result.Department}");
            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.name} {employee.salary:F2} {employee.email} {employee.age}");
            }
        }
    }
}
