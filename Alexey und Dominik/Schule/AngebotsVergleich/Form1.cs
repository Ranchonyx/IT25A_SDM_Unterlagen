using System.Data.SqlClient;




namespace AngebotsVergleich
{

    public partial class Form1 : Form
    {
        #region unwichtiges
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void Felder_Leeren() // Leert eingabe Felder
        {
            textBezugspreis.Clear();
            textLieferRabatt.Clear();
            textFirma.Clear();
            textLieferSkonto.Clear();
            textListenPreis.Clear();
            textSonstRabatt.Clear();
        }
        
        private string Inhalt_pruefen(string Inhalt, string Aufruf) // Prueft Inhalt auf Logik 
        {
            int Ergebnis;
            bool success = int.TryParse(Inhalt, out Ergebnis);
            if (success)
            {
                if (Ergebnis > 100 && (Aufruf == textSonstRabatt.Name || Aufruf == textLieferRabatt.Name || Aufruf == textLieferSkonto.Name))
                {
                    Felder_Leeren();
                    System.Windows.Forms.MessageBox.Show("Ungueltige Eingabe oder mehr als 100%");
                    return "0";
                }
                return Inhalt;
            }
            Felder_Leeren();
            System.Windows.Forms.MessageBox.Show("Ungueltige Eingabe oder mehr als 100%");
            return "0";
        }

        Angebot[] AngebotNEU = new Angebot[0]; // Objekt Deklariert
        private void Erstellen_click(object sender, EventArgs e)
        {
            Array.Resize(ref AngebotNEU, AngebotNEU.Length + 1); // Array größe inkrementiert 
            // Daten bekommen
            for (int i = AngebotNEU.Length-1; i < AngebotNEU.Length; i++)
            {
                AngebotNEU[i] = new Angebot // füllen von Werten 
                {
                    Firma = textFirma.Text,
                    Bezugspreis = int.Parse(textBezugspreis.Text),
                    Lieferskonto = int.Parse(Inhalt_pruefen(textLieferSkonto.Text, textLieferSkonto.Name)),
                    Listeneinkaufspreis = int.Parse(textListenPreis.Text),
                    Lieferrabatt = int.Parse(Inhalt_pruefen(textLieferRabatt.Text, textLieferRabatt.Name)),
                    SonstRabatt = int.Parse(Inhalt_pruefen(textSonstRabatt.Text, textSonstRabatt.Name))
                };

                
                // Füllen der Tabelle            
                BindingSource binding = new BindingSource();
                binding.DataSource = AngebotNEU;
                dataGridView1.DataSource = binding;
            }
            System.Windows.Forms.MessageBox.Show("Angebot angelegt");
            Felder_Leeren();
            #region sql
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=AngebotVergleich;");

            SqlCommand selectCommand = new SqlCommand("SELECT Firma FROM dbo.Angebot",conn);
            selectCommand.Connection.Open();
            SqlDataReader sqlReader;
            try
            {
                sqlReader = selectCommand.ExecuteReader();
                if (sqlReader.Read())
                {
                    SqlLabel.Text = sqlReader.GetString(0);
                }
            }
            catch
            {
                Console.WriteLine("Error occurred while attempting SELECT.");
            }
                selectCommand.Connection.Close();
            #endregion
        }

        private void Vergleichen_Click(object sender, EventArgs e) // Mathe
        {
        foreach (Angebot Iteration in AngebotNEU)
            {
                float zieleinkaufspreis;
                float bareinkaufspreis;
                float bezugspreis;

                // Formel
                zieleinkaufspreis = Iteration.Listeneinkaufspreis - ((Iteration.Listeneinkaufspreis / 100) * Iteration.Lieferrabatt);
                bareinkaufspreis = zieleinkaufspreis - ((zieleinkaufspreis / 100) * Iteration.Lieferrabatt);
                bezugspreis = bareinkaufspreis + Iteration.Bezugspreis;
                Iteration.Wert = bezugspreis;
            }
            Angebot AngebotMin = AngebotNEU.MinBy(x => x.Wert); // Kleinstes Angebot
            BindingSource binding2 = new BindingSource();
            binding2.DataSource = AngebotMin;
            dataGridView2.DataSource = binding2; // Werte für die andere Tabelle
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}