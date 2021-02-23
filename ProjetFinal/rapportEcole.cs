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
    public partial class rapportEcole : UserControl
    {
        public rapportEcole()
        {
            InitializeComponent();
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet datajointure = new DataSet("DataJointure");
            DataTable tablejointure = new DataTable("tablejointure");
            tablejointure.Columns.Add("cne");
            tablejointure.Columns.Add("Nom");
            tablejointure.Columns.Add("Prenom");
            tablejointure.Columns.Add("Sexe");
            tablejointure.Columns.Add("Date");
            tablejointure.Columns.Add("Adresse");
            tablejointure.Columns.Add("Telephone");
            tablejointure.Columns.Add("NOM_filliere");
            datajointure.Tables.Add(tablejointure);
            for (int i = 0; i < DScnxBd.ds.Tables["etudiant"].Rows.Count; i++)
            {
                DataRow ligne = datajointure.Tables["tablejointure"].NewRow();
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
                datajointure.Tables["tablejointure"].Rows.Add(ligne);
            }

            CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(datajointure.Tables["tablejointure"]);
            crystalReportViewer1.ReportSource = cr1;
            crystalReportViewer1.Refresh();
        }
    }
}
