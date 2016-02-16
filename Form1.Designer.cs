namespace CustomerD
{
    partial class Form1
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
            this.getter = new System.Windows.Forms.Button();
            this.widokDanych = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.widokDanych)).BeginInit();
            this.SuspendLayout();
            // 
            // getter
            // 
            this.getter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getter.Location = new System.Drawing.Point(105, 217);
            this.getter.Name = "getter";
            this.getter.Size = new System.Drawing.Size(75, 23);
            this.getter.TabIndex = 0;
            this.getter.Text = "Pobierz";
            this.getter.UseVisualStyleBackColor = true;
            this.getter.Click += new System.EventHandler(this.getter_Click);
            // 
            // widokDanych
            // 
            this.widokDanych.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widokDanych.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widokDanych.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.widokDanych.Location = new System.Drawing.Point(12, 12);
            this.widokDanych.Name = "widokDanych";
            this.widokDanych.Size = new System.Drawing.Size(260, 187);
            this.widokDanych.TabIndex = 1;
            this.widokDanych.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.widokDanych_CellEndEdit);
            this.widokDanych.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.widokDanych_RowLeave);
            this.widokDanych.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.widokDanych_UserDeletingRow);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.widokDanych);
            this.Controls.Add(this.getter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.widokDanych)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getter;
        private System.Windows.Forms.DataGridView widokDanych;
    }
}

