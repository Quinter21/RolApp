namespace WindowsFormsApp1
{
    partial class Enemigos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaEnemigos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.Label();
            this.LabVida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numPV = new System.Windows.Forms.NumericUpDown();
            this.numPM = new System.Windows.Forms.NumericUpDown();
            this.numFUE = new System.Windows.Forms.NumericUpDown();
            this.numCON = new System.Windows.Forms.NumericUpDown();
            this.numTAM = new System.Windows.Forms.NumericUpDown();
            this.numINT = new System.Windows.Forms.NumericUpDown();
            this.numAPA = new System.Windows.Forms.NumericUpDown();
            this.numDES = new System.Windows.Forms.NumericUpDown();
            this.numMOV = new System.Windows.Forms.NumericUpDown();
            this.numEDU = new System.Windows.Forms.NumericUpDown();
            this.numPOD = new System.Windows.Forms.NumericUpDown();
            this.Atributos = new System.Windows.Forms.ComboBox();
            this.numAtrib = new System.Windows.Forms.NumericUpDown();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.enemigosTest = new System.Windows.Forms.DataGridView();
            this.atributosTest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEnemigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numINT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAPA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAtrib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigosTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributosTest)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaEnemigos
            // 
            this.ListaEnemigos.AllowUserToAddRows = false;
            this.ListaEnemigos.AllowUserToDeleteRows = false;
            this.ListaEnemigos.AllowUserToResizeColumns = false;
            this.ListaEnemigos.AllowUserToResizeRows = false;
            this.ListaEnemigos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListaEnemigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaEnemigos.ColumnHeadersVisible = false;
            this.ListaEnemigos.Location = new System.Drawing.Point(12, 12);
            this.ListaEnemigos.Name = "ListaEnemigos";
            this.ListaEnemigos.ReadOnly = true;
            this.ListaEnemigos.RowHeadersVisible = false;
            this.ListaEnemigos.RowHeadersWidth = 51;
            this.ListaEnemigos.RowTemplate.Height = 24;
            this.ListaEnemigos.Size = new System.Drawing.Size(179, 426);
            this.ListaEnemigos.TabIndex = 0;
            this.ListaEnemigos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaEnemigos_CellDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(215, 13);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(142, 38);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre:";
            // 
            // LabVida
            // 
            this.LabVida.AutoSize = true;
            this.LabVida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabVida.Location = new System.Drawing.Point(217, 77);
            this.LabVida.Name = "LabVida";
            this.LabVida.Size = new System.Drawing.Size(45, 25);
            this.LabVida.TabIndex = 2;
            this.LabVida.Text = "PV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "PM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "FUE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "CON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "TAM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(511, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "DES:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(511, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "APA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(511, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "INT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(636, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "POD:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(636, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "EDU:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(636, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Mov:";
            // 
            // numPV
            // 
            this.numPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPV.Location = new System.Drawing.Point(266, 75);
            this.numPV.Name = "numPV";
            this.numPV.Size = new System.Drawing.Size(64, 30);
            this.numPV.TabIndex = 32;
            this.numPV.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numPM
            // 
            this.numPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPM.Location = new System.Drawing.Point(266, 116);
            this.numPM.Name = "numPM";
            this.numPM.Size = new System.Drawing.Size(64, 30);
            this.numPM.TabIndex = 33;
            this.numPM.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numFUE
            // 
            this.numFUE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFUE.Location = new System.Drawing.Point(441, 75);
            this.numFUE.Name = "numFUE";
            this.numFUE.Size = new System.Drawing.Size(64, 30);
            this.numFUE.TabIndex = 34;
            this.numFUE.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numCON
            // 
            this.numCON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCON.Location = new System.Drawing.Point(441, 111);
            this.numCON.Name = "numCON";
            this.numCON.Size = new System.Drawing.Size(64, 30);
            this.numCON.TabIndex = 35;
            this.numCON.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numTAM
            // 
            this.numTAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTAM.Location = new System.Drawing.Point(441, 147);
            this.numTAM.Name = "numTAM";
            this.numTAM.Size = new System.Drawing.Size(64, 30);
            this.numTAM.TabIndex = 36;
            this.numTAM.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numINT
            // 
            this.numINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numINT.Location = new System.Drawing.Point(566, 147);
            this.numINT.Name = "numINT";
            this.numINT.Size = new System.Drawing.Size(64, 30);
            this.numINT.TabIndex = 39;
            this.numINT.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numAPA
            // 
            this.numAPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAPA.Location = new System.Drawing.Point(566, 111);
            this.numAPA.Name = "numAPA";
            this.numAPA.Size = new System.Drawing.Size(64, 30);
            this.numAPA.TabIndex = 38;
            this.numAPA.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numDES
            // 
            this.numDES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDES.Location = new System.Drawing.Point(566, 75);
            this.numDES.Name = "numDES";
            this.numDES.Size = new System.Drawing.Size(64, 30);
            this.numDES.TabIndex = 37;
            this.numDES.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numMOV
            // 
            this.numMOV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMOV.Location = new System.Drawing.Point(703, 147);
            this.numMOV.Name = "numMOV";
            this.numMOV.Size = new System.Drawing.Size(64, 30);
            this.numMOV.TabIndex = 42;
            this.numMOV.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numEDU
            // 
            this.numEDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEDU.Location = new System.Drawing.Point(703, 111);
            this.numEDU.Name = "numEDU";
            this.numEDU.Size = new System.Drawing.Size(64, 30);
            this.numEDU.TabIndex = 41;
            this.numEDU.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numPOD
            // 
            this.numPOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPOD.Location = new System.Drawing.Point(703, 75);
            this.numPOD.Name = "numPOD";
            this.numPOD.Size = new System.Drawing.Size(64, 30);
            this.numPOD.TabIndex = 40;
            this.numPOD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Atributos
            // 
            this.Atributos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atributos.FormattingEnabled = true;
            this.Atributos.IntegralHeight = false;
            this.Atributos.Location = new System.Drawing.Point(227, 217);
            this.Atributos.Name = "Atributos";
            this.Atributos.Size = new System.Drawing.Size(278, 33);
            this.Atributos.TabIndex = 43;
            this.Atributos.SelectedIndexChanged += new System.EventHandler(this.Atributos_SelectedIndexChanged);
            // 
            // numAtrib
            // 
            this.numAtrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAtrib.Location = new System.Drawing.Point(516, 218);
            this.numAtrib.Name = "numAtrib";
            this.numAtrib.Size = new System.Drawing.Size(64, 30);
            this.numAtrib.TabIndex = 44;
            this.numAtrib.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numAtrib.ValueChanged += new System.EventHandler(this.numAtrib_ValueChanged);
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(363, 10);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(404, 45);
            this.textNombre.TabIndex = 45;
            // 
            // Nuevo
            // 
            this.Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo.Location = new System.Drawing.Point(222, 300);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(135, 56);
            this.Nuevo.TabIndex = 46;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(426, 300);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(135, 56);
            this.Guardar.TabIndex = 47;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(632, 300);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(135, 56);
            this.Eliminar.TabIndex = 48;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // enemigosTest
            // 
            this.enemigosTest.AllowUserToAddRows = false;
            this.enemigosTest.AllowUserToDeleteRows = false;
            this.enemigosTest.AllowUserToResizeColumns = false;
            this.enemigosTest.AllowUserToResizeRows = false;
            this.enemigosTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enemigosTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enemigosTest.ColumnHeadersVisible = false;
            this.enemigosTest.Location = new System.Drawing.Point(790, 10);
            this.enemigosTest.Name = "enemigosTest";
            this.enemigosTest.RowHeadersVisible = false;
            this.enemigosTest.RowHeadersWidth = 51;
            this.enemigosTest.RowTemplate.Height = 24;
            this.enemigosTest.Size = new System.Drawing.Size(617, 251);
            this.enemigosTest.TabIndex = 49;
            // 
            // atributosTest
            // 
            this.atributosTest.AllowUserToAddRows = false;
            this.atributosTest.AllowUserToDeleteRows = false;
            this.atributosTest.AllowUserToResizeColumns = false;
            this.atributosTest.AllowUserToResizeRows = false;
            this.atributosTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.atributosTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atributosTest.ColumnHeadersVisible = false;
            this.atributosTest.Location = new System.Drawing.Point(222, 379);
            this.atributosTest.Name = "atributosTest";
            this.atributosTest.RowHeadersVisible = false;
            this.atributosTest.RowHeadersWidth = 51;
            this.atributosTest.RowTemplate.Height = 24;
            this.atributosTest.Size = new System.Drawing.Size(1185, 302);
            this.atributosTest.TabIndex = 50;
            // 
            // Enemigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 706);
            this.Controls.Add(this.atributosTest);
            this.Controls.Add(this.enemigosTest);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.numAtrib);
            this.Controls.Add(this.Atributos);
            this.Controls.Add(this.numMOV);
            this.Controls.Add(this.numEDU);
            this.Controls.Add(this.numPOD);
            this.Controls.Add(this.numINT);
            this.Controls.Add(this.numAPA);
            this.Controls.Add(this.numDES);
            this.Controls.Add(this.numTAM);
            this.Controls.Add(this.numCON);
            this.Controls.Add(this.numFUE);
            this.Controls.Add(this.numPM);
            this.Controls.Add(this.numPV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabVida);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.ListaEnemigos);
            this.Name = "Enemigos";
            this.Text = "Enemigos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Enemigos_FormClosing);
            this.Load += new System.EventHandler(this.Enemigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaEnemigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numINT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAPA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEDU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAtrib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemigosTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atributosTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaEnemigos;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label LabVida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numPV;
        private System.Windows.Forms.NumericUpDown numPM;
        private System.Windows.Forms.NumericUpDown numFUE;
        private System.Windows.Forms.NumericUpDown numCON;
        private System.Windows.Forms.NumericUpDown numTAM;
        private System.Windows.Forms.NumericUpDown numINT;
        private System.Windows.Forms.NumericUpDown numAPA;
        private System.Windows.Forms.NumericUpDown numDES;
        private System.Windows.Forms.NumericUpDown numMOV;
        private System.Windows.Forms.NumericUpDown numEDU;
        private System.Windows.Forms.NumericUpDown numPOD;
        private System.Windows.Forms.ComboBox Atributos;
        private System.Windows.Forms.NumericUpDown numAtrib;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridView enemigosTest;
        private System.Windows.Forms.DataGridView atributosTest;
    }
}