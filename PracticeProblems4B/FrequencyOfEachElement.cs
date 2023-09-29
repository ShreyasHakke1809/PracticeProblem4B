namespace PracticeProblems4B
{
    internal class FrequencyOfEachElement
    {
        public static void Frequency()
        {
            int freq = 0;
            int count = 0;
            Console.WriteLine("Arry size");
            int arr = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arr];
            Console.WriteLine("Add elements in array");
            for (int i = 0; i < arr; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter element to find frequency");
            int key = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr; i++)
            {
                if (array[i] == key)
                {
                    count++;
                }
            }
            Console.WriteLine("Frequency {0} is {1}:", key, count);
        }
    }
}
