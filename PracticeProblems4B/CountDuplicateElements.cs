namespace PracticeProblems4B
{
    internal class CountDuplicateElements
    {
        public static void Duplicate()
        {
            int count = 0;
            Console.WriteLine("Arry size");
            int arr = Convert.ToInt32(Console.Read());

            int[] array = new int[arr];
            Console.WriteLine("Add elements in array");
            for (int i = 0; i < arr; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Duplicate Elements:");
            for (int i = 0; i < arr; i++)
            {
                for (int j = i + 1; j < arr; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.Write(array[i] + " ");
                    }
                }
            }
        }
    }
}
