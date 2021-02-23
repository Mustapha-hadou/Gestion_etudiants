
namespace ProjetFinal
{
    partial class Form1
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
            DScnxBd.updateBD();
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
            this.filliereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chaqueEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ttEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistique1 = new ProjetFinal.statistique();
            this.filliere1 = new ProjetFinal.filliere();
            this.etudiant1 = new ProjetFinal.etudiant();
            this.rapportEcole1 = new ProjetFinal.rapportEcole();
            this.rapport_etudaint1 = new ProjetFinal.rapport_etudaint();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filliereToolStripMenuItem,
            this.etudiantToolStripMenuItem,
            this.statistiqueToolStripMenuItem,
            this.reportingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filliereToolStripMenuItem
            // 
            this.filliereToolStripMenuItem.Name = "filliereToolStripMenuItem";
            this.filliereToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.filliereToolStripMenuItem.Text = "filliere";
            this.filliereToolStripMenuItem.Click += new System.EventHandler(this.filliereToolStripMenuItem_Click);
            // 
            // etudiantToolStripMenuItem
            // 
            this.etudiantToolStripMenuItem.Name = "etudiantToolStripMenuItem";
            this.etudiantToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.etudiantToolStripMenuItem.Text = "etudiant";
            this.etudiantToolStripMenuItem.Click += new System.EventHandler(this.etudiantToolStripMenuItem_Click);
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.statistiqueToolStripMenuItem.Text = "statistique";
            this.statistiqueToolStripMenuItem.Click += new System.EventHandler(this.statistiqueToolStripMenuItem_Click);
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaqueEtudiantToolStripMenuItem,
            this.ttEtudiantToolStripMenuItem});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.reportingToolStripMenuItem.Text = "reporting";
            this.reportingToolStripMenuItem.Click += new System.EventHandler(this.reportingToolStripMenuItem_Click);
            // 
            // chaqueEtudiantToolStripMenuItem
            // 
            this.chaqueEtudiantToolStripMenuItem.Name = "chaqueEtudiantToolStripMenuItem";
            this.chaqueEtudiantToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.chaqueEtudiantToolStripMenuItem.Text = "chaque etudiant";
            this.chaqueEtudiantToolStripMenuItem.Click += new System.EventHandler(this.chaqueEtudiantToolStripMenuItem_Click);
            // 
            // ttEtudiantToolStripMenuItem
            // 
            this.ttEtudiantToolStripMenuItem.Name = "ttEtudiantToolStripMenuItem";
            this.ttEtudiantToolStripMenuItem.Size = new System.Drawing.Size(241, 34);
            this.ttEtudiantToolStripMenuItem.Text = "tous etudiant";
            this.ttEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ttEtudiantToolStripMenuItem_Click);
            // 
            // statistique1
            // 
            this.statistique1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statistique1.Location = new System.Drawing.Point(0, 33);
            this.statistique1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.statistique1.Name = "statistique1";
            this.statistique1.Size = new System.Drawing.Size(1293, 702);
            this.statistique1.TabIndex = 3;
            // 
            // filliere1
            // 
            this.filliere1.Location = new System.Drawing.Point(0, 32);
            this.filliere1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.filliere1.Name = "filliere1";
            this.filliere1.Size = new System.Drawing.Size(1200, 642);
            this.filliere1.TabIndex = 2;
            // 
            // etudiant1
            // 
            this.etudiant1.Location = new System.Drawing.Point(0, 48);
            this.etudiant1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.etudiant1.Name = "etudiant1";
            this.etudiant1.Size = new System.Drawing.Size(1200, 649);
            this.etudiant1.TabIndex = 1;
            // 
            // rapportEcole1
            // 
            this.rapportEcole1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rapportEcole1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rapportEcole1.Location = new System.Drawing.Point(0, 33);
            this.rapportEcole1.Name = "rapportEcole1";
            this.rapportEcole1.Size = new System.Drawing.Size(1293, 702);
            this.rapportEcole1.TabIndex = 4;
            // 
            // rapport_etudaint1
            // 
            this.rapport_etudaint1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rapport_etudaint1.Location = new System.Drawing.Point(0, 33);
            this.rapport_etudaint1.Name = "rapport_etudaint1";
            this.rapport_etudaint1.Size = new System.Drawing.Size(1293, 702);
            this.rapport_etudaint1.TabIndex = 5;
            this.rapport_etudaint1.Load += new System.EventHandler(this.rapport_etudaint1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 735);
            this.Controls.Add(this.rapport_etudaint1);
            this.Controls.Add(this.rapportEcole1);
            this.Controls.Add(this.statistique1);
            this.Controls.Add(this.filliere1);
            this.Controls.Add(this.etudiant1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filliereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chaqueEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ttEtudiantToolStripMenuItem;
        private etudiant etudiant1;
        private filliere filliere1;
        private statistique statistique1;
        private rapportEcole rapportEcole1;
        private rapport_etudaint rapport_etudaint1;
    }
}

