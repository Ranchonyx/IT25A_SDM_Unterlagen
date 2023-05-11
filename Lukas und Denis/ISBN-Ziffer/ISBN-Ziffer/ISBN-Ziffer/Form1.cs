namespace ISBN_Ziffer
{
    public partial class Form1 : Form
    {
        char[] chars;
        string txt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt = isBN.Text;
            chars = txt.ToCharArray();
            double abschluss = 0;
            double i = 0;
            foreach (char c in chars )
            {
                i++;
                double temp;
                temp = char.GetNumericValue(c);
                temp = temp * i;
                abschluss = abschluss + temp;
            }
            if (i == 9)
            {
                double ziffer = abschluss % 11;
                if (ziffer == 10)
                    prfZiffer.Text = "X";
                else
                    prfZiffer.Text = ziffer.ToString();
            }
            else 
            MessageBox.Show("Eine ISBN benötigt genau 9 Ziffern");
        }


    }
}