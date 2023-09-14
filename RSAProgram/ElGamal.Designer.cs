
namespace RSAProgram
{
    partial class ElGamal
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
            this.textCifrat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.cheiePrivata = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cheiePublica = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mesajDecriptat = new System.Windows.Forms.TextBox();
            this.btnDecriptare = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCriptare = new System.Windows.Forms.Button();
            this.genereazaChei = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCifrat
            // 
            this.textCifrat.Location = new System.Drawing.Point(337, 337);
            this.textCifrat.Multiline = true;
            this.textCifrat.Name = "textCifrat";
            this.textCifrat.ReadOnly = true;
            this.textCifrat.Size = new System.Drawing.Size(179, 65);
            this.textCifrat.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "gamma =";
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(359, 116);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.ReadOnly = true;
            this.textBoxGamma.Size = new System.Drawing.Size(179, 22);
            this.textBoxGamma.TabIndex = 45;
            // 
            // cheiePrivata
            // 
            this.cheiePrivata.Location = new System.Drawing.Point(87, 360);
            this.cheiePrivata.Multiline = true;
            this.cheiePrivata.Name = "cheiePrivata";
            this.cheiePrivata.ReadOnly = true;
            this.cheiePrivata.Size = new System.Drawing.Size(179, 22);
            this.cheiePrivata.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Cheia privata:";
            // 
            // cheiePublica
            // 
            this.cheiePublica.Location = new System.Drawing.Point(87, 303);
            this.cheiePublica.Multiline = true;
            this.cheiePublica.Name = "cheiePublica";
            this.cheiePublica.ReadOnly = true;
            this.cheiePublica.Size = new System.Drawing.Size(179, 22);
            this.cheiePublica.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Cheia publica:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(586, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "MESAJ DECRIPTAT";
            // 
            // mesajDecriptat
            // 
            this.mesajDecriptat.Location = new System.Drawing.Point(562, 278);
            this.mesajDecriptat.Multiline = true;
            this.mesajDecriptat.Name = "mesajDecriptat";
            this.mesajDecriptat.ReadOnly = true;
            this.mesajDecriptat.Size = new System.Drawing.Size(179, 65);
            this.mesajDecriptat.TabIndex = 39;
            // 
            // btnDecriptare
            // 
            this.btnDecriptare.Location = new System.Drawing.Point(563, 354);
            this.btnDecriptare.Name = "btnDecriptare";
            this.btnDecriptare.Size = new System.Drawing.Size(178, 34);
            this.btnDecriptare.TabIndex = 38;
            this.btnDecriptare.Text = "Decripteaza";
            this.btnDecriptare.UseVisualStyleBackColor = true;
            this.btnDecriptare.Click += new System.EventHandler(this.btnDecriptare_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Generare chei";
            // 
            // btnCriptare
            // 
            this.btnCriptare.Location = new System.Drawing.Point(337, 283);
            this.btnCriptare.Name = "btnCriptare";
            this.btnCriptare.Size = new System.Drawing.Size(179, 34);
            this.btnCriptare.TabIndex = 36;
            this.btnCriptare.Text = "Cripteaza mesajul clar";
            this.btnCriptare.UseVisualStyleBackColor = true;
            this.btnCriptare.Click += new System.EventHandler(this.btnCriptare_Click);
            // 
            // genereazaChei
            // 
            this.genereazaChei.Location = new System.Drawing.Point(120, 206);
            this.genereazaChei.Name = "genereazaChei";
            this.genereazaChei.Size = new System.Drawing.Size(133, 34);
            this.genereazaChei.TabIndex = 35;
            this.genereazaChei.Text = "Genereaza cheile";
            this.genereazaChei.UseVisualStyleBackColor = true;
            this.genereazaChei.Click += new System.EventHandler(this.genereazaChei_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "MESAJ CLAR";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(337, 206);
            this.textBoxM.Multiline = true;
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(179, 65);
            this.textBoxM.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "k =";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(359, 77);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.ReadOnly = true;
            this.textBoxK.Size = new System.Drawing.Size(179, 22);
            this.textBoxK.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "alpha =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "p =";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(102, 161);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(179, 22);
            this.textBoxA.TabIndex = 27;
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(102, 116);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(179, 22);
            this.textBoxAlpha.TabIndex = 26;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(102, 79);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(179, 22);
            this.textBoxP.TabIndex = 25;
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Location = new System.Drawing.Point(359, 156);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.ReadOnly = true;
            this.textBoxDelta.Size = new System.Drawing.Size(179, 22);
            this.textBoxDelta.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "delta =";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(589, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 50;
            this.button1.Text = "Info Algoritm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElGamal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDelta);
            this.Controls.Add(this.textCifrat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGamma);
            this.Controls.Add(this.cheiePrivata);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cheiePublica);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mesajDecriptat);
            this.Controls.Add(this.btnDecriptare);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCriptare);
            this.Controls.Add(this.genereazaChei);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxAlpha);
            this.Controls.Add(this.textBoxP);
            this.Name = "ElGamal";
            this.Text = "ElGamal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCifrat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.TextBox cheiePrivata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cheiePublica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mesajDecriptat;
        private System.Windows.Forms.Button btnDecriptare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCriptare;
        private System.Windows.Forms.Button genereazaChei;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}