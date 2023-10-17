﻿namespace PRESENTACION
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btnCerrarSesion = new Button();
            panelContenedor = new Panel();
            panelFormularios = new Panel();
            panelMenu = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblRol = new Label();
            pictureBox1 = new PictureBox();
            btnUsuarios = new Button();
            btnProgramadores = new Button();
            btnTareas = new Button();
            btnProyectos = new Button();
            panelBarraTitulo = new Panel();
            panel1 = new Panel();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            panelContenedor.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.Gainsboro;
            btnCerrarSesion.Location = new Point(54, 426);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(158, 30);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Controls.Add(panelFormularios);
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Controls.Add(panelBarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(800, 524);
            panelContenedor.TabIndex = 1;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = Color.FromArgb(15, 15, 15);
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(233, 47);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(567, 477);
            panelFormularios.TabIndex = 2;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 122, 204);
            panelMenu.Controls.Add(pictureBox6);
            panelMenu.Controls.Add(pictureBox5);
            panelMenu.Controls.Add(pictureBox4);
            panelMenu.Controls.Add(pictureBox3);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(lblNombre);
            panelMenu.Controls.Add(lblApellido);
            panelMenu.Controls.Add(lblRol);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnProgramadores);
            panelMenu.Controls.Add(btnTareas);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnProyectos);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 47);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(233, 477);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(25, 426);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(30, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Click += btnCerrarSesion_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(25, 263);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            pictureBox5.Click += btnProgramadores_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(25, 214);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += btnTareas_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 165);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += btnProyectos_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += btnUsuarios_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(103, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "label3";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(103, 36);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(38, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "label2";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(103, 7);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(38, 15);
            lblRol.TabIndex = 5;
            lblRol.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.Gainsboro;
            btnUsuarios.Location = new Point(54, 115);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(158, 30);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProgramadores
            // 
            btnProgramadores.Cursor = Cursors.Hand;
            btnProgramadores.FlatAppearance.BorderSize = 0;
            btnProgramadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnProgramadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnProgramadores.FlatStyle = FlatStyle.Flat;
            btnProgramadores.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnProgramadores.ForeColor = Color.Gainsboro;
            btnProgramadores.Location = new Point(54, 263);
            btnProgramadores.Name = "btnProgramadores";
            btnProgramadores.Size = new Size(158, 30);
            btnProgramadores.TabIndex = 2;
            btnProgramadores.Text = "Programadores";
            btnProgramadores.UseVisualStyleBackColor = true;
            btnProgramadores.Click += btnProgramadores_Click;
            // 
            // btnTareas
            // 
            btnTareas.Cursor = Cursors.Hand;
            btnTareas.FlatAppearance.BorderSize = 0;
            btnTareas.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnTareas.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnTareas.FlatStyle = FlatStyle.Flat;
            btnTareas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnTareas.ForeColor = Color.Gainsboro;
            btnTareas.Location = new Point(54, 214);
            btnTareas.Name = "btnTareas";
            btnTareas.Size = new Size(158, 30);
            btnTareas.TabIndex = 1;
            btnTareas.Text = "Tareas";
            btnTareas.UseVisualStyleBackColor = true;
            btnTareas.Click += btnTareas_Click;
            // 
            // btnProyectos
            // 
            btnProyectos.Cursor = Cursors.Hand;
            btnProyectos.FlatAppearance.BorderSize = 0;
            btnProyectos.FlatAppearance.MouseDownBackColor = Color.FromArgb(33, 50, 70);
            btnProyectos.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 61, 92);
            btnProyectos.FlatStyle = FlatStyle.Flat;
            btnProyectos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnProyectos.ForeColor = Color.Gainsboro;
            btnProyectos.Location = new Point(54, 165);
            btnProyectos.Name = "btnProyectos";
            btnProyectos.Size = new Size(158, 30);
            btnProyectos.TabIndex = 0;
            btnProyectos.Text = "Proyectos";
            btnProyectos.UseVisualStyleBackColor = true;
            btnProyectos.Click += btnProyectos_Click;
            // 
            // panelBarraTitulo
            // 
            panelBarraTitulo.BackColor = SystemColors.ControlLight;
            panelBarraTitulo.Controls.Add(panel1);
            panelBarraTitulo.Controls.Add(btnMinimizar);
            panelBarraTitulo.Controls.Add(btnMaximizar);
            panelBarraTitulo.Controls.Add(btnRestaurar);
            panelBarraTitulo.Controls.Add(btnCerrar);
            panelBarraTitulo.Dock = DockStyle.Top;
            panelBarraTitulo.Location = new Point(0, 0);
            panelBarraTitulo.Name = "panelBarraTitulo";
            panelBarraTitulo.Size = new Size(800, 47);
            panelBarraTitulo.TabIndex = 0;
            panelBarraTitulo.MouseMove += panelBarraTitulo_MouseMove;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 100);
            panel1.TabIndex = 4;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(716, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(20, 20);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 7;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(742, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(20, 20);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 6;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(742, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(20, 20);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 5;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(768, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 20);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 4;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 524);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(650, 450);
            Name = "FormPrincipal";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            panelContenedor.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrarSesion;
        private Panel panelContenedor;
        private Panel panelFormularios;
        private Panel panelMenu;
        private Panel panelBarraTitulo;
        private Button btnProyectos;
        private Button btnUsuarios;
        private Button btnProgramadores;
        private Button btnTareas;
        private PictureBox btnMinimizar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblRol;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
    }
}