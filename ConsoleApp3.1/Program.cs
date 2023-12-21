using System;

namespace ConsoleApp3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metni daxil et: ");
            string text = Console.ReadLine();

            bool check = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'A')
                {
                    check = true;
                    break;
                }
            }

            if (check)
            {
                Console.WriteLine(" A herfi var.");
            }
            else
            {
                Console.WriteLine(" A herfi yoxdur.");
            }
        }
    }
}
