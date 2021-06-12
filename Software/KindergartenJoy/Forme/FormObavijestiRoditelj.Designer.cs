
namespace KindergartenJoy.Forme
{
    partial class FormObavijestiRoditelj
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
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.dtpKreiranjaObavijesti = new System.Windows.Forms.DateTimePicker();
            this.txtOpisObavijesti = new System.Windows.Forms.TextBox();
            this.txtNazivObavijesti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Location = new System.Drawing.Point(12, 12);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.Size = new System.Drawing.Size(776, 150);
            this.dgvObavijesti.TabIndex = 0;
            // 
            // dtpKreiranjaObavijesti
            // 
            this.dtpKreiranjaObavijesti.Location = new System.Drawing.Point(190, 221);
            this.dtpKreiranjaObavijesti.Name = "dtpKreiranjaObavijesti";
            this.dtpKreiranjaObavijesti.Size = new System.Drawing.Size(200, 20);
            this.dtpKreiranjaObavijesti.TabIndex = 11;
            // 
            // txtOpisObavijesti
            // 
            this.txtOpisObavijesti.Location = new System.Drawing.Point(49, 264);
            this.txtOpisObavijesti.Multiline = true;
            this.txtOpisObavijesti.Name = "txtOpisObavijesti";
            this.txtOpisObavijesti.Size = new System.Drawing.Size(283, 102);
            this.txtOpisObavijesti.TabIndex = 10;
            // 
            // txtNazivObavijesti
            // 
            this.txtNazivObavijesti.Location = new System.Drawing.Point(101, 175);
            this.txtNazivObavijesti.Name = "txtNazivObavijesti";
            this.txtNazivObavijesti.Size = new System.Drawing.Size(231, 20);
            this.txtNazivObavijesti.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Datum i vrijeme kreiranja obavijesti:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naslov obavijesti:";
            // 
            // FormObavijestiRoditelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpKreiranjaObavijesti);
            this.Controls.Add(this.txtOpisObavijesti);
            this.Controls.Add(this.txtNazivObavijesti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvObavijesti);
            this.Name = "FormObavijestiRoditelj";
            this.Text = "Obavijesti";
            this.Load += new System.EventHandler(this.FormObavijestiRoditelj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.DateTimePicker dtpKreiranjaObavijesti;
        private System.Windows.Forms.TextBox txtOpisObavijesti;
        private System.Windows.Forms.TextBox txtNazivObavijesti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}