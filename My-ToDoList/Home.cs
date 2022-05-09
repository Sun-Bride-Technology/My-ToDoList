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

        List<Tareas> tareas = new List<Tareas>();


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
            LoadTasks();

        }

        public void LoadTasks()
        {
            StreamReader reader;
            if (File.Exists(@"C:\Users\igles\source\repos\My-ToDoList\My-ToDoList\Base de Datos\Tareas.csv"))
            {
                reader = new StreamReader(File.OpenRead(@"C:\Users\igles\source\repos\My-ToDoList\My-ToDoList\Base de Datos\Tareas.csv"), System.Text.Encoding.UTF8);
            }
            else
            {                
                StringBuilder salida = new StringBuilder();
                salida.AppendLine(string.Join("|", "Id|Seccion|Tarea|Status"));
                File.AppendAllText(@"C:\Users\igles\source\repos\My-ToDoList\My-ToDoList\Base de Datos\Tareas.csv", salida.ToString());
                
                
                reader = new StreamReader(File.OpenRead(@"C:\Users\igles\source\repos\My-ToDoList\My-ToDoList\Base de Datos\Tareas.csv"), System.Text.Encoding.UTF8);
            }

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
                    case "Mi Día":
                        ListMyDay.Items.Add(item.Tarea);
                        break;
                    case "Importante":
                        break;
                    case "Agenda":
                        break;
                    case "Asignadas a mí":
                        break;
                    case "Tareas":
                        //ListTasks.Items.Add(item.Tarea);
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }

            }
            reader.Close();
        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            panelNuevaTarea.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\Users\igles\source\repos\My-ToDoList\My-ToDoList\Base de Datos\Tareas.csv";
            string separador = "|";

            StringBuilder salida = new StringBuilder();
            salida.AppendLine(string.Join(separador, "Id|Seccion|Tarea|Status"));
            for (int i = 0; i < tareas.Count; i++)
            {
                string cadena = $"{tareas[i].Id}|{tareas[i].Seccion}|{tareas[i].Tarea}|{tareas[i].Status}";
                salida.AppendLine(string.Join(separador, cadena));
            }
            salida.AppendLine(string.Join(separador, $"{tareas.Count + 1}|{cmbLists.Text}|{txtTask.Text}|Active"));
            File.Delete(ruta);
            File.AppendAllText(ruta, salida.ToString());

            Tareas newTask = new Tareas()
            {
                Id = tareas.Count + 1,
                Seccion = cmbLists.Text,
                Tarea = txtTask.Text,
                Status = "Active"
            };
            tareas.Add(newTask);

            switch (cmbLists.Text)
            {
                case "Mi Día":
                    ListMyDay.Items.Add(txtTask.Text);
                    break;
                case "Importante":
                    break;
                case "Agenda":
                    break;
                case "Asignadas a mí":
                    break;
                case "Tareas":
                    //ListTasks.Items.Add(item.Tarea);
                    break;
                default:
                    Console.WriteLine();
                    break;
            }

            txtTask.Text = "";
            cmbLists.SelectedText = "";
        }

        private void btnHiddePanelNewTask_Click(object sender, EventArgs e)
        {
            panelNuevaTarea.Visible = false;
        }

        private void ListMyDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListMyDay.SelectedIndex;

            if (ListMyDay.SelectedIndex >= 0 && (MessageBox.Show("¿Quieres marcar esta tarea como terminada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                ListMyDay.Items.RemoveAt(index);
                List<Tareas> tareasCopy = new List<Tareas>();
                
                foreach (var item in tareas)
                {
                    if (item.Id != index + 1)
                    {
                        tareasCopy.Add(item);
                    }
                }
                //tareas = tareasCopy;
                SaveChanges(tareasCopy);
                MessageBox.Show("Tarea Completada");
            }
        }

        public void SaveChanges(List<Tareas> p_tareas)
        {
            string ruta = @"C:\Users\igles\source\repos\My-ToDoList\My-ToDoList\Base de Datos\Tareas.csv";
            string separador = "|";
            File.Delete(ruta);

            StringBuilder salida = new StringBuilder();
            salida.AppendLine(string.Join(separador, "Id|Seccion|Tarea|Status"));
            for (int i = 0; i < p_tareas.Count; i++)
            {
                string cadena = $"{i+1}|{p_tareas[i].Seccion}|{p_tareas[i].Tarea}|{p_tareas[i].Status}";
                salida.AppendLine(string.Join(separador, cadena));
            }
            
            File.AppendAllText(ruta, salida.ToString());
            tareas = p_tareas;
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
