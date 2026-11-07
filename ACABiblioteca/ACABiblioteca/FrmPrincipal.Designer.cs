namespace ACABiblioteca
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnPrestamos = new FontAwesome.Sharp.IconButton();
            btnEditoriales = new FontAwesome.Sharp.IconButton();
            bntAutores = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            BtnLibros = new FontAwesome.Sharp.IconButton();
            PnlLogo = new Panel();
            piclogo = new PictureBox();
            LblSubtitulo = new Label();
            lblTitulo = new Label();
            PlnSuperior = new Panel();
            PlnEstado = new Panel();
            PlnContenido = new Panel();
            pnlMenu.SuspendLayout();
            PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btnEditoriales);
            pnlMenu.Controls.Add(bntAutores);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(BtnLibros);
            pnlMenu.Controls.Add(PnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(299, 611);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 25;
            btnSalir.Location = new Point(0, 350);
            btnSalir.Margin = new Padding(0, 10, 0, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(299, 45);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.Transparent;
            btnReportes.BackgroundImageLayout = ImageLayout.None;
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.TableColumns;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 25;
            btnReportes.Location = new Point(0, 305);
            btnReportes.Margin = new Padding(0, 10, 0, 10);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(299, 45);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleRight;
            btnReportes.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = Color.Transparent;
            btnPrestamos.BackgroundImageLayout = ImageLayout.None;
            btnPrestamos.Cursor = Cursors.Hand;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.FlatStyle = FlatStyle.Flat;
            btnPrestamos.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPrestamos.IconChar = FontAwesome.Sharp.IconChar.File;
            btnPrestamos.IconColor = Color.Black;
            btnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrestamos.IconSize = 25;
            btnPrestamos.Location = new Point(0, 260);
            btnPrestamos.Margin = new Padding(0, 10, 0, 10);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(299, 45);
            btnPrestamos.TabIndex = 6;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleRight;
            btnPrestamos.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnEditoriales
            // 
            btnEditoriales.BackColor = Color.Transparent;
            btnEditoriales.BackgroundImageLayout = ImageLayout.None;
            btnEditoriales.Cursor = Cursors.Hand;
            btnEditoriales.Dock = DockStyle.Top;
            btnEditoriales.FlatAppearance.BorderSize = 0;
            btnEditoriales.FlatStyle = FlatStyle.Flat;
            btnEditoriales.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnEditoriales.IconChar = FontAwesome.Sharp.IconChar.List12;
            btnEditoriales.IconColor = Color.Black;
            btnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditoriales.IconSize = 25;
            btnEditoriales.Location = new Point(0, 215);
            btnEditoriales.Margin = new Padding(0, 10, 0, 10);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(299, 45);
            btnEditoriales.TabIndex = 5;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.TextAlign = ContentAlignment.MiddleRight;
            btnEditoriales.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEditoriales.UseVisualStyleBackColor = false;
            btnEditoriales.Click += btnEditoriales_Click;
            // 
            // bntAutores
            // 
            bntAutores.BackColor = Color.Transparent;
            bntAutores.BackgroundImageLayout = ImageLayout.None;
            bntAutores.Cursor = Cursors.Hand;
            bntAutores.Dock = DockStyle.Top;
            bntAutores.FlatAppearance.BorderSize = 0;
            bntAutores.FlatStyle = FlatStyle.Flat;
            bntAutores.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            bntAutores.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            bntAutores.IconColor = Color.Black;
            bntAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bntAutores.IconSize = 25;
            bntAutores.Location = new Point(0, 170);
            bntAutores.Margin = new Padding(0, 10, 0, 10);
            bntAutores.Name = "bntAutores";
            bntAutores.Size = new Size(299, 45);
            bntAutores.TabIndex = 4;
            bntAutores.Text = "Autores";
            bntAutores.TextAlign = ContentAlignment.MiddleRight;
            bntAutores.TextImageRelation = TextImageRelation.TextBeforeImage;
            bntAutores.UseVisualStyleBackColor = false;
            bntAutores.Click += bntAutores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.Transparent;
            btnUsuarios.BackgroundImageLayout = ImageLayout.None;
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 25;
            btnUsuarios.Location = new Point(0, 125);
            btnUsuarios.Margin = new Padding(0, 10, 0, 10);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(299, 45);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // BtnLibros
            // 
            BtnLibros.BackColor = Color.Transparent;
            BtnLibros.BackgroundImageLayout = ImageLayout.None;
            BtnLibros.Cursor = Cursors.Hand;
            BtnLibros.Dock = DockStyle.Top;
            BtnLibros.FlatAppearance.BorderSize = 0;
            BtnLibros.FlatStyle = FlatStyle.Flat;
            BtnLibros.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BtnLibros.ForeColor = Color.Black;
            BtnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnLibros.IconColor = Color.Black;
            BtnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLibros.IconSize = 25;
            BtnLibros.Location = new Point(0, 80);
            BtnLibros.Margin = new Padding(0, 10, 0, 10);
            BtnLibros.Name = "BtnLibros";
            BtnLibros.Size = new Size(299, 45);
            BtnLibros.TabIndex = 2;
            BtnLibros.Text = "Libros";
            BtnLibros.TextAlign = ContentAlignment.MiddleRight;
            BtnLibros.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnLibros.UseVisualStyleBackColor = false;
            BtnLibros.Click += BtnLibros_Click;
            // 
            // PnlLogo
            // 
            PnlLogo.BackColor = Color.FromArgb(224, 224, 224);
            PnlLogo.Controls.Add(piclogo);
            PnlLogo.Controls.Add(LblSubtitulo);
            PnlLogo.Controls.Add(lblTitulo);
            PnlLogo.Dock = DockStyle.Top;
            PnlLogo.Location = new Point(0, 0);
            PnlLogo.Name = "PnlLogo";
            PnlLogo.Size = new Size(299, 80);
            PnlLogo.TabIndex = 0;
            // 
            // piclogo
            // 
            piclogo.BackColor = Color.Transparent;
            piclogo.BorderStyle = BorderStyle.Fixed3D;
            piclogo.Image = (Image)resources.GetObject("piclogo.Image");
            piclogo.Location = new Point(53, 12);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(60, 60);
            piclogo.SizeMode = PictureBoxSizeMode.Zoom;
            piclogo.TabIndex = 2;
            piclogo.TabStop = false;
            piclogo.Click += piclogo_Click;
            // 
            // LblSubtitulo
            // 
            LblSubtitulo.AutoSize = true;
            LblSubtitulo.Font = new Font("News706 BT", 9F, FontStyle.Bold);
            LblSubtitulo.Location = new Point(130, 57);
            LblSubtitulo.Name = "LblSubtitulo";
            LblSubtitulo.Size = new Size(118, 15);
            LblSubtitulo.TabIndex = 1;
            LblSubtitulo.Text = "Sistema de gestión";
            LblSubtitulo.Click += LblSubtitulo_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Onyx", 40F, FontStyle.Bold);
            lblTitulo.Location = new Point(119, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(159, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Biblioteca";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // PlnSuperior
            // 
            PlnSuperior.BackColor = Color.LightGray;
            PlnSuperior.Dock = DockStyle.Top;
            PlnSuperior.Location = new Point(299, 0);
            PlnSuperior.Name = "PlnSuperior";
            PlnSuperior.Size = new Size(1065, 80);
            PlnSuperior.TabIndex = 1;
            // 
            // PlnEstado
            // 
            PlnEstado.BackColor = Color.MistyRose;
            PlnEstado.Dock = DockStyle.Bottom;
            PlnEstado.Location = new Point(299, 571);
            PlnEstado.Name = "PlnEstado";
            PlnEstado.Size = new Size(1065, 40);
            PlnEstado.TabIndex = 2;
            // 
            // PlnContenido
            // 
            PlnContenido.BackColor = Color.PaleGreen;
            PlnContenido.Dock = DockStyle.Fill;
            PlnContenido.Location = new Point(299, 80);
            PlnContenido.Name = "PlnContenido";
            PlnContenido.Size = new Size(1065, 491);
            PlnContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 611);
            Controls.Add(PlnContenido);
            Controls.Add(PlnEstado);
            Controls.Add(PlnSuperior);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Biblioteca";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            pnlMenu.ResumeLayout(false);
            PnlLogo.ResumeLayout(false);
            PnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel PlnSuperior;
        private Panel PnlLogo;
        private Panel PlnEstado;
        private Panel PlnContenido;
        private Label LblSubtitulo;
        public Label lblTitulo;
        private PictureBox piclogo;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton BtnLibros;
        private FontAwesome.Sharp.IconButton btnPrestamos;
        private FontAwesome.Sharp.IconButton btnEditoriales;
        private FontAwesome.Sharp.IconButton bntAutores;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnReportes;
    }
}
