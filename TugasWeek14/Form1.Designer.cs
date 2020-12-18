
namespace TugasWeek14
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
            this.lblkalimat = new System.Windows.Forms.Label();
            this.lblhuruf = new System.Windows.Forms.Label();
            this.tboxkalimat = new System.Windows.Forms.TextBox();
            this.tboxhuruf1 = new System.Windows.Forms.TextBox();
            this.lblmenjadi = new System.Windows.Forms.Label();
            this.tboxhuruf2 = new System.Windows.Forms.TextBox();
            this.btnkonversi = new System.Windows.Forms.Button();
            this.lblhasil = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblkalimat
            // 
            this.lblkalimat.AutoSize = true;
            this.lblkalimat.Location = new System.Drawing.Point(26, 40);
            this.lblkalimat.Name = "lblkalimat";
            this.lblkalimat.Size = new System.Drawing.Size(94, 13);
            this.lblkalimat.TabIndex = 0;
            this.lblkalimat.Text = "Masukkan Kalimat";
            // 
            // lblhuruf
            // 
            this.lblhuruf.AutoSize = true;
            this.lblhuruf.Location = new System.Drawing.Point(26, 70);
            this.lblhuruf.Name = "lblhuruf";
            this.lblhuruf.Size = new System.Drawing.Size(86, 13);
            this.lblhuruf.TabIndex = 1;
            this.lblhuruf.Text = "Masukkan Huruf";
            // 
            // tboxkalimat
            // 
            this.tboxkalimat.Location = new System.Drawing.Point(126, 37);
            this.tboxkalimat.Name = "tboxkalimat";
            this.tboxkalimat.Size = new System.Drawing.Size(199, 20);
            this.tboxkalimat.TabIndex = 2;
            // 
            // tboxhuruf1
            // 
            this.tboxhuruf1.Location = new System.Drawing.Point(126, 67);
            this.tboxhuruf1.Name = "tboxhuruf1";
            this.tboxhuruf1.Size = new System.Drawing.Size(72, 20);
            this.tboxhuruf1.TabIndex = 3;
            // 
            // lblmenjadi
            // 
            this.lblmenjadi.AutoSize = true;
            this.lblmenjadi.Location = new System.Drawing.Point(204, 70);
            this.lblmenjadi.Name = "lblmenjadi";
            this.lblmenjadi.Size = new System.Drawing.Size(44, 13);
            this.lblmenjadi.TabIndex = 4;
            this.lblmenjadi.Text = "Menjadi";
            // 
            // tboxhuruf2
            // 
            this.tboxhuruf2.Location = new System.Drawing.Point(254, 67);
            this.tboxhuruf2.Name = "tboxhuruf2";
            this.tboxhuruf2.Size = new System.Drawing.Size(71, 20);
            this.tboxhuruf2.TabIndex = 5;
            // 
            // btnkonversi
            // 
            this.btnkonversi.Location = new System.Drawing.Point(126, 116);
            this.btnkonversi.Name = "btnkonversi";
            this.btnkonversi.Size = new System.Drawing.Size(199, 23);
            this.btnkonversi.TabIndex = 6;
            this.btnkonversi.Text = "Konversi!";
            this.btnkonversi.UseVisualStyleBackColor = true;
            this.btnkonversi.Click += new System.EventHandler(this.btnkonversi_Click);
            // 
            // lblhasil
            // 
            this.lblhasil.AutoSize = true;
            this.lblhasil.Location = new System.Drawing.Point(29, 166);
            this.lblhasil.Name = "lblhasil";
            this.lblhasil.Size = new System.Drawing.Size(36, 13);
            this.lblhasil.TabIndex = 7;
            this.lblhasil.Text = "Hasil :";
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Location = new System.Drawing.Point(126, 165);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(0, 13);
            this.lbloutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 216);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblhasil);
            this.Controls.Add(this.btnkonversi);
            this.Controls.Add(this.tboxhuruf2);
            this.Controls.Add(this.lblmenjadi);
            this.Controls.Add(this.tboxhuruf1);
            this.Controls.Add(this.tboxkalimat);
            this.Controls.Add(this.lblhuruf);
            this.Controls.Add(this.lblkalimat);
            this.Name = "Form1";
            this.Text = "QUIZ PANDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkalimat;
        private System.Windows.Forms.Label lblhuruf;
        private System.Windows.Forms.TextBox tboxkalimat;
        private System.Windows.Forms.TextBox tboxhuruf1;
        private System.Windows.Forms.Label lblmenjadi;
        private System.Windows.Forms.TextBox tboxhuruf2;
        private System.Windows.Forms.Button btnkonversi;
        private System.Windows.Forms.Label lblhasil;
        private System.Windows.Forms.Label lbloutput;
    }
}

