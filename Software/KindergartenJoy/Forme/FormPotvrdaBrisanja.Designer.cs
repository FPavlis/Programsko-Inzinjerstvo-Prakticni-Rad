
namespace KindergartenJoy.Forme
{
    partial class FormPotvrdaBrisanja
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDa = new System.Windows.Forms.Button();
            this.btnNe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Jeste li sigurni da želite obrisati svoj profil?";
            // 
            // btnDa
            // 
            this.btnDa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDa.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDa.Location = new System.Drawing.Point(47, 112);
            this.btnDa.Name = "btnDa";
            this.btnDa.Size = new System.Drawing.Size(175, 42);
            this.btnDa.TabIndex = 17;
            this.btnDa.Text = "DA";
            this.btnDa.UseVisualStyleBackColor = false;
            this.btnDa.Click += new System.EventHandler(this.btnDa_Click);
            // 
            // btnNe
            // 
            this.btnNe.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNe.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNe.ForeColor = System.Drawing.Color.Black;
            this.btnNe.Location = new System.Drawing.Point(293, 112);
            this.btnNe.Name = "btnNe";
            this.btnNe.Size = new System.Drawing.Size(175, 42);
            this.btnNe.TabIndex = 27;
            this.btnNe.TabStop = false;
            this.btnNe.Text = "NE";
            this.btnNe.UseVisualStyleBackColor = false;
            this.btnNe.Click += new System.EventHandler(this.btnNe_Click);
            // 
            // FormPotvrdaBrisanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(510, 198);
            this.Controls.Add(this.btnNe);
            this.Controls.Add(this.btnDa);
            this.Controls.Add(this.label2);
            this.Name = "FormPotvrdaBrisanja";
            this.Text = "FormPotvrdaBrisanja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDa;
        private System.Windows.Forms.Button btnNe;
    }
}