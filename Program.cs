namespace лаба_1._3
{
        public class Program
        {
            // Метод для работы с консолью
            public static void Main(string[] args)
            {
                Console.WriteLine("Введите предложение:");
                string input = Console.ReadLine();
                string inputWithoutSpaces = input.Replace(" ", "");
                string lowerCaseInput = inputWithoutSpaces.ToLower();
                int count = CountAdjacentSameLetters(lowerCaseInput);
                Console.WriteLine("Количество одинаковых соседних букв: " + count);
            }

            // Метод для подсчета одинаковых соседних букв
            public static int CountAdjacentSameLetters(string input)
            {
                int count = 0;

                for (int i = 1; i < input.Length; i++)
                {
                    if (input[i] == input[i - 1])
                    {
                        count++;
                    }
                }

                return count;
            }
        }
}



