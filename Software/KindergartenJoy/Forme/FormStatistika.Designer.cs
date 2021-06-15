
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnPrikaziDjecu = new System.Windows.Forms.Button();
            this.dgvGlavni = new System.Windows.Forms.DataGridView();
            this.btnPrikaziKorisnike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrikaziAktivnosti = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnStatistikaPretplatnika = new System.Windows.Forms.Button();
            this.chartPretplatnici = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlavni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPretplatnici)).BeginInit();
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
            this.dgvGlavni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGlavni.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvGlavni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlavni.Location = new System.Drawing.Point(12, 12);
            this.dgvGlavni.Name = "dgvGlavni";
            this.dgvGlavni.Size = new System.Drawing.Size(794, 285);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ukupan broj djece u vrtiću:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ukupan broj korisnika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "0";
            // 
            // btnPrikaziAktivnosti
            // 
            this.btnPrikaziAktivnosti.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPrikaziAktivnosti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikaziAktivnosti.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziAktivnosti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrikaziAktivnosti.Location = new System.Drawing.Point(358, 394);
            this.btnPrikaziAktivnosti.Name = "btnPrikaziAktivnosti";
            this.btnPrikaziAktivnosti.Size = new System.Drawing.Size(195, 44);
            this.btnPrikaziAktivnosti.TabIndex = 16;
            this.btnPrikaziAktivnosti.Text = "PRIKAŽI AKTIVNOSTI IZ BAZE";
            this.btnPrikaziAktivnosti.UseVisualStyleBackColor = false;
            this.btnPrikaziAktivnosti.Click += new System.EventHandler(this.btnPrikaziAktivnosti_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ukupan broj aktivnosti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "0";
            // 
            // btnStatistikaPretplatnika
            // 
            this.btnStatistikaPretplatnika.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStatistikaPretplatnika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatistikaPretplatnika.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistikaPretplatnika.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStatistikaPretplatnika.Location = new System.Drawing.Point(559, 394);
            this.btnStatistikaPretplatnika.Name = "btnStatistikaPretplatnika";
            this.btnStatistikaPretplatnika.Size = new System.Drawing.Size(247, 44);
            this.btnStatistikaPretplatnika.TabIndex = 19;
            this.btnStatistikaPretplatnika.Text = "STATISTIKA PRETPLATNIKA NA OBAVIJESTI";
            this.btnStatistikaPretplatnika.UseVisualStyleBackColor = false;
            this.btnStatistikaPretplatnika.Click += new System.EventHandler(this.btnStatistikaPretplatnika_Click);
            // 
            // chartPretplatnici
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPretplatnici.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPretplatnici.Legends.Add(legend1);
            this.chartPretplatnici.Location = new System.Drawing.Point(215, 56);
            this.chartPretplatnici.Name = "chartPretplatnici";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Broj pretplatnika";
            this.chartPretplatnici.Series.Add(series1);
            this.chartPretplatnici.Size = new System.Drawing.Size(540, 300);
            this.chartPretplatnici.TabIndex = 20;
            this.chartPretplatnici.Text = "chart1";
            // 
            // FormStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.chartPretplatnici);
            this.Controls.Add(this.btnStatistikaPretplatnika);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrikaziAktivnosti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikaziKorisnike);
            this.Controls.Add(this.dgvGlavni);
            this.Controls.Add(this.btnPrikaziDjecu);
            this.Name = "FormStatistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.FormStatistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlavni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPretplatnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziDjecu;
        private System.Windows.Forms.DataGridView dgvGlavni;
        private System.Windows.Forms.Button btnPrikaziKorisnike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrikaziAktivnosti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStatistikaPretplatnika;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPretplatnici;
    }
}