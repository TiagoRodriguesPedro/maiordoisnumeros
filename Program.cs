using System;

namespace maiordoisnumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiro, segundo, maiornumeros;
            Console.Write(" primeiro numero..");
            primeiro = Convert.ToInt32(Console.ReadLine());

            Console.Write("segundo numero....");
            segundo = Convert.ToInt32(Console.ReadLine());

            if (primeiro>segundo)
            {
                maiornumeros = primeiro;
            }
            else
            {
                maiornumeros = segundo;
            }

            Console.WriteLine($"maior numero é {maiornumeros}");



        }
    }
}
