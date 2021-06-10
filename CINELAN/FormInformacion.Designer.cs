namespace CINELAN
{
    partial class FormInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacion));
            this.btnInformacion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPersonasEdades = new System.Windows.Forms.Button();
            this.btnCompraronCOmida = new System.Windows.Forms.Button();
            this.btnNoCompraronComida = new System.Windows.Forms.Button();
            this.btnDineroSala = new System.Windows.Forms.Button();
            this.btnPeliculaMasVista = new System.Windows.Forms.Button();
            this.btnTotalVentaComida = new System.Windows.Forms.Button();
            this.TotalVentaComidaYCine = new System.Windows.Forms.Button();
            this.txtTotalVentasComida = new System.Windows.Forms.TextBox();
            this.txtPeliculaMasVista = new System.Windows.Forms.TextBox();
            this.txtTotalVentasComidaYCIne = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(19, 52);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(133, 23);
            this.btnInformacion.TabIndex = 0;
            this.btnInformacion.Text = "Informacion General";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 195);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPersonasEdades
            // 
            this.btnPersonasEdades.Location = new System.Drawing.Point(161, 52);
            this.btnPersonasEdades.Name = "btnPersonasEdades";
            this.btnPersonasEdades.Size = new System.Drawing.Size(129, 23);
            this.btnPersonasEdades.TabIndex = 2;
            this.btnPersonasEdades.Text = "Personas Por Edades";
            this.btnPersonasEdades.UseVisualStyleBackColor = true;
            this.btnPersonasEdades.Click += new System.EventHandler(this.btnPersonasEdades_Click);
            // 
            // btnCompraronCOmida
            // 
            this.btnCompraronCOmida.Location = new System.Drawing.Point(301, 52);
            this.btnCompraronCOmida.Name = "btnCompraronCOmida";
            this.btnCompraronCOmida.Size = new System.Drawing.Size(115, 23);
            this.btnCompraronCOmida.TabIndex = 3;
            this.btnCompraronCOmida.Text = "Compraron Comida";
            this.btnCompraronCOmida.UseVisualStyleBackColor = true;
            this.btnCompraronCOmida.Click += new System.EventHandler(this.btnCompraronCOmida_Click);
            // 
            // btnNoCompraronComida
            // 
            this.btnNoCompraronComida.Location = new System.Drawing.Point(426, 52);
            this.btnNoCompraronComida.Name = "btnNoCompraronComida";
            this.btnNoCompraronComida.Size = new System.Drawing.Size(130, 23);
            this.btnNoCompraronComida.TabIndex = 4;
            this.btnNoCompraronComida.Text = "No Compraron Comida";
            this.btnNoCompraronComida.UseVisualStyleBackColor = true;
            this.btnNoCompraronComida.Click += new System.EventHandler(this.btnNoCompraronComida_Click);
            // 
            // btnDineroSala
            // 
            this.btnDineroSala.Location = new System.Drawing.Point(564, 52);
            this.btnDineroSala.Name = "btnDineroSala";
            this.btnDineroSala.Size = new System.Drawing.Size(161, 23);
            this.btnDineroSala.TabIndex = 5;
            this.btnDineroSala.Text = "Total Dinero Cada Sala";
            this.btnDineroSala.UseVisualStyleBackColor = true;
            this.btnDineroSala.Click += new System.EventHandler(this.btnDineroSala_Click);
            // 
            // btnPeliculaMasVista
            // 
            this.btnPeliculaMasVista.Location = new System.Drawing.Point(161, 311);
            this.btnPeliculaMasVista.Name = "btnPeliculaMasVista";
            this.btnPeliculaMasVista.Size = new System.Drawing.Size(148, 23);
            this.btnPeliculaMasVista.TabIndex = 6;
            this.btnPeliculaMasVista.Text = "Pelicula Más Vista";
            this.btnPeliculaMasVista.UseVisualStyleBackColor = true;
            this.btnPeliculaMasVista.Click += new System.EventHandler(this.btnPeliculaMasVista_Click);
            // 
            // btnTotalVentaComida
            // 
            this.btnTotalVentaComida.Location = new System.Drawing.Point(161, 343);
            this.btnTotalVentaComida.Name = "btnTotalVentaComida";
            this.btnTotalVentaComida.Size = new System.Drawing.Size(148, 23);
            this.btnTotalVentaComida.TabIndex = 7;
            this.btnTotalVentaComida.Text = "Total Ventas Por Comida";
            this.btnTotalVentaComida.UseVisualStyleBackColor = true;
            this.btnTotalVentaComida.Click += new System.EventHandler(this.btnTotalVentaComida_Click);
            // 
            // TotalVentaComidaYCine
            // 
            this.TotalVentaComidaYCine.Location = new System.Drawing.Point(161, 376);
            this.TotalVentaComidaYCine.Name = "TotalVentaComidaYCine";
            this.TotalVentaComidaYCine.Size = new System.Drawing.Size(148, 41);
            this.TotalVentaComidaYCine.TabIndex = 8;
            this.TotalVentaComidaYCine.Text = "Total Ventas Por Entrada al Cine";
            this.TotalVentaComidaYCine.UseVisualStyleBackColor = true;
            this.TotalVentaComidaYCine.Click += new System.EventHandler(this.TotalVentaComidaYCine_Click);
            // 
            // txtTotalVentasComida
            // 
            this.txtTotalVentasComida.Location = new System.Drawing.Point(340, 346);
            this.txtTotalVentasComida.Name = "txtTotalVentasComida";
            this.txtTotalVentasComida.ReadOnly = true;
            this.txtTotalVentasComida.Size = new System.Drawing.Size(130, 20);
            this.txtTotalVentasComida.TabIndex = 9;
            // 
            // txtPeliculaMasVista
            // 
            this.txtPeliculaMasVista.Location = new System.Drawing.Point(340, 317);
            this.txtPeliculaMasVista.Name = "txtPeliculaMasVista";
            this.txtPeliculaMasVista.ReadOnly = true;
            this.txtPeliculaMasVista.Size = new System.Drawing.Size(130, 20);
            this.txtPeliculaMasVista.TabIndex = 11;
            // 
            // txtTotalVentasComidaYCIne
            // 
            this.txtTotalVentasComidaYCIne.Location = new System.Drawing.Point(340, 387);
            this.txtTotalVentasComidaYCIne.Name = "txtTotalVentasComidaYCIne";
            this.txtTotalVentasComidaYCIne.ReadOnly = true;
            this.txtTotalVentasComidaYCIne.Size = new System.Drawing.Size(130, 20);
            this.txtTotalVentasComidaYCIne.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(537, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Volver Atras";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(238, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(276, 39);
            this.label10.TabIndex = 14;
            this.label10.Text = "CINELAN H && H...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tipo de Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtTotalVentasComidaYCIne);
            this.Controls.Add(this.txtPeliculaMasVista);
            this.Controls.Add(this.txtTotalVentasComida);
            this.Controls.Add(this.TotalVentaComidaYCine);
            this.Controls.Add(this.btnTotalVentaComida);
            this.Controls.Add(this.btnPeliculaMasVista);
            this.Controls.Add(this.btnDineroSala);
            this.Controls.Add(this.btnNoCompraronComida);
            this.Controls.Add(this.btnCompraronCOmida);
            this.Controls.Add(this.btnPersonasEdades);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInformacion);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInformacion";
            this.Text = "Informacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInformacion_FormClosing);
            this.Load += new System.EventHandler(this.FormInformacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPersonasEdades;
        private System.Windows.Forms.Button btnCompraronCOmida;
        private System.Windows.Forms.Button btnNoCompraronComida;
        private System.Windows.Forms.Button btnDineroSala;
        private System.Windows.Forms.Button btnPeliculaMasVista;
        private System.Windows.Forms.Button btnTotalVentaComida;
        private System.Windows.Forms.Button TotalVentaComidaYCine;
        private System.Windows.Forms.TextBox txtTotalVentasComida;
        private System.Windows.Forms.TextBox txtPeliculaMasVista;
        private System.Windows.Forms.TextBox txtTotalVentasComidaYCIne;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}