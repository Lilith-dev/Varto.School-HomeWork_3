using System.Text;

namespace Homework_03
{
    class MainClass
    {
        public static void task_2()
        {
            Random random = new Random();

            int length = random.Next(24, 51);

            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            Console.Write("Числа у масиві: ");
            int evenCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(", ");
                }
                if (array[i] % 2 == 0)
                {
                    evenCount++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Кількість парних чисел у масиві: {evenCount}");

            Console.Write("Парні числа у масиві: ");
            for (int i = 0, even_j = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write(array[i]);
                    even_j++;
                    if (even_j != evenCount)
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.WriteLine();

        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            task_2();
        }
    }
}