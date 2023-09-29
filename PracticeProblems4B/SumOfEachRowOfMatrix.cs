namespace PracticeProblems4B
{
    internal class SumOfEachRowOfMatrix
    {
        static int i, j, m, n;
        static int[,] a = new int[20, 20];
        public static void getmatrix()
        {

            Console.WriteLine("Enter The Number of Rows : ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number of Columns : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Given Matrix");
            for (i = 1; i <= m; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write("\t{0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void Row()
        {
            int r;
            for (i = 1; i <= m; i++)
            {
                r = 0;
                for (j = 1; j <= n; j++)
                {
                    r = r + a[i, j];
                }
                Console.WriteLine("{0} Row Sum : {1}", i, r);
            }
        }
    }
}
