using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Inicio";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = user.Text;
            string contrasena = pass.Text;
            if (usuario.Equals("marco"))
            {
                if(contrasena.Equals("antonio"))
                {
                    //MessageBox.Show("Usuario y contraseña son correctoss");
                    new Administrador().Show();
                }
                else
                {
                    MessageBox.Show("El usuario y la contraseña son incorrectos");
                }
            }
            else
            {
                MessageBox.Show("El usuario y la contraseña son incorrectos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
