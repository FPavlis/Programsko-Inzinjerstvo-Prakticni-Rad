
namespace KindergartenJoy.Forme
{
    partial class PregledajAktivnosti
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
            this.dgvAktivnosti = new System.Windows.Forms.DataGridView();
            this.btnDodajAktivnost = new System.Windows.Forms.Button();
            this.btnObrisiAktivnost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivnosti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAktivnosti
            // 
            this.dgvAktivnosti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivnosti.Location = new System.Drawing.Point(12, 12);
            this.dgvAktivnosti.Name = "dgvAktivnosti";
            this.dgvAktivnosti.Size = new System.Drawing.Size(528, 236);
            this.dgvAktivnosti.TabIndex = 0;
            // 
            // btnDodajAktivnost
            // 
            this.btnDodajAktivnost.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDodajAktivnost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajAktivnost.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajAktivnost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDodajAktivnost.Location = new System.Drawing.Point(241, 254);
            this.btnDodajAktivnost.Name = "btnDodajAktivnost";
            this.btnDodajAktivnost.Size = new System.Drawing.Size(146, 42);
            this.btnDodajAktivnost.TabIndex = 9;
            this.btnDodajAktivnost.Text = "DODAJ AKTIVNOST";
            this.btnDodajAktivnost.UseVisualStyleBackColor = false;
            this.btnDodajAktivnost.Click += new System.EventHandler(this.btnDodajAktivnost_Click);
            // 
            // btnObrisiAktivnost
            // 
            this.btnObrisiAktivnost.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnObrisiAktivnost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiAktivnost.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiAktivnost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnObrisiAktivnost.Location = new System.Drawing.Point(393, 254);
            this.btnObrisiAktivnost.Name = "btnObrisiAktivnost";
            this.btnObrisiAktivnost.Size = new System.Drawing.Size(146, 42);
            this.btnObrisiAktivnost.TabIndex = 10;
            this.btnObrisiAktivnost.Text = "OBRIŠI AKTIVNOST";
            this.btnObrisiAktivnost.UseVisualStyleBackColor = false;
            this.btnObrisiAktivnost.Click += new System.EventHandler(this.btnObrisiAktivnost_Click);
            // 
            // PregledajAktivnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(551, 305);
            this.Controls.Add(this.btnObrisiAktivnost);
            this.Controls.Add(this.btnDodajAktivnost);
            this.Controls.Add(this.dgvAktivnosti);
            this.Name = "PregledajAktivnosti";
            this.Text = "Pregledaj aktivnosti";
            this.Load += new System.EventHandler(this.PregledajAktivnosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivnosti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAktivnosti;
        private System.Windows.Forms.Button btnDodajAktivnost;
        private System.Windows.Forms.Button btnObrisiAktivnost;
    }
}