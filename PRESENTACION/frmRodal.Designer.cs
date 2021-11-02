namespace PRESENTACION
{
    partial class frmRodal
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
            this.labArboles = new System.Windows.Forms.Label();
            this.labFecha = new System.Windows.Forms.Label();
            this.labEspecie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArboles = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labArboles
            // 
            this.labArboles.AutoSize = true;
            this.labArboles.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labArboles.Location = new System.Drawing.Point(10, 43);
            this.labArboles.Name = "labArboles";
            this.labArboles.Size = new System.Drawing.Size(201, 39);
            this.labArboles.TabIndex = 1;
            this.labArboles.Text = "cantArboles";
            // 
            // labFecha
            // 
            this.labFecha.AutoSize = true;
            this.labFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFecha.Location = new System.Drawing.Point(12, 113);
            this.labFecha.Name = "labFecha";
            this.labFecha.Size = new System.Drawing.Size(193, 25);
            this.labFecha.TabIndex = 2;
            this.labFecha.Text = "fechaDePlantacion";
            // 
            // labEspecie
            // 
            this.labEspecie.AutoSize = true;
            this.labEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEspecie.Location = new System.Drawing.Point(26, 164);
            this.labEspecie.Name = "labEspecie";
            this.labEspecie.Size = new System.Drawing.Size(141, 39);
            this.labEspecie.TabIndex = 3;
            this.labEspecie.Text = "Especie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 39);
            this.label3.TabIndex = 4;
            // 
            // txtArboles
            // 
            this.txtArboles.Location = new System.Drawing.Point(200, 43);
            this.txtArboles.Multiline = true;
            this.txtArboles.Name = "txtArboles";
            this.txtArboles.Size = new System.Drawing.Size(221, 45);
            this.txtArboles.TabIndex = 5;
          
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(200, 102);
            this.txtFecha.Multiline = true;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(221, 45);
            this.txtFecha.TabIndex = 6;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(200, 164);
            this.txtEspecie.Multiline = true;
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(221, 45);
            this.txtEspecie.TabIndex = 7;
           
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(165, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRodal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtArboles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labEspecie);
            this.Controls.Add(this.labFecha);
            this.Controls.Add(this.labArboles);
            this.Name = "frmRodal";
            this.Text = "frmProducto";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labArboles;
        private System.Windows.Forms.Label labFecha;
        private System.Windows.Forms.Label labEspecie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArboles;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Button button1;
    }
}