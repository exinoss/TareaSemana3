namespace Publicaciones.MenuPrincipal
{
    partial class frmInfoEditorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoEditorial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrmPersonal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnLogo);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.txtInformacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 330);
            this.panel1.TabIndex = 13;
            // 
            // btnLogo
            // 
            this.btnLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.Location = new System.Drawing.Point(334, 178);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(81, 32);
            this.btnLogo.TabIndex = 27;
            this.btnLogo.Text = "Cargar";
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(334, 27);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(208, 145);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 26;
            this.picLogo.TabStop = false;
            // 
            // txtInformacion
            // 
            this.txtInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtInformacion.Location = new System.Drawing.Point(22, 61);
            this.txtInformacion.Multiline = true;
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(306, 111);
            this.txtInformacion.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalles";
            // 
            // lblFrmPersonal
            // 
            this.lblFrmPersonal.AutoSize = true;
            this.lblFrmPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFrmPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmPersonal.Location = new System.Drawing.Point(0, 0);
            this.lblFrmPersonal.Name = "lblFrmPersonal";
            this.lblFrmPersonal.Size = new System.Drawing.Size(258, 26);
            this.lblFrmPersonal.TabIndex = 12;
            this.lblFrmPersonal.Text = "Configuracion de editorial";
            this.lblFrmPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(194, 236);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(183, 54);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar información";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmInfoEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFrmPersonal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfoEditorial";
            this.Text = "frmInfoEditorial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFrmPersonal;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnGuardar;
    }
}