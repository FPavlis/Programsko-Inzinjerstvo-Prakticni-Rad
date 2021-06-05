
namespace KindergartenJoy.Forme
{
    partial class IzradiAktivnost
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
            this.txtNazivAktivnosti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpisAktivnosti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDatumIVrijemeAktivnosti = new System.Windows.Forms.DateTimePicker();
            this.btnSpremiAktivnost = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv aktivnosti:";
            // 
            // txtNazivAktivnosti
            // 
            this.txtNazivAktivnosti.Location = new System.Drawing.Point(164, 14);
            this.txtNazivAktivnosti.Name = "txtNazivAktivnosti";
            this.txtNazivAktivnosti.Size = new System.Drawing.Size(217, 20);
            this.txtNazivAktivnosti.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis aktivnosti:";
            // 
            // txtOpisAktivnosti
            // 
            this.txtOpisAktivnosti.Location = new System.Drawing.Point(164, 58);
            this.txtOpisAktivnosti.Multiline = true;
            this.txtOpisAktivnosti.Name = "txtOpisAktivnosti";
            this.txtOpisAktivnosti.Size = new System.Drawing.Size(216, 102);
            this.txtOpisAktivnosti.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum i vrijeme aktivnosti:";
            // 
            // dtpDatumIVrijemeAktivnosti
            // 
            this.dtpDatumIVrijemeAktivnosti.Location = new System.Drawing.Point(392, 37);
            this.dtpDatumIVrijemeAktivnosti.Name = "dtpDatumIVrijemeAktivnosti";
            this.dtpDatumIVrijemeAktivnosti.Size = new System.Drawing.Size(232, 20);
            this.dtpDatumIVrijemeAktivnosti.TabIndex = 5;
            // 
            // btnSpremiAktivnost
            // 
            this.btnSpremiAktivnost.Location = new System.Drawing.Point(436, 164);
            this.btnSpremiAktivnost.Name = "btnSpremiAktivnost";
            this.btnSpremiAktivnost.Size = new System.Drawing.Size(91, 37);
            this.btnSpremiAktivnost.TabIndex = 7;
            this.btnSpremiAktivnost.Text = "Spremi";
            this.btnSpremiAktivnost.UseVisualStyleBackColor = true;
            this.btnSpremiAktivnost.Click += new System.EventHandler(this.btnSpremiAktivnost_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(533, 164);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(91, 37);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // IzradiAktivnost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(637, 213);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremiAktivnost);
            this.Controls.Add(this.dtpDatumIVrijemeAktivnosti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOpisAktivnosti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNazivAktivnosti);
            this.Controls.Add(this.label1);
            this.Name = "IzradiAktivnost";
            this.Text = "Izradi Aktivnost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivAktivnosti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpisAktivnosti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDatumIVrijemeAktivnosti;
        private System.Windows.Forms.Button btnSpremiAktivnost;
        private System.Windows.Forms.Button btnOdustani;
    }
}