using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Personnummer
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Eingabe des Geburtsjahres
            Console.Write("Bitte geben Sie Ihr Geburtsjahr ein (JJ): ");
            int year = int.Parse(Console.ReadLine());

            //Eingabe des Geburtsmonats
            Console.Write("Bitte geben Sie Ihr Geburtsmonat ein (MM): ");
            int month = int.Parse(Console.ReadLine());

            //Eingabe des Geburtstags
            Console.Write("Bitte geben Sie Ihr Geburtstag ein (TT): ");
            int day = int.Parse(Console.ReadLine());

            //Überprüfen der Eingabe
            if (month > 12 || day > 31)
            {
                Console.Clear();
                Console.WriteLine("Eingabe des Datums ist falsch! Versuche es erneut!\n");
                Main(args);
            }

            //Zufällige Geburtsnummer erstellen
            Random rand = new Random();
            int serial = rand.Next(1, 1000);

            //Berechnen der Prüfziffer
            int checksum = CalculateChecksum(year, month, day, serial);

            //Ausgabe der Personnummer
            Console.WriteLine($"Die schwedische Personnummer lautet: {year}{month:00}{day:00}-{serial:000}{checksum}");
            Console.ReadLine();
        }

        static int CalculateChecksum(int year, int month, int day, int serial)
        
        {
            // Gewichtung für die Berechnung der Prüfsumme
            int[] factors = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int sum = 0;

            
            // Geburtsdatum auf 8-stellige Zahl reduzieren
            year %= 100;
            if (year >= 40) year -= 40;
            month--; //Verringerung des Monats um 1, da bei der Prüfziffernberechnung Januar = 0, Februar = 1, usw. ist
            

            // Ziffern der Personnummer mit Faktoren multiplizieren und aufsumieren
            sum += year / 10 * factors[0];
            sum += year % 10 * factors[1];
            sum += month / 10 * factors[2];
            sum += month % 10 * factors[3];
            sum += day / 10 * factors[4];
            sum += day % 10 * factors[5];
            sum += serial / 100 * factors[6];
            sum += serial % 100 / 10 * factors[7];
            sum += serial % 10 * factors[8];

            // Prüfziffer berechnen
            int checksum = 10 - sum % 10;
            if (checksum == 10) checksum = 0;

            return checksum;
        }
    }
}