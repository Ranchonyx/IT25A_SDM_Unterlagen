using System.Diagnostics;

namespace Pruefziffer
{
    public partial class Pruefziffer : Form
    {
        bool modusBerechnen = true;
        // prüfziffer generieren und überprüfen
        //bsp: 3400 0000 0000 009 
        public Pruefziffer()
        {
            InitializeComponent();
            lbl_check_status.Text = null;
        }
        private void mtb_ziffer_KeyPress(object sender, KeyPressEventArgs e)
        { if (e.KeyChar == (char)Keys.Enter) CheckZiffer(); }
        private void btn_check_Click(object sender, EventArgs e)
        { if (!CheckZiffer()) { lbl_check_status.Text = "error"; lbl_check_status.ForeColor = Color.Red; } }

        private bool CheckZiffer()
        {
            string nummer = mtb_nummer.Text;
            nummer = nummer.Replace("-", "");
            if (mtb_nummer.Text.Contains(" "))
                return false;
            int pruefzifferEingabe = nummer.Select(c => int.Parse(c.ToString())).Last();
            if (!modusBerechnen) nummer = nummer.Remove(nummer.Length - 1, 1);
            int[] ziffern = nummer.Select(c => int.Parse(c.ToString())).ToArray();
            string faktor = mtb_faktor.Text;
            faktor = faktor.Replace("-", "");
            int[] faktoren = faktor.Select(c => int.Parse(c.ToString())).ToArray();
            int pruefziffer = PruefzifferBerechnen(ziffern, faktoren);
            tb_pruefziffer.Text = pruefziffer.ToString();
            mtb_nummer_new.Text = nummer + pruefziffer.ToString();
            if (!modusBerechnen)
            {
                Debug.WriteLine("last ziffer " + pruefzifferEingabe);
                if (pruefzifferEingabe == pruefziffer)
                {
                    lbl_check_status.Text = "Prüfziffer richtig";
                    lbl_check_status.ForeColor = Color.Green;
                }
                else
                {
                    lbl_check_status.Text = "Prüfziffer falsch";
                    lbl_check_status.ForeColor = Color.Red;
                }
            }
            return true;
        }

        private int PruefzifferBerechnen(int[] ziffer, int[] faktor)
        {
            int[] summe = new int[ziffer.Length];
            int[] quersumme = new int[ziffer.Length];

            for (int i = 0; i < ziffer.Length; i++)
            {
                summe[i] = ziffer[i] * faktor[i];
                int tempSumme = summe[i];
                while (tempSumme > 0)
                {
                    quersumme[i] += tempSumme % 10;
                    tempSumme /= 10;
                }
                //Debug.WriteLine(ziffer[i] + " x " + faktor[i] + " = " + summe[i] + " -> QS= " + quersumme[i]);
            }

            int quersummeGesammt = 0;
            foreach (int i in quersumme) { quersummeGesammt += i; }
            int modulo = quersummeGesammt % 10;

            int pruefziffer = 10 - modulo;
            if (pruefziffer == 10) { pruefziffer = 1; }
            Debug.WriteLine("Quersumme Gesammt: " + quersummeGesammt);
            Debug.WriteLine("Modulo: " + modulo);
            Debug.WriteLine("Pruefziffer: " + pruefziffer);
            return pruefziffer;
        }

        private void btn_change_mode_Click(object sender, EventArgs e)
        {
            if (modusBerechnen)
            {
                modusBerechnen = false;
                lbl_mode.Text = "Prüfen";
                btn_check.Text = "Prüfen";
                mtb_nummer.Mask = "0000-0000-0000-0000";
                mtb_nummer.Text = null;
            }
            else
            {
                modusBerechnen = true;
                lbl_mode.Text = "Berechnen";
                btn_check.Text = "Berechnen";
                mtb_nummer.Mask = "0000-0000-0000-000";
                mtb_nummer.Text = null;
            }
        }

        private void mtb_nummer_TextChanged(object sender, EventArgs e)
        {
            tb_pruefziffer.Text = null;
            mtb_nummer_new.Text = null;
            lbl_check_status.Text = null;
        }

        private void mtb_nummer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && (e.Modifiers & Keys.Control) != Keys.None)
            {
                string textToPaste = Clipboard.GetText();
                textToPaste = textToPaste.Replace(" ", "");
                mtb_nummer.Text = textToPaste;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}