using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            maskedTextBox2.Enabled = false;
            textBox1.Enabled = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text.Equals("INNS Laboral"))
            {
                label2.Text = "Subtotal(Antes del INNS Laboral";
                label3.Text = "Total";

            }
            else if (treeView1.SelectedNode.Text.Equals("INNS Patronal"))
            {
                label2.Text = "Subtotal(Antes del INNS Patronal)";
                label3.Text = "Total";

            }
            else if (treeView1.SelectedNode.Text.Equals("IR"))
            {
                label2.Text = "Subtotal(Antes del IR";
                label3.Text = "Total";

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            textBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cod, Ing, men, sub, total;
            if (maskedTextBox1.Text == "" || maskedTextBox3.Text == "")
            {
                MessageBox.Show("No se pueden dejar espacios en blancos", "Error, ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cod = double.Parse(maskedTextBox3.Text);
                Ing = double.Parse(maskedTextBox1.Text);
                if (Ing >= 6000 && Ing <= 500000)
                {
                    if (treeView1.SelectedNode.Text.Equals("INNS Laboral"))
                    {
                        ;
                        men = Ing * 0.07;
                        sub = Ing;
                        maskedTextBox2.Text = sub.ToString();
                        total = Ing - men;
                        textBox1.Text = total.ToString();
                    }
                    else if (treeView1.SelectedNode.Text.Equals("INNS Patronal"))
                    {
                        ;
                        men = Ing * 0.22;
                        sub = Ing;
                        maskedTextBox2.Text = sub.ToString();
                        total = Ing + men;
                        textBox1.Text = total.ToString();
                    }
                    else if (treeView1.SelectedNode.Text.Equals("IR"))
                    {
                        ;
                        men = Ing * 0.11;
                        sub = Ing;
                        maskedTextBox2.Text = sub.ToString();
                        total = Ing - men;
                        textBox1.Text = total.ToString();
                    } else
                    {
                        MessageBox.Show("Seleccione Una de deduccion");
                    }


                }
                else
                {
                    MessageBox.Show("El rango es de 6,000 a 500,000");
                }
            }
        }
    }
}
