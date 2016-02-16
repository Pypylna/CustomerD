namespace CustomerD
{
    partial class logowanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.nazwaSerwera = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.MaskedTextBox();
            this.nazwaUz = new System.Windows.Forms.TextBox();
            this.nazwaBazy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz sposób logowania do bazy danych";
            // 
            // nazwaSerwera
            // 
            this.nazwaSerwera.Location = new System.Drawing.Point(144, 82);
            this.nazwaSerwera.Name = "nazwaSerwera";
            this.nazwaSerwera.Size = new System.Drawing.Size(100, 20);
            this.nazwaSerwera.TabIndex = 3;
            // 
            // haslo
            // 
            this.haslo.Enabled = false;
            this.haslo.Location = new System.Drawing.Point(144, 191);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(100, 20);
            this.haslo.TabIndex = 4;
            // 
            // nazwaUz
            // 
            this.nazwaUz.Enabled = false;
            this.nazwaUz.Location = new System.Drawing.Point(144, 156);
            this.nazwaUz.Name = "nazwaUz";
            this.nazwaUz.Size = new System.Drawing.Size(100, 20);
            this.nazwaUz.TabIndex = 5;
            // 
            // nazwaBazy
            // 
            this.nazwaBazy.Location = new System.Drawing.Point(144, 117);
            this.nazwaBazy.Name = "nazwaBazy";
            this.nazwaBazy.Size = new System.Drawing.Size(100, 20);
            this.nazwaBazy.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwa serwera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nazwa bazy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Użytkownik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hasło";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(101, 226);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 11;
            this.connectButton.Text = "Połącz";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(49, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(178, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "łączenie z autoryzacją Windows";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(44, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(189, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "łączenie z autoryzacją SQL Server";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazwaBazy);
            this.Controls.Add(this.nazwaUz);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.nazwaSerwera);
            this.Controls.Add(this.label1);
            this.Name = "logowanie";
            this.Text = "CDM - logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazwaSerwera;
        private System.Windows.Forms.MaskedTextBox haslo;
        private System.Windows.Forms.TextBox nazwaUz;
        private System.Windows.Forms.TextBox nazwaBazy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}