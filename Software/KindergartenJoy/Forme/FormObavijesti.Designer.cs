
namespace KindergartenJoy.Forme
{
    partial class FormObavijesti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNazivObavijesti = new System.Windows.Forms.TextBox();
            this.txtOpisObavijesti = new System.Windows.Forms.TextBox();
            this.dtpKreiranjaObavijesti = new System.Windows.Forms.DateTimePicker();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov obavijesti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum i vrijeme kreiranja obavijesti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis:";
            // 
            // txtNazivObavijesti
            // 
            this.txtNazivObavijesti.Location = new System.Drawing.Point(154, 42);
            this.txtNazivObavijesti.Name = "txtNazivObavijesti";
            this.txtNazivObavijesti.Size = new System.Drawing.Size(100, 20);
            this.txtNazivObavijesti.TabIndex = 3;
            // 
            // txtOpisObavijesti
            // 
            this.txtOpisObavijesti.Location = new System.Drawing.Point(82, 131);
            this.txtOpisObavijesti.Multiline = true;
            this.txtOpisObavijesti.Name = "txtOpisObavijesti";
            this.txtOpisObavijesti.Size = new System.Drawing.Size(283, 102);
            this.txtOpisObavijesti.TabIndex = 4;
            // 
            // dtpKreiranjaObavijesti
            // 
            this.dtpKreiranjaObavijesti.Location = new System.Drawing.Point(223, 88);
            this.dtpKreiranjaObavijesti.Name = "dtpKreiranjaObavijesti";
            this.dtpKreiranjaObavijesti.Size = new System.Drawing.Size(200, 20);
            this.dtpKreiranjaObavijesti.TabIndex = 5;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpremi.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpremi.Location = new System.Drawing.Point(48, 239);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(109, 42);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "SPREMI OBAVIJEST";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FormObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dtpKreiranjaObavijesti);
            this.Controls.Add(this.txtOpisObavijesti);
            this.Controls.Add(this.txtNazivObavijesti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormObavijesti";
            this.Text = "Obavijesti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNazivObavijesti;
        private System.Windows.Forms.TextBox txtOpisObavijesti;
        private System.Windows.Forms.DateTimePicker dtpKreiranjaObavijesti;
        private System.Windows.Forms.Button btnSpremi;
    }
}