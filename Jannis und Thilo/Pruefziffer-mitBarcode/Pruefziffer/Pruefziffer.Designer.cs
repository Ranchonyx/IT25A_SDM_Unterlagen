namespace Pruefziffer
{
    partial class Pruefziffer
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
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_mode_text = new System.Windows.Forms.Label();
            this.mtb_nummer = new System.Windows.Forms.MaskedTextBox();
            this.lbl_nummer = new System.Windows.Forms.Label();
            this.btn_change_mode = new System.Windows.Forms.Button();
            this.lbl_faktor = new System.Windows.Forms.Label();
            this.mtb_faktor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_nummer_new = new System.Windows.Forms.MaskedTextBox();
            this.tb_pruefziffer = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.lbl_check_status = new System.Windows.Forms.Label();
            this.lbl_mode = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.btn_generate_barcode = new System.Windows.Forms.Button();
            this.tlp_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 3;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Controls.Add(this.lbl_mode_text, 0, 0);
            this.tlp_main.Controls.Add(this.mtb_nummer, 1, 1);
            this.tlp_main.Controls.Add(this.lbl_nummer, 0, 1);
            this.tlp_main.Controls.Add(this.btn_change_mode, 2, 0);
            this.tlp_main.Controls.Add(this.lbl_faktor, 0, 2);
            this.tlp_main.Controls.Add(this.mtb_faktor, 1, 2);
            this.tlp_main.Controls.Add(this.label1, 0, 3);
            this.tlp_main.Controls.Add(this.label2, 0, 4);
            this.tlp_main.Controls.Add(this.mtb_nummer_new, 1, 4);
            this.tlp_main.Controls.Add(this.tb_pruefziffer, 1, 3);
            this.tlp_main.Controls.Add(this.btn_check, 2, 1);
            this.tlp_main.Controls.Add(this.lbl_check_status, 2, 4);
            this.tlp_main.Controls.Add(this.lbl_mode, 1, 0);
            this.tlp_main.Controls.Add(this.pb, 1, 5);
            this.tlp_main.Controls.Add(this.btn_generate_barcode, 0, 5);
            this.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_main.Location = new System.Drawing.Point(0, 0);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 6;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_main.Size = new System.Drawing.Size(438, 348);
            this.tlp_main.TabIndex = 0;
            // 
            // lbl_mode_text
            // 
            this.lbl_mode_text.AutoSize = true;
            this.lbl_mode_text.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mode_text.Location = new System.Drawing.Point(3, 3);
            this.lbl_mode_text.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_mode_text.Name = "lbl_mode_text";
            this.lbl_mode_text.Size = new System.Drawing.Size(72, 24);
            this.lbl_mode_text.TabIndex = 10;
            this.lbl_mode_text.Text = "Modus:";
            // 
            // mtb_nummer
            // 
            this.mtb_nummer.Location = new System.Drawing.Point(103, 33);
            this.mtb_nummer.Mask = "0000-0000-0000-000";
            this.mtb_nummer.Name = "mtb_nummer";
            this.mtb_nummer.Size = new System.Drawing.Size(180, 27);
            this.mtb_nummer.TabIndex = 0;
            this.mtb_nummer.TextChanged += new System.EventHandler(this.mtb_nummer_TextChanged);
            this.mtb_nummer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtb_nummer_KeyDown);
            this.mtb_nummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtb_ziffer_KeyPress);
            // 
            // lbl_nummer
            // 
            this.lbl_nummer.AutoSize = true;
            this.lbl_nummer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nummer.Location = new System.Drawing.Point(3, 33);
            this.lbl_nummer.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_nummer.Name = "lbl_nummer";
            this.lbl_nummer.Size = new System.Drawing.Size(86, 24);
            this.lbl_nummer.TabIndex = 1;
            this.lbl_nummer.Text = "Nummer:";
            // 
            // btn_change_mode
            // 
            this.btn_change_mode.Location = new System.Drawing.Point(301, 1);
            this.btn_change_mode.Margin = new System.Windows.Forms.Padding(1);
            this.btn_change_mode.Name = "btn_change_mode";
            this.btn_change_mode.Size = new System.Drawing.Size(135, 28);
            this.btn_change_mode.TabIndex = 5;
            this.btn_change_mode.Text = "Modus wechseln";
            this.btn_change_mode.UseVisualStyleBackColor = true;
            this.btn_change_mode.Click += new System.EventHandler(this.btn_change_mode_Click);
            // 
            // lbl_faktor
            // 
            this.lbl_faktor.AutoSize = true;
            this.lbl_faktor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_faktor.Location = new System.Drawing.Point(3, 63);
            this.lbl_faktor.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_faktor.Name = "lbl_faktor";
            this.lbl_faktor.Size = new System.Drawing.Size(65, 24);
            this.lbl_faktor.TabIndex = 3;
            this.lbl_faktor.Text = "Faktor:";
            // 
            // mtb_faktor
            // 
            this.mtb_faktor.Location = new System.Drawing.Point(103, 63);
            this.mtb_faktor.Mask = "0000-0000-0000-000";
            this.mtb_faktor.Name = "mtb_faktor";
            this.mtb_faktor.ReadOnly = true;
            this.mtb_faktor.Size = new System.Drawing.Size(180, 27);
            this.mtb_faktor.TabIndex = 4;
            this.mtb_faktor.Text = "212121212121212";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prüfziffer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nummer:";
            // 
            // mtb_nummer_new
            // 
            this.mtb_nummer_new.Location = new System.Drawing.Point(103, 123);
            this.mtb_nummer_new.Mask = "0000-0000-0000-0000";
            this.mtb_nummer_new.Name = "mtb_nummer_new";
            this.mtb_nummer_new.ReadOnly = true;
            this.mtb_nummer_new.Size = new System.Drawing.Size(180, 27);
            this.mtb_nummer_new.TabIndex = 8;
            // 
            // tb_pruefziffer
            // 
            this.tb_pruefziffer.Location = new System.Drawing.Point(103, 93);
            this.tb_pruefziffer.Name = "tb_pruefziffer";
            this.tb_pruefziffer.ReadOnly = true;
            this.tb_pruefziffer.Size = new System.Drawing.Size(50, 27);
            this.tb_pruefziffer.TabIndex = 9;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(301, 31);
            this.btn_check.Margin = new System.Windows.Forms.Padding(1);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(135, 28);
            this.btn_check.TabIndex = 12;
            this.btn_check.Text = "Berechnen";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lbl_check_status
            // 
            this.lbl_check_status.AutoSize = true;
            this.lbl_check_status.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_check_status.Location = new System.Drawing.Point(303, 123);
            this.lbl_check_status.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_check_status.Name = "lbl_check_status";
            this.lbl_check_status.Size = new System.Drawing.Size(131, 23);
            this.lbl_check_status.TabIndex = 13;
            this.lbl_check_status.Text = "Prüfziffer richtig";
            // 
            // lbl_mode
            // 
            this.lbl_mode.AutoSize = true;
            this.lbl_mode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mode.Location = new System.Drawing.Point(103, 3);
            this.lbl_mode.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_mode.Name = "lbl_mode";
            this.lbl_mode.Size = new System.Drawing.Size(93, 24);
            this.lbl_mode.TabIndex = 11;
            this.lbl_mode.Text = "Berechnen";
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pb.Location = new System.Drawing.Point(103, 153);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(194, 100);
            this.pb.TabIndex = 14;
            this.pb.TabStop = false;
            // 
            // btn_generate_barcode
            // 
            this.btn_generate_barcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_generate_barcode.Location = new System.Drawing.Point(3, 153);
            this.btn_generate_barcode.Name = "btn_generate_barcode";
            this.btn_generate_barcode.Size = new System.Drawing.Size(94, 53);
            this.btn_generate_barcode.TabIndex = 15;
            this.btn_generate_barcode.Text = "Barcode generieren";
            this.btn_generate_barcode.UseVisualStyleBackColor = true;
            this.btn_generate_barcode.Click += new System.EventHandler(this.generate_barcode_click);
            // 
            // Pruefziffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 348);
            this.Controls.Add(this.tlp_main);
            this.Name = "Pruefziffer";
            this.Text = "Pruefziffer-Kreditkartennummer";
            this.tlp_main.ResumeLayout(false);
            this.tlp_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp_main;
        private MaskedTextBox mtb_nummer;
        private Label lbl_nummer;
        private Label lbl_faktor;
        private MaskedTextBox mtb_faktor;
        private Button btn_change_mode;
        private Label label1;
        private Label label2;
        private MaskedTextBox mtb_nummer_new;
        private TextBox tb_pruefziffer;
        private Label lbl_mode_text;
        private Label lbl_mode;
        private Button btn_check;
        private Label lbl_check_status;
        private PictureBox pb;
        private Button btn_generate_barcode;
    }
}