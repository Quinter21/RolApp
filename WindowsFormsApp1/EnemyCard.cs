using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EnemyCard : UserControl
    {
        public int id;

        string name;


        public EnemyCard(String nombre)
        {
            InitializeComponent();
            name = nombre;
            Nombre.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Dispose();
        }
    }
}
