
namespace KindergartenJoy.Forme
{
    partial class FormWinService
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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnDeinstaliraj = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInstaliraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(197, 271);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(183, 42);
            this.btnStop.TabIndex = 28;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnDeinstaliraj
            // 
            this.btnDeinstaliraj.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDeinstaliraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeinstaliraj.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeinstaliraj.ForeColor = System.Drawing.Color.Black;
            this.btnDeinstaliraj.Location = new System.Drawing.Point(450, 271);
            this.btnDeinstaliraj.Name = "btnDeinstaliraj";
            this.btnDeinstaliraj.Size = new System.Drawing.Size(183, 42);
            this.btnDeinstaliraj.TabIndex = 29;
            this.btnDeinstaliraj.Text = "Deinstaliraj";
            this.btnDeinstaliraj.UseVisualStyleBackColor = false;
            this.btnDeinstaliraj.Click += new System.EventHandler(this.btnDeinstaliraj_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(450, 157);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(183, 42);
            this.btnStart.TabIndex = 30;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInstaliraj
            // 
            this.btnInstaliraj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInstaliraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInstaliraj.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstaliraj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInstaliraj.Location = new System.Drawing.Point(197, 157);
            this.btnInstaliraj.Name = "btnInstaliraj";
            this.btnInstaliraj.Size = new System.Drawing.Size(183, 42);
            this.btnInstaliraj.TabIndex = 31;
            this.btnInstaliraj.Text = "Instaliraj";
            this.btnInstaliraj.UseVisualStyleBackColor = false;
            this.btnInstaliraj.Click += new System.EventHandler(this.btnInstaliraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 32;
            // 
            // FormWinService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstaliraj);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDeinstaliraj);
            this.Controls.Add(this.btnStop);
            this.Name = "FormWinService";
            this.Text = "FormWinService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnDeinstaliraj;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInstaliraj;
        private System.Windows.Forms.Label label1;
    }
}