namespace ACABiblioteca
{
    partial class FrmPrestamos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamos));
            cbousuarios = new ComboBox();
            cbolibros = new ComboBox();
            dtpfechaprestamo = new DateTimePicker();
            dtpfechadevolucion = new DateTimePicker();
            btnnuevoprestamos = new Button();
            btnguardarprestamos = new Button();
            btneditarprestamos = new Button();
            btneliminarprestamos = new Button();
            btncancelarprestamos = new Button();
            dgvprestamos = new DataGridView();
            lblusuario = new Label();
            lbllibro = new Label();
            lblfechaprestamo = new Label();
            lblfechadevolucion = new Label();
            pnlencabezado = new Panel();
            lbltitulo = new Label();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvprestamos).BeginInit();
            pnlencabezado.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbousuarios
            // 
            cbousuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cbousuarios.FormattingEnabled = true;
            cbousuarios.Location = new Point(370, 158);
            cbousuarios.Name = "cbousuarios";
            cbousuarios.Size = new Size(400, 23);
            cbousuarios.TabIndex = 0;
            // 
            // cbolibros
            // 
            cbolibros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbolibros.FormattingEnabled = true;
            cbolibros.Location = new Point(370, 198);
            cbolibros.Name = "cbolibros";
            cbolibros.Size = new Size(400, 23);
            cbolibros.TabIndex = 1;
            // 
            // dtpfechaprestamo
            // 
            dtpfechaprestamo.Format = DateTimePickerFormat.Short;
            dtpfechaprestamo.Location = new Point(370, 238);
            dtpfechaprestamo.Name = "dtpfechaprestamo";
            dtpfechaprestamo.Size = new Size(400, 23);
            dtpfechaprestamo.TabIndex = 2;
            // 
            // dtpfechadevolucion
            // 
            dtpfechadevolucion.Format = DateTimePickerFormat.Short;
            dtpfechadevolucion.Location = new Point(370, 278);
            dtpfechadevolucion.Name = "dtpfechadevolucion";
            dtpfechadevolucion.Size = new Size(400, 23);
            dtpfechadevolucion.TabIndex = 3;
            // 
            // btnnuevoprestamos
            // 
            btnnuevoprestamos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnnuevoprestamos.Location = new Point(235, 334);
            btnnuevoprestamos.Name = "btnnuevoprestamos";
            btnnuevoprestamos.Size = new Size(95, 35);
            btnnuevoprestamos.TabIndex = 4;
            btnnuevoprestamos.Text = "Nuevo";
            btnnuevoprestamos.UseVisualStyleBackColor = true;
            // 
            // btnguardarprestamos
            // 
            btnguardarprestamos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnguardarprestamos.Location = new Point(350, 334);
            btnguardarprestamos.Name = "btnguardarprestamos";
            btnguardarprestamos.Size = new Size(95, 35);
            btnguardarprestamos.TabIndex = 5;
            btnguardarprestamos.Text = "Guardar";
            btnguardarprestamos.UseVisualStyleBackColor = true;
            // 
            // btneditarprestamos
            // 
            btneditarprestamos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btneditarprestamos.Location = new Point(465, 334);
            btneditarprestamos.Name = "btneditarprestamos";
            btneditarprestamos.Size = new Size(95, 35);
            btneditarprestamos.TabIndex = 6;
            btneditarprestamos.Text = "Editar";
            btneditarprestamos.UseVisualStyleBackColor = true;
            // 
            // btneliminarprestamos
            // 
            btneliminarprestamos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btneliminarprestamos.Location = new Point(580, 334);
            btneliminarprestamos.Name = "btneliminarprestamos";
            btneliminarprestamos.Size = new Size(95, 35);
            btneliminarprestamos.TabIndex = 7;
            btneliminarprestamos.Text = "Eliminar";
            btneliminarprestamos.UseVisualStyleBackColor = true;
            // 
            // btncancelarprestamos
            // 
            btncancelarprestamos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncancelarprestamos.Location = new Point(695, 334);
            btncancelarprestamos.Name = "btncancelarprestamos";
            btncancelarprestamos.Size = new Size(95, 35);
            btncancelarprestamos.TabIndex = 8;
            btncancelarprestamos.Text = "Cancelar";
            btncancelarprestamos.UseVisualStyleBackColor = true;
            // 
            // dgvprestamos
            // 
            dgvprestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvprestamos.Location = new Point(83, 387);
            dgvprestamos.Name = "dgvprestamos";
            dgvprestamos.Size = new Size(790, 260);
            dgvprestamos.TabIndex = 9;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblusuario.Location = new Point(235, 158);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(64, 19);
            lblusuario.TabIndex = 0;
            lblusuario.Text = "Usuario:";
            // 
            // lbllibro
            // 
            lbllibro.AutoSize = true;
            lbllibro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbllibro.Location = new Point(235, 198);
            lbllibro.Name = "lbllibro";
            lbllibro.Size = new Size(48, 19);
            lbllibro.TabIndex = 1;
            lbllibro.Text = "Libro:";
            // 
            // lblfechaprestamo
            // 
            lblfechaprestamo.AutoSize = true;
            lblfechaprestamo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblfechaprestamo.Location = new Point(235, 238);
            lblfechaprestamo.Name = "lblfechaprestamo";
            lblfechaprestamo.Size = new Size(119, 19);
            lblfechaprestamo.TabIndex = 2;
            lblfechaprestamo.Text = "Fecha Préstamo:";
            // 
            // lblfechadevolucion
            // 
            lblfechadevolucion.AutoSize = true;
            lblfechadevolucion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblfechadevolucion.Location = new Point(235, 278);
            lblfechadevolucion.Name = "lblfechadevolucion";
            lblfechadevolucion.Size = new Size(130, 19);
            lblfechadevolucion.TabIndex = 3;
            lblfechadevolucion.Text = "Fecha Devolución:";
            // 
            // pnlencabezado
            // 
            pnlencabezado.BackColor = Color.FromArgb(143, 212, 218);
            pnlencabezado.Controls.Add(lbltitulo);
            pnlencabezado.Dock = DockStyle.Top;
            pnlencabezado.Location = new Point(0, 0);
            pnlencabezado.Name = "pnlencabezado";
            pnlencabezado.Size = new Size(1191, 65);
            pnlencabezado.TabIndex = 20;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbltitulo.ForeColor = Color.Black;
            lbltitulo.Location = new Point(30, 14);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(296, 37);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Gestión de Préstamos";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1191, 57);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(707, 45);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1191, 717);
            Controls.Add(panel1);
            Controls.Add(pnlencabezado);
            Controls.Add(lblfechadevolucion);
            Controls.Add(lblfechaprestamo);
            Controls.Add(lbllibro);
            Controls.Add(lblusuario);
            Controls.Add(dgvprestamos);
            Controls.Add(btncancelarprestamos);
            Controls.Add(btneliminarprestamos);
            Controls.Add(btneditarprestamos);
            Controls.Add(btnguardarprestamos);
            Controls.Add(btnnuevoprestamos);
            Controls.Add(dtpfechadevolucion);
            Controls.Add(dtpfechaprestamo);
            Controls.Add(cbolibros);
            Controls.Add(cbousuarios);
            Name = "FrmPrestamos";
            Text = "Gestión de Préstamos";
            Load += FrmPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvprestamos).EndInit();
            pnlencabezado.ResumeLayout(false);
            pnlencabezado.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbousuarios;
        private System.Windows.Forms.ComboBox cbolibros;
        private System.Windows.Forms.DateTimePicker dtpfechaprestamo;
        private System.Windows.Forms.DateTimePicker dtpfechadevolucion;
        private System.Windows.Forms.Button btnnuevoprestamos;
        private System.Windows.Forms.Button btnguardarprestamos;
        private System.Windows.Forms.Button btneditarprestamos;
        private System.Windows.Forms.Button btneliminarprestamos;
        private System.Windows.Forms.Button btncancelarprestamos;
        private System.Windows.Forms.DataGridView dgvprestamos;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lbllibro;
        private System.Windows.Forms.Label lblfechaprestamo;
        private System.Windows.Forms.Label lblfechadevolucion;
        private System.Windows.Forms.Panel pnlencabezado;
        private System.Windows.Forms.Label lbltitulo;
        private Panel panel1;
        private Label label1;
    }
}