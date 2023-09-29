namespace PracticeProblems4B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loopAgain = true;
            while (loopAgain)
            {
                Console.WriteLine("Please Choose option from given");
                Console.WriteLine("\n1.Count duplicate elements in array\n2.Print all unique elements in array\n3.Frequency of each element in array\n4.Find maximum and minimum elelment in array" +
                    "\n5.Pattern with 8 row and 8 column\n6.Rectangle pattern\n7.Reverse each word in string\n8.Sum of all digits\n9.Sum of each row of matrix\n10.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CountDuplicateElements.Duplicate();
                        break;
                    case 2:
                        PrintUniqueElements.Unique();
                        break;
                    case 3:
                        FrequencyOfEachElement.Frequency();
                        break;
                    case 4:
                        MaxAndMinElement.MaxAndMin();
                        break;
                    case 5:
                        PatternEightRowAndColumn.Pattern1();
                        break;
                    case 6:
                        RectanglePattern.Pattern();
                        break;
                    case 7:
                        ReverseWordInString.Reverse();
                        break;
                    case 8:
                        SumOfAllDigits.Digits();
                        break;
                    case 9:
                        SumOfEachRowOfMatrix.getmatrix();
                        SumOfEachRowOfMatrix.Row();
                        break;
                    case 10:
                        Environment.Exit(0);
                        break;
                    case 11:
                        loopAgain = false;
                        break;
                }
            }
        }
    }
}