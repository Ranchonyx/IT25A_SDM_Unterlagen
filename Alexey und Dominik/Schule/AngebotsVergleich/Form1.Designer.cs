namespace AngebotsVergleich
{
    public class Angebot 
    {
        public string Firma { get; set; }
        public float Listeneinkaufspreis { get; set; }
        public int Lieferrabatt { get; set; }
        public int Lieferskonto { get; set; }
        public float Bezugspreis { get; set; }
        public int SonstRabatt { get; set; }
        public float Wert { get; set; }

        public Angebot()
        {

        }
        public Angebot(string Firma , int Listeneinkaufspreis, int Lieferrabatt, int Lieferskonto, int Bezugspreis, int SonstRabatt, float Wert)
        {   // Konstruktur
            Firma = Firma;
            Listeneinkaufspreis = Listeneinkaufspreis;
            Lieferrabatt = Lieferrabatt;
            Lieferskonto = Lieferskonto;
            Bezugspreis = Bezugspreis;
            SonstRabatt = SonstRabatt;
            Wert = Wert;
        }
    }
    partial class Form1 //Automatisch erstellter code
    {
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textListenPreis = new System.Windows.Forms.TextBox();
            this.textLieferSkonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLieferRabatt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBezugspreis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AngebotErstellen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textFirma = new System.Windows.Forms.TextBox();
            this.textSonstRabatt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SqlLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listeneinkaufspreis";
            // 
            // textListenPreis
            // 
            this.textListenPreis.Location = new System.Drawing.Point(177, 109);
            this.textListenPreis.Name = "textListenPreis";
            this.textListenPreis.Size = new System.Drawing.Size(125, 27);
            this.textListenPreis.TabIndex = 2;
            // 
            // textLieferSkonto
            // 
            this.textLieferSkonto.Location = new System.Drawing.Point(177, 192);
            this.textLieferSkonto.Name = "textLieferSkonto";
            this.textLieferSkonto.Size = new System.Drawing.Size(125, 27);
            this.textLieferSkonto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lieferskonto (%)";
            // 
            // textLieferRabatt
            // 
            this.textLieferRabatt.Location = new System.Drawing.Point(177, 151);
            this.textLieferRabatt.Name = "textLieferRabatt";
            this.textLieferRabatt.Size = new System.Drawing.Size(125, 27);
            this.textLieferRabatt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lieferrabatt (%)";
            // 
            // textBezugspreis
            // 
            this.textBezugspreis.Location = new System.Drawing.Point(177, 233);
            this.textBezugspreis.Name = "textBezugspreis";
            this.textBezugspreis.Size = new System.Drawing.Size(125, 27);
            this.textBezugspreis.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bezugspreis";
            // 
            // AngebotErstellen
            // 
            this.AngebotErstellen.AutoSize = true;
            this.AngebotErstellen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AngebotErstellen.Location = new System.Drawing.Point(38, 364);
            this.AngebotErstellen.Name = "AngebotErstellen";
            this.AngebotErstellen.Size = new System.Drawing.Size(265, 39);
            this.AngebotErstellen.TabIndex = 6;
            this.AngebotErstellen.Text = "Anlegen";
            this.AngebotErstellen.UseVisualStyleBackColor = true;
            this.AngebotErstellen.Click += new System.EventHandler(this.Erstellen_click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Firma";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(118, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 31);
            this.label11.TabIndex = 23;
            this.label11.Text = "Angebot";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(309, 191);
            this.dataGridView1.TabIndex = 24;
            // 
            // textFirma
            // 
            this.textFirma.Location = new System.Drawing.Point(177, 69);
            this.textFirma.Name = "textFirma";
            this.textFirma.Size = new System.Drawing.Size(125, 27);
            this.textFirma.TabIndex = 1;
            // 
            // textSonstRabatt
            // 
            this.textSonstRabatt.Location = new System.Drawing.Point(177, 292);
            this.textSonstRabatt.Name = "textSonstRabatt";
            this.textSonstRabatt.Size = new System.Drawing.Size(125, 27);
            this.textSonstRabatt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Sonst. Rabatt (%)";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(457, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Vergleichen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Vergleichen_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(441, 250);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(309, 90);
            this.dataGridView2.TabIndex = 28;
            // 
            // SqlLabel
            // 
            this.SqlLabel.AutoSize = true;
            this.SqlLabel.Location = new System.Drawing.Point(-3, 433);
            this.SqlLabel.Name = "SqlLabel";
            this.SqlLabel.Size = new System.Drawing.Size(188, 20);
            this.SqlLabel.TabIndex = 29;
            this.SqlLabel.Text = "Datenbank Anbindung Test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.SqlLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textSonstRabatt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textFirma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AngebotErstellen);
            this.Controls.Add(this.textBezugspreis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textLieferRabatt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLieferSkonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textListenPreis);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Angebots Vergleich";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox textListenPreis;
        private TextBox textLieferSkonto;
        private Label label2;
        private TextBox textLieferRabatt;
        private Label label3;
        private TextBox textBezugspreis;
        private Label label4;
        private Button AngebotErstellen;
        private Label label6;
        private Label label11;
        private DataGridView dataGridView1;
        private TextBox textFirma;
        private TextBox textSonstRabatt;
        private Label label5;
        private Button button1;
        private DataGridView dataGridView2;
        private Label SqlLabel;
    }
}