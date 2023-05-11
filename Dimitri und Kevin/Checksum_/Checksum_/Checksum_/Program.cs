using System.Diagnostics;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {   
        //Übergabe der Ländercodes
        string[] Codes = { "DE", "US", "AT", "GB", "JP", "AU", "BR", "DK", "FI", "RU", "IN", "IS", "KR", "NL", "NO", "PL", "VN", "CX"};

        //Console.WriteLine(generate_checksum(Codes));

        //Specifications
        bool generate = false;
        bool check = false;
        bool selfdestruct = false;
        bool shutdown = false;

        //Crystalyse Specifications
        foreach (string arg in args) {
            //
            if (arg == "generate") {
                generate = true;
            }
            //
            if (arg == "check") {
                check = true;
            }
            //
            if (arg == "selfdestruct"){
                selfdestruct = true;
            }
            //
            if (arg == "wimpywimpywimpy"){
                shutdown = true;
            }
            //
        }
        if (generate && check) {
            throw new NotImplementedException("Es ist nicht möglich 'check' und 'generate' zeitgleich zu verwenden!");
        }

        if (generate) {
            Console.WriteLine(generate_checksum(Codes));
        }
        if (check){
            Console.WriteLine(check_checksum(args[1]));
        }
        if (selfdestruct){
            for(int i = 0; i < 10; i++) {
                Console.Beep(1000, 1000);
            }
        }
        if (shutdown){
            Process.Start("shutdown", "/s /t 0");
        }
    }
    static private string generate_checksum(string[]Codes){
        Ländercodes lco = new Ländercodes(Codes);
        Random rnd = new Random();
        string generated_checksum = lco.lco[rnd.Next(Codes.Length)] + rnd.Next(10) + rnd.Next(10) + rnd.Next(10) + rnd.Next(10) + rnd.Next(10) + rnd.Next(10) + rnd.Next(10) + rnd.Next(10) + rnd.Next(10);

        string anzuhängende_prüfziffer = check_checksum(generated_checksum, true);
        generated_checksum = generated_checksum + anzuhängende_prüfziffer;

        return generated_checksum;
    }
    static private string check_checksum(string checksum, bool get_checksum = false){
        string valid = "false";

        //Console.WriteLine(checksum);

        char extrahierte_prüfziffer = checksum[checksum.Length - 1];

        string checksum_code_string = checksum.Substring(2);

        if (!get_checksum){
            checksum_code_string = checksum_code_string.Remove(checksum_code_string.Length - 1, 1); //letzte Stelle entfernen
        }

        long checksum_code = long.Parse(checksum_code_string);
        char first_lco = checksum[0];
        char second_lco = checksum[1];

        int first_lco_num = (int)first_lco - 55; //Alphabetstelle + 10
        int second_lco_num = (int)second_lco - 55; //Alphabetstelle + 10

        string kleben =  first_lco_num.ToString() + second_lco_num.ToString() + checksum_code.ToString(); // Klebt alles zu einem Long zusammen

        //checksum_code = long.Parse(kleben);

        string produktstring = "";
        for (int i = 0; i < kleben.Length; i++){
            string parse = kleben[i].ToString(); //CHAR TO STRING
            int number = int.Parse(parse); //STRING TO INT

            if(i % 2 == 0) { //Gerade Zahlen x 2 multiplizieren

                number = number;
                
            }else{ //Ungerade Zahlen x 1 multiplizieren

                number = number * 2;

            };
            produktstring = produktstring + number.ToString();
        };

        int quersumme = 0;
        for (int i = 0; i < produktstring.Length; i++){
            quersumme = quersumme + int.Parse(produktstring[i].ToString());
        };

        int prüfziffer = (10 - (quersumme % 10)) % 10;

        //Im falle das ich die Prüfziffer haben will
        if (get_checksum){
            return prüfziffer.ToString();
        }

        if (prüfziffer == (int)extrahierte_prüfziffer -48){
            valid = "true";
        }

        return valid;
    }

}
class Ländercodes {
    public string[] lco;
    public Ländercodes(string[] lco){
      this.lco = lco;
    }
}