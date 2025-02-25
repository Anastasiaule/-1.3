namespace лаба_1._3
{
        public class Program
        {
            // Метод для работы с консолью
            public static void Main(string[] args)
            {
                Console.WriteLine("Введите предложение:");
                string input = Console.ReadLine();
                int count = CountAdjacentSameLetters(input);
                Console.WriteLine("Количество одинаковых соседних букв: " + count);
            }

            // Метод для подсчета одинаковых соседних букв
            public static int CountAdjacentSameLetters(string input)
            {
            string inputWithoutSpaces = input.Replace(" ", "");
            string lowerCaseInput = inputWithoutSpaces.ToLower();
            int count = 0;

                for (int i = 1; i < inputWithoutSpaces.Length; i++)
                {
                    if (inputWithoutSpaces[i] == inputWithoutSpaces[i - 1])
                    {
                        count++;
                    }
                }
                return count;
            }
        }
}
}



