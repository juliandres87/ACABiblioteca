namespace ACABiblioteca
{
    partial class FrmInicio
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.lblMenuLibros = new System.Windows.Forms.Label();
            this.lblMenuUsuarios = new System.Windows.Forms.Label();
            this.lblMenuAutores = new System.Windows.Forms.Label();
            this.lblMenuEditoriales = new System.Windows.Forms.Label();
            this.lblMenuPrestamos = new System.Windows.Forms.Label();
            this.lblMenuReportes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.lblBienvenida.Location = new System.Drawing.Point(50, 40);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(434, 45);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "¡Bienvenidos a tu Biblioteca!";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(55, 90);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(325, 25);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Sistema de Gestión — ACABiblioteca";
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInstruccion.ForeColor = System.Drawing.Color.DimGray;
            this.lblInstruccion.Location = new System.Drawing.Point(55, 135);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(398, 20);
            this.lblInstruccion.TabIndex = 2;
            this.lblInstruccion.Text = "A continuación, te explicamos las funciones del menú lateral:";
            // 
            // lblMenuLibros
            // 
            this.lblMenuLibros.AutoSize = true;
            this.lblMenuLibros.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblMenuLibros.Location = new System.Drawing.Point(70, 180);
            this.lblMenuLibros.Name = "lblMenuLibros";
            this.lblMenuLibros.Size = new System.Drawing.Size(395, 19);
            this.lblMenuLibros.TabIndex = 3;
            this.lblMenuLibros.Text = "• Libros: Permite registrar, editar y administrar el catálogo bibliográfico.";
            // 
            // lblMenuUsuarios
            // 
            this.lblMenuUsuarios.AutoSize = true;
            this.lblMenuUsuarios.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblMenuUsuarios.Location = new System.Drawing.Point(70, 220);
            this.lblMenuUsuarios.Name = "lblMenuUsuarios";
            this.lblMenuUsuarios.Size = new System.Drawing.Size(433, 19);
            this.lblMenuUsuarios.TabIndex = 4;
            this.lblMenuUsuarios.Text = "• Usuarios: Gestión completa de lectores registrados en la biblioteca.";
            // 
            // lblMenuAutores
            // 
            this.lblMenuAutores.AutoSize = true;
            this.lblMenuAutores.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblMenuAutores.Location = new System.Drawing.Point(70, 260);
            this.lblMenuAutores.Name = "lblMenuAutores";
            this.lblMenuAutores.Size = new System.Drawing.Size(387, 19);
            this.lblMenuAutores.TabIndex = 5;
            this.lblMenuAutores.Text = "• Autores: Control y registro de los escritores de las obras.";
            // 
            // lblMenuEditoriales
            // 
            this.lblMenuEditoriales.AutoSize = true;
            this.lblMenuEditoriales.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblMenuEditoriales.Location = new System.Drawing.Point(70, 300);
            this.lblMenuEditoriales.Name = "lblMenuEditoriales";
            this.lblMenuEditoriales.Size = new System.Drawing.Size(425, 19);
            this.lblMenuEditoriales.TabIndex = 6;
            this.lblMenuEditoriales.Text = "• Editoriales: Administración de las casas editoras asociadas.";
            // 
            // lblMenuPrestamos
            // 
            this.lblMenuPrestamos.AutoSize = true;
            this.lblMenuPrestamos.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblMenuPrestamos.Location = new System.Drawing.Point(70, 340);
            this.lblMenuPrestamos.Name = "lblMenuPrestamos";
            this.lblMenuPrestamos.Size = new System.Drawing.Size(447, 19);
            this.lblMenuPrestamos.TabIndex = 7;
            this.lblMenuPrestamos.Text = "• Préstamos: Control de salidas, entregas y devolución de ejemplares.";
            // 
            // lblMenuReportes
            // 
            this.lblMenuReportes.AutoSize = true;
            this.lblMenuReportes.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblMenuReportes.Location = new System.Drawing.Point(70, 380);
            this.lblMenuReportes.Name = "lblMenuReportes";
            this.lblMenuReportes.Size = new System.Drawing.Size(441, 19);
            this.lblMenuReportes.TabIndex = 8;
            this.lblMenuReportes.Text = "• Reportes: Generación de estadísticas de préstamos e inventario.";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.Add(this.lblMenuReportes);
            this.Controls.Add(this.lblMenuPrestamos);
            this.Controls.Add(this.lblMenuEditoriales);
            this.Controls.Add(this.lblMenuAutores);
            this.Controls.Add(this.lblMenuUsuarios);
            this.Controls.Add(this.lblMenuLibros);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Label lblMenuLibros;
        private System.Windows.Forms.Label lblMenuUsuarios;
        private System.Windows.Forms.Label lblMenuAutores;
        private System.Windows.Forms.Label lblMenuEditoriales;
        private System.Windows.Forms.Label lblMenuPrestamos;
        private System.Windows.Forms.Label lblMenuReportes;
    }
}