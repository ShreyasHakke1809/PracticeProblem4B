namespace PracticeProblems4B
{
    internal class PrintUniqueElements
    {
        public static void Unique()
        {
            Console.WriteLine("Arry size");
            int arr = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arr];
            Console.WriteLine("Add elements in array");
            for (int i = 0; i < arr; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Unique elements are");

            for (int i = 0; i < arr; i++)
            {
                int count = 0;

                for (int j = 0; j < arr; j++)
                {
                    if (i != j)
                    {
                        if (array[i] == array[j])
                        {
                            count++;
                        }
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
