namespace PracticeProblems4B
{
    internal class PatternEightRowAndColumn
    {
        public static void Pattern1()
        {
            for (int i = 1; i <= 8; i++)
            {
                for (int j = i; j <= 8; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
