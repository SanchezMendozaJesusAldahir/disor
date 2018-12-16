using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int desp = (int)desplazaminento.Value;
            Cesar cesar = new Cesar(textBox1.Text, desp);
            textBox2.Text = cesar.Cifrar();
            textBox4.Text = textBox1.Text;
            char[] array = textBox1.Text.ToCharArray();
            Array.Reverse(array);
            textBox3.Text = new String(array);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int desp = (int)desplazaminento.Value;
            Cesar cesar = new Cesar(textBox1.Text, desp);
            textBox2.Text = cesar.Cifrar();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void desplazaminento_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void numericUpDown2_MouseUp(object sender, MouseEventArgs e)
        {
            int grupo = (int)grupos.Value;
            String texto = textBox1.Text;
            char[] array;
            if (texto.Length == grupo || grupo > texto.Length )
            {
                array = texto.ToCharArray();
                Array.Reverse(array);
                textBox4.Text = new String(array);
            }
            else
            {
                textBox4.Text = texto;
            }
        }
    }
}
