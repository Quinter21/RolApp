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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private String path = Environment.CurrentDirectory + "/prueba1.txt";
        private DataTable prueba = new DataTable();
        private bool editando = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prueba.Columns.Add("Campo1");
            prueba.Columns.Add("Campo2");

            dataGridView1.DataSource = prueba;
            Campo2.Text = "";
        }

        private void Nueva_Click(object sender, EventArgs e)
        {
            prueba.Rows.Add(Campo1.Text, Campo2.Text);
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            prueba.Rows.Clear();
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                String[] lines = text.Split(';');
                foreach (string line in lines)
                {
                    String[] parts = line.Split(',');
                    prueba.Rows.Add(parts);
                }
            }
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string total = "";
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < prueba.Rows.Count; i++)
                {
                    for (int j = 0; j < prueba.Columns.Count; j++)
                    {
                        total += prueba.Rows[i][j].ToString();
                        if (j < prueba.Columns.Count - 1) { total += ",";}
                    }
                    if (i < prueba.Rows.Count - 1) { total += ";"; } 
                }
                sw.WriteLine(total);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                prueba.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }catch(Exception ex) {}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Campo1.Text = prueba.Rows[dataGridView1.CurrentCell.RowIndex]["campo1"].ToString();
            Campo2.Text = prueba.Rows[dataGridView1.CurrentCell.RowIndex]["campo2"].ToString();

            editando = true;
        }

        private void GuardarFila_Click(object sender, EventArgs e)
        {
            if (editando)
            {
                prueba.Rows[dataGridView1.CurrentCell.RowIndex]["Campo1"] = Campo1.Text;
                prueba.Rows[dataGridView1.CurrentCell.RowIndex]["Campo2"] = Campo2.Text;
            }
            else
            {
                prueba.Rows.Add(Campo1.Text, Campo2.Text);
            }
        }

        private void NuevoArchivo_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                MessageBox.Show("File created");
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Campo1.Text = Campo2.Text = "";
        }
    }
}
