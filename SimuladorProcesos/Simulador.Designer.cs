namespace SimuladorProcesos
{
    partial class Simulador
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
            this.PanelMenuVertical = new System.Windows.Forms.Panel();
            this.PanelMetodos = new System.Windows.Forms.Panel();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSlide = new System.Windows.Forms.PictureBox();
            this.btnTemperaturas = new System.Windows.Forms.Button();
            this.btnEstrucuras = new System.Windows.Forms.Button();
            this.btnTemplabilidad = new System.Windows.Forms.Button();
            this.btnSliceMetodos = new System.Windows.Forms.Button();
            this.btnConsTablas = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Button();
            this.PanelMenuVertical.SuspendLayout();
            this.PanelMetodos.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenuVertical
            // 
            this.PanelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(183)))));
            this.PanelMenuVertical.Controls.Add(this.PanelMetodos);
            this.PanelMenuVertical.Controls.Add(this.btnConsTablas);
            this.PanelMenuVertical.Controls.Add(this.Logo);
            this.PanelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuVertical.Name = "PanelMenuVertical";
            this.PanelMenuVertical.Size = new System.Drawing.Size(250, 650);
            this.PanelMenuVertical.TabIndex = 0;
            // 
            // PanelMetodos
            // 
            this.PanelMetodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(183)))));
            this.PanelMetodos.Controls.Add(this.btnSliceMetodos);
            this.PanelMetodos.Controls.Add(this.btnTemperaturas);
            this.PanelMetodos.Controls.Add(this.btnEstrucuras);
            this.PanelMetodos.Controls.Add(this.btnTemplabilidad);
            this.PanelMetodos.Location = new System.Drawing.Point(3, 190);
            this.PanelMetodos.Name = "PanelMetodos";
            this.PanelMetodos.Size = new System.Drawing.Size(247, 42);
            this.PanelMetodos.TabIndex = 0;
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.PanelTitulo.Controls.Add(this.btnRestaurar);
            this.PanelTitulo.Controls.Add(this.btnCerrar);
            this.PanelTitulo.Controls.Add(this.btnMinimizar);
            this.PanelTitulo.Controls.Add(this.btnSlide);
            this.PanelTitulo.Controls.Add(this.btnMaximizar);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(250, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(1050, 41);
            this.PanelTitulo.TabIndex = 1;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(250, 41);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1050, 609);
            this.PanelContenedor.TabIndex = 1;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.ErrorImage = null;
            this.btnMaximizar.Image = global::SimuladorProcesos.Properties.Resources.maximizar__1_;
            this.btnMaximizar.InitialImage = null;
            this.btnMaximizar.Location = new System.Drawing.Point(968, 1);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 40);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.ErrorImage = null;
            this.btnRestaurar.Image = global::SimuladorProcesos.Properties.Resources.restaurar;
            this.btnRestaurar.InitialImage = null;
            this.btnRestaurar.Location = new System.Drawing.Point(968, 1);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 40);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::SimuladorProcesos.Properties.Resources.ventanas_cerradas__1_;
            this.btnCerrar.Location = new System.Drawing.Point(1010, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::SimuladorProcesos.Properties.Resources.minimizar_pestana;
            this.btnMinimizar.Location = new System.Drawing.Point(922, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnSlide.Image = global::SimuladorProcesos.Properties.Resources.boton_de_menu_de_tres_lineas_horizontales;
            this.btnSlide.Location = new System.Drawing.Point(0, 0);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(45, 40);
            this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSlide.TabIndex = 0;
            this.btnSlide.TabStop = false;
            this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // btnTemperaturas
            // 
            this.btnTemperaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(183)))));
            this.btnTemperaturas.FlatAppearance.BorderSize = 0;
            this.btnTemperaturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnTemperaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemperaturas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemperaturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnTemperaturas.Image = global::SimuladorProcesos.Properties.Resources.herramienta_de_control_de_temperatura_termometro;
            this.btnTemperaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemperaturas.Location = new System.Drawing.Point(0, 224);
            this.btnTemperaturas.Name = "btnTemperaturas";
            this.btnTemperaturas.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnTemperaturas.Size = new System.Drawing.Size(250, 75);
            this.btnTemperaturas.TabIndex = 5;
            this.btnTemperaturas.Text = "Cálculo De \r\nTemperaturas\r\nCríticas";
            this.btnTemperaturas.UseVisualStyleBackColor = false;
            // 
            // btnEstrucuras
            // 
            this.btnEstrucuras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(183)))));
            this.btnEstrucuras.FlatAppearance.BorderSize = 0;
            this.btnEstrucuras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnEstrucuras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstrucuras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstrucuras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnEstrucuras.Image = global::SimuladorProcesos.Properties.Resources.composicion_quimica;
            this.btnEstrucuras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstrucuras.Location = new System.Drawing.Point(0, 136);
            this.btnEstrucuras.Name = "btnEstrucuras";
            this.btnEstrucuras.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnEstrucuras.Size = new System.Drawing.Size(250, 71);
            this.btnEstrucuras.TabIndex = 4;
            this.btnEstrucuras.Text = "Relación\r\nEstructura\r\nPropiedades";
            this.btnEstrucuras.UseVisualStyleBackColor = false;
            // 
            // btnTemplabilidad
            // 
            this.btnTemplabilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(183)))));
            this.btnTemplabilidad.FlatAppearance.BorderSize = 0;
            this.btnTemplabilidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnTemplabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplabilidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemplabilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnTemplabilidad.Image = global::SimuladorProcesos.Properties.Resources.soldador_electrico;
            this.btnTemplabilidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemplabilidad.Location = new System.Drawing.Point(0, 52);
            this.btnTemplabilidad.Name = "btnTemplabilidad";
            this.btnTemplabilidad.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnTemplabilidad.Size = new System.Drawing.Size(250, 72);
            this.btnTemplabilidad.TabIndex = 3;
            this.btnTemplabilidad.Text = "Templabilidad \r\ny Revenido";
            this.btnTemplabilidad.UseVisualStyleBackColor = false;
            // 
            // btnSliceMetodos
            // 
            this.btnSliceMetodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(183)))));
            this.btnSliceMetodos.FlatAppearance.BorderSize = 0;
            this.btnSliceMetodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnSliceMetodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSliceMetodos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSliceMetodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnSliceMetodos.Image = global::SimuladorProcesos.Properties.Resources.senal_de_flecha_hacia_abajo_para_navegar;
            this.btnSliceMetodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSliceMetodos.Location = new System.Drawing.Point(-3, -3);
            this.btnSliceMetodos.Name = "btnSliceMetodos";
            this.btnSliceMetodos.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnSliceMetodos.Size = new System.Drawing.Size(250, 43);
            this.btnSliceMetodos.TabIndex = 2;
            this.btnSliceMetodos.Text = "Módulos";
            this.btnSliceMetodos.UseVisualStyleBackColor = false;
            this.btnSliceMetodos.Click += new System.EventHandler(this.BtnSliceMetodos_Click);
            // 
            // btnConsTablas
            // 
            this.btnConsTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(114)))), ((int)(((byte)(183)))));
            this.btnConsTablas.FlatAppearance.BorderSize = 0;
            this.btnConsTablas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnConsTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsTablas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsTablas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnConsTablas.Image = global::SimuladorProcesos.Properties.Resources.buscar_documentos__1_;
            this.btnConsTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsTablas.Location = new System.Drawing.Point(0, 141);
            this.btnConsTablas.Name = "btnConsTablas";
            this.btnConsTablas.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnConsTablas.Size = new System.Drawing.Size(250, 43);
            this.btnConsTablas.TabIndex = 1;
            this.btnConsTablas.Text = " Consulta Tablas ";
            this.btnConsTablas.UseVisualStyleBackColor = false;
            this.btnConsTablas.Click += new System.EventHandler(this.BtnConsTablas_Click);
            // 
            // Logo
            // 
            this.Logo.FlatAppearance.BorderSize = 0;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.Logo.Image = global::SimuladorProcesos.Properties.Resources.ccim;
            this.Logo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(250, 71);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "SIMULADOR CCIM";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Logo.UseVisualStyleBackColor = true;
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.PanelMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simulador";
            this.Text = "Form1";
            this.PanelMenuVertical.ResumeLayout(false);
            this.PanelMetodos.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuVertical;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnSlide;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button Logo;
        private System.Windows.Forms.Button btnConsTablas;
        private System.Windows.Forms.Panel PanelMetodos;
        private System.Windows.Forms.Button btnTemperaturas;
        private System.Windows.Forms.Button btnEstrucuras;
        private System.Windows.Forms.Button btnTemplabilidad;
        private System.Windows.Forms.Button btnSliceMetodos;
    }
}

