using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_ToDoList
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && (txtContrasenia.Text != "" && txtContrasenia.Text.Length >= 5) )
            {
                Home home = new Home();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Verificar que se hayan llenado todos los valores de manera correcta");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
