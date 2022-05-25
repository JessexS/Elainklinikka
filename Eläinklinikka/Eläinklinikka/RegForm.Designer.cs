using System;

namespace Eläinklinikka
{
    partial class RegForm
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
            this.Uname = new System.Windows.Forms.TextBox();
            this.Pnumber = new System.Windows.Forms.TextBox();
            this.Pword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TakaisinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(352, 167);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(92, 20);
            this.Uname.TabIndex = 0;
            // 
            // Pnumber
            // 
            this.Pnumber.Location = new System.Drawing.Point(352, 219);
            this.Pnumber.Name = "Pnumber";
            this.Pnumber.Size = new System.Drawing.Size(92, 20);
            this.Pnumber.TabIndex = 1;
            // 
            // Pword
            // 
            this.Pword.Location = new System.Drawing.Point(352, 193);
            this.Pword.Name = "Pword";
            this.Pword.Size = new System.Drawing.Size(92, 20);
            this.Pword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Käyttäjätunnus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salasana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Puhelinnumero";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lähetä";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TakaisinButton
            // 
            this.TakaisinButton.Location = new System.Drawing.Point(713, 415);
            this.TakaisinButton.Name = "TakaisinButton";
            this.TakaisinButton.Size = new System.Drawing.Size(75, 23);
            this.TakaisinButton.TabIndex = 7;
            this.TakaisinButton.Text = "Takaisin";
            this.TakaisinButton.UseVisualStyleBackColor = true;
            this.TakaisinButton.Click += new System.EventHandler(this.TakaisinButton_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TakaisinButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pword);
            this.Controls.Add(this.Pnumber);
            this.Controls.Add(this.Uname);
            this.Name = "RegForm";
            this.Text = "Rekisteröidy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.TextBox Pnumber;
        private System.Windows.Forms.TextBox Pword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private EventHandler label1_Click;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TakaisinButton;
    }
}