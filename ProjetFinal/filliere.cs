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
    public partial class filliere : UserControl
    {
        public filliere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataRow ligne = DScnxBd.ds.Tables["filliere"].NewRow();

            ligne[1] = textBox1.Text;
            int DerniereligneSupprime = -1;

            for (int i = 0; i < DScnxBd.ds.Tables["filliere"].Rows.Count; i++)
            {
                if (!(DScnxBd.ds.Tables["filliere"].Rows[i].RowState == DataRowState.Deleted))
                {
                    DerniereligneSupprime = i;
                }

            }
            if (DerniereligneSupprime != -1)
            {
                ligne[0] = Convert.ToInt32(DScnxBd.ds.Tables["filliere"].Rows[DerniereligneSupprime][0]) + 1;
            }
            else
            {
                ligne[0] = 1;
            }
            DScnxBd.ds.Tables["filliere"].Rows.Add(ligne);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            for (int i = 0; i < DScnxBd.ds.Tables["filliere"].Rows.Count; i++)
            {
                if (!(DScnxBd.ds.Tables["filliere"].Rows[i].RowState == DataRowState.Deleted))
                {
                    if (Convert.ToInt32(DScnxBd.ds.Tables["filliere"].Rows[i][0]) == n)
                    {
                        DScnxBd.ds.Tables["filliere"].Rows[i].Delete();
                    }

                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int n = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            MessageBox.Show(DScnxBd.ds.Tables["filliere"].Rows.Count.ToString());
            for (int i = 0; i < DScnxBd.ds.Tables["filliere"].Rows.Count; i++)
            {

                if (!(DScnxBd.ds.Tables["filliere"].Rows[i].RowState == DataRowState.Deleted))
                {
                    if (Convert.ToInt32(DScnxBd.ds.Tables["filliere"].Rows[i][0]) == n)
                    {
                        DScnxBd.ds.Tables["filliere"].Rows[i][1] = textBox2.Text;
                        panel1.Hide();

                    }

                }

            }

        }
        private void filliere_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            dataGridView1.DataSource = DScnxBd.ds.Tables["filliere"];
        }
    }
}
