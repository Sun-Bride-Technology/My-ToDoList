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
        public List<User> lstUser = new List<User>();
        

        public Login()
        {
            InitializeComponent();
        }
        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && (txtContrasenia.Text != "" && txtContrasenia.Text.Length >= 5) )
            {
                bool login = false;
                foreach (var item in lstUser)
                {
                    if (txtUsuario.Text == item.username && txtContrasenia.Text == item.password)
                    {
                        login = true;
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                    }
                }
                if (login == false)
                    MessageBox.Show("Usuario No encontrado");
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

        private void Login_Load(object sender, EventArgs e)
        {
            User user = new User();
            user.username = "Alfredo01"; user.password = "123456";
            lstUser.Add(user);
        }
    }

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
