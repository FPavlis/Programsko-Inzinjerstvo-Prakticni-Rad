
namespace KindergartenJoy.Forme
{
    partial class FormStatistika
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
            this.btnPrikaziDjecu = new System.Windows.Forms.Button();
            this.dgvGlavni = new System.Windows.Forms.DataGridView();
            this.btnPrikaziKorisnike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlavni)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikaziDjecu
            // 
            this.btnPrikaziDjecu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrikaziDjecu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikaziDjecu.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziDjecu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrikaziDjecu.Location = new System.Drawing.Point(12, 394);
            this.btnPrikaziDjecu.Name = "btnPrikaziDjecu";
            this.btnPrikaziDjecu.Size = new System.Drawing.Size(145, 44);
            this.btnPrikaziDjecu.TabIndex = 9;
            this.btnPrikaziDjecu.Text = "PRIKAŽI DJECU IZ BAZE";
            this.btnPrikaziDjecu.UseVisualStyleBackColor = false;
            this.btnPrikaziDjecu.Click += new System.EventHandler(this.btnPrikaziDjecu_Click);
            // 
            // dgvGlavni
            // 
            this.dgvGlavni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlavni.Location = new System.Drawing.Point(12, 12);
            this.dgvGlavni.Name = "dgvGlavni";
            this.dgvGlavni.Size = new System.Drawing.Size(776, 285);
            this.dgvGlavni.TabIndex = 10;
            // 
            // btnPrikaziKorisnike
            // 
            this.btnPrikaziKorisnike.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrikaziKorisnike.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikaziKorisnike.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziKorisnike.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrikaziKorisnike.Location = new System.Drawing.Point(163, 394);
            this.btnPrikaziKorisnike.Name = "btnPrikaziKorisnike";
            this.btnPrikaziKorisnike.Size = new System.Drawing.Size(189, 44);
            this.btnPrikaziKorisnike.TabIndex = 11;
            this.btnPrikaziKorisnike.Text = "PRIKAŽI KORISNIKE IZ BAZE";
            this.btnPrikaziKorisnike.UseVisualStyleBackColor = false;
            this.btnPrikaziKorisnike.Click += new System.EventHandler(this.btnPrikaziKorisnike_Click);
            // 
            // FormStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikaziKorisnike);
            this.Controls.Add(this.dgvGlavni);
            this.Controls.Add(this.btnPrikaziDjecu);
            this.Name = "FormStatistika";
            this.Text = "Statistika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlavni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziDjecu;
        private System.Windows.Forms.DataGridView dgvGlavni;
        private System.Windows.Forms.Button btnPrikaziKorisnike;
    }
}