using System;

namespace konsol_programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("isminizi girin:");
            var name = Console.ReadLine();
            Console.WriteLine("soyadinizi girin:");
            var surname = Console.ReadLine();

            Console.WriteLine ( " merhaba " + name + " " + surname);
            //alı gorgun
        }   
    }
}
