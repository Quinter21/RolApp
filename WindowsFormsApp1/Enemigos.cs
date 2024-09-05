using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        public DataTable TEnemigos = new DataTable();
        public DataTable TAtributos = new DataTable();
        private int seleccionado = -1;
        private bool iniBox = false;
        private Size oriSize;

        private DataRow tempAtribs;

        private Rectangle atRecTest;
        private Rectangle enRecTest;
        private Rectangle temRecTest;
        public Enemigos()
        {
            InitializeComponent();

            this.Resize += Enemigos_Resiz;
            oriSize = this.Size;
            atRecTest = new Rectangle(atributosTest.Location, atributosTest.Size);
            enRecTest = new Rectangle(enemigosTest.Location, enemigosTest.Size);
            
            inicializar_T_enemigos();
            inicializar_T_atributos();
            cargarDatos();

        }

        private void Enemigos_Resiz(object sender, EventArgs e)
        {
            resize_Control(enemigosTest, enRecTest);
            resize_Control(atributosTest, atRecTest);
        }

        private void Enemigos_FormClosing(object sender, FormClosingEventArgs e)
        {
            guardarDatos();
        }

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float) this.Width - (float) oriSize.Width;
            int newWidth = (int)(r.Width + xRatio);

            c.Size = new Size(newWidth, r.Height);
        }

        private void Enemigos_Load(object sender, EventArgs e)
        {
            Atributos.SelectedIndex = -1;
            iniBox = true;

            /*DataRow row = TEnemigos.NewRow();
            row["Nombre"] = "JOSE";
            row["PM"] = 14;
            row["PV"] = 15;
            row["FUE"] = 60;
            row["DES"] = 50;
            row["POD"] = 60;
            row["CON"] = 70;
            row["APA"] = 75;
            row["EDU"] = 80;
            row["TAM"] = 65;
            row["INT"] = 80;
            row["MOV"] = 7;
            TEnemigos.Rows.Add(row);
            TAtributos.Rows.Add();

            row = TEnemigos.NewRow();
            row["Nombre"] = "ANGEL";
            row["PM"] = 24;
            row["PV"] = 5;
            row["FUE"] = 90;
            row["DES"] = 80;
            row["POD"] = 50;
            row["CON"] = 80;
            row["APA"] = 65;
            row["EDU"] = 60;
            row["TAM"] = 70;
            row["INT"] = 50;
            row["MOV"] = 9;
            TEnemigos.Rows.Add(row);
            TAtributos.Rows.Add(100);*/
        }

        private void ListaEnemigos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textNombre.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["Nombre"].ToString();
            numPM.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["PM"].ToString();
            numPV.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["PV"].ToString();
            numFUE.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["FUE"].ToString();
            numDES.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["DES"].ToString();
            numPOD.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["POD"].ToString();
            numCON.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["CON"].ToString();
            numAPA.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["APA"].ToString();
            numEDU.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["EDU"].ToString();
            numTAM.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["TAM"].ToString();
            numINT.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["INT"].ToString();
            numMOV.Text = TEnemigos.Rows[ListaEnemigos.CurrentCell.RowIndex]["MOV"].ToString();

            seleccionado = e.RowIndex;
            tempAtribs = TAtributos.NewRow();

            foreach (DataColumn column in TAtributos.Columns)
                tempAtribs[column] = TAtributos.Rows[seleccionado][column];

            Atributos_SelectedIndexChanged(Atributos.SelectedItem, null);
        }

        private void Atributos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!iniBox) { return; }
            
            if (Atributos.SelectedIndex != -1)
            {
                if (tempAtribs[Atributos.SelectedIndex] != null)
                {
                    Console.WriteLine(tempAtribs[Atributos.SelectedIndex]);
                    Console.WriteLine(tempAtribs[Atributos.SelectedIndex].GetType());
                    numAtrib.Value = Convert.ToDecimal(tempAtribs[Atributos.SelectedItem.ToString()]);
                }
            }
        }

        private void inicializar_T_enemigos()
        {
            DataColumn idColumn = new DataColumn("ID", typeof (int));
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

            ListaEnemigos.DataSource = TEnemigos;
            for (int i = 2; i < ListaEnemigos.Columns.Count; i++)
            {
                ListaEnemigos.Columns[i].Visible = false;
            }

            enemigosTest.DataSource = TEnemigos;
        }
        
        private void inicializar_T_atributos()
        {
            TAtributos.Columns.Add("ANTROPOLOGÍA", typeof(int)).DefaultValue = 1;
            TAtributos.Columns.Add("ARMA CORTA (FUEGO)", typeof(int)).DefaultValue = 20;
            TAtributos.Columns.Add("FUSIL/ESCOPETA", typeof(int)).DefaultValue = 25;
            TAtributos.Columns.Add("ARQUEOLOGÍA", typeof(int)).DefaultValue = 1;
            TAtributos.Columns.Add("BUSCAR LIBROS", typeof(int)).DefaultValue = 20;
            TAtributos.Columns.Add("CERRAJERÍA", typeof(int)).DefaultValue = 1;
            TAtributos.Columns.Add("CHARLATANERÍA", typeof(int)).DefaultValue = 5;
            TAtributos.Columns.Add("CIENCIA", typeof(int)).DefaultValue = 1;
            TAtributos.Columns.Add("CIANCIAS OCULTAS", typeof(int)).DefaultValue = 5;
            TAtributos.Columns.Add("PELEA", typeof(int)).DefaultValue = 25;
            TAtributos.Columns.Add("ARMA CORTA (CaC)", typeof(int)).DefaultValue = 15;
            TAtributos.Columns.Add("CONDUCIR AUTOMÓVIL", typeof(int)).DefaultValue = 20;
            TAtributos.Columns.Add("CONDUCIR MAQUINARIA", typeof(int)).DefaultValue = 1;
            TAtributos.Columns.Add("CONTABILIDAD", typeof(int)).DefaultValue = 5;
            TAtributos.Columns.Add("CRÉDITO", typeof(int)).DefaultValue = 0;
            TAtributos.Columns.Add("DERECHO", typeof(int)).DefaultValue = 5;
            TAtributos.Columns.Add("DESCUBRIR", typeof(int)).DefaultValue = 25;
            TAtributos.Columns.Add("DISFRAZARSE", typeof(int)).DefaultValue = 5;
            TAtributos.Columns.Add("ELECTRICIDAD", typeof(int)).DefaultValue = 10;
            TAtributos.Columns.Add("ENCANTO", typeof(int)).DefaultValue = 15;
            TAtributos.Columns.Add("EQUITACIÓN", typeof(int)).DefaultValue = 5;
            TAtributos.Columns.Add("ESCUCHAR", typeof(int)).DefaultValue = 20;
            TAtributos.Columns.Add("ESQUIVAR", typeof(int)).DefaultValue = 0;
            TAtributos.Columns.Add("HISTORIA", typeof(int)).DefaultValue = 5;
            TAtributos.Columns.Add("INTIMIDAR", typeof(int)).DefaultValue = 15;
            TAtributos.Columns.Add("JUEGO DE MANOS", typeof(int)).DefaultValue = 10;
            TAtributos.Columns.Add("LANZAR", typeof(int)).DefaultValue = 20;
            TAtributos.Columns.Add("MECÁNICA", typeof(int)).DefaultValue = 10;
            TAtributos.Columns.Add("MEDICINA", typeof(int)).DefaultValue = 1;
            TAtributos.Columns.Add("NADAR", typeof(int)).DefaultValue = 20;
            TAtributos.Columns.Add("NATURALEZA", typeof(int)).DefaultValue = 10;
            TAtributos.Columns.Add("ORIENTARSE", typeof(int)).DefaultValue = 10;
            TAtributos.Columns.Add("PERSUASIÓN", typeof(int)).DefaultValue = 10;
            TAtributos.Columns.Add("PILOTAR", typeof(int)).DefaultValue = 1;
            TAtributos.Columns.Add("PRIMEROS AUXILIOS", typeof(int)).DefaultValue = 30;
            TAtributos.Columns.Add("PSICOANÁLISIS", typeof(int)).DefaultValue = 1;
            TAtributos.Columns.Add("PSICOLOGÍA", typeof(int)).DefaultValue = 10;
            TAtributos.Columns.Add("SALTAR", typeof(int)).DefaultValue = 20;
            TAtributos.Columns.Add("SEGUIR RASTROS", typeof(int)).DefaultValue = 10;
            TAtributos.Columns.Add("SIGILO", typeof(int)).DefaultValue = 20;
            TAtributos.Columns.Add("SUPERVIVENCIA", typeof(int)).DefaultValue = 10;
            TAtributos.Columns.Add("TASACIÓN", typeof(int)).DefaultValue = 5;
            TAtributos.Columns.Add("TREPAR", typeof(int)).DefaultValue = 20;

            var nombresColumnas = new List<string>();

            foreach (DataColumn column in TAtributos.Columns)
            {
                nombresColumnas.Add(column.ColumnName);
            }

            Atributos.DataSource = nombresColumnas;

            atributosTest.DataSource = TAtributos;

            tempAtribs = TAtributos.NewRow();
            tempAtribs.ItemArray = new object[] {1, 20, 25, 1, 20, 1, 5, 1, 5, 25, 15, 20, 1, 5, 0, 5, 25, 5, 10, 15, 5, 20, 0, 5, 15, 10, 20, 10, 1, 20, 10, 10, 10, 1, 30, 1, 10, 20, 10, 20, 10, 5, 20};
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            DataRow enemigo = TEnemigos.NewRow();
            enemigo["Nombre"] = textNombre.Text;
            enemigo["PV"] = (int)numPV.Value;
            enemigo["PM"] = (int)numPM.Value;
            enemigo["FUE"] = (int)numFUE.Value;
            enemigo["DES"] = (int)numDES.Value;
            enemigo["POD"] = (int)numPOD.Value;
            enemigo["CON"] = (int)numCON.Value;
            enemigo["APA"] = (int)numAPA.Value;
            enemigo["EDU"] = (int)numEDU.Value;
            enemigo["TAM"] = (int)numTAM.Value;
            enemigo["INT"] = (int)numINT.Value;
            enemigo["MOV"] = (int)numMOV.Value;
            TEnemigos.Rows.Add(enemigo);
            

            TAtributos.Rows.Add(tempAtribs);
            
            tempAtribs = TAtributos.NewRow();
            tempAtribs.ItemArray = new object[] {1, 20, 25, 1, 20, 1, 5, 1, 5, 25, 15, 20, 1, 5, 0, 5, 25, 5, 10, 15, 5, 20, 0, 5, 15, 10, 20, 10, 1, 20, 10, 10, 10, 1, 30, 1, 10, 20, 10, 20, 10, 5, 20 };

            Atributos.SelectedIndex = -1;
            textNombre.Text = "";
            numAtrib.Value = numPV.Value = numPV.Value = numFUE.Value = numDES.Value = numPOD.Value = numCON.Value = numAPA.Value = numEDU.Value = numTAM.Value = numINT.Value = numMOV.Value = 0;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (seleccionado == -1)
            {
                MessageBox.Show("Selecciona un enemigo.");
            }
            else
            {
                TEnemigos.Rows[seleccionado]["Nombre"] = textNombre.Text;
                TEnemigos.Rows[seleccionado]["PV"] = (int)numPV.Value;
                TEnemigos.Rows[seleccionado]["PM"] = (int)numPM.Value;
                TEnemigos.Rows[seleccionado]["FUE"] = (int)numFUE.Value;
                TEnemigos.Rows[seleccionado]["DES"] = (int)numDES.Value;
                TEnemigos.Rows[seleccionado]["POD"] = (int)numPOD.Value;
                TEnemigos.Rows[seleccionado]["CON"] = (int)numCON.Value;
                TEnemigos.Rows[seleccionado]["APA"] = (int)numAPA.Value;
                TEnemigos.Rows[seleccionado]["EDU"] = (int)numEDU.Value;
                TEnemigos.Rows[seleccionado]["TAM"] = (int)numTAM.Value;
                TEnemigos.Rows[seleccionado]["INT"] = (int)numINT.Value;
                TEnemigos.Rows[seleccionado]["MOV"] = (int)numMOV.Value;

                foreach (DataColumn column in TAtributos.Columns)
                    TAtributos.Rows[seleccionado][column] = tempAtribs[column];
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado == -1)
            {
                MessageBox.Show("Selecciona un enemigo.");
            }
            else
            {
                TEnemigos.Rows[seleccionado].Delete();
                TAtributos.Rows[seleccionado].Delete();

                seleccionado = -1;
            }
        }

        private void numAtrib_ValueChanged(object sender, EventArgs e)
        {
            if (Atributos.SelectedIndex != -1)
                tempAtribs[Atributos.SelectedItem.ToString()] = (int)numAtrib.Value;
        }

        private void guardarDatos()
        {
            
            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "/enemigos.txt"))
            {
                string total = "";
                for (int i = 0; i < TEnemigos.Rows.Count; i++)
                {
                    for (int j = 0; j < TEnemigos.Columns.Count; j++)
                    {
                        total += TEnemigos.Rows[i][j].ToString();
                        
                        if (j < TEnemigos.Columns.Count - 1 && total !="") { total += ","; }
                    }
                    if (i < TEnemigos.Rows.Count - 1) { total += Environment.NewLine; }
                }
                sw.WriteLine(total);
            }

            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + "/atributos.txt"))
            {
                string total = "";
                for (int i = 0; i < TAtributos.Rows.Count; i++)
                {
                    for (int j = 0; j < TAtributos.Columns.Count; j++)
                    {
                        total += TAtributos.Rows[i][j].ToString();

                        if (j < TAtributos.Columns.Count - 1 && total != "") { total += ","; }
                    }
                    if (i < TAtributos.Rows.Count - 1) { total += Environment.NewLine; }
                }
                sw.WriteLine(total);
            }
        }

        private void cargarDatos()
        {
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

            if (!File.Exists(Environment.CurrentDirectory + "/atributos.txt"))
            {
                using (FileStream fs = File.Create(Environment.CurrentDirectory + "/atributos.txt")) { }
            }
            using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "/atributos.txt"))
            {
                string text = sr.ReadToEnd();
                String[] lines = text.Split('\n');
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        String[] parts = line.Split(',');
                        TAtributos.Rows.Add(parts);
                    }
                }
            }
        }
    }
}
