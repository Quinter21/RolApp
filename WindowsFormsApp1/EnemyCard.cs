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

        private void EnemyCard_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Wiii");
        }

        private void Nombre_Click(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                var box = new TextBox();
                box.Name = "TextField";
                box.Text = label.Text;
                box.TextAlign = HorizontalAlignment.Center;
                box.AutoSize = false;
                box.Dock = DockStyle.None;
                box.Size = label.Size;
                box.Location = this.PointToClient(label.Parent.PointToScreen(label.Location));
                box.BackColor = Color.White;
                box.PreviewKeyDown += (a, b) => {
                    if (b.KeyCode == Keys.Escape)
                    {
                        box.Parent.Controls.Remove(box);
                    }
                    else if (b.KeyCode == Keys.Enter)
                    {
                        if (box.Text != "")
                        {
                            label.Text = box.Text;
                        }
                        box.Parent.Controls.Remove(box);
                    }
                };
                box.LostFocus += (a, b) => { box.Parent?.Controls.Remove(box); };

                Controls.Add(box);
                Controls.SetChildIndex(box, 0);
                box.SelectAll();
                box.Focus();
            }
        }
    }
}
