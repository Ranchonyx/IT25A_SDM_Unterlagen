using System.Collections;
using System;

namespace FahrzeugPruefziffer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EingabeBox_TextChanged(object sender, EventArgs e)
        {

        }

        #region vergleich
        private void VergleichButton_Click(object sender, EventArgs e)
        {
            // Fehlerhafte eingaben abfangen
            EingabeErgebnis.Visible = false;
            char[] cEingabe = new char[0];
            cEingabe = EingabeBox.Text.ToCharArray();
            if (EingabeBox.Text == null || EingabeBox.Text == "" || EingabeBox.Text == " ")
            {
                System.Windows.Forms.MessageBox.Show("Leeres Feld"); 
                return;
            }
            if (EingabeBox.Text.Length > 9 || EingabeBox.Text.Length < 5)
            {
                System.Windows.Forms.MessageBox.Show("Fehlerhafte Zeichen Anzahl"); // +2 Zeichen wegen "-" und " " (Leerzeichen)
                return;
            }
            if (cEingabe[7].ToString() != "-" || (cEingabe[3].ToString() != " "))
            {
                System.Windows.Forms.MessageBox.Show("Die Eingabe ist nicht nach dem Muster aufgebaut");
                return;
            }
            //Verarbeiten der Eingabe
            int[] iZahlenArray = new int[6];
            ArrayList iZahlenListe = new ArrayList();
            
            for (int i = 0; i < 8; i++)
            {
                if (i == 3) { continue;}
                if (i == 7) { continue;}
               iZahlenListe.Add(int.Parse(cEingabe[i].ToString()));
            }
            int a = 0;
            foreach(int zahl in iZahlenListe) // Macht aus der Arraylist einen Array ohne die Sonderzeichen für die Methode
            {
                iZahlenArray[a] = zahl;
                a++;
            }
            int pruefziffer = berechnePruefziffer(iZahlenArray);
            if (pruefziffer != int.Parse(cEingabe[8].ToString())) // pruefen der eingabe pruefziffer mit der echten
            {
                System.Windows.Forms.MessageBox.Show("Falsche Prüfziffer");
                return;
            }
            EingabeErgebnis.Enabled = true;
            EingabeErgebnis.Visible = true;
        }
        #endregion
        #region generieren
        private int berechnePruefziffer(int[] iEingabe)
        {
            int[] iZahlenMultiplizieren = new[] { 8, 4, 2, 1, 5, 7, };
            for (int i = 0; i < iEingabe.Length; i++)
            {
                iEingabe[i] *= iZahlenMultiplizieren[i];
            }
            int iSumme = iEingabe.Sum(x => x) + 4;
            int pruefziffer = 0;
            if (iSumme.ToString().Length>1)
            {
                pruefziffer = QuersummeAusrechnen(iSumme, iSumme.ToString().Length);
                iSumme = pruefziffer;
                
                while (pruefziffer.ToString().Length>1) // rekursion
                {
                    pruefziffer = QuersummeAusrechnen(iSumme, iSumme.ToString().Length);
                }
            }
            return pruefziffer;
        }

        private int QuersummeAusrechnen(int summe, int länge)
        {
            int quersumme = 0;
            int[] summeElemente = new int[länge];
            for (int i = 0; i < länge; i++)
            {
                char[] zwischenergebnis = summe.ToString().ToArray(); // Zahl -> string -> char array
                summeElemente[i] = int.Parse(zwischenergebnis[i].ToString()); // char array -> int array 

                quersumme += summeElemente[i];
            }
            return quersumme;
        }
        private void GenerierenButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] iMultiplizierteZahlen = new int[6];
            int[] iUrspruenglicheZahlen = new int[6];
            string fahrzeugnummer = "";
            for (int i = 0; i < 6; i++)
            {
                iMultiplizierteZahlen[i] = rnd.Next(1, 10);
                iUrspruenglicheZahlen[i] = iMultiplizierteZahlen[i];
            }
            int pruefziffer = berechnePruefziffer(iMultiplizierteZahlen);
            
            for (int i = 0; i < 7; i++) 
            {
                if (i == 3) { fahrzeugnummer += " "; }
                if (i == 6) { fahrzeugnummer += "-" +pruefziffer; continue; } 
                fahrzeugnummer += iUrspruenglicheZahlen[i];
            }
            AusgabeBox.Text = fahrzeugnummer;
        }
        #endregion
    }
}