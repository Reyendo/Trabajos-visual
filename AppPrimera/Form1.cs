using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppPrimera
{
    public partial class Form1 : Form
    {
        Double total = 0;
        int contar = 1;
        string abs = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm!@#$%^&*(){}[]<>,/;'][[-+";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void btinicial_Click(object sender, EventArgs e)
        {
            string Peso, Altura;

            Peso = ctusua.Text;
            Altura = ctclave.Text;

            if (Peso == "" || Altura == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (char ab in ctusua.Text)
                {
                    foreach (char c in abs)
                    {
                        if (c == ab)
                        {
                            Peso = "a";
                        }
                    }
                    foreach (char ass in ctusua.Text)
                    {
                        foreach (char c in abs)
                        {
                            if (c == ass)
                            {
                                Peso = "a";
                            }
                        }
                    }
                    if (Peso == "a" || Altura == "a")
                    {
                        MessageBox.Show("Por favor, inserte solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Double PPeso = 0, AAltura = 0;
                        string opa = "";
                        PPeso = Convert.ToDouble(ctusua.Text);
                        AAltura = Convert.ToDouble(ctclave.Text);
                        total = PPeso / (Math.Pow(AAltura, 2));
                        if (total < 16)
                        {
                            opa = "Delgadez severa";
                        }
                        else
                        if (16 < total && total < 18.5)
                        {
                            opa = "Delgadez moderada";
                        }
                        else
                        if (18.5 < total && total < 25)
                        {
                            opa = "Peso normal";
                        }
                        else
                        if (25 < total && total < 30)
                        {
                            opa = "Sobre peso";
                        }
                        else
                        if (30 < total && total < 35)
                        {
                            opa = "Obesidad grado 1";
                        }
                        else
                        if (35 < total && total < 40)
                        {
                            opa = "Obesidad grado 2";
                        }
                        else
                        if (40 < total)
                        {
                            opa = "Obesidad grado 3";
                        }
                        MessageBox.Show("Su IMC es: " + total + "\nSu peso es " + opa, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            contadorSS.Text = Convert.ToString(contar);
            contar = contar + 1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cel = 0;
            double heits = 0;
            if (sius.Text != "")
            {
                cel = Convert.ToDouble(sius.Text);
            }
            if(heit.Text != "")
            {
                heits = Convert.ToDouble(heit.Text);
            }
            if (cel != 0 && heits != 0)
            {
                MessageBox.Show("Solo inserte una conversion a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sius.Text = "";
                heit.Text = "";
                return;
            }
            else
            {
                if (cel != 0)
                {
                    
                    cel = ((cel * (1.8)) + 32);
                    heit.Text=Convert.ToString(cel);
                }
                if (heits != 0)
                {
                    heits = ((heits -32) * (0.5555555556));
                    sius.Text = Convert.ToString(heits);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sius.Text = "";
            heit.Text = "";
        }
    }
}
