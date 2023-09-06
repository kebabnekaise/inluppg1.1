using System;

namespace inluppg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Denna delen skriver ut den första textbiten. Den använder WriteLine-commandot.
            Console.WriteLine("Du är nästan klar med kapitel 1.");

            //Denna delen skriver ut den andra textbiten.
            Console.WriteLine("Du har lärt dig skriva ut tecken som \" och \\");

            //Denna delen gör så att konsollen inte ska skriva ut text efter texten jag skrev.
            Console.ReadKey();
        }
    }
}