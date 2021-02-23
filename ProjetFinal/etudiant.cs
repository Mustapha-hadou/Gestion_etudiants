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
    public partial class etudiant : UserControl
    {
        public etudiant()
        {
            InitializeComponent();
        }
           

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DScnxBd.ds.Tables["etudiant"];

        }

        private void etudiant_Load(object sender, EventArgs e)
        {
                comboBox1.DataSource = DScnxBd.ds.Tables["etudiant"];
                comboBox1.DisplayMember = "cne";
                comboBox1.ValueMember = "cne";
                comboBox3.DataSource = DScnxBd.ds.Tables["filliere"];
                comboBox3.DisplayMember = "NOM_filliere";
                comboBox3.ValueMember = "ID_filliere";
 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DScnxBd.ds.Tables["etudiant"].DefaultView.Sort = "Nom";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            DScnxBd.ds.Tables["etudiant"].DefaultView.Sort = "Nom DESC";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!DScnxBd.verifierExitanceCNE(textBox3.Text))
            {

                DataRow ligne = DScnxBd.ds.Tables["etudiant"].NewRow();

                ligne[0] = textBox3.Text;
                ligne[1] = textBox5.Text;
                ligne[2] = textBox4.Text;
                if (radioButton1.Checked)
                {
                    ligne[3] = 'f';
                }
                else
                {
                    ligne[3] = 'h';
                }

                ligne[4] = (DateTime)dateTimePicker1.Value;
                ligne[5] = textBox6.Text;
                ligne[6] = textBox7.Text;
                ligne[7] = comboBox3.SelectedValue;


                DScnxBd.ds.Tables["etudiant"].Rows.Add(ligne);
            }
            else
            {
                MessageBox.Show("l'etudiant eexiste deja");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int cp = -1;
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("veuillez choisir un etudiant");
            }
            else
            {
                for (int i = 0; i < DScnxBd.ds.Tables["etudiant"].Rows.Count; i++)
                {
                    if (!(DScnxBd.ds.Tables["etudiant"].Rows[i].RowState == DataRowState.Deleted))
                    {
                        if (DScnxBd.ds.Tables["etudiant"].Rows[i][0].ToString() == comboBox1.SelectedValue)
                        {
                            DScnxBd.ds.Tables["etudiant"].Rows[i].Delete();
                            //comboBox1.Items.Remove(DScnxBd.ds.Tables["etudiant"].Rows[i][0]);
                            textBox3.Text = null;
                            textBox4.Text = null;
                            textBox5.Text = null;
                            textBox6.Text = null;
                            textBox7.Text = null;
                            comboBox1.SelectedItem = null;
                            cp = i;
                            break;
                        }
                    }
                }
                if (cp == -1)
                {
                    MessageBox.Show("l'etudiant n'existe pas");
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogForm dial = new DialogForm();
            dial.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DScnxBd.ds.Tables["etudiant"].Rows.Count; i++)
            {
                if (!(DScnxBd.ds.Tables["etudiant"].Rows[i].RowState == DataRowState.Deleted))
                {
                    if (DScnxBd.ds.Tables["etudiant"].Rows[i][0].ToString() == comboBox1.SelectedValue)
                    {
                        textBox3.Text = DScnxBd.ds.Tables["etudiant"].Rows[i][0].ToString();
                        textBox5.Text = DScnxBd.ds.Tables["etudiant"].Rows[i][1].ToString();
                        textBox4.Text = DScnxBd.ds.Tables["etudiant"].Rows[i][2].ToString();
                        dateTimePicker1.Value = (DateTime)DScnxBd.ds.Tables["etudiant"].Rows[i][4];

                        if (DScnxBd.ds.Tables["etudiant"].Rows[i][3].ToString().Equals("f"))
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        textBox6.Text = DScnxBd.ds.Tables["etudiant"].Rows[i][5].ToString();
                        textBox7.Text = DScnxBd.ds.Tables["etudiant"].Rows[i][6].ToString();
                        comboBox3.SelectedValue = DScnxBd.ds.Tables["etudiant"].Rows[i][7].ToString();
                    }
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
            
            MessageBox.Show(textBox5.Text);

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("veuillez choisir un etudiant");
            }
            else
            {
                
                for (int i = 0; i < DScnxBd.ds.Tables["etudiant"].Rows.Count; i++)
                {

                    if (!(DScnxBd.ds.Tables["etudiant"].Rows[i].RowState == DataRowState.Deleted))
                    {
                        if (DScnxBd.ds.Tables["etudiant"].Rows[i][0].ToString() == comboBox1.SelectedValue.ToString())
                        {
                            comboBox1.SelectedIndex = -1;

                            MessageBox.Show(DScnxBd.ds.Tables["etudiant"].Rows[i][1].ToString());
                            DScnxBd.ds.Tables["etudiant"].Rows[i][0] = textBox3.Text;
                            DScnxBd.ds.Tables["etudiant"].Rows[i][1] = textBox5.Text;
                            DScnxBd.ds.Tables["etudiant"].Rows[i][2] = textBox4.Text;
                            DScnxBd.ds.Tables["etudiant"].Rows[i][4] = dateTimePicker1.Value;

                            DScnxBd.ds.Tables["etudiant"].Rows[i][5] = textBox6.Text;
                            DScnxBd.ds.Tables["etudiant"].Rows[i][6] = textBox7.Text;
                            DScnxBd.ds.Tables["etudiant"].Rows[i][7] = comboBox3.SelectedValue;
                            if (radioButton1.Checked)
                            {
                                DScnxBd.ds.Tables["etudiant"].Rows[i][3] = 'f';
                            }
                            else
                            {
                                DScnxBd.ds.Tables["etudiant"].Rows[i][3] = 'h';
                            }
                            
                            MessageBox.Show(DScnxBd.ds.Tables["etudiant"].Rows[i][1].ToString());
                            break;
                        }
                    }
                }
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
