using System.Drawing;

namespace CG
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAbrir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbH = new System.Windows.Forms.Label();
            this.lbS = new System.Windows.Forms.Label();
            this.lbI = new System.Windows.Forms.Label();
            this.lbR = new System.Windows.Forms.Label();
            this.lbG = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.lbYY = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.trackBarHUE = new System.Windows.Forms.TrackBar();
            this.lbHUE = new System.Windows.Forms.Label();
            this.trackBarIntensity = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntensity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(17, 454);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(48, 23);
            this.btAbrir.TabIndex = 1;
            this.btAbrir.Text = "Abrir ";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.BtAbrir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(71, 453);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(46, 23);
            this.btLimpar.TabIndex = 2;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.ForeColor = System.Drawing.SystemColors.Control;
            this.lbX.Location = new System.Drawing.Point(621, 238);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(43, 13);
            this.lbX.TabIndex = 3;
            this.lbX.Text = "Lin = ";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbY.ForeColor = System.Drawing.SystemColors.Control;
            this.lbY.Location = new System.Drawing.Point(621, 218);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(37, 13);
            this.lbY.TabIndex = 4;
            this.lbY.Text = "Col =";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.Location = new System.Drawing.Point(543, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lbH
            // 
            this.lbH.AutoSize = true;
            this.lbH.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbH.ForeColor = System.Drawing.SystemColors.Control;
            this.lbH.Location = new System.Drawing.Point(170, 437);
            this.lbH.Name = "lbH";
            this.lbH.Size = new System.Drawing.Size(31, 13);
            this.lbH.TabIndex = 7;
            this.lbH.Text = "H = ";
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.ForeColor = System.Drawing.SystemColors.Control;
            this.lbS.Location = new System.Drawing.Point(170, 450);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(25, 13);
            this.lbS.TabIndex = 8;
            this.lbS.Text = "S =";
            // 
            // lbI
            // 
            this.lbI.AutoSize = true;
            this.lbI.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbI.ForeColor = System.Drawing.SystemColors.Control;
            this.lbI.Location = new System.Drawing.Point(170, 463);
            this.lbI.Name = "lbI";
            this.lbI.Size = new System.Drawing.Size(31, 13);
            this.lbI.TabIndex = 9;
            this.lbI.Text = "I = ";
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR.ForeColor = System.Drawing.SystemColors.Control;
            this.lbR.Location = new System.Drawing.Point(299, 437);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(31, 13);
            this.lbR.TabIndex = 10;
            this.lbR.Text = "R = ";
            // 
            // lbG
            // 
            this.lbG.AutoSize = true;
            this.lbG.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbG.ForeColor = System.Drawing.SystemColors.Control;
            this.lbG.Location = new System.Drawing.Point(299, 450);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(31, 13);
            this.lbG.TabIndex = 11;
            this.lbG.Text = "G = ";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.ForeColor = System.Drawing.SystemColors.Control;
            this.lbB.Location = new System.Drawing.Point(299, 466);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(31, 13);
            this.lbB.TabIndex = 12;
            this.lbB.Text = "B = ";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.ForeColor = System.Drawing.SystemColors.Control;
            this.lbC.Location = new System.Drawing.Point(231, 436);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(31, 13);
            this.lbC.TabIndex = 13;
            this.lbC.Text = "C = ";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM.ForeColor = System.Drawing.SystemColors.Control;
            this.lbM.Location = new System.Drawing.Point(231, 450);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(31, 13);
            this.lbM.TabIndex = 14;
            this.lbM.Text = "M = ";
            // 
            // lbYY
            // 
            this.lbYY.AutoSize = true;
            this.lbYY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYY.ForeColor = System.Drawing.SystemColors.Control;
            this.lbYY.Location = new System.Drawing.Point(231, 466);
            this.lbYY.Name = "lbYY";
            this.lbYY.Size = new System.Drawing.Size(31, 13);
            this.lbYY.TabIndex = 15;
            this.lbYY.Text = "Y = ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox4.Location = new System.Drawing.Point(418, 126);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 95);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Location = new System.Drawing.Point(418, 227);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 95);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox5.Location = new System.Drawing.Point(418, 328);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(95, 95);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // trackBarHUE
            // 
            this.trackBarHUE.Location = new System.Drawing.Point(587, 453);
            this.trackBarHUE.Maximum = 360;
            this.trackBarHUE.Name = "trackBarHUE";
            this.trackBarHUE.Size = new System.Drawing.Size(237, 45);
            this.trackBarHUE.TabIndex = 24;
            this.trackBarHUE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBarHUE_MouseUp);
            // 
            // lbHUE
            // 
            this.lbHUE.AutoSize = true;
            this.lbHUE.Location = new System.Drawing.Point(594, 437);
            this.lbHUE.Name = "lbHUE";
            this.lbHUE.Size = new System.Drawing.Size(27, 13);
            this.lbHUE.TabIndex = 25;
            this.lbHUE.Text = "Hue";
            // 
            // trackBarIntensity
            // 
            this.trackBarIntensity.Location = new System.Drawing.Point(587, 517);
            this.trackBarIntensity.Maximum = 100;
            this.trackBarIntensity.Name = "trackBarIntensity";
            this.trackBarIntensity.Size = new System.Drawing.Size(237, 45);
            this.trackBarIntensity.TabIndex = 26;
            this.trackBarIntensity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBarIntensity_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(999, 570);
            this.Controls.Add(this.trackBarIntensity);
            this.Controls.Add(this.lbHUE);
            this.Controls.Add(this.lbR);
            this.Controls.Add(this.lbG);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbI);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbYY);
            this.Controls.Add(this.lbH);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.trackBarHUE);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntensity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbH;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label lbI;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Label lbG;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Label lbYY;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TrackBar trackBarHUE;
        private System.Windows.Forms.Label lbHUE;
        private System.Windows.Forms.TrackBar trackBarIntensity;
    }
}

