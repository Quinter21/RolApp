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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enemigos fe = new Enemigos();
            fe.Show();
        }
    }
}
