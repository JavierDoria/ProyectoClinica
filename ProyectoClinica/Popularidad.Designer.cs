namespace ProyectoClinica
{
    partial class Popularidad
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MedicinaGeneral = new System.Windows.Forms.ProgressBar();
            this.Pediatria = new System.Windows.Forms.ProgressBar();
            this.Traumotologia = new System.Windows.Forms.ProgressBar();
            this.Odontologia = new System.Windows.Forms.ProgressBar();
            this.medi = new System.Windows.Forms.Label();
            this.pedi = new System.Windows.Forms.Label();
            this.tra = new System.Windows.Forms.Label();
            this.odo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESPECIALIDADES MAS SOLICITADAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MEDICINA GENERAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PEDIATRIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TRAUMOTOLOGIA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ODONTOLOGIA";
            // 
            // MedicinaGeneral
            // 
            this.MedicinaGeneral.Location = new System.Drawing.Point(219, 137);
            this.MedicinaGeneral.Name = "MedicinaGeneral";
            this.MedicinaGeneral.Size = new System.Drawing.Size(414, 23);
            this.MedicinaGeneral.TabIndex = 5;
            this.MedicinaGeneral.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Pediatria
            // 
            this.Pediatria.Location = new System.Drawing.Point(219, 194);
            this.Pediatria.Name = "Pediatria";
            this.Pediatria.Size = new System.Drawing.Size(414, 23);
            this.Pediatria.TabIndex = 6;
            // 
            // Traumotologia
            // 
            this.Traumotologia.Location = new System.Drawing.Point(219, 248);
            this.Traumotologia.Name = "Traumotologia";
            this.Traumotologia.Size = new System.Drawing.Size(414, 23);
            this.Traumotologia.TabIndex = 7;
            // 
            // Odontologia
            // 
            this.Odontologia.Location = new System.Drawing.Point(219, 302);
            this.Odontologia.Name = "Odontologia";
            this.Odontologia.Size = new System.Drawing.Size(414, 23);
            this.Odontologia.TabIndex = 8;
            // 
            // medi
            // 
            this.medi.AutoSize = true;
            this.medi.Location = new System.Drawing.Point(656, 137);
            this.medi.Name = "medi";
            this.medi.Size = new System.Drawing.Size(22, 13);
            this.medi.TabIndex = 9;
            this.medi.Text = "-----";
            // 
            // pedi
            // 
            this.pedi.AutoSize = true;
            this.pedi.Location = new System.Drawing.Point(656, 204);
            this.pedi.Name = "pedi";
            this.pedi.Size = new System.Drawing.Size(22, 13);
            this.pedi.TabIndex = 10;
            this.pedi.Text = "-----";
            // 
            // tra
            // 
            this.tra.AutoSize = true;
            this.tra.Location = new System.Drawing.Point(656, 258);
            this.tra.Name = "tra";
            this.tra.Size = new System.Drawing.Size(22, 13);
            this.tra.TabIndex = 11;
            this.tra.Text = "-----";
            // 
            // odo
            // 
            this.odo.AutoSize = true;
            this.odo.Location = new System.Drawing.Point(662, 312);
            this.odo.Name = "odo";
            this.odo.Size = new System.Drawing.Size(19, 13);
            this.odo.TabIndex = 12;
            this.odo.Text = "----";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Popularidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 486);
            this.Controls.Add(this.odo);
            this.Controls.Add(this.tra);
            this.Controls.Add(this.pedi);
            this.Controls.Add(this.medi);
            this.Controls.Add(this.Odontologia);
            this.Controls.Add(this.Traumotologia);
            this.Controls.Add(this.Pediatria);
            this.Controls.Add(this.MedicinaGeneral);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Popularidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Popularidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar MedicinaGeneral;
        private System.Windows.Forms.ProgressBar Pediatria;
        private System.Windows.Forms.ProgressBar Traumotologia;
        private System.Windows.Forms.ProgressBar Odontologia;
        private System.Windows.Forms.Label medi;
        private System.Windows.Forms.Label pedi;
        private System.Windows.Forms.Label tra;
        private System.Windows.Forms.Label odo;
        private System.Windows.Forms.Timer timer1;
    }
}