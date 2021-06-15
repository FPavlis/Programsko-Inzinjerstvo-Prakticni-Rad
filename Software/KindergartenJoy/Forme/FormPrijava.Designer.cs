
namespace KindergartenJoy
{
    partial class FormPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrijava));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNetocno = new System.Windows.Forms.Label();
            this.lblKreiraj = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 562);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 297);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.lblNetocno);
            this.panel2.Controls.Add(this.lblKreiraj);
            this.panel2.Controls.Add(this.btnPrijava);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtLozinka);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(478, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 562);
            this.panel2.TabIndex = 3;
            // 
            // lblNetocno
            // 
            this.lblNetocno.AutoSize = true;
            this.lblNetocno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetocno.Location = new System.Drawing.Point(127, 314);
            this.lblNetocno.Name = "lblNetocno";
            this.lblNetocno.Size = new System.Drawing.Size(194, 18);
            this.lblNetocno.TabIndex = 11;
            this.lblNetocno.Text = "Netočno uneseni podaci!";
            this.lblNetocno.Visible = false;
            // 
            // lblKreiraj
            // 
            this.lblKreiraj.AutoSize = true;
            this.lblKreiraj.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKreiraj.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblKreiraj.Location = new System.Drawing.Point(156, 417);
            this.lblKreiraj.Name = "lblKreiraj";
            this.lblKreiraj.Size = new System.Drawing.Size(124, 13);
            this.lblKreiraj.TabIndex = 10;
            this.lblKreiraj.Text = "KREIRAJ RAČUN";
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrijava.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrijava.Location = new System.Drawing.Point(147, 361);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(146, 42);
            this.btnPrijava.TabIndex = 8;
            this.btnPrijava.Text = "PRIJAVA";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prijavi se";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(111, 266);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(225, 20);
            this.txtLozinka.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "LOZINKA";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(111, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMAIL";
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrijava";
            this.Text = "Kindergarten Joy App";
            this.Load += new System.EventHandler(this.FormPrijava_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label lblKreiraj;
        private System.Windows.Forms.Label lblNetocno;
    }
}

