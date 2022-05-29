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
            this.Pword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Uname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pword
            // 
            this.Pword.Location = new System.Drawing.Point(181, 172);
            this.Pword.Name = "Pword";
            this.Pword.Size = new System.Drawing.Size(141, 20);
            this.Pword.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Salasana";
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(181, 146);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(141, 20);
            this.Uname.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rekisteröidy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Käyttäjätunnus";
            // 
            // Pnumber
            // 
            this.Pnumber.Location = new System.Drawing.Point(181, 198);
            this.Pnumber.Name = "Pnumber";
            this.Pnumber.Size = new System.Drawing.Size(141, 20);
            this.Pnumber.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Puhelin numero";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Takaisin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.Pnumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegForm";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}