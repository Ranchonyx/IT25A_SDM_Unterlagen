namespace ISBN_Ziffer
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
            isBN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            prfZiffer = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // isBN
            // 
            isBN.Location = new Point(309, 108);
            isBN.Name = "isBN";
            isBN.Size = new Size(100, 23);
            isBN.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 72);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(332, 165);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Prüfziffer";
            // 
            // prfZiffer
            // 
            prfZiffer.Location = new Point(309, 202);
            prfZiffer.Name = "prfZiffer";
            prfZiffer.Size = new Size(100, 23);
            prfZiffer.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(429, 107);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "berechnen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(prfZiffer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(isBN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox isBN;
        private Label label1;
        private Label label2;
        private TextBox prfZiffer;
        private Button button1;
    }
}