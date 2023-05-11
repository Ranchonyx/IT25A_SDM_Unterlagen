class Program
{
    static void Main(string[] args)
    {
        Console.Write("Geben sie Ihre Zahl ein: ");
        bool numberIsDigit = false;
        string number = "";

        //solange der string number nicht nur aus Zahlen besteht soll eine neue Abfrage erstellt werden
        while (numberIsDigit == false)
        {
            numberIsDigit = true;
            number = Convert.ToString(Console.ReadLine());
            // liest alle Stellen aus dem String und überprüft nach Zahlen
            foreach (char c in number)
            {
                // wenn Keine Zahl soll eine neue Ausgabe erstellt werden
                if (!Char.IsDigit(c) || number == "")
                {
                    Console.Write("Geben Sie die Zahl erneut ein: ");
                    numberIsDigit = false;
                    break;
                }
            }
        }

        int checkDigit = CalculateLuhnCheckDigit(number);
        if (checkDigit != 0)
        {
            Console.WriteLine("Ungültig");
        }
        else
        {
            Console.WriteLine("Gültig");
        }
    }

    public static int CalculateLuhnCheckDigit(string number)
    {
        int sum = 0;
        bool alternate = false;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            int digit = int.Parse(number[i].ToString());

            if (alternate)
            {
                digit *= 2;
                if (digit > 9)
                {
                    digit -= 9;
                }
            }

            sum += digit;
            alternate = !alternate;
        }

        return (sum * 9) % 10;
    }
}