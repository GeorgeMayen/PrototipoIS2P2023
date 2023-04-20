
namespace Vista_Seguridad
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
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnMantenimientos = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Location = new System.Drawing.Point(80, 114);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(142, 93);
            this.btnCatalogo.TabIndex = 10;
            this.btnCatalogo.Text = "Catalogos";
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.Location = new System.Drawing.Point(379, 114);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(142, 93);
            this.btnProcesos.TabIndex = 11;
            this.btnProcesos.Text = "Procesos";
            this.btnProcesos.UseVisualStyleBackColor = true;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(713, 114);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(142, 93);
            this.btnInformes.TabIndex = 12;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnMantenimientos
            // 
            this.btnMantenimientos.Location = new System.Drawing.Point(225, 313);
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.Size = new System.Drawing.Size(142, 93);
            this.btnMantenimientos.TabIndex = 13;
            this.btnMantenimientos.Text = "Mantenimientos";
            this.btnMantenimientos.UseVisualStyleBackColor = true;
            this.btnMantenimientos.Click += new System.EventHandler(this.btnMantenimientos_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(580, 326);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(142, 93);
            this.btnAyuda.TabIndex = 14;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(994, 562);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(994, 562);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 562);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnMantenimientos);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnProcesos);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Button btnProcesos;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnMantenimientos;
        private System.Windows.Forms.Button btnAyuda;
    }
}