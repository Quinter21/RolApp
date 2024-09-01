namespace WindowsFormsApp1
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NuevaFila = new System.Windows.Forms.Button();
            this.Cargar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Campo2 = new System.Windows.Forms.TextBox();
            this.BorrarFila = new System.Windows.Forms.Button();
            this.Campo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BorrarArchivo = new System.Windows.Forms.Button();
            this.GuardarFila = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.NuevoArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevaFila
            // 
            this.NuevaFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevaFila.Location = new System.Drawing.Point(700, 524);
            this.NuevaFila.Name = "NuevaFila";
            this.NuevaFila.Size = new System.Drawing.Size(219, 56);
            this.NuevaFila.TabIndex = 0;
            this.NuevaFila.Text = "Nueva Fila";
            this.NuevaFila.UseVisualStyleBackColor = true;
            this.NuevaFila.Click += new System.EventHandler(this.Nueva_Click);
            // 
            // Cargar
            // 
            this.Cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargar.Location = new System.Drawing.Point(12, 586);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(219, 56);
            this.Cargar.TabIndex = 3;
            this.Cargar.Text = "Cargar Archivo";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(244, 586);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(221, 56);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar Archivo";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 506);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Campo2
            // 
            this.Campo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo2.Location = new System.Drawing.Point(480, 101);
            this.Campo2.Multiline = true;
            this.Campo2.Name = "Campo2";
            this.Campo2.Size = new System.Drawing.Size(674, 417);
            this.Campo2.TabIndex = 6;
            // 
            // BorrarFila
            // 
            this.BorrarFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarFila.Location = new System.Drawing.Point(932, 524);
            this.BorrarFila.Name = "BorrarFila";
            this.BorrarFila.Size = new System.Drawing.Size(221, 56);
            this.BorrarFila.TabIndex = 7;
            this.BorrarFila.Text = "Borrar fila";
            this.BorrarFila.UseVisualStyleBackColor = true;
            this.BorrarFila.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Campo1
            // 
            this.Campo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo1.Location = new System.Drawing.Point(480, 40);
            this.Campo1.Name = "Campo1";
            this.Campo1.Size = new System.Drawing.Size(674, 30);
            this.Campo1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Campo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Campo 2";
            // 
            // BorrarArchivo
            // 
            this.BorrarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarArchivo.Location = new System.Drawing.Point(244, 524);
            this.BorrarArchivo.Name = "BorrarArchivo";
            this.BorrarArchivo.Size = new System.Drawing.Size(221, 56);
            this.BorrarArchivo.TabIndex = 14;
            this.BorrarArchivo.Text = "Borrar Archivo";
            this.BorrarArchivo.UseVisualStyleBackColor = true;
            // 
            // GuardarFila
            // 
            this.GuardarFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarFila.Location = new System.Drawing.Point(932, 586);
            this.GuardarFila.Name = "GuardarFila";
            this.GuardarFila.Size = new System.Drawing.Size(221, 56);
            this.GuardarFila.TabIndex = 13;
            this.GuardarFila.Text = "Guardar Fila";
            this.GuardarFila.UseVisualStyleBackColor = true;
            this.GuardarFila.Click += new System.EventHandler(this.GuardarFila_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Location = new System.Drawing.Point(700, 586);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(219, 56);
            this.Limpiar.TabIndex = 12;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // NuevoArchivo
            // 
            this.NuevoArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoArchivo.Location = new System.Drawing.Point(12, 524);
            this.NuevoArchivo.Name = "NuevoArchivo";
            this.NuevoArchivo.Size = new System.Drawing.Size(219, 56);
            this.NuevoArchivo.TabIndex = 11;
            this.NuevoArchivo.Text = "Nuevo Archivo";
            this.NuevoArchivo.UseVisualStyleBackColor = true;
            this.NuevoArchivo.Click += new System.EventHandler(this.NuevoArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 660);
            this.Controls.Add(this.BorrarArchivo);
            this.Controls.Add(this.GuardarFila);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.NuevoArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Campo1);
            this.Controls.Add(this.BorrarFila);
            this.Controls.Add(this.Campo2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.NuevaFila);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NuevaFila;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Campo2;
        private System.Windows.Forms.Button BorrarFila;
        private System.Windows.Forms.TextBox Campo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BorrarArchivo;
        private System.Windows.Forms.Button GuardarFila;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button NuevoArchivo;
    }
}

