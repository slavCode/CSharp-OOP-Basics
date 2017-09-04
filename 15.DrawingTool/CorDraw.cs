namespace DrawingTool
{
    using System;
    public class CorDraw
    {
        public int width;
        public int height;

        public virtual void Draw()
        {
            Console.Write("|");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("|");
            for (int i = 0; i < height - 2; i++)
            {
                Console.Write("|");
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("|");
            }

            Console.Write("|");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("|");
        }
    }
}
