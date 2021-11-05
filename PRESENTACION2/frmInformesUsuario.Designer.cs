namespace PRESENTACION2
{
    partial class frmInformesUsuario
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
            this.btnI1 = new System.Windows.Forms.Button();
            this.dgvInformeU = new System.Windows.Forms.DataGridView();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnI1
            // 
            this.btnI1.Location = new System.Drawing.Point(67, 54);
            this.btnI1.Name = "btnI1";
            this.btnI1.Size = new System.Drawing.Size(172, 28);
            this.btnI1.TabIndex = 0;
            this.btnI1.Text = "Informacion de un usuario";
            this.btnI1.UseVisualStyleBackColor = true;
            this.btnI1.Click += new System.EventHandler(this.btnI1_Click);
            // 
            // dgvInformeU
            // 
            this.dgvInformeU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeU.Location = new System.Drawing.Point(310, 211);
            this.dgvInformeU.Name = "dgvInformeU";
            this.dgvInformeU.Size = new System.Drawing.Size(337, 150);
            this.dgvInformeU.TabIndex = 1;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(67, 100);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(172, 20);
            this.txtConsulta.TabIndex = 2;
            // 
            // frmInformesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(982, 487);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.dgvInformeU);
            this.Controls.Add(this.btnI1);
            this.Name = "frmInformesUsuario";
            this.Text = "frmInformesUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnI1;
        private System.Windows.Forms.DataGridView dgvInformeU;
        private System.Windows.Forms.TextBox txtConsulta;
    }
}