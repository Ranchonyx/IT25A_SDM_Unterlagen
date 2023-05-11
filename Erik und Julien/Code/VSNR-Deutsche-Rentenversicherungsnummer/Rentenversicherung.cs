using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

class Rentenversicherungsnummer
{
    static bool Case = false;

    static void Main(string[] args)
    {
        int auswahl = 0;

        // Schleife, die es dem Benutzer ermöglicht, mehrere Aktionen auszuführen, bevor das Programm beendet wird
        while (true)
        {
            Console.WriteLine("Wählen Sie eine Option:");
            Console.WriteLine("1. Prüfziffer einer Rentenversicherungsnummer berechnen");
            Console.WriteLine("2. Rentenversicherungsnummer generieren");
            Console.WriteLine("3. Programm beenden");
            Console.Write("Geben Sie 1, 2 oder 3 ein: ");
            auswahl = int.Parse(Console.ReadLine());

            // Eingabe der Benutzerwahl
            switch (auswahl)
            {
                case 1:     // Wenn der Benutzer die Prüfziffer einer vorhandenen Rentenversicherungsnummer berechnen möchte, wird die Prüfzifferberechnung auf die letzten beiden Stellen beschränkt
                    Case = true;
                    Console.Write("Geben Sie die ersten 12 Stellen der Rentenversicherungsnummer ein: ");
                    string nummer = Console.ReadLine();
                    int pruefziffer = BerechnePruefziffer(nummer);
                    Console.WriteLine("Die Prüfziffer ist: " + pruefziffer);
                    break;

                case 2:     // Wenn der Benutzer eine neue Rentenversicherungsnummer generieren möchte, wird die Prüfzifferberechnung auf alle Stellen angewendet
                    Case = false;
                    Console.WriteLine("Generierte Rentenversicherungsnummer: " + GeneriereRentenversicherungsnummer());
                    break;

                case 3:      // Das Programm wird beendet, wenn der Benutzer diese Option wählt
                    Console.WriteLine("Programm wird beendet.");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
            Console.WriteLine(); // Fügt eine leere Zeile hinzu, um den Programmablauf übersichtlicher zu gestalten.
        }
    }


    /// <summary>
    /// Generiert eine Rentenversicherungsnummer basierend auf den Benutzereingaben.
    /// </summary>
    /// <returns>Die generierte Rentenversicherungsnummer als Zeichenkette.</returns>
    static string GeneriereRentenversicherungsnummer()
    {
        string Bereichsnummer = "";
        string bereinigtesGeburtsdatum = "";
        string Geburtsname = "";
        string Seriennummer = "";

        // Eingabe der Bereichsnummer
        while (true)
        {
            Console.Write("Geben Sie Ihre Bereichsnummer im Format XX ein: ");
            Bereichsnummer = Console.ReadLine();
            if (Bereichsnummer.Length != 2)
            {
                Console.WriteLine("Fehler: Der eingegebene Text muss genau 2 Zeichen lang sein.");
            }
            else
            {
                Console.WriteLine("Ihre eingegebene Bereichsnummer ist: " + Bereichsnummer);
                break;
            }
        }

        // Eingabe des Geburtsdatums
        while (true)
        {
            Console.Write("Geben Sie Ihr Geburtsdatum im Format TT.MM.JJ ein: ");
            string Geburtsdatum = Console.ReadLine();
            bereinigtesGeburtsdatum = Geburtsdatum.Replace(".", "");
            if (bereinigtesGeburtsdatum.Length != 6)
            {
                Console.WriteLine("Fehler: Der eingegebene Text muss genau 6 Zeichen lang sein.");
            }
            else
            {
                Console.WriteLine("Ihr eingegebenes Geburtsdatum ist: " + Geburtsdatum);
                break;
            }
        }

        // Eingabe des ersten Buchstabens des Geburtsnamens
        while (true)
        {
            Console.Write("Geben Sie Ihren ersten Buchstaben des Geburtsnames ein: ");
            Geburtsname = Console.ReadLine();
            if (Geburtsname.Length != 1)
            {
                Console.WriteLine("Fehler: Der eingegebene Text muss genau 1 Zeichen lang sein.");
            }
            else
            {
                Console.WriteLine("Ihr eingegebenes Geburtsname ist: " + Geburtsname);
                break;
            }
        }

        // Eingabe der Seriennummer
        while (true)
        {
            Console.Write("Geben Sie Ihre Seriennummer im Format XX ein (00 - 49 für Männer, 50 - 99 für Frauen): ");
            Seriennummer = Console.ReadLine();
            if (Seriennummer.Length != 2)
            {
                Console.WriteLine("Fehler: Der eingegebene Text muss genau 2 Zeichen lang sein.");
            }
            else
            {
                Console.WriteLine("Ihre eingegebenes Seriennummer ist: " + Seriennummer);
                break;
            }
        }

        // Berechnung der Prüfziffer
        int pruefziffer = BerechnePruefziffer($"{Bereichsnummer:D2}{bereinigtesGeburtsdatum:D3}{Geburtsname:D1}{Seriennummer:D2}");

        // Rückgabe der generierten Rentenversicherungsnummer
        return $"{Bereichsnummer:D2}{bereinigtesGeburtsdatum:D3}{Geburtsname:D1}{Seriennummer:D2}{pruefziffer}";
    }


    /// <summary>
    /// Berechnet die Prüfziffer einer Rentenversicherungsnummer.
    /// </summary>
    /// <param name="inputNumber">Die Rentenversicherungsnummer als Zeichenkette.</param>
    /// <returns>Die berechnete Prüfziffer als Ganzzahl.</returns>
    static int BerechnePruefziffer(string inputNumber)
    {
        int[] gewichtung = { 2, 1, 2, 5, 7, 1, 2, 1, 2, 1, 2, 1 };
        int pruefziffer = 0;
        int result = 0;

        if (Case == true)
        {
            // Speichere die letzten zwei Zeichen in einer neuen Variable
            string letzteZweiZeichen = inputNumber.Substring(inputNumber.Length - 1);

            // Entferne die letzten zwei Zeichen aus dem ursprünglichen String
            inputNumber = inputNumber.Remove(inputNumber.Length - 1);
        }

        // Ersetze Buchstaben durch Zahlen
        StringBuilder Number = new StringBuilder();
        foreach (char c in inputNumber)
        {
            if (char.IsLetter(c))
            {
                int position = char.ToUpper(c) - 'A' + 1;
                Number.Append(position.ToString().PadLeft(1, '0'));
            }
            else
            {
                Number.Append(c);
            }
        }

        //Berechnung der Prüfziffer
        if (Number.Length != gewichtung.Length)
        {
            Console.WriteLine("Die Länge der Eingabeziffern sollte der Länge der Gewichtung entsprechen.");
        }

        for (int i = 0; i < Number.Length; i++)
        {
            //Rentennummer wir mit der Gewichtung multipliziert
            int digit = int.Parse(Number[i].ToString());
            int num = digit * gewichtung[i];

            int quersumme = calcualteQuersumme(num);

            //Quersummen werden zusammen addiert
            result = result + quersumme;
        }

        pruefziffer = result % 10;  //Modulo 10 wird auf das Ergebnis der vorherigen Rechnung angewendet

        return pruefziffer;         //Prüfziffer wird zurückgegeben
    }
    private static int calcualteQuersumme(int num)
    {
        int sum = 0;
        //Aus dem Ergebnis der gewichteten Nummer wird die Quersumme gebildet
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}