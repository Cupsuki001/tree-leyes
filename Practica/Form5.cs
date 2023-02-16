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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sub, des, total, imp;
            sub = Convert.ToDouble(maskedTextBox1.Text);
            if (treeView1.SelectedNode.Text.Equals("Contado"))
            {

                MessageBox.Show("Listo");
                if (sub >= 100 && sub <= 1000)
                {
                    if (checkBox1.Checked == true)
                    {
                        des = sub * 0.05;
                        textBox1.Text = des.ToString();
                        total = sub - des;
                        textBox2.Text = total.ToString();
                    }
                    else
                    {
                        if (checkBox1.Checked == false)
                        {
                            textBox1.Text = "";
                            imp = sub * 0.15;
                            textBox1.Text = imp.ToString();
                            total = sub * 1.15;
                            textBox2.Text = total.ToString();
                        }

                    }
                }
                else
                {
                    if (sub > 100 && sub <= 3000)
                    {
                        if (checkBox1.Checked == true)
                        {

                            des = sub * 0.10;
                            textBox1.Text = des.ToString();
                            total = sub - des;
                            textBox2.Text = total.ToString();
                        }
                        else
                        {
                            if (checkBox1.Checked == false)
                            {
                                textBox1.Text = "";
                                imp = sub * 0.10;
                                textBox1.Text = imp.ToString();
                                total = sub * 1.10;
                                textBox2.Text = total.ToString();
                            }
                        }
                    }
                    else
                    {
                        if (sub >= 3001)
                        {
                            if (checkBox1.Checked == true)
                            {
                                des = sub * 0.12;
                                textBox1.Text = des.ToString();
                                total = sub - des;
                                textBox2.Text = total.ToString();
                            }
                            else
                            {
                                if (checkBox1.Checked == false)
                                {
                                    textBox1.Text = "";
                                    textBox1.Enabled = false;
                                    imp = sub * 1.15;

                                    textBox2.Text = imp.ToString();
                                }
                            }
                        }
                    }

                }
            }
            else
            {
                if (treeView1.SelectedNode.Text.Equals("Credito"))
                {
                    checkBox1.Enabled = false;
                    if (sub >= 100 && sub <= 1000)
                    {
                        if (checkBox1.Checked == true)
                        {
                            des = sub * 0.12;
                            textBox1.Text = des.ToString();
                            total = sub + des;
                            textBox2.Text = total.ToString();
                        }
                    }

                }
                else
                {
                    if (sub >= 1001 && sub <= 3000)
                    {
                        if (checkBox1.Checked == true)
                        {

                            des = sub * 0.10;
                            textBox1.Text = des.ToString();
                            total = sub + des;
                            textBox2.Text = total.ToString();
                        }

                    }
                    else
                    {
                        if (sub >= 3001)
                        {
                            if (checkBox1.Checked == true)
                            {
                                des = sub * 0.05;
                                textBox1.Text = des.ToString();
                                total = sub + des;
                                textBox2.Text = total.ToString();
                            }

                        }
                    }

                }
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           

        }
    }
}
