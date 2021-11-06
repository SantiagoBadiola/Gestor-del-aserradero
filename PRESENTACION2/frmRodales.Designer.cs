namespace PRESENTACION2
{
    partial class frmRodales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRodales));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvRodales = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.btnModificar2 = new System.Windows.Forms.Button();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.txtIDRodal = new System.Windows.Forms.TextBox();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodales)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnInforme);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnListar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Location = new System.Drawing.Point(178, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 573);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.dgvRodales);
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Controls.Add(this.dtpFecha);
            this.panel3.Controls.Add(this.txtEspecie);
            this.panel3.Controls.Add(this.btnModificar2);
            this.panel3.Controls.Add(this.btnEliminar2);
            this.panel3.Controls.Add(this.txtTamanio);
            this.panel3.Controls.Add(this.btnAgregar2);
            this.panel3.Controls.Add(this.txtIDRodal);
            this.panel3.Location = new System.Drawing.Point(21, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 476);
            this.panel3.TabIndex = 5;
            // 
            // dgvRodales
            // 
            this.dgvRodales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvRodales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRodales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRodales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRodales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRodales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRodales.EnableHeadersVisualStyles = false;
            this.dgvRodales.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvRodales.Location = new System.Drawing.Point(145, 234);
            this.dgvRodales.Name = "dgvRodales";
            this.dgvRodales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRodales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvRodales.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRodales.Size = new System.Drawing.Size(394, 171);
            this.dgvRodales.TabIndex = 24;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(276, 50);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(108, 13);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "Fecha de Plantacion:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(390, 50);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(149, 20);
            this.dtpFecha.TabIndex = 21;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(566, 68);
            this.txtEspecie.Multiline = true;
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(122, 32);
            this.txtEspecie.TabIndex = 20;
            this.txtEspecie.Text = "ID Especie";
            // 
            // btnModificar2
            // 
            this.btnModificar2.BackColor = System.Drawing.Color.DarkGray;
            this.btnModificar2.Location = new System.Drawing.Point(351, 147);
            this.btnModificar2.Name = "btnModificar2";
            this.btnModificar2.Size = new System.Drawing.Size(113, 40);
            this.btnModificar2.TabIndex = 19;
            this.btnModificar2.Text = "MODIFICAR";
            this.btnModificar2.UseVisualStyleBackColor = false;
            this.btnModificar2.Click += new System.EventHandler(this.btnModificar2_Click);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminar2.Location = new System.Drawing.Point(194, 147);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(113, 40);
            this.btnEliminar2.TabIndex = 18;
            this.btnEliminar2.Text = "ELIMINAR";
            this.btnEliminar2.UseVisualStyleBackColor = false;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(194, 72);
            this.txtTamanio.Multiline = true;
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(122, 32);
            this.txtTamanio.TabIndex = 16;
            this.txtTamanio.Text = "Tamaño";
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.BackColor = System.Drawing.Color.DarkGray;
            this.btnAgregar2.Location = new System.Drawing.Point(44, 147);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(113, 40);
            this.btnAgregar2.TabIndex = 12;
            this.btnAgregar2.Text = "AGREGAR";
            this.btnAgregar2.UseVisualStyleBackColor = false;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // txtIDRodal
            // 
            this.txtIDRodal.Location = new System.Drawing.Point(35, 72);
            this.txtIDRodal.Multiline = true;
            this.txtIDRodal.Name = "txtIDRodal";
            this.txtIDRodal.Size = new System.Drawing.Size(122, 32);
            this.txtIDRodal.TabIndex = 11;
            this.txtIDRodal.Text = "ID Rodal";
            // 
            // btnInforme
            // 
            this.btnInforme.BackColor = System.Drawing.Color.DarkGray;
            this.btnInforme.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Underline);
            this.btnInforme.Location = new System.Drawing.Point(601, 13);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(108, 64);
            this.btnInforme.TabIndex = 4;
            this.btnInforme.Text = "Informe por especie";
            this.btnInforme.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Underline);
            this.btnEliminar.Location = new System.Drawing.Point(190, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DarkGray;
            this.btnModificar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Underline);
            this.btnModificar.Location = new System.Drawing.Point(332, 24);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 40);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.DarkGray;
            this.btnListar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Underline);
            this.btnListar.Location = new System.Drawing.Point(469, 24);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 40);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Underline);
            this.btnAgregar.Location = new System.Drawing.Point(40, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(1, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 603);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rol";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Nombre.Location = new System.Drawing.Point(12, 164);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(75, 24);
            this.Nombre.TabIndex = 14;
            this.Nombre.Text = "Nombre";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(51, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 61);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.linkLabel1.Location = new System.Drawing.Point(12, 570);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(98, 18);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cerrar sesión";
            // 
            // frmRodales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(934, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRodales";
            this.Text = "Rodales";
            this.Load += new System.EventHandler(this.frmRodales_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRodales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnModificar2;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.TextBox txtIDRodal;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvRodales;
    }
}