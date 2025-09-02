using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    
    public partial class Form1 : Form
    {
        double var1, var2, var3, memoru=0;
        int cont=0;
        int op=0;
        bool listeza=true;
        bool operador=false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        

        private void button31_Click(object sender, EventArgs e)
        {
            double var2 = double.Parse(calc.Text);
            switch (op)
            {
                case 1:
                    var3 = var1 + var2;
                    break;
                case 2:
                    var3 = var1 - var2;
                    break;
                case 3:
                    var3 = var1 * var2;
                    break;
                case 4:
                    if (var2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var3 = var1 / var2;
                    break;
                case 5:
                    var3 = Math.Pow(var1, var2);
                    break;
                default:
                    break;
                }
            calc.Text = var3.ToString();
            var1 = var3; 
            operador = false;
            listeza = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (calc.Text == "0")
            {
                calc.Text = "";
            }
            if (listeza)
            {
                calc.Text = "";
            }
            
                calc.Text = calc.Text + "1";
            
          
            listeza = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (calc.Text == "0")
            {
                calc.Text = "";
            }
            if (listeza)
            {
                calc.Text = "";
            }
            
                calc.Text = calc.Text + "2";
            
            
            listeza = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
           if (calc.Text == "0")
            {
                calc.Text = "";
            }
            if (listeza)
            {
                calc.Text = "";
            }
            
                calc.Text = calc.Text + "3";
            
            
            listeza = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (calc.Text == "0")
            {
                calc.Text = "";
            }
            if (listeza)
            {
                calc.Text = "";
            }
            
                calc.Text = calc.Text + "4";
            
           
            listeza = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (calc.Text == "0")
            {
                calc.Text = "";
            }
            if (listeza)
            {
                calc.Text = "";
            }
            
                calc.Text = calc.Text + "5";
            
            
            listeza = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (calc.Text == "0")
            {
                calc.Text = "";
            }
            if (listeza)
            {
                calc.Text = "";

            }
            
                calc.Text = calc.Text + "6";
            
            
            listeza=false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (calc.Text == "0")
            {
                calc.Text = "";
            }
            if (listeza)
            {
                calc.Text = "";
            }
            
                calc.Text = calc.Text + "7";
            
            
            listeza = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (calc.Text == "0")
            {
                calc.Text = "";
            }
            if (listeza)
            {
                calc.Text = "";
            }
            
                calc.Text = calc.Text + "8";
            
            
            listeza = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (calc.Text == "0")
            {
                calc.Text = "";
            }
            if (listeza)
            {
                calc.Text = "";
            }
            
                calc.Text = calc.Text + "9";
            
            
            listeza = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (calc.Text == "0")
            {
                calc.Text = "";
            }
            if (listeza)
            {
                calc.Text = "";
            }
            
                calc.Text = calc.Text + "0";
            
          
            listeza = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (!listeza)
            {
                var1 = double.Parse(calc.Text);
                listeza = true;
            }
            op = 1;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (!listeza)
            {
                var1 = double.Parse(calc.Text);
                listeza = true;
            }
            op = 2;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (!listeza)
            {
                var1 = double.Parse(calc.Text);
                listeza = true;
            }
            op = 3;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!listeza)
            {
                var1 = double.Parse(calc.Text);
                listeza = true;
            }
            op = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc.Text = "0";
            var1 = 0;
            op = 0;
            operador = false;
            listeza = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            calc.Text = Math.PI.ToString();
            listeza = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calc.Text = memoru.ToString();
            listeza = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calc.Text);
            if (num < 0)
            {
                MessageBox.Show("No se puede calcular la raíz cuadrada de un número negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            calc.Text = Math.Sqrt(num).ToString();
            listeza = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            memoru -= double.Parse(calc.Text);
            listeza = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            memoru = 0;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (listeza)
            {
                calc.Text = "";
                listeza = false;
            }

            Button btn = (Button)sender;
            // Evita múltiples puntos decimales.
            if (btn.Text == "." && calc.Text.Contains("."))
            {
                return;
            }

            calc.Text = calc.Text + btn.Text;
            listeza = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double degrees = double.Parse(calc.Text);
            double radians = degrees * (Math.PI / 180);
            calc.Text = Math.Sin(radians).ToString();
            listeza = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double degrees = double.Parse(calc.Text);
            double radians = degrees * (Math.PI / 180);
            calc.Text = Math.Cos(radians).ToString();
            listeza = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double degrees = double.Parse(calc.Text);
            double radians = degrees * (Math.PI / 180);
            calc.Text = Math.Tan(radians).ToString();
            listeza = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calc.Text = "0";
            var1 = 0;
            op = 0;
            operador = false;
            listeza = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            calc.Text = "2.71828";
            listeza = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            memoru += double.Parse(calc.Text);
            listeza = true;
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            if (!listeza)
            {
                var1 = double.Parse(calc.Text);
                listeza = true;
            }
            op = 4;
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double num = double.Parse(calc.Text);
            if (num <= 0)
            {
                MessageBox.Show("El logaritmo solo se puede calcular para números positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            calc.Text = Math.Log(num).ToString();
            listeza = true;
        }
    }
}
