using System;

namespace _6hanelisifreuretme
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sayilar = new int[6];

            
            Random rastgele = new Random();

            
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(10); 
            }

            
            Console.WriteLine("Rastgele Sayılar:");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
