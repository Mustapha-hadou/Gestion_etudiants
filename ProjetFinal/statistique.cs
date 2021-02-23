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
    public partial class statistique : UserControl
    {
        public statistique()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tracerStatistique();

        }
        public void tracerStatistique()
        {

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            int k = 0;
            int somme;

            for (int i = 0; i < DScnxBd.ds.Tables["filliere"].Rows.Count; i++)
            {
                somme = 0;
                if (!(DScnxBd.ds.Tables["filliere"].Rows[i].RowState == DataRowState.Deleted))
                {
                    int cp = 0;
                    for (int j = 0; j < DScnxBd.ds.Tables["etudiant"].Rows.Count; j++)
                    {
                        if (!(DScnxBd.ds.Tables["etudiant"].Rows[j].RowState == DataRowState.Deleted))
                        {
                            somme++;
                            if (Convert.ToInt32(DScnxBd.ds.Tables["etudiant"].Rows[j][7]) == Convert.ToInt32(DScnxBd.ds.Tables["filliere"].Rows[i][0]))
                            {

                                cp++;
                            }
                        }
                    }
                    if (cp != 0)
                    {
                        double c = Convert.ToDouble(cp);
                        double p = (double)(c * 100 / somme);
                        chart1.Series[0].Points.AddXY(DScnxBd.ds.Tables["filliere"].Rows[i][1], p);
                        String val = String.Format("{0:0.00}", p);
                        chart1.Series[0].Points[k].Label = val + "%";
                        k++;
                    }
                }
            }

        }

        private void statistique_Load(object sender, EventArgs e)
        {
            tracerStatistique();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
