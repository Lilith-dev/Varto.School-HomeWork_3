using System.Text;

namespace Homework_03
{
    class MainClass
    {
        public static void task_3()
        {
            Console.Write("Введіть текст: ");
            string inputText = Console.ReadLine();
            int characterCount = inputText.Length;
            Console.WriteLine($"Кількість символів у введеному рядку: {characterCount}");


            Console.Write("Введіть символ для пошуку у рядку: ");
            char targetChar = Console.ReadLine()[0];

            int countCaseInsensitive = 0;
            int countCaseSensitive = 0;

            foreach (char c in inputText)
            {
                if (char.ToLower(c) == char.ToLower(targetChar))
                {
                    countCaseInsensitive++;
                }

                if (c == targetChar)
                {
                    countCaseSensitive++;
                }
            }

            Console.WriteLine($"Знайдено {countCaseInsensitive} разів символ '{char.ToLower(targetChar)}' або '{char.ToUpper(targetChar)}'.");
            Console.WriteLine($"Знайдено {countCaseSensitive} разів символ '{char.ToLower(targetChar)}'.");

        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            task_3();
        }
    }
}