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
    public partial class Principal : Form
    {
        public DataTable TEnemigos = new DataTable();
        EnemyCard[] enemyCards = new EnemyCard[0];

        public Principal()
        {
            InitializeComponent();

            inicializar_T_enemigos();
            cargarDatos();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            doubleClick1.DoubleClick += DoubleClick1_DoubleClick;
        }

        private void DoubleClick1_DoubleClick(object sender, EventArgs e)
        {
            Enemigos fe = new Enemigos();
            fe.Show();
            fe.FormClosed += delegate
                {
                    cargarDatos();
                };
        }


        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Arial", 12);
            Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(22, 5);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Enemigos", font, brush, 0, 0);
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Arial", 14);
            Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(20, 20);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("Enemigos blablabla", font, brush, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablePrevisual.DataSource = TEnemigos;
            for (int i = 1; i < TablePrevisual.Columns.Count; i++)
            {
                TablePrevisual.Columns[i].Visible = false;
            }
        }

        private void inicializar_T_enemigos()
        {
            DataColumn idColumn = new DataColumn("ID", typeof(int));
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 1;
            idColumn.AutoIncrementStep = 1;
            idColumn.Unique = true;
            idColumn.AllowDBNull = false;

            TEnemigos.Columns.Add("Nombre", typeof(string));
            TEnemigos.Columns.Add("PV", typeof(int));
            TEnemigos.Columns.Add("PM", typeof(int));
            TEnemigos.Columns.Add("FUE", typeof(int));
            TEnemigos.Columns.Add("DES", typeof(int));
            TEnemigos.Columns.Add("POD", typeof(int));
            TEnemigos.Columns.Add("CON", typeof(int));
            TEnemigos.Columns.Add("APA", typeof(int));
            TEnemigos.Columns.Add("EDU", typeof(int));
            TEnemigos.Columns.Add("TAM", typeof(int));
            TEnemigos.Columns.Add("INT", typeof(int));
            TEnemigos.Columns.Add("MOV", typeof(int));

            TEnemigos.Rows.Clear();
        }

        private void cargarDatos()
        {
            TEnemigos.Clear();

            if (!File.Exists(Environment.CurrentDirectory + "/enemigos.txt"))
            {
                using (FileStream fs = File.Create(Environment.CurrentDirectory + "/enemigos.txt")) { }
            }

            using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "/enemigos.txt"))
            {
                string text = sr.ReadToEnd();
                String[] lines = text.Split('\n');
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        String[] parts = line.Split(',');
                        TEnemigos.Rows.Add(parts);
                    }
                }
            }
        }

        private void TablePrevisual_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EnemyCard enemy = new EnemyCard(TEnemigos.Rows[e.RowIndex]["Nombre"].ToString());
            AreaPanel.Controls.Add(enemy);
        }

        private void TablePrevisual_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            TablePrevisual.DoDragDrop(e.RowIndex.ToString(), DragDropEffects.Copy);

        }

        private void AreaPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void AreaPanel_DragDrop(object sender, DragEventArgs e)
        {
            int index = Int32.Parse(e.Data.GetData(DataFormats.Text).ToString());
            //EnemyCard enemy = new EnemyCard(TEnemigos.Rows[TablePrevisual.CurrentCell.RowIndex]["Nombre"].ToString());
            EnemyCard enemy = new EnemyCard(TEnemigos.Rows[index]["Nombre"].ToString());
            AreaPanel.Controls.Add(enemy);
        }

        
    }
}
