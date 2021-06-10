
namespace CINELAN
{
    partial class Acercade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acercade));
            this.TotalVentaComidaYCine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalVentaComidaYCine
            // 
            this.TotalVentaComidaYCine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TotalVentaComidaYCine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVentaComidaYCine.Location = new System.Drawing.Point(12, 21);
            this.TotalVentaComidaYCine.Name = "TotalVentaComidaYCine";
            this.TotalVentaComidaYCine.Size = new System.Drawing.Size(544, 281);
            this.TotalVentaComidaYCine.TabIndex = 9;
            this.TotalVentaComidaYCine.Text = resources.GetString("TotalVentaComidaYCine.Text");
            this.TotalVentaComidaYCine.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TotalVentaComidaYCine.UseVisualStyleBackColor = true;
            // 
            // Acercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 323);
            this.Controls.Add(this.TotalVentaComidaYCine);
            this.MaximizeBox = false;
            this.Name = "Acercade";
            this.Text = "Acercade";
            this.Load += new System.EventHandler(this.Acercade_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TotalVentaComidaYCine;
    }
}