using System;

namespace ConsoleApp7
{
    class Program
    {

        public delegate bool Eded<T>(T num);

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Action<int> calc = Menfi;
            calc.Invoke(number);
            Action<int> calc1 = Tek;
            calc1.Invoke(number);
            Action<int> calc2 = Sade;
            calc2.Invoke(number);

        }




        public static void Menfi(int n)
        {
            if( n < 0)
            {
                Console.WriteLine("daxil edilen eded menfidir");
            }
        }
        public static void Tek(int n)
        {
            if( n % 2 != 0)
            {
                Console.WriteLine("daxil edilen eded tekdir");
            }
            else
            {
                Console.WriteLine("daxil edilen eded cutdur");
            }
        }
        public static void Sade(int n)
        {
            if ( n % n ==1)
            {
                Console.WriteLine("eded sadedir ");
            }
        }
    }
}
