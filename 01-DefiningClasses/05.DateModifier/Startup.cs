namespace DateModifier
{
    using System;
    public class Startup
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine().Split(' ');
            var secondInput = Console.ReadLine().Split(' ');
            var firstDate = new DateTime(int.Parse(firstInput[0]), int.Parse(firstInput[1]), int.Parse(firstInput[2]));
            var secondDate = new DateTime(int.Parse(secondInput[0]), int.Parse(secondInput[1]), int.Parse(secondInput[2]));

            var dateModifier = new DateModifier
            {
                StartDate = firstDate,
                EndDate = secondDate
            };

            Console.WriteLine(dateModifier.GetNumberOfDaysBetweenDates());
        }
    }
}
