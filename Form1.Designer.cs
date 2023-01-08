namespace iki_tarih_arasındaki_farkı_bulma
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
            this.lblcıkacak = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblKalanGun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcıkacak
            // 
            this.lblcıkacak.AutoSize = true;
            this.lblcıkacak.Location = new System.Drawing.Point(12, 103);
            this.lblcıkacak.Name = "lblcıkacak";
            this.lblcıkacak.Size = new System.Drawing.Size(85, 13);
            this.lblcıkacak.TabIndex = 0;
            this.lblcıkacak.Text = "Çıkarılacak tarih:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblKalanGun
            // 
            this.lblKalanGun.AutoSize = true;
            this.lblKalanGun.Location = new System.Drawing.Point(322, 133);
            this.lblKalanGun.Name = "lblKalanGun";
            this.lblKalanGun.Size = new System.Drawing.Size(40, 13);
            this.lblKalanGun.TabIndex = 4;
            this.lblKalanGun.Text = "0 GÜN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKalanGun);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcıkacak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcıkacak;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblKalanGun;
    }
}

