﻿namespace sem10_paw
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbMedie = new System.Windows.Forms.TextBox();
            this.cbForma = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(237, 81);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 20);
            this.tbNume.TabIndex = 0;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(237, 150);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(100, 20);
            this.tbVarsta.TabIndex = 1;
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(237, 218);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(100, 20);
            this.tbMedie.TabIndex = 2;
            // 
            // cbForma
            // 
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Items.AddRange(new object[] {
            "ZI",
            "ID"});
            this.cbForma.Location = new System.Drawing.Point(237, 307);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(121, 21);
            this.cbForma.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbForma);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbNume);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.TextBox tbMedie;
        private System.Windows.Forms.ComboBox cbForma;
        private System.Windows.Forms.Button button1;
    }
}