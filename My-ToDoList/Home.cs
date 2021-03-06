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

        private void Home_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString().ToLower();

            //Load Task's
            LoadTasks();

        }


        //Tareas
        private void ListMyDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListMyDay.SelectedIndex;

            if (ListMyDay.SelectedIndex >= 0 && (MessageBox.Show("¿Quieres marcar esta tarea como terminada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                var filter = FilterCategory("Mi Día");
                int i = 0;

                foreach (var item in filter)
                {
                    if (i == index)
                    {
                        SaveChanges(item.Id);
                        ListMyDay.Items.RemoveAt(index);
                    }
                    i++;
                }
                MessageBox.Show("Tarea Completada");
            }
        }
        private void ListImportant_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListImportant.SelectedIndex;

            if (ListImportant.SelectedIndex >= 0 && (MessageBox.Show("¿Quieres marcar esta tarea como terminada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                
                

                var filter = FilterCategory("Importante");
                int i = 0;
                foreach (var item in filter)
                {
                    if (i == index)
                    {
                        SaveChanges(item.Id);
                        ListImportant.Items.RemoveAt(index);
                    }
                    i++;
                }
                MessageBox.Show("Tarea Completada");
            }
        }

        
        //Funciones
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

            ClearList();
            //Load List Tasks
            foreach (var item in tareas)
            {
                switch (item.Seccion)
                {
                    case "Mi Día":
                        ListMyDay.Items.Add(item.Tarea);
                        break;
                    case "Importante":
                        ListImportant.Items.Add(item.Tarea);
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
        public void ClearList()
        {
            ListMyDay.Items.Clear();
            ListImportant.Items.Clear();
        }
        public List<Tareas> FilterCategory(string Category)
        {
            List<Tareas> tareasFiltradas = new List<Tareas>();
            foreach (var item in tareas)
            {
                if (item.Seccion == Category)
                {
                    tareasFiltradas.Add(item);
                }
            }
            return tareasFiltradas;
        }
        public void SaveChanges(int IdTarea)
        {
            string ruta = @"C:\Users\igles\source\repos\My-ToDoList\My-ToDoList\Base de Datos\Tareas.csv";
            string separador = "|";

            List<Tareas> tareasCopy = new List<Tareas>();
            File.Delete(ruta);

            StringBuilder salida = new StringBuilder();
            salida.AppendLine(string.Join(separador, "Id|Seccion|Tarea|Status"));
            for (int i = 0; i < tareas.Count; i++)
            {
                if (tareas[i].Id != IdTarea)
                {
                    string cadena = $"{i + 1}|{tareas[i].Seccion}|{tareas[i].Tarea}|{tareas[i].Status}";

                    Tareas tarea = new Tareas()
                    {
                        Id = i,
                        Seccion = tareas[i].Seccion,
                        Tarea = tareas[i].Tarea,
                        Status = tareas[i].Status
                    };

                    tareasCopy.Add(tarea);
                    salida.AppendLine(string.Join(separador, cadena));
                }
            }

            File.AppendAllText(ruta, salida.ToString());
            tareas = tareasCopy;
        }


        //Botones
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtTask.Text != "" && cmbLists.Text != "")
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
                        ListImportant.Items.Add(txtTask.Text);
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
            else
            {
                MessageBox.Show("Ambos campos son obligatorios");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            panelNuevaTarea.Visible = true;
        }
        private void btnHiddePanelNewTask_Click(object sender, EventArgs e)
        {
            panelNuevaTarea.Visible = false;
        }
        private void btnImportant_Click(object sender, EventArgs e)
        {
            label1.Text = "Tareas Importantes";
            ListImportant.Visible = true;

            ListMyDay.Visible = false;
        }
        private void btnMyDay_Click(object sender, EventArgs e)
        {
            label1.Text = "Mi Día";
            ListMyDay.Visible = true;

            ListImportant.Visible = false;
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
