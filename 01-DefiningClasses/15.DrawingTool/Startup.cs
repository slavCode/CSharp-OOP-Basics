namespace DrawingTool
{
    using System;
    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            if (input == "Rectangle")
            {
                var rectangle = new CorDraw
                {
                    width = int.Parse(Console.ReadLine()),
                    height = int.Parse(Console.ReadLine())
                };

                rectangle.Draw();
                return;
            }

            else if (input == "Square")
            {
                var square = new Square(int.Parse(Console.ReadLine()));
                square.Draw();
            }
        }
    }
}
