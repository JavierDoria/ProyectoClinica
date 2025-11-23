namespace ProyectoClinica
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pACIENTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mEDICINASToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rECETASToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eSPECIALIDADESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pOPULARIDADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.pACIENTESToolStripMenuItem1,
            this.mEDICINASToolStripMenuItem1,
            this.rECETASToolStripMenuItem1,
            this.eSPECIALIDADESToolStripMenuItem1,
            this.pOPULARIDADToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.mantenimientoToolStripMenuItem.Text = "DOCTORES";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // pACIENTESToolStripMenuItem1
            // 
            this.pACIENTESToolStripMenuItem1.Name = "pACIENTESToolStripMenuItem1";
            this.pACIENTESToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.pACIENTESToolStripMenuItem1.Text = "PACIENTES";
            this.pACIENTESToolStripMenuItem1.Click += new System.EventHandler(this.pACIENTESToolStripMenuItem1_Click);
            // 
            // mEDICINASToolStripMenuItem1
            // 
            this.mEDICINASToolStripMenuItem1.Name = "mEDICINASToolStripMenuItem1";
            this.mEDICINASToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.mEDICINASToolStripMenuItem1.Text = "MEDICINAS";
            this.mEDICINASToolStripMenuItem1.Click += new System.EventHandler(this.mEDICINASToolStripMenuItem1_Click);
            // 
            // rECETASToolStripMenuItem1
            // 
            this.rECETASToolStripMenuItem1.Name = "rECETASToolStripMenuItem1";
            this.rECETASToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.rECETASToolStripMenuItem1.Text = "RECETAS";
            this.rECETASToolStripMenuItem1.Click += new System.EventHandler(this.rECETASToolStripMenuItem1_Click);
            // 
            // eSPECIALIDADESToolStripMenuItem1
            // 
            this.eSPECIALIDADESToolStripMenuItem1.Name = "eSPECIALIDADESToolStripMenuItem1";
            this.eSPECIALIDADESToolStripMenuItem1.Size = new System.Drawing.Size(108, 20);
            this.eSPECIALIDADESToolStripMenuItem1.Text = "ESPECIALIDADES";
            this.eSPECIALIDADESToolStripMenuItem1.Click += new System.EventHandler(this.eSPECIALIDADESToolStripMenuItem1_Click);
            // 
            // pOPULARIDADToolStripMenuItem
            // 
            this.pOPULARIDADToolStripMenuItem.Name = "pOPULARIDADToolStripMenuItem";
            this.pOPULARIDADToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.pOPULARIDADToolStripMenuItem.Text = "POPULARIDAD";
            this.pOPULARIDADToolStripMenuItem.Click += new System.EventHandler(this.pOPULARIDADToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 532);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pACIENTESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mEDICINASToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rECETASToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eSPECIALIDADESToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pOPULARIDADToolStripMenuItem;
    }
}