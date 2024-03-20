using System.Text;

namespace Homework_03
{
    class MainClass
    {
        public static void task_4()
        {
            char startLetter = 'a', endLetter = 'z';
            int startLetterCode = Convert.ToInt32(startLetter), endLetterCode = Convert.ToInt32(endLetter);


            int arrayLenth = endLetterCode - startLetterCode + 1;

            char[] charArray = new char[arrayLenth];

            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = Convert.ToChar(i + startLetterCode);
            }
            Console.WriteLine("Letter\tASCII code");
            foreach (char symbol in charArray)
            {
                Console.WriteLine($"{symbol}\t{Convert.ToInt32(symbol)}");
            }

        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            task_4();
        }
    }
}