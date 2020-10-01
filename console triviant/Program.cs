using System;
using System.Text.Json;

namespace console_triviant
{
    class Program
    {
        static int score = 0; // aantal vragen goed
        static string vraag = "in welk jaar overleed de zanger Micheal Jackson"; //vraag
        static string[] antwoorden = { "2002", "2009", "2010", "2011" }; //array met multi
        static int juisteAntwoord = 1; // index in array antwoorden van het juiste antwoord

        static void showvraag(int Nr)
        {
            Console.WriteLine("vraag" + Nr + ":");
            Console.WriteLine(vraag);
            Console.WriteLine("");

            showvraag(1);



        }
        static void showAntwoorden()
        {
            int teller = 0;
            foreach (string antwoord in antwoorden) ;
            {
                teller++;
                Console.WriteLine((teller) + ". " + antwoord);
            }

            Console.WriteLine("");
            Console.WriteLine("type uw keuze : 1,2,3 of 4");
        }

        main showAntwoorden();
        int antwoord = int.Parse(Console.ReadLine());

        static int checkAntwoord(int antw);
 {
          if (antw == juisteAntwoord + 1)
          {
             return 1;
          }
             else if (antw > 4)
          {
             return 99;
          }
        else 
        {
            return 0;
        }
}






        static void Main(string[] args)
        {
            Console.WriteLine("welkom bij triviant");
            Console.WriteLine("je ziet een vraag op het scherm");
            Console.WriteLine("je ziet vier antwoorden");
            Console.WriteLine("kies het juiste antwoord em je krijgt gelijk" + "resultaat. zullen we beginnen, geef dan enter.");
            Console.ReadLine();
        }
    }
}
