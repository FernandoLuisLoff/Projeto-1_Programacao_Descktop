namespace appSeguradora
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.Cad_Marcas = new System.Windows.Forms.Button();
            this.Cad_Modelo = new System.Windows.Forms.Button();
            this.Cad_Fipe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cad_Marcas
            // 
            this.Cad_Marcas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cad_Marcas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cad_Marcas.BackgroundImage")));
            this.Cad_Marcas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cad_Marcas.Location = new System.Drawing.Point(12, 79);
            this.Cad_Marcas.Name = "Cad_Marcas";
            this.Cad_Marcas.Size = new System.Drawing.Size(220, 254);
            this.Cad_Marcas.TabIndex = 0;
            this.Cad_Marcas.UseVisualStyleBackColor = true;
            this.Cad_Marcas.Click += new System.EventHandler(this.Cad_Marcas_Click);
            // 
            // Cad_Modelo
            // 
            this.Cad_Modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cad_Modelo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cad_Modelo.BackgroundImage")));
            this.Cad_Modelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cad_Modelo.Location = new System.Drawing.Point(238, 79);
            this.Cad_Modelo.Name = "Cad_Modelo";
            this.Cad_Modelo.Size = new System.Drawing.Size(220, 254);
            this.Cad_Modelo.TabIndex = 1;
            this.Cad_Modelo.UseVisualStyleBackColor = true;
            this.Cad_Modelo.Click += new System.EventHandler(this.Cad_Modelo_Click);
            // 
            // Cad_Fipe
            // 
            this.Cad_Fipe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cad_Fipe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cad_Fipe.BackgroundImage")));
            this.Cad_Fipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cad_Fipe.Location = new System.Drawing.Point(464, 79);
            this.Cad_Fipe.Name = "Cad_Fipe";
            this.Cad_Fipe.Size = new System.Drawing.Size(220, 254);
            this.Cad_Fipe.TabIndex = 2;
            this.Cad_Fipe.UseVisualStyleBackColor = true;
            this.Cad_Fipe.Click += new System.EventHandler(this.Cad_Fipe_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastros";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fipe";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelos";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marcas";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cad_Fipe);
            this.Controls.Add(this.Cad_Modelo);
            this.Controls.Add(this.Cad_Marcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cad_Marcas;
        private System.Windows.Forms.Button Cad_Modelo;
        private System.Windows.Forms.Button Cad_Fipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}