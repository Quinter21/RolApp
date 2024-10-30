namespace WindowsFormsApp1
{
    partial class EnemyCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Nombre = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Location = new System.Drawing.Point(42, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 318);
            this.panel1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(172, 118);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(79, 29);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "label1";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(147, 245);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(127, 49);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "button1";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnemyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.panel1);
            this.Name = "EnemyCard";
            this.Size = new System.Drawing.Size(487, 378);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button Delete;
    }
}
