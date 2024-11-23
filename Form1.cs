using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA

{

    public partial class Form1 : Form
    {

        double valor = 0;
        string operacion = "";
        bool operadorPresionado = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0"; 
            valor = 0;
            operacion = "";
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (operadorPresionado || textBox1.Text == "6")
                textBox1.Clear();
            operadorPresionado = false;
            textBox1.Text += boton.Text;
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (operadorPresionado || textBox1.Text == "7")
                textBox1.Clear();
            operadorPresionado = false;
            textBox1.Text += boton.Text;
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (operadorPresionado || textBox1.Text == "8")
                textBox1.Clear();
            operadorPresionado = false;
            textBox1.Text += boton.Text;
        }

        

        
