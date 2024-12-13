namespace Publicaciones.MenuPrincipal.Titulo
{
    partial class CUTitulos
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
            this.btnTitulo = new System.Windows.Forms.Button();
            this.btnEditorial = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDatosEditorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTitulo
            // 
            this.btnTitulo.BackColor = System.Drawing.Color.YellowGreen;
            this.btnTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitulo.ForeColor = System.Drawing.Color.Black;
            this.btnTitulo.Location = new System.Drawing.Point(459, 16);
            this.btnTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTitulo.Name = "btnTitulo";
            this.btnTitulo.Size = new System.Drawing.Size(110, 45);
            this.btnTitulo.TabIndex = 4;
            this.btnTitulo.Text = "Titulo";
            this.btnTitulo.UseVisualStyleBackColor = false;
            this.btnTitulo.Click += new System.EventHandler(this.btnTitulo_Click);
            // 
            // btnEditorial
            // 
            this.btnEditorial.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditorial.ForeColor = System.Drawing.Color.Black;
            this.btnEditorial.Location = new System.Drawing.Point(573, 18);
            this.btnEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditorial.Name = "btnEditorial";
            this.btnEditorial.Size = new System.Drawing.Size(110, 43);
            this.btnEditorial.TabIndex = 3;
            this.btnEditorial.Text = "Editorial";
            this.btnEditorial.UseVisualStyleBackColor = false;
            this.btnEditorial.Click += new System.EventHandler(this.btnEditorial_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SkyBlue;
            this.panel3.Location = new System.Drawing.Point(40, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 8);
            this.panel3.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(350, 36);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 46);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Gray;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(39, 46);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(288, 26);
            this.txtBuscar.TabIndex = 0;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 108);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(714, 298);
            this.dgvDatos.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnDatosEditorial);
            this.panel1.Controls.Add(this.btnTitulo);
            this.panel1.Controls.Add(this.btnEditorial);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 108);
            this.panel1.TabIndex = 6;
            // 
            // btnDatosEditorial
            // 
            this.btnDatosEditorial.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDatosEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosEditorial.ForeColor = System.Drawing.Color.Black;
            this.btnDatosEditorial.Location = new System.Drawing.Point(488, 61);
            this.btnDatosEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatosEditorial.Name = "btnDatosEditorial";
            this.btnDatosEditorial.Size = new System.Drawing.Size(164, 43);
            this.btnDatosEditorial.TabIndex = 5;
            this.btnDatosEditorial.Text = "Datos editorial";
            this.btnDatosEditorial.UseVisualStyleBackColor = false;
            this.btnDatosEditorial.Click += new System.EventHandler(this.btnDatosEditorial_Click);
            // 
            // CUTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.panel1);
            this.Name = "CUTitulos";
            this.Size = new System.Drawing.Size(714, 406);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTitulo;
        private System.Windows.Forms.Button btnEditorial;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDatosEditorial;
    }
}
