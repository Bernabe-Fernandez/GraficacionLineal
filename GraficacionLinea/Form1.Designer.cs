namespace GraficacionLinea
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
            this.Lbl_Xa = new System.Windows.Forms.Label();
            this.Lbl_Ya = new System.Windows.Forms.Label();
            this.Lbl_Xb = new System.Windows.Forms.Label();
            this.Lbl_Yb = new System.Windows.Forms.Label();
            this.Txt_Xa = new System.Windows.Forms.TextBox();
            this.Txt_Ya = new System.Windows.Forms.TextBox();
            this.Txt_Xb = new System.Windows.Forms.TextBox();
            this.Txt_Yb = new System.Windows.Forms.TextBox();
            this.Lbl_Pendiente = new System.Windows.Forms.Label();
            this.Txt_Pendiente = new System.Windows.Forms.TextBox();
            this.Lbl_Indicacion = new System.Windows.Forms.Label();
            this.Btn_Trazar = new System.Windows.Forms.Button();
            this.Dgv_Coordenadas = new System.Windows.Forms.DataGridView();
            this.Column_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pb_Mapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Coordenadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Mapa)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Xa
            // 
            this.Lbl_Xa.AutoSize = true;
            this.Lbl_Xa.Location = new System.Drawing.Point(55, 39);
            this.Lbl_Xa.Name = "Lbl_Xa";
            this.Lbl_Xa.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Xa.TabIndex = 0;
            this.Lbl_Xa.Text = "Valor Xa";
            // 
            // Lbl_Ya
            // 
            this.Lbl_Ya.AutoSize = true;
            this.Lbl_Ya.Location = new System.Drawing.Point(55, 72);
            this.Lbl_Ya.Name = "Lbl_Ya";
            this.Lbl_Ya.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Ya.TabIndex = 1;
            this.Lbl_Ya.Text = "Valor Ya";
            // 
            // Lbl_Xb
            // 
            this.Lbl_Xb.AutoSize = true;
            this.Lbl_Xb.Location = new System.Drawing.Point(231, 39);
            this.Lbl_Xb.Name = "Lbl_Xb";
            this.Lbl_Xb.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Xb.TabIndex = 2;
            this.Lbl_Xb.Text = "Valor Xb";
            // 
            // Lbl_Yb
            // 
            this.Lbl_Yb.AutoSize = true;
            this.Lbl_Yb.Location = new System.Drawing.Point(231, 72);
            this.Lbl_Yb.Name = "Lbl_Yb";
            this.Lbl_Yb.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Yb.TabIndex = 3;
            this.Lbl_Yb.Text = "Valor Yb";
            // 
            // Txt_Xa
            // 
            this.Txt_Xa.Location = new System.Drawing.Point(109, 36);
            this.Txt_Xa.Name = "Txt_Xa";
            this.Txt_Xa.Size = new System.Drawing.Size(100, 20);
            this.Txt_Xa.TabIndex = 5;
            // 
            // Txt_Ya
            // 
            this.Txt_Ya.Location = new System.Drawing.Point(108, 69);
            this.Txt_Ya.Name = "Txt_Ya";
            this.Txt_Ya.Size = new System.Drawing.Size(100, 20);
            this.Txt_Ya.TabIndex = 6;
            // 
            // Txt_Xb
            // 
            this.Txt_Xb.Location = new System.Drawing.Point(284, 36);
            this.Txt_Xb.Name = "Txt_Xb";
            this.Txt_Xb.Size = new System.Drawing.Size(100, 20);
            this.Txt_Xb.TabIndex = 7;
            // 
            // Txt_Yb
            // 
            this.Txt_Yb.Location = new System.Drawing.Point(284, 69);
            this.Txt_Yb.Name = "Txt_Yb";
            this.Txt_Yb.Size = new System.Drawing.Size(100, 20);
            this.Txt_Yb.TabIndex = 8;
            // 
            // Lbl_Pendiente
            // 
            this.Lbl_Pendiente.AutoSize = true;
            this.Lbl_Pendiente.Location = new System.Drawing.Point(409, 56);
            this.Lbl_Pendiente.Name = "Lbl_Pendiente";
            this.Lbl_Pendiente.Size = new System.Drawing.Size(28, 13);
            this.Lbl_Pendiente.TabIndex = 9;
            this.Lbl_Pendiente.Text = "M = ";
            // 
            // Txt_Pendiente
            // 
            this.Txt_Pendiente.Location = new System.Drawing.Point(443, 53);
            this.Txt_Pendiente.Name = "Txt_Pendiente";
            this.Txt_Pendiente.Size = new System.Drawing.Size(63, 20);
            this.Txt_Pendiente.TabIndex = 10;
            // 
            // Lbl_Indicacion
            // 
            this.Lbl_Indicacion.AutoSize = true;
            this.Lbl_Indicacion.Location = new System.Drawing.Point(534, 55);
            this.Lbl_Indicacion.Name = "Lbl_Indicacion";
            this.Lbl_Indicacion.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Indicacion.TabIndex = 11;
            this.Lbl_Indicacion.Text = "Texto";
            // 
            // Btn_Trazar
            // 
            this.Btn_Trazar.Location = new System.Drawing.Point(143, 143);
            this.Btn_Trazar.Name = "Btn_Trazar";
            this.Btn_Trazar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Trazar.TabIndex = 12;
            this.Btn_Trazar.Text = "Trazar";
            this.Btn_Trazar.UseVisualStyleBackColor = true;
            this.Btn_Trazar.Click += new System.EventHandler(this.Btn_Trazar_Click);
            // 
            // Dgv_Coordenadas
            // 
            this.Dgv_Coordenadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Coordenadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_X,
            this.Column_Y});
            this.Dgv_Coordenadas.Location = new System.Drawing.Point(91, 227);
            this.Dgv_Coordenadas.Name = "Dgv_Coordenadas";
            this.Dgv_Coordenadas.Size = new System.Drawing.Size(187, 150);
            this.Dgv_Coordenadas.TabIndex = 13;
            // 
            // Column_X
            // 
            this.Column_X.HeaderText = "X";
            this.Column_X.Name = "Column_X";
            this.Column_X.Width = 50;
            // 
            // Column_Y
            // 
            this.Column_Y.HeaderText = "Y";
            this.Column_Y.Name = "Column_Y";
            this.Column_Y.Width = 50;
            // 
            // Pb_Mapa
            // 
            this.Pb_Mapa.Location = new System.Drawing.Point(352, 123);
            this.Pb_Mapa.Name = "Pb_Mapa";
            this.Pb_Mapa.Size = new System.Drawing.Size(360, 360);
            this.Pb_Mapa.TabIndex = 14;
            this.Pb_Mapa.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.Pb_Mapa);
            this.Controls.Add(this.Dgv_Coordenadas);
            this.Controls.Add(this.Btn_Trazar);
            this.Controls.Add(this.Lbl_Indicacion);
            this.Controls.Add(this.Txt_Pendiente);
            this.Controls.Add(this.Lbl_Pendiente);
            this.Controls.Add(this.Txt_Yb);
            this.Controls.Add(this.Txt_Xb);
            this.Controls.Add(this.Txt_Ya);
            this.Controls.Add(this.Txt_Xa);
            this.Controls.Add(this.Lbl_Yb);
            this.Controls.Add(this.Lbl_Xb);
            this.Controls.Add(this.Lbl_Ya);
            this.Controls.Add(this.Lbl_Xa);
            this.Name = "Form1";
            this.Text = "Graficación";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Coordenadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Mapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Xa;
        private System.Windows.Forms.Label Lbl_Ya;
        private System.Windows.Forms.Label Lbl_Xb;
        private System.Windows.Forms.Label Lbl_Yb;
        private System.Windows.Forms.TextBox Txt_Xa;
        private System.Windows.Forms.TextBox Txt_Ya;
        private System.Windows.Forms.TextBox Txt_Xb;
        private System.Windows.Forms.TextBox Txt_Yb;
        private System.Windows.Forms.Label Lbl_Pendiente;
        private System.Windows.Forms.TextBox Txt_Pendiente;
        private System.Windows.Forms.Label Lbl_Indicacion;
        private System.Windows.Forms.Button Btn_Trazar;
        private System.Windows.Forms.DataGridView Dgv_Coordenadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Y;
        private System.Windows.Forms.PictureBox Pb_Mapa;
    }
}

