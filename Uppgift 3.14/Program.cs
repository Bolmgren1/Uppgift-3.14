using System;

namespace Inlämningsuppgift

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? (Ja eller Nej)");
            Console.Write("Svara här:  "); string svar1 = Console.ReadLine().ToLower();
            Console.WriteLine("Hur gammal är du?");
            Console.Write("Svara här:  "); int svar2 = int.Parse(Console.ReadLine());

            char[] svar = svar1.ToCharArray();

            if (svar[1] == 'j' && svar2 < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig.");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");


            }
        }
    }
}
