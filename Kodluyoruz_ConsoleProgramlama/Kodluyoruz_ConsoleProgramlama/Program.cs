using System;

namespace Kodluyoruz_ConsoleProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi girin: ");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz: ");
            string soyad = Console.ReadLine();
            Console.WriteLine("********************************");
            Console.WriteLine("Merhaba");
            Console.WriteLine("Adın: " + isim);
            Console.WriteLine("Soyadın: " + soyad);
        }
    }
}
