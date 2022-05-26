namespace Eläinklinikka
{
    partial class EläintenLisäys
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.txtOnimi = new System.Windows.Forms.TextBox();
            this.txtSynty = new System.Windows.Forms.TextBox();
            this.txtLaji = new System.Windows.Forms.TextBox();
            this.txtTila = new System.Windows.Forms.TextBox();
            this.txtAika = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLisää = new System.Windows.Forms.Button();
            this.btnPäivitä = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(125, 47);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(100, 20);
            this.txtNimi.TabIndex = 1;
            // 
            // txtOnimi
            // 
            this.txtOnimi.Location = new System.Drawing.Point(125, 73);
            this.txtOnimi.Name = "txtOnimi";
            this.txtOnimi.Size = new System.Drawing.Size(100, 20);
            this.txtOnimi.TabIndex = 2;
            // 
            // txtSynty
            // 
            this.txtSynty.Location = new System.Drawing.Point(125, 99);
            this.txtSynty.Name = "txtSynty";
            this.txtSynty.Size = new System.Drawing.Size(100, 20);
            this.txtSynty.TabIndex = 3;
            // 
            // txtLaji
            // 
            this.txtLaji.Location = new System.Drawing.Point(125, 128);
            this.txtLaji.Name = "txtLaji";
            this.txtLaji.Size = new System.Drawing.Size(100, 20);
            this.txtLaji.TabIndex = 4;
            // 
            // txtTila
            // 
            this.txtTila.Location = new System.Drawing.Point(125, 154);
            this.txtTila.Name = "txtTila";
            this.txtTila.Size = new System.Drawing.Size(100, 20);
            this.txtTila.TabIndex = 5;
            // 
            // txtAika
            // 
            this.txtAika.Location = new System.Drawing.Point(125, 177);
            this.txtAika.Name = "txtAika";
            this.txtAika.Size = new System.Drawing.Size(100, 20);
            this.txtAika.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(252, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 417);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "EläimenID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Eläimen_nimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Omistajan nimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Syntymäpäivä";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Laji";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tila";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Varattu_aika";
            // 
            // btnLisää
            // 
            this.btnLisää.Location = new System.Drawing.Point(43, 218);
            this.btnLisää.Name = "btnLisää";
            this.btnLisää.Size = new System.Drawing.Size(182, 23);
            this.btnLisää.TabIndex = 15;
            this.btnLisää.Text = "Lisää";
            this.btnLisää.UseVisualStyleBackColor = true;
            this.btnLisää.Click += new System.EventHandler(this.btnLisää_Click);
            // 
            // btnPäivitä
            // 
            this.btnPäivitä.Location = new System.Drawing.Point(43, 258);
            this.btnPäivitä.Name = "btnPäivitä";
            this.btnPäivitä.Size = new System.Drawing.Size(182, 23);
            this.btnPäivitä.TabIndex = 16;
            this.btnPäivitä.Text = "Päivitä";
            this.btnPäivitä.UseVisualStyleBackColor = true;
            this.btnPäivitä.Click += new System.EventHandler(this.btnPäivitä_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(43, 298);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(182, 23);
            this.btnPoista.TabIndex = 17;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // EläintenLisäys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnPäivitä);
            this.Controls.Add(this.btnLisää);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAika);
            this.Controls.Add(this.txtTila);
            this.Controls.Add(this.txtLaji);
            this.Controls.Add(this.txtSynty);
            this.Controls.Add(this.txtOnimi);
            this.Controls.Add(this.txtNimi);
            this.Controls.Add(this.txtID);
            this.Name = "EläintenLisäys";
            this.Text = "EläintenLisäys";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.TextBox txtOnimi;
        private System.Windows.Forms.TextBox txtSynty;
        private System.Windows.Forms.TextBox txtLaji;
        private System.Windows.Forms.TextBox txtTila;
        private System.Windows.Forms.TextBox txtAika;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLisää;
        private System.Windows.Forms.Button btnPäivitä;
        private System.Windows.Forms.Button btnPoista;
    }
}