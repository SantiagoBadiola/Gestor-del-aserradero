namespace PRESENTACION2
{
    partial class frmLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLote));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvLotes = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFech = new System.Windows.Forms.DateTimePicker();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnModificar2 = new System.Windows.Forms.Button();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblRol2 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(100)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnListar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Location = new System.Drawing.Point(177, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 573);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.dgvLotes);
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Controls.Add(this.dtpFech);
            this.panel3.Controls.Add(this.txtUsuario);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.btnModificar2);
            this.panel3.Controls.Add(this.btnEliminar2);
            this.panel3.Controls.Add(this.btnAgregar2);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Location = new System.Drawing.Point(21, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 476);
            this.panel3.TabIndex = 5;
            // 
            // dgvLotes
            // 
            this.dgvLotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvLotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLotes.EnableHeadersVisualStyles = false;
            this.dgvLotes.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvLotes.Location = new System.Drawing.Point(169, 276);
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dgvLotes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLotes.Size = new System.Drawing.Size(394, 171);
            this.dgvLotes.TabIndex = 25;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(150, 68);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFech
            // 
            this.dtpFech.Location = new System.Drawing.Point(196, 68);
            this.dtpFech.Name = "dtpFech";
            this.dtpFech.Size = new System.Drawing.Size(149, 20);
            this.dtpFech.TabIndex = 22;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(507, 97);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(122, 32);
            this.txtUsuario.TabIndex = 18;
            this.txtUsuario.Text = "ID Usuario";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(351, 97);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(122, 32);
            this.txtCantidad.TabIndex = 17;
            this.txtCantidad.Text = "Cantidad";
            // 
            // btnModificar2
            // 
            this.btnModificar2.BackColor = System.Drawing.Color.DarkGray;
            this.btnModificar2.Location = new System.Drawing.Point(311, 179);
            this.btnModificar2.Name = "btnModificar2";
            this.btnModificar2.Size = new System.Drawing.Size(113, 40);
            this.btnModificar2.TabIndex = 15;
            this.btnModificar2.Text = "Modificar";
            this.btnModificar2.UseVisualStyleBackColor = false;
            this.btnModificar2.Click += new System.EventHandler(this.btnModificar2_Click);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminar2.Location = new System.Drawing.Point(169, 179);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(113, 40);
            this.btnEliminar2.TabIndex = 14;
            this.btnEliminar2.Text = "Eliminar";
            this.btnEliminar2.UseVisualStyleBackColor = false;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.BackColor = System.Drawing.Color.DarkGray;
            this.btnAgregar2.Location = new System.Drawing.Point(32, 179);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(113, 40);
            this.btnAgregar2.TabIndex = 13;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = false;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(32, 97);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(122, 32);
            this.txtID.TabIndex = 11;
            this.txtID.Text = "ID Lote";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Underline);
            this.button6.Location = new System.Drawing.Point(601, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 64);
            this.button6.TabIndex = 4;
            this.button6.Text = "Informe por especie";
            this.button6.UseVisualStyleBackColor = false;
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
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblRol2);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 603);
            this.panel1.TabIndex = 9;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(93, 164);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 24);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "label3";
            // 
            // lblRol2
            // 
            this.lblRol2.AutoSize = true;
            this.lblRol2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol2.Location = new System.Drawing.Point(69, 201);
            this.lblRol2.Name = "lblRol2";
            this.lblRol2.Size = new System.Drawing.Size(61, 24);
            this.lblRol2.TabIndex = 15;
            this.lblRol2.Text = "label2";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRol.Location = new System.Drawing.Point(12, 201);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(37, 24);
            this.lblRol.TabIndex = 13;
            this.lblRol.Text = "Rol";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(12, 164);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 24);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
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
            // frmLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(933, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmLote";
            this.Text = "Lote";
            this.Load += new System.EventHandler(this.frmLote_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnModificar2;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblRol2;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker dtpFech;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvLotes;
    }
}