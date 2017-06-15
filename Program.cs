using System;


namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {
                int Remainder = Number % 10;
                Reverse = (Reverse * 10) + Remainder;
                Number = Number / 10;

            }
            Console.WriteLine("Reverse Number:" + Reverse);
            Console.ReadLine();
        }
    }
}
