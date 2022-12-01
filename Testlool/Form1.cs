using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testlool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Procesor procaak;
        RAM ramka;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                procaak = new Procesor(textBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
                ramka = new RAM(textBox2.Text, (short)numericUpDown4.Value, (int)numericUpDown3.Value);
                MessageBox.Show(procaak.ToString());
                MessageBox.Show(ramka.ToString());
            }
            else
            {
                MessageBox.Show("Zadej značku");
            }
        }
    }
}
