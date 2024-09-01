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
    public partial class Enemigos : Form
    {
        private String path = Environment.CurrentDirectory + "/enemigos.txt";
        public DataTable enemigos = new DataTable();
        public Enemigos()
        {
            InitializeComponent();
        }

        private void Enemigos_Load(object sender, EventArgs e)
        {

            inicializar_enemigos();
            

            enemigos.Rows.Add("JOSE", "14", "15", "50", "50", "50", "50", "50", "50", "50", "50", "50");
            enemigos.Rows.Add("ANGEL", "24", "5", "70", "60", "80", "90", "50", "50", "70", "80", "60");

            String[] atribs = { "Pelea", "Esquivar" };

            Atributos.DataSource = atribs;
        }

        private void ListaEnemigos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Nombre.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["Nombre"].ToString();
            numPM.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["PM"].ToString();
            numPV.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["PV"].ToString();
            numFUE.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["FUE"].ToString();
            numDES.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["DES"].ToString();
            numPOD.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["POD"].ToString();
            numCON.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["CON"].ToString();
            numAPA.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["APA"].ToString();
            numEDU.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["EDU"].ToString();
            numTAM.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["TAM"].ToString();
            numINT.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["INT"].ToString();
            numMOV.Text = enemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["MOV"].ToString();
        }

        private void Atributos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(Atributos.SelectedItem.ToString()); 
            if(Atributos.SelectedItem.ToString() == "Pelea")
            {
                numAtrib.Value = 65;
            }
            else
            {
                numAtrib.Value = 70;
            }
        }

        private void inicializar_enemigos()
        {
            //enemigos.Columns.Add("id", typeof(int));
            enemigos.Columns.Add("Nombre", typeof(string));
            enemigos.Columns.Add("PV", typeof(int));
            enemigos.Columns.Add("PM", typeof(int));
            enemigos.Columns.Add("FUE", typeof(int));
            enemigos.Columns.Add("DES", typeof(int));
            enemigos.Columns.Add("POD", typeof(int));
            enemigos.Columns.Add("CON", typeof(int));
            enemigos.Columns.Add("APA", typeof(int));
            enemigos.Columns.Add("EDU", typeof(int));
            enemigos.Columns.Add("TAM", typeof(int));
            enemigos.Columns.Add("INT", typeof(int));
            enemigos.Columns.Add("MOV", typeof(int));

            //enemigos.PrimaryKey = new DataColumn[] { enemigos.Columns["id"] };

            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
            }

            enemigos.Rows.Clear();

            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                if (text != "")
                {
                    String[] lines = text.Split(';');
                    foreach (string line in lines)
                    {
                        String[] parts = line.Split(',');
                        enemigos.Rows.Add(parts);
                    }
                }
            }

            ListaEnemigos.DataSource = enemigos;
            for (int i = 1; i < ListaEnemigos.Columns.Count; i++)
            {
                ListaEnemigos.Columns[i].Visible = false;
            }
        }
    }
}
