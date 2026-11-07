namespace ACABiblioteca
{
    partial class Frmlibros
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
            pnltitulo = new Panel();
            lbltitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscarisbm = new TextBox();
            lblbuscar = new Label();
            PnlDatos = new Panel();
            cmbeditorial = new ComboBox();
            cmbautor = new ComboBox();
            txtexistencias = new TextBox();
            txtano = new TextBox();
            txtcategoria = new TextBox();
            txttitulo = new TextBox();
            txtisbn = new TextBox();
            lbnExistencias = new Label();
            lbnano = new Label();
            lbncategoria = new Label();
            lbbneditorial = new Label();
            lbnAutor = new Label();
            lbntitulolib = new Label();
            lbnISBN = new Label();
            pnlbotones = new Panel();
            btncancelar = new FontAwesome.Sharp.IconButton();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            btneditar = new FontAwesome.Sharp.IconButton();
            btnnuevo = new FontAwesome.Sharp.IconButton();
            dgvlibros = new DataGridView();
            pnltitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            PnlDatos.SuspendLayout();
            pnlbotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlibros).BeginInit();
            SuspendLayout();
            // 
            // pnltitulo
            // 
            pnltitulo.BackColor = Color.PowderBlue;
            pnltitulo.Controls.Add(lbltitulo);
            pnltitulo.Dock = DockStyle.Top;
            pnltitulo.Location = new Point(0, 0);
            pnltitulo.Name = "pnltitulo";
            pnltitulo.Size = new Size(1350, 60);
            pnltitulo.TabIndex = 0;
            pnltitulo.Paint += pnltitulo_Paint;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Transparent;
            lbltitulo.Font = new Font("Rockwell Condensed", 25F, FontStyle.Bold);
            lbltitulo.ForeColor = Color.Black;
            lbltitulo.Location = new Point(22, 9);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(253, 40);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Gestión de Libros";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.Gainsboro;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscarisbm);
            pnlBusqueda.Controls.Add(lblbuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1350, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(682, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarisbm
            // 
            txtBuscarisbm.Location = new Point(161, 17);
            txtBuscarisbm.Name = "txtBuscarisbm";
            txtBuscarisbm.Size = new Size(489, 23);
            txtBuscarisbm.TabIndex = 1;
            // 
            // lblbuscar
            // 
            lblbuscar.AutoSize = true;
            lblbuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblbuscar.Location = new Point(65, 21);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(80, 15);
            lblbuscar.TabIndex = 0;
            lblbuscar.Text = "Ingrese ISBN";
            lblbuscar.Click += lbl_Click;
            // 
            // PnlDatos
            // 
            PnlDatos.Controls.Add(cmbeditorial);
            PnlDatos.Controls.Add(cmbautor);
            PnlDatos.Controls.Add(txtexistencias);
            PnlDatos.Controls.Add(txtano);
            PnlDatos.Controls.Add(txtcategoria);
            PnlDatos.Controls.Add(txttitulo);
            PnlDatos.Controls.Add(txtisbn);
            PnlDatos.Controls.Add(lbnExistencias);
            PnlDatos.Controls.Add(lbnano);
            PnlDatos.Controls.Add(lbncategoria);
            PnlDatos.Controls.Add(lbbneditorial);
            PnlDatos.Controls.Add(lbnAutor);
            PnlDatos.Controls.Add(lbntitulolib);
            PnlDatos.Controls.Add(lbnISBN);
            PnlDatos.Dock = DockStyle.Top;
            PnlDatos.Location = new Point(0, 115);
            PnlDatos.Name = "PnlDatos";
            PnlDatos.Size = new Size(1350, 236);
            PnlDatos.TabIndex = 2;
            // 
            // cmbeditorial
            // 
            cmbeditorial.FormattingEnabled = true;
            cmbeditorial.Location = new Point(161, 106);
            cmbeditorial.Name = "cmbeditorial";
            cmbeditorial.Size = new Size(489, 23);
            cmbeditorial.TabIndex = 17;
            // 
            // cmbautor
            // 
            cmbautor.FormattingEnabled = true;
            cmbautor.Location = new Point(161, 77);
            cmbautor.Name = "cmbautor";
            cmbautor.Size = new Size(489, 23);
            cmbautor.TabIndex = 16;
            // 
            // txtexistencias
            // 
            txtexistencias.Location = new Point(161, 188);
            txtexistencias.Name = "txtexistencias";
            txtexistencias.Size = new Size(489, 23);
            txtexistencias.TabIndex = 15;
            // 
            // txtano
            // 
            txtano.Location = new Point(161, 161);
            txtano.Name = "txtano";
            txtano.Size = new Size(489, 23);
            txtano.TabIndex = 14;
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(161, 133);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(489, 23);
            txtcategoria.TabIndex = 13;
            // 
            // txttitulo
            // 
            txttitulo.Location = new Point(161, 49);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(489, 23);
            txttitulo.TabIndex = 10;
            // 
            // txtisbn
            // 
            txtisbn.Location = new Point(161, 20);
            txtisbn.Name = "txtisbn";
            txtisbn.Size = new Size(489, 23);
            txtisbn.TabIndex = 3;
            // 
            // lbnExistencias
            // 
            lbnExistencias.AutoSize = true;
            lbnExistencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbnExistencias.Location = new Point(65, 191);
            lbnExistencias.Name = "lbnExistencias";
            lbnExistencias.Size = new Size(70, 15);
            lbnExistencias.TabIndex = 9;
            lbnExistencias.Text = "Existencias:";
            // 
            // lbnano
            // 
            lbnano.AutoSize = true;
            lbnano.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbnano.Location = new Point(65, 161);
            lbnano.Name = "lbnano";
            lbnano.Size = new Size(32, 15);
            lbnano.TabIndex = 8;
            lbnano.Text = "Año:";
            // 
            // lbncategoria
            // 
            lbncategoria.AutoSize = true;
            lbncategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbncategoria.Location = new Point(65, 136);
            lbncategoria.Name = "lbncategoria";
            lbncategoria.Size = new Size(63, 15);
            lbncategoria.TabIndex = 7;
            lbncategoria.Text = "Categoría:";
            lbncategoria.Click += label1_Click_1;
            // 
            // lbbneditorial
            // 
            lbbneditorial.AutoSize = true;
            lbbneditorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbbneditorial.Location = new Point(65, 107);
            lbbneditorial.Name = "lbbneditorial";
            lbbneditorial.Size = new Size(55, 15);
            lbbneditorial.TabIndex = 6;
            lbbneditorial.Text = "Editorial:";
            // 
            // lbnAutor
            // 
            lbnAutor.AutoSize = true;
            lbnAutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbnAutor.Location = new Point(65, 80);
            lbnAutor.Name = "lbnAutor";
            lbnAutor.Size = new Size(42, 15);
            lbnAutor.TabIndex = 5;
            lbnAutor.Text = "Autor:";
            lbnAutor.Click += label1_Click;
            // 
            // lbntitulolib
            // 
            lbntitulolib.AutoSize = true;
            lbntitulolib.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbntitulolib.Location = new Point(65, 52);
            lbntitulolib.Name = "lbntitulolib";
            lbntitulolib.Size = new Size(42, 15);
            lbntitulolib.TabIndex = 4;
            lbntitulolib.Text = "Titulo:";
            lbntitulolib.Click += lbntitulolib_Click;
            // 
            // lbnISBN
            // 
            lbnISBN.AutoSize = true;
            lbnISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbnISBN.Location = new Point(65, 27);
            lbnISBN.Name = "lbnISBN";
            lbnISBN.Size = new Size(38, 15);
            lbnISBN.TabIndex = 3;
            lbnISBN.Text = "ISBN:";
            // 
            // pnlbotones
            // 
            pnlbotones.BackColor = SystemColors.ActiveCaption;
            pnlbotones.Controls.Add(btncancelar);
            pnlbotones.Controls.Add(btneliminar);
            pnlbotones.Controls.Add(btnguardar);
            pnlbotones.Controls.Add(btneditar);
            pnlbotones.Controls.Add(btnnuevo);
            pnlbotones.Dock = DockStyle.Top;
            pnlbotones.Location = new Point(0, 351);
            pnlbotones.Name = "pnlbotones";
            pnlbotones.Size = new Size(1350, 66);
            pnlbotones.TabIndex = 3;
            // 
            // btncancelar
            // 
            btncancelar.IconChar = FontAwesome.Sharp.IconChar.C;
            btncancelar.IconColor = Color.Black;
            btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btncancelar.IconSize = 30;
            btncancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btncancelar.Location = new Point(496, 6);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(100, 40);
            btncancelar.TabIndex = 4;
            btncancelar.Text = "Cancelar";
            btncancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            btneliminar.IconChar = FontAwesome.Sharp.IconChar.E;
            btneliminar.IconColor = Color.Black;
            btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminar.IconSize = 30;
            btneliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btneliminar.Location = new Point(375, 6);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(100, 40);
            btneliminar.TabIndex = 3;
            btneliminar.Text = "Eliminar";
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.S;
            btnguardar.IconColor = Color.Black;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 30;
            btnguardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnguardar.Location = new Point(131, 6);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(100, 40);
            btnguardar.TabIndex = 2;
            btnguardar.Text = "Guardar";
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneditar
            // 
            btneditar.IconChar = FontAwesome.Sharp.IconChar.E;
            btneditar.IconColor = Color.Black;
            btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneditar.IconSize = 30;
            btneditar.ImageAlign = ContentAlignment.MiddleLeft;
            btneditar.Location = new Point(254, 6);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(100, 40);
            btneditar.TabIndex = 1;
            btneditar.Text = "Editar";
            btneditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btnEditar_Click;
            // 
            // btnnuevo
            // 
            btnnuevo.IconChar = FontAwesome.Sharp.IconChar.N;
            btnnuevo.IconColor = Color.Black;
            btnnuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnnuevo.IconSize = 30;
            btnnuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnnuevo.Location = new Point(13, 6);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(100, 40);
            btnnuevo.TabIndex = 0;
            btnnuevo.Text = "Nuevo";
            btnnuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnnuevo.UseVisualStyleBackColor = true;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // dgvlibros
            // 
            dgvlibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlibros.Location = new Point(188, 449);
            dgvlibros.Name = "dgvlibros";
            dgvlibros.Size = new Size(800, 268);
            dgvlibros.TabIndex = 4;
            dgvlibros.CellDoubleClick += dgvlibros_CellDoubleClick;
            // 
            // Frmlibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(dgvlibros);
            Controls.Add(pnlbotones);
            Controls.Add(PnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnltitulo);
            Name = "Frmlibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frmlibros";
            WindowState = FormWindowState.Maximized;
            pnltitulo.ResumeLayout(false);
            pnltitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            PnlDatos.ResumeLayout(false);
            PnlDatos.PerformLayout();
            pnlbotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvlibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnltitulo;
        private Label lbltitulo;
        private Panel pnlBusqueda;
        private Button btnBuscar;
        private TextBox txtBuscarisbm;
        private Label lblbuscar;
        private Panel PnlDatos;
        private Label lbnAutor;
        private Label lbntitulolib;
        private Label lbnISBN;
        private Label lbbneditorial;
        private Label lbncategoria;
        private ComboBox cmbeditorial;
        private ComboBox cmbautor;
        private TextBox txtexistencias;
        private TextBox txtano;
        private TextBox txtcategoria;
        private TextBox txttitulo;
        private TextBox txtisbn;
        private Label lbnExistencias;
        private Label lbnano;
        private Panel pnlbotones;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btnnuevo;
        private FontAwesome.Sharp.IconButton btncancelar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private DataGridView dgvlibros;
    }
}