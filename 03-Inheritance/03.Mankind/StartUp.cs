using System;

public class StartUp
{
    static void Main()
    {
        try
        {
            var studentInfo = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
            var workerInfo = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), decimal.Parse(workerInfo[3]));

            Console.WriteLine($"{student.GetStudentInfo()}\n\n{worker.GetWorkerInfo()}");

        }
        catch (Exception ae)
        {
            Console.WriteLine(ae.Message);
        }


    }
}
