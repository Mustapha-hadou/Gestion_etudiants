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
    public partial class rapport_etudaint : UserControl
    {
        public rapport_etudaint()
        {
            InitializeComponent();
            crystalReportViewer1.Hide();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void afficher_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < DScnxBd.ds.Tables["etudiant"].Rows.Count; i++)
            {
                if ((DScnxBd.ds.Tables["etudiant"].Rows[i][0].ToString().Trim()).Equals(textBox1.Text.ToString()))
                {
                    c = 1;

                }

            }
            if (c == 1)
            {
                crystalReportViewer1.Show();
            }
            else
            {
                MessageBox.Show("il n'existe pas");
            }
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

            DataSet etu = new DataSet("DataJointure");
            DataTable tablejointure = new DataTable("tablejointure");
            tablejointure.Columns.Add("cne");
            tablejointure.Columns.Add("Nom");
            tablejointure.Columns.Add("Prenom");
            tablejointure.Columns.Add("Sexe");
            tablejointure.Columns.Add("Date");
            tablejointure.Columns.Add("Adresse");
            tablejointure.Columns.Add("Telephone");
            tablejointure.Columns.Add("NOM_filliere");
            etu.Tables.Add(tablejointure);
            for (int i = 0; i < DScnxBd.ds.Tables["etudiant"].Rows.Count; i++)
            {
                if ((DScnxBd.ds.Tables["etudiant"].Rows[i][0].ToString().Trim()).Equals(textBox1.Text.ToString()))
                {
                    DataRow ligne = etu.Tables["tablejointure"].NewRow();
                    ligne[0] = DScnxBd.ds.Tables["etudiant"].Rows[i][0];
                    ligne[1] = DScnxBd.ds.Tables["etudiant"].Rows[i][1];
                    ligne[2] = DScnxBd.ds.Tables["etudiant"].Rows[i][2];
                    ligne[3] = DScnxBd.ds.Tables["etudiant"].Rows[i][3];
                    ligne[4] = DScnxBd.ds.Tables["etudiant"].Rows[i][4];
                    ligne[5] = DScnxBd.ds.Tables["etudiant"].Rows[i][5];
                    ligne[6] = DScnxBd.ds.Tables["etudiant"].Rows[i][6];
                    for (int j = 0; j < DScnxBd.ds.Tables["filliere"].Rows.Count; j++)
                    {
                        if (DScnxBd.ds.Tables["filliere"].Rows[j][0].ToString().Equals(DScnxBd.ds.Tables["etudiant"].Rows[i][7].ToString()))
                        {
                            ligne[7] = DScnxBd.ds.Tables["filliere"].Rows[j][1];
                        }
                    }
                    etu.Tables["tablejointure"].Rows.Add(ligne);
                }

            }

            CrystalReport3 cr3 = new CrystalReport3();
            cr3.SetDataSource(etu.Tables["tablejointure"]);
            crystalReportViewer1.ReportSource = cr3;
            crystalReportViewer1.Refresh();
        }
    }
}
