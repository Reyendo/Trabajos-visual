using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer1
{
    public partial class Form1 : Form
    {
        int z= 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = User.Text;
            string b = pass.Text;
            if(a=="" || b == "")
            {
                MessageBox.Show("Complete los campos","Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }
            else
            {
                if (a == "admin" && b == "admin123")
                {
                    MessageBox.Show("Bienvenido Admin", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.None);
                    User.Text = "";
                    pass.Text = "";
                }
                else
                {
                    MessageBox.Show("Usuario o Contrasena incorrectos, le quedan "+ (3-z) +" intentos.", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    z = z + 1;
                    if (z == 4)
                    {
                        MessageBox.Show("Se ha quedado sin intentos", "Sin intentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                    }
                }
            }
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
