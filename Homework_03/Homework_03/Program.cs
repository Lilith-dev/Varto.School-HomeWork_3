using System.Text;

namespace Homework_03
{
    class MainClass
    {
        public static void task_1()
        {
            int[] array = new int[50];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

            // int[] array2 = Enumerable.Range(0, 50).Select(x => x * 2).ToArray();

            foreach (int element in array)
            {
                Console.WriteLine($"Element: {element}");
            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            task_1();
        }
    }
}