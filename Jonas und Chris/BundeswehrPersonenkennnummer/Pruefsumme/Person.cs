namespace Pruefsumme
{
    internal class Person
    {
        public string vorname {  get; set; }
        public string name { get; set; }
        public string birthdate { get; set; }
        public int stateId { get; set; }

        public Person(string v, string n, string b, int stateId)
        {
            this.vorname = v;
            this.name = n;
            this.birthdate = b;
            this.stateId = stateId;
        }

        public string Personenkennziffer()
        {
            Dictionary<char, int> map = new Dictionary<char, int>
            {
                ['S'] = 4,
                ['J'] = 6,
                ['T'] = 6,
                ['K'] = 8,
                ['U'] = 8,
                ['L'] = 10,
                ['V'] = 10,
                ['A'] = 12,
                ['M'] = 12,
                ['W'] = 12,
                ['B'] = 14,
                ['N'] = 14,
                ['X'] = 14,
                ['C'] = 16,
                ['O'] = 16,
                ['Y'] = 16,
                ['D'] = 18,
                ['P'] = 18,
                ['Z'] = 18,
                ['E'] = 20,
                ['Q'] = 20,
                ['F'] = 22,
                ['R'] = 22,
                ['G'] = 24,
                ['H'] = 26,
                ['I'] = 28
            };

            string s = "";
            string ende = "";

            string datum = DateTime.ParseExact(birthdate, "dd.MM.yyyy", null).ToString("ddMMyy");
            s += datum;
            ende += datum;
            char firstChar = char.ToUpper(name.Substring(0, 1)[0]);
            
            Random random = new Random();
            int randomNumber = random.Next(100);
            s += "-" + firstChar + "-" + stateId;
            if (randomNumber < 10) {
                s += 0;
            }
            s += randomNumber;
            ende += randomNumber;

            int sum = 0;
            foreach(char c in ende)
            {
                string str = Convert.ToString(c);
                int i = Int32.Parse(str);
                sum += i;
            }
            sum += map[firstChar];
            sum = 11 - Convert.ToInt32(sum / 11);
            s += sum;
            return s;
        }
    }
}
