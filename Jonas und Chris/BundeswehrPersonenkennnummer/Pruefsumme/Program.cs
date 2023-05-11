using Pruefsumme;
using System.Runtime.ConstrainedExecution;

class Program
{
    public static void Main(string[] args)
    {
        string[] states =
        {
            "Schleswig-Holstein und Hamburg",
            "Niedersachsen und Bremen",
            "Nordrhein-Westfalen",
            "Rheinland-Pfalz, Saarland und Hessen",
            "Baden-Württemberg",
            "Bayern",
            "Mecklenburg-Vorpommern, Thüringen, Sachsen, Sachsen-Anhalt, Brandenburg und Berlin",
            "Bundesamt für das Personalmanagement der Bundeswehr"
        };

        Console.Write("Vorname: ");
        string v = Console.ReadLine();
        Console.Write("Nachname: ");
        string n = Console.ReadLine();
        Console.Write("Geburtsdatum (01.01.2000): ");
        string b = Console.ReadLine();
        Console.WriteLine("Wähle dein Bundesland:");
        for(int i = 0; i<states.Length;i++)
        {
            Console.WriteLine(Convert.ToString(i + 1) + " = " + states[i]);
        }
        int stateId = Convert.ToInt32(Console.ReadLine());
        
        Person p = new Person(v,n,b,stateId);
        Console.WriteLine(p.Personenkennziffer());
    }
}