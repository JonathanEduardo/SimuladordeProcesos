namespace SimuladorProcesos
{
    partial class Fomr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fomr));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnMaximiza = new System.Windows.Forms.PictureBox();
            this.btnMinimiza = new System.Windows.Forms.PictureBox();
            this.btnCierra = new System.Windows.Forms.PictureBox();
            this.btnRestaura = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimiza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCierra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(32)))));
            this.PanelMenu.Controls.Add(this.button2);
            this.PanelMenu.Controls.Add(this.button1);
            this.PanelMenu.Controls.Add(this.btnConsultas);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(250, 650);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.PanelTitulo.Controls.Add(this.btnRestaura);
            this.PanelTitulo.Controls.Add(this.btnMaximiza);
            this.PanelTitulo.Controls.Add(this.btnCierra);
            this.PanelTitulo.Controls.Add(this.btnMinimiza);
            this.PanelTitulo.Controls.Add(this.btnSlide);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(250, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1050, 47);
            this.PanelTitulo.TabIndex = 1;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(250, 47);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1050, 603);
            this.PanelContenedor.TabIndex = 2;
            // 
            // btnMaximiza
            // 
            this.btnMaximiza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.btnMaximiza.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximiza.Image")));
            this.btnMaximiza.Location = new System.Drawing.Point(975, 6);
            this.btnMaximiza.Name = "btnMaximiza";
            this.btnMaximiza.Size = new System.Drawing.Size(35, 36);
            this.btnMaximiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximiza.TabIndex = 2;
            this.btnMaximiza.TabStop = false;
            this.btnMaximiza.Click += new System.EventHandler(this.BtnMaximiza_Click);
            // 
            // btnMinimiza
            // 
            this.btnMinimiza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.btnMinimiza.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimiza.Image")));
            this.btnMinimiza.Location = new System.Drawing.Point(935, 6);
            this.btnMinimiza.Name = "btnMinimiza";
            this.btnMinimiza.Size = new System.Drawing.Size(34, 37);
            this.btnMinimiza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimiza.TabIndex = 4;
            this.btnMinimiza.TabStop = false;
            this.btnMinimiza.Click += new System.EventHandler(this.BtnMinimiza_Click);
            // 
            // btnCierra
            // 
            this.btnCierra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.btnCierra.Image = ((System.Drawing.Image)(resources.GetObject("btnCierra.Image")));
            this.btnCierra.Location = new System.Drawing.Point(1016, 5);
            this.btnCierra.Name = "btnCierra";
            this.btnCierra.Size = new System.Drawing.Size(34, 37);
            this.btnCierra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCierra.TabIndex = 3;
            this.btnCierra.TabStop = false;
            this.btnCierra.Click += new System.EventHandler(this.BtnCierra_Click);
            // 
            // btnRestaura
            // 
            this.btnRestaura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
            this.btnRestaura.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaura.Image")));
            this.btnRestaura.Location = new System.Drawing.Point(975, 5);
            this.btnRestaura.Name = "btnRestaura";
            this.btnRestaura.Size = new System.Drawing.Size(40, 36);
            this.btnRestaura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRestaura.TabIndex = 1;
            this.btnRestaura.TabStop = false;
            this.btnRestaura.Visible = false;
            this.btnRestaura.Click += new System.EventHandler(this.BtnRestaura_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(109)))));
           // this.btnSlide.Image = global::SimuladorProcesos.Properties.Resources.boton_de_menu_de_tres_lineas_horizontales;
            this.btnSlide.Location = new System.Drawing.Point(3, 3);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(47, 39);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            //this.button2.Image = global::SimuladorProcesos.Properties.Resources.ingeniero__2_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 77);
            this.button2.TabIndex = 3;
            this.button2.Text = "SIMULADOR ICMM";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
           // this.button1.Image = global::SimuladorProcesos.Properties.Resources.buscar_documentos__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(0, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "  Consulta Metales ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConsultas
            // 
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
           // this.btnConsultas.Image = global::SimuladorProcesos.Properties.Resources.buscar_documentos__1_;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnConsultas.Location = new System.Drawing.Point(0, 98);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(250, 38);
            this.btnConsultas.TabIndex = 0;
            this.btnConsultas.Text = "  Consulta Metales ";
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // Fomr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fomr";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimiza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCierra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.PictureBox btnMinimiza;
        private System.Windows.Forms.PictureBox btnCierra;
        private System.Windows.Forms.PictureBox btnMaximiza;
        private System.Windows.Forms.PictureBox btnRestaura;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

