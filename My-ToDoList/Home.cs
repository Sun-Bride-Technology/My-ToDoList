using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_ToDoList
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString().ToLower();

            //Load Task's
            List<Tareas> tareas = new List<Tareas>();
            var reader = new StreamReader(File.OpenRead(@"C:\Users\igles\source\repos\My-ToDoList\My-ToDoList\Base de Datos\Tareas.csv"), System.Text.Encoding.UTF8);
            while (!reader.EndOfStream)
            {
                var linea = reader.ReadLine();
                var valores = linea.Split('|');

                for (int i = 0; i < valores.Length; i++)
                {
                    if ((i % 4) == 0)
                    {
                        //MessageBox.Show(valores[i] + " - " + valores[i + 1] + " - " + valores[i + 2] + " - " + valores[i + 3]);
                        if (valores[i + 3] == "Active")
                        {
                            Tareas tarea = new Tareas()
                            {
                                Id = Convert.ToInt32(valores[i]),
                                Seccion = valores[i + 1],
                                Tarea = valores[i + 2],
                                Status = valores[i + 3]
                            };

                            tareas.Add(tarea);
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
            ListMyDay.Items.Clear();
            //Load List Tasks
            foreach (var item in tareas)
            {
                switch (item.Seccion)
                {
                    case "MyDay":
                        ListMyDay.Items.Add(item.Tarea);
                        break;
                    case "Important":
                        break;
                    case "Planned":
                        break;
                    case "ForMe":
                        break;
                    case "Tasks":
                        //ListTasks.Items.Add(item.Tarea);
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                
            }
            //ListTasks.Items.Add("Añadido");
        }
    }

    public class Tareas
    {
        public int Id{ get; set; }
        public string Seccion{ get; set; }
        public string Tarea { get; set; }
        public string Status { get; set; }
    }
}
