namespace PracticeProblems4B
{
    internal class MaxAndMinElement
    {
        public static void MaxAndMin()
        {
            int i, max, min;
            Console.WriteLine("Please declare the size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Please add elements in array");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Max value of array is:" + max);
            Console.WriteLine("Min value of array is:" + min);
        }
    }
}
