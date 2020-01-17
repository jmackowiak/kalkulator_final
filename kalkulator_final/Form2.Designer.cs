namespace kalkulator_final
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bWyczysc = new System.Windows.Forms.Button();
            this.bKonwertuj = new System.Windows.Forms.Button();
            this.tbSzukana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBin = new System.Windows.Forms.TextBox();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.tbOct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bWyczysc
            // 
            this.bWyczysc.Location = new System.Drawing.Point(31, 83);
            this.bWyczysc.Name = "bWyczysc";
            this.bWyczysc.Size = new System.Drawing.Size(75, 23);
            this.bWyczysc.TabIndex = 0;
            this.bWyczysc.Text = "Wyczyść";
            this.bWyczysc.UseVisualStyleBackColor = true;
            this.bWyczysc.Click += new System.EventHandler(this.bWyczysc_Click);
            // 
            // bKonwertuj
            // 
            this.bKonwertuj.Location = new System.Drawing.Point(122, 83);
            this.bKonwertuj.Name = "bKonwertuj";
            this.bKonwertuj.Size = new System.Drawing.Size(75, 23);
            this.bKonwertuj.TabIndex = 1;
            this.bKonwertuj.Text = "Konwertuj";
            this.bKonwertuj.UseVisualStyleBackColor = true;
            this.bKonwertuj.Click += new System.EventHandler(this.bKonwertuj_Click);
            // 
            // tbSzukana
            // 
            this.tbSzukana.Location = new System.Drawing.Point(59, 39);
            this.tbSzukana.Name = "tbSzukana";
            this.tbSzukana.Size = new System.Drawing.Size(100, 20);
            this.tbSzukana.TabIndex = 2;
            this.tbSzukana.TextChanged += new System.EventHandler(this.tbSzukana_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wpisz szukaną liczbę dziesiętną:";
            // 
            // tbBin
            // 
            this.tbBin.Location = new System.Drawing.Point(94, 140);
            this.tbBin.Name = "tbBin";
            this.tbBin.ReadOnly = true;
            this.tbBin.Size = new System.Drawing.Size(100, 20);
            this.tbBin.TabIndex = 4;
            // 
            // tbHex
            // 
            this.tbHex.Location = new System.Drawing.Point(94, 192);
            this.tbHex.Name = "tbHex";
            this.tbHex.ReadOnly = true;
            this.tbHex.Size = new System.Drawing.Size(100, 20);
            this.tbHex.TabIndex = 6;
            // 
            // tbOct
            // 
            this.tbOct.Location = new System.Drawing.Point(94, 166);
            this.tbOct.Name = "tbOct";
            this.tbOct.ReadOnly = true;
            this.tbOct.Size = new System.Drawing.Size(100, 20);
            this.tbOct.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Oct";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hex:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 237);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOct);
            this.Controls.Add(this.tbHex);
            this.Controls.Add(this.tbBin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSzukana);
            this.Controls.Add(this.bKonwertuj);
            this.Controls.Add(this.bWyczysc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Kalkulator binarny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bWyczysc;
        private System.Windows.Forms.Button bKonwertuj;
        private System.Windows.Forms.TextBox tbSzukana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBin;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.TextBox tbOct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}