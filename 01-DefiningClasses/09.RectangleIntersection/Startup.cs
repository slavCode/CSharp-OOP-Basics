namespace RectangleIntersection
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    public class Startup
    {
        public static void Main()
        {
            //80-100
            var input = Console.ReadLine().Split();
            var numberOfRectangles = int.Parse(input[0]);
            var numberOfIntersections = int.Parse(input[1]);
            var rectangles = new List<Rectangle>();

            for (int i = 0; i < numberOfRectangles; i++)
            {
                var rectangleParams = Console.ReadLine().Split();
                var rectangleCoordinates = new[] { int.Parse(rectangleParams[3]), int.Parse(rectangleParams[4]) };
                var rectangle = new Rectangle(rectangleParams[0], int.Parse(rectangleParams[1]), int.Parse(rectangleParams[2]), rectangleCoordinates);
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < numberOfIntersections; i++)
            {
                var pairOfIds = Console.ReadLine().Split();
                var firstRectangle = rectangles.FirstOrDefault(r => r.id == pairOfIds[0]);
                var secondRectangle = rectangles.FirstOrDefault(r => r.id == pairOfIds[1]);
                Console.WriteLine(firstRectangle.IsRectanglesMatch(secondRectangle).ToString().ToLower());
            }
        }
    }
}
