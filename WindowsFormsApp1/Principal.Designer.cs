namespace WindowsFormsApp1
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablePrevisual = new System.Windows.Forms.DataGridView();
            this.AreaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.doubleClick1 = new WindowsFormsApp1.DoubleClick();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablePrevisual)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.doubleClick1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 675);
            this.panel1.TabIndex = 0;
            // 
            // TablePrevisual
            // 
            this.TablePrevisual.AllowUserToAddRows = false;
            this.TablePrevisual.AllowUserToDeleteRows = false;
            this.TablePrevisual.AllowUserToResizeColumns = false;
            this.TablePrevisual.AllowUserToResizeRows = false;
            this.TablePrevisual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TablePrevisual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablePrevisual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablePrevisual.ColumnHeadersVisible = false;
            this.TablePrevisual.Location = new System.Drawing.Point(32, 0);
            this.TablePrevisual.Name = "TablePrevisual";
            this.TablePrevisual.ReadOnly = true;
            this.TablePrevisual.RowHeadersVisible = false;
            this.TablePrevisual.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablePrevisual.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TablePrevisual.RowTemplate.Height = 24;
            this.TablePrevisual.Size = new System.Drawing.Size(240, 675);
            this.TablePrevisual.TabIndex = 1;
            this.TablePrevisual.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TablePrevisual_CellMouseDoubleClick);
            this.TablePrevisual.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TablePrevisual_CellMouseDown);
            // 
            // AreaPanel
            // 
            this.AreaPanel.AllowDrop = true;
            this.AreaPanel.AutoScroll = true;
            this.AreaPanel.BackColor = System.Drawing.Color.LightBlue;
            this.AreaPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AreaPanel.Location = new System.Drawing.Point(278, 0);
            this.AreaPanel.Name = "AreaPanel";
            this.AreaPanel.Size = new System.Drawing.Size(1113, 675);
            this.AreaPanel.TabIndex = 2;
            // 
            // doubleClick1
            // 
            this.doubleClick1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubleClick1.Location = new System.Drawing.Point(0, 0);
            this.doubleClick1.Name = "doubleClick1";
            this.doubleClick1.Size = new System.Drawing.Size(35, 114);
            this.doubleClick1.TabIndex = 1;
            this.doubleClick1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.doubleClick1.UseVisualStyleBackColor = true;
            this.doubleClick1.Click += new System.EventHandler(this.button1_Click);
            this.doubleClick1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 675);
            this.Controls.Add(this.AreaPanel);
            this.Controls.Add(this.TablePrevisual);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablePrevisual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TablePrevisual;
        private DoubleClick doubleClick1;
        private System.Windows.Forms.FlowLayoutPanel AreaPanel;
    }
}