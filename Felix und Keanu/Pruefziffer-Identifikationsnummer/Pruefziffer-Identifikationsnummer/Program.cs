//Berechnen der Prüfsumme der Bundesweiten Identifikationsnummer
static uint B_Ident_Calc(uint[] EArray)
{
    uint m = 10;
    uint n = 11;
    uint Prod = m;

    //Falls EArray.length nicht gleich m, return 0.
    if(!(EArray.Length == m))
    {
        Console.WriteLine("Ungültige Eingabelänge.");
        return 0;
    }

    //Für jedes element in EArray ...
    for(uint i = 0; i < EArray.Length; i++)
    {
        //Rechne s := (Summe von EArray[i] + Prod) modulo m
        uint s = (EArray[i] + Prod) % m;

        //Falls s == 0, dann Prod := (2 * m) mod m sonst Prod = (2 * s) mod m
        Prod = (2 * (s == 0 ? m : s)) % n;
        Console.WriteLine($"a[i]: {EArray[i]}, summe: {s}, prod: {Prod}, s == 0: {s == 0}");
    }
    return n - Prod;
}

//String in einen uint-Array konvertieren.
static uint[] B_strtoa(string str)
{
    //Uint-Puffer mit der Länge des Parameters `str` erstellen
    uint[] ubuf = new uint[str.Length];

    //Cstring (char[]) aus dem Parameter `str` erstellen
    char[] cstr = str.ToCharArray();

    //Für jedes Element in dem Cstring ...
    for(int i = 0; i < cstr.Length; i++)
    {
        //Dem Uint-Puffer den Wert des momentanen Chars als uint zuweisen
        ubuf[i] = (uint) char.GetNumericValue(cstr[i]);
    }
    return ubuf;
}

static int main()
{
    Console.Clear();
    Console.WriteLine("Prüfziffer Berechnen oder Abgleichen? (b/a)");
    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "b":
            Console.WriteLine("Bitte Produktcode eingeben (10 Zeichen).");
            Console.WriteLine($"Prüfsumme: {B_Ident_Calc(B_strtoa(Console.ReadLine() ?? ""))}");
            break;
        case "a":
            Console.WriteLine("Bitte Prüfsumme eingeben.");
            uint checksum = B_strtoa(Console.ReadLine() ?? "")[0];
            Console.WriteLine("Bitte Produktcode eingeben.");
            Console.WriteLine(B_Ident_Calc(B_strtoa(Console.ReadLine() ?? "")) == checksum ? "Prüfsumme korrekt." : "Prüfsumme fehlerhaft.");
            break;
        default:
            Console.WriteLine("Ungültige Auswahl!");
            break;
    }

    Console.ReadLine();
    main();
    return 0;
}
main();