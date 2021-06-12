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
            this.txtNazivObavijesti = new System.Windows.Forms.TextBox();
            this.txtOpisObavijesti = new System.Windows.Forms.TextBox();
            this.dtpKreiranjaObavijesti = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtNazivObavijesti
            // 
            this.txtNazivObavijesti.Location = new System.Drawing.Point(280, 93);
            this.txtNazivObavijesti.Name = "txtNazivObavijesti";
            this.txtNazivObavijesti.Size = new System.Drawing.Size(100, 20);
            this.txtNazivObavijesti.TabIndex = 0;
            // 
            // txtOpisObavijesti
            // 
            this.txtOpisObavijesti.Location = new System.Drawing.Point(280, 136);
            this.txtOpisObavijesti.Name = "txtOpisObavijesti";
            this.txtOpisObavijesti.Size = new System.Drawing.Size(100, 20);
            this.txtOpisObavijesti.TabIndex = 1;
            // 
            // dtpKreiranjaObavijesti
            // 
            this.dtpKreiranjaObavijesti.Location = new System.Drawing.Point(280, 178);
            this.dtpKreiranjaObavijesti.Name = "dtpKreiranjaObavijesti";
            this.dtpKreiranjaObavijesti.Size = new System.Drawing.Size(200, 20);
            this.dtpKreiranjaObavijesti.TabIndex = 2;
            // 
            // FormObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpKreiranjaObavijesti);
            this.Controls.Add(this.txtOpisObavijesti);
            this.Controls.Add(this.txtNazivObavijesti);
            this.Name = "FormObavijesti";
            this.Text = "FormObavijesti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivObavijesti;
        private System.Windows.Forms.TextBox txtOpisObavijesti;
        private System.Windows.Forms.DateTimePicker dtpKreiranjaObavijesti;
    }
}