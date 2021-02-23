using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace ProjetFinal
{
    public partial class DialogForm : Form
    {
        Excel.Application app = new Excel.Application();
        Excel.Workbook wb;
        Excel.Worksheet ws;
        public DialogForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opnFileDialog.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= ws.UsedRange.Rows.Count; i++)
            {

                if (!DScnxBd.verifierExitanceCNE(ws.Cells[i, 1].Value))
                {

                    DataRow ligne = DScnxBd.ds.Tables["etudiant"].NewRow();
                    for (int j = 1; j <= ws.UsedRange.Columns.Count; j++)
                    {
                        if (j == 5)
                        {
                            ligne[j - 1] = (DateTime)ws.Cells[i, j].Value;

                        }
                        else if (j == 8)
                        {
                            for (int k = 0; k < DScnxBd.ds.Tables["filliere"].Rows.Count; k++)
                            {
                                if (DScnxBd.ds.Tables["filliere"].Rows[k][1].ToString().Trim() == ws.Cells[i, j].Value)
                                {
                                    ligne[j - 1] = DScnxBd.ds.Tables["filliere"].Rows[k][0];
                                }
                            }
                        }
                        else
                        {
                            ligne[j - 1] = ws.Cells[i, j].Value;
                        }
                    }
                    DScnxBd.ds.Tables["etudiant"].Rows.Add(ligne);

                }
                else
                {
                    MessageBox.Show("L'etudiant numero " + i + "existe deja");
                }
            }

            this.Dispose();
        }

        private void opnFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            String path = opnFileDialog.FileName;
            textBox1.Text = path;
            wb = app.Workbooks.Open(path);
            ws = wb.Worksheets[1];
        }
    }
}
