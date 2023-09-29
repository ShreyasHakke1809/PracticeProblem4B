namespace PracticeProblems4B
{
    internal class RectanglePattern
    {
        public static void Pattern()
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (i == 1 || i == 7 || j == 1 || j == 7)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
