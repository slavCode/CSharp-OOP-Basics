﻿using System;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WeekSalary
    {
        get => this.weekSalary; 
        private set
        {
            if (value < 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }

            this.weekSalary = value;
        }
    }

    public decimal WorkHoursPerDay
    {
        get => this.workHoursPerDay; 
        private set
        {
            if (value < 1 || value > 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }

            this.workHoursPerDay = value;
        }
    }

    public string GetWorkerInfo()
    {
        return $"{ToString()}\n" +
               $"Week Salary: {this.WeekSalary:F2}\n" +
               $"Hours per day: {this.WorkHoursPerDay:F2}\n" +
               $"Salary per hour: {(this.WeekSalary / this.WorkHoursPerDay) / 5.0m:F2}";
    }

}
