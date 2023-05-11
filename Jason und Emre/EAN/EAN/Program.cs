using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAN
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.Write("Schreiben Sie einen 12-Stelligen Code ein, zu dem die Prüfziffer berechnet werden soll:");
              
            string ean = Console.ReadLine(); // Beispiel-EAN-Nummer


            if (ean.Length > 12) 
            {
                Console.WriteLine("Die Eingabe ist zu lang");
            }
            else if (ean.Length <12)
            {
                Console.WriteLine("Die Eingabe ist zu kurz");
            }
            else
            {
                berechnungZiffer(ean);
            }
                Console.ReadLine();
        }

        private static void berechnungZiffer(string code)
        {
            int sum = 0;

            // Die EAN-Prüfziffer wird nicht in die Summe aufgenommen
            for (int i = 0; i < code.Length; i++)
            {
                int num = int.Parse(code[i].ToString());
                if (i % 2 == 0)
                {
                    sum += num * 1;
                }
                else
                {
                    sum += num * 3;
                }
            }
            
            // Die nächste höhere Zehnerzahl der Summe wird berechnet
            int nextMultipleOfTen = ((sum + 9) / 10) * 10;

            // Die EAN-Prüfziffer wird berechnet
            int checksum = nextMultipleOfTen - sum;

            try
            {
                Print.PrintCode(code);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine(
                "Die EAN-Prüfziffer für " + code + " lautet: " + checksum);
        }
    }
}
