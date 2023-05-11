namespace FahrzeugPruefziffer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
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
            this.EingabeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VergleichButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AusgabeBox = new System.Windows.Forms.TextBox();
            this.EingabeErgebnis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EingabeBox
            // 
            this.EingabeBox.Location = new System.Drawing.Point(120, 42);
            this.EingabeBox.Name = "EingabeBox";
            this.EingabeBox.Size = new System.Drawing.Size(288, 27);
            this.EingabeBox.TabIndex = 0;
            this.EingabeBox.TextChanged += new System.EventHandler(this.EingabeBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eingabe";
            // 
            // VergleichButton
            // 
            this.VergleichButton.Location = new System.Drawing.Point(426, 42);
            this.VergleichButton.Name = "VergleichButton";
            this.VergleichButton.Size = new System.Drawing.Size(94, 29);
            this.VergleichButton.TabIndex = 2;
            this.VergleichButton.Text = "Prüfen";
            this.VergleichButton.UseVisualStyleBackColor = true;
            this.VergleichButton.Click += new System.EventHandler(this.VergleichButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generien";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerierenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ausgabe";
            // 
            // AusgabeBox
            // 
            this.AusgabeBox.Location = new System.Drawing.Point(120, 97);
            this.AusgabeBox.Name = "AusgabeBox";
            this.AusgabeBox.ReadOnly = true;
            this.AusgabeBox.Size = new System.Drawing.Size(288, 27);
            this.AusgabeBox.TabIndex = 5;
            // 
            // EingabeErgebnis
            // 
            this.EingabeErgebnis.AutoSize = true;
            this.EingabeErgebnis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EingabeErgebnis.ForeColor = System.Drawing.Color.Green;
            this.EingabeErgebnis.Location = new System.Drawing.Point(526, 39);
            this.EingabeErgebnis.Name = "EingabeErgebnis";
            this.EingabeErgebnis.Size = new System.Drawing.Size(68, 28);
            this.EingabeErgebnis.TabIndex = 7;
            this.EingabeErgebnis.Text = "richtig";
            this.EingabeErgebnis.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 159);
            this.Controls.Add(this.EingabeErgebnis);
            this.Controls.Add(this.AusgabeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VergleichButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EingabeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fahrzeugnummern in der DDR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox EingabeBox;
        private Label label1;
        private Button VergleichButton;
        private Button button1;
        private Label label2;
        private TextBox AusgabeBox;
        private Label label3;
        private Label EingabeErgebnis;
    }
}