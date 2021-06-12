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
            this.txtOpisObavijesti = new System.Windows.Forms.TextBox();
            this.txtNazivObavijesti = new System.Windows.Forms.TextBox();
            this.dtpKreiranjaObavijesti = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Location = new System.Drawing.Point(146, 146);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.Size = new System.Drawing.Size(240, 150);
            this.dgvObavijesti.TabIndex = 0;
            // 
            // txtOpisObavijesti
            // 
            this.txtOpisObavijesti.Location = new System.Drawing.Point(508, 104);
            this.txtOpisObavijesti.Name = "txtOpisObavijesti";
            this.txtOpisObavijesti.Size = new System.Drawing.Size(100, 20);
            this.txtOpisObavijesti.TabIndex = 1;
            // 
            // txtNazivObavijesti
            // 
            this.txtNazivObavijesti.Location = new System.Drawing.Point(508, 146);
            this.txtNazivObavijesti.Name = "txtNazivObavijesti";
            this.txtNazivObavijesti.Size = new System.Drawing.Size(100, 20);
            this.txtNazivObavijesti.TabIndex = 2;
            // 
            // dtpKreiranjaObavijesti
            // 
            this.dtpKreiranjaObavijesti.Location = new System.Drawing.Point(508, 205);
            this.dtpKreiranjaObavijesti.Name = "dtpKreiranjaObavijesti";
            this.dtpKreiranjaObavijesti.Size = new System.Drawing.Size(200, 20);
            this.dtpKreiranjaObavijesti.TabIndex = 3;
            // 
            // FormObavijestiRoditelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpKreiranjaObavijesti);
            this.Controls.Add(this.txtNazivObavijesti);
            this.Controls.Add(this.txtOpisObavijesti);
            this.Controls.Add(this.dgvObavijesti);
            this.Name = "FormObavijestiRoditelj";
            this.Text = "FormObavijestiRoditelj";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.TextBox txtOpisObavijesti;
        private System.Windows.Forms.TextBox txtNazivObavijesti;
        private System.Windows.Forms.DateTimePicker dtpKreiranjaObavijesti;
    }
}