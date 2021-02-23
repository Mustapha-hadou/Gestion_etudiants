using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            etudiant1.Hide();
            filliere1.Hide();
            statistique1.Hide();
            rapportEcole1.Hide();
            rapport_etudaint1.Hide();
            

        }

        private void filliereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rapport_etudaint1.Hide();
            etudiant1.Hide();
            filliere1.Show();
            statistique1.Hide();
            rapportEcole1.Hide();

        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rapport_etudaint1.Hide();
            etudiant1.Show();
            filliere1.Hide();
            statistique1.Hide();
            rapportEcole1.Hide();

        }

        private void statistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rapport_etudaint1.Hide();
            etudiant1.Hide();
            filliere1.Hide();
            rapportEcole1.Hide();
            statistique1.Show();

        }

        private void chaqueEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rapport_etudaint1.Show();
            etudiant1.Hide();
            filliere1.Hide();
            statistique1.Hide();
            rapportEcole1.Hide();

        }

        private void ttEtudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rapport_etudaint1.Hide();
            etudiant1.Hide();
            filliere1.Hide();
            statistique1.Hide();
            rapportEcole1.Show();
        }

        private void reportingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rapport_etudaint1_Load(object sender, EventArgs e)
        {

        }
    }
}
