namespace ACABiblioteca
{
    partial class FrmUsuarios
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
            txtnombreusuarios = new TextBox();
            txtapellidousuarios = new TextBox();
            txtdocumentousuarios = new TextBox();
            txttelefonousuarios = new TextBox();
            txtcorreousuarios = new TextBox();
            btnnuevousuarios = new Button();
            btnguardarusuarios = new Button();
            btneditarusuarios = new Button();
            btneliminarusuarios = new Button();
            btncancelarusuarios = new Button();
            dgvusuarios = new DataGridView();
            lblnombre = new Label();
            lblapellido = new Label();
            lbldocumento = new Label();
            lbltelefono = new Label();
            lblcorreo = new Label();
            pnltitulousuarios = new Panel();
            lbltitulousuarios = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvusuarios).BeginInit();
            pnltitulousuarios.SuspendLayout();
            SuspendLayout();
            // 
            // txtnombreusuarios
            // 
            txtnombreusuarios.Location = new Point(549, 106);
            txtnombreusuarios.Name = "txtnombreusuarios";
            txtnombreusuarios.Size = new Size(250, 23);
            txtnombreusuarios.TabIndex = 0;
            // 
            // txtapellidousuarios
            // 
            txtapellidousuarios.Location = new Point(549, 146);
            txtapellidousuarios.Name = "txtapellidousuarios";
            txtapellidousuarios.Size = new Size(250, 23);
            txtapellidousuarios.TabIndex = 1;
            // 
            // txtdocumentousuarios
            // 
            txtdocumentousuarios.Location = new Point(549, 186);
            txtdocumentousuarios.Name = "txtdocumentousuarios";
            txtdocumentousuarios.Size = new Size(250, 23);
            txtdocumentousuarios.TabIndex = 2;
            // 
            // txttelefonousuarios
            // 
            txttelefonousuarios.Location = new Point(549, 226);
            txttelefonousuarios.Name = "txttelefonousuarios";
            txttelefonousuarios.Size = new Size(250, 23);
            txttelefonousuarios.TabIndex = 3;
            // 
            // txtcorreousuarios
            // 
            txtcorreousuarios.Location = new Point(549, 264);
            txtcorreousuarios.Name = "txtcorreousuarios";
            txtcorreousuarios.Size = new Size(250, 23);
            txtcorreousuarios.TabIndex = 4;
            // 
            // btnnuevousuarios
            // 
            btnnuevousuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnnuevousuarios.Location = new Point(411, 308);
            btnnuevousuarios.Name = "btnnuevousuarios";
            btnnuevousuarios.Size = new Size(75, 30);
            btnnuevousuarios.TabIndex = 5;
            btnnuevousuarios.Text = "Nuevo";
            btnnuevousuarios.UseVisualStyleBackColor = true;
            // 
            // btnguardarusuarios
            // 
            btnguardarusuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnguardarusuarios.Location = new Point(501, 308);
            btnguardarusuarios.Name = "btnguardarusuarios";
            btnguardarusuarios.Size = new Size(75, 30);
            btnguardarusuarios.TabIndex = 6;
            btnguardarusuarios.Text = "Guardar";
            btnguardarusuarios.UseVisualStyleBackColor = true;
            // 
            // btneditarusuarios
            // 
            btneditarusuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btneditarusuarios.Location = new Point(591, 308);
            btneditarusuarios.Name = "btneditarusuarios";
            btneditarusuarios.Size = new Size(75, 30);
            btneditarusuarios.TabIndex = 7;
            btneditarusuarios.Text = "Editar";
            btneditarusuarios.UseVisualStyleBackColor = true;
            // 
            // btneliminarusuarios
            // 
            btneliminarusuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btneliminarusuarios.Location = new Point(681, 308);
            btneliminarusuarios.Name = "btneliminarusuarios";
            btneliminarusuarios.Size = new Size(75, 30);
            btneliminarusuarios.TabIndex = 8;
            btneliminarusuarios.Text = "Eliminar";
            btneliminarusuarios.UseVisualStyleBackColor = true;
            // 
            // btncancelarusuarios
            // 
            btncancelarusuarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncancelarusuarios.Location = new Point(771, 308);
            btncancelarusuarios.Name = "btncancelarusuarios";
            btncancelarusuarios.Size = new Size(75, 30);
            btncancelarusuarios.TabIndex = 9;
            btncancelarusuarios.Text = "Cancelar";
            btncancelarusuarios.UseVisualStyleBackColor = true;
            // 
            // dgvusuarios
            // 
            dgvusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvusuarios.Location = new Point(272, 353);
            dgvusuarios.Name = "dgvusuarios";
            dgvusuarios.Size = new Size(700, 180);
            dgvusuarios.TabIndex = 10;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblnombre.Location = new Point(469, 109);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(56, 15);
            lblnombre.TabIndex = 4;
            lblnombre.Text = "Nombre:";
            // 
            // lblapellido
            // 
            lblapellido.AutoSize = true;
            lblapellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblapellido.Location = new Point(469, 149);
            lblapellido.Name = "lblapellido";
            lblapellido.Size = new Size(55, 15);
            lblapellido.TabIndex = 3;
            lblapellido.Text = "Apellido:";
            // 
            // lbldocumento
            // 
            lbldocumento.AutoSize = true;
            lbldocumento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbldocumento.Location = new Point(469, 189);
            lbldocumento.Name = "lbldocumento";
            lbldocumento.Size = new Size(76, 15);
            lbldocumento.TabIndex = 2;
            lbldocumento.Text = "Documento:";
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltelefono.Location = new Point(469, 229);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(59, 15);
            lbltelefono.TabIndex = 1;
            lbltelefono.Text = "Teléfono:";
            // 
            // lblcorreo
            // 
            lblcorreo.AutoSize = true;
            lblcorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblcorreo.Location = new Point(469, 269);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(48, 15);
            lblcorreo.TabIndex = 0;
            lblcorreo.Text = "Correo:";
            // 
            // pnltitulousuarios
            // 
            pnltitulousuarios.BackColor = Color.PowderBlue;
            pnltitulousuarios.Controls.Add(lbltitulousuarios);
            pnltitulousuarios.Dock = DockStyle.Top;
            pnltitulousuarios.Location = new Point(0, 0);
            pnltitulousuarios.Name = "pnltitulousuarios";
            pnltitulousuarios.Size = new Size(1293, 84);
            pnltitulousuarios.TabIndex = 11;
            // 
            // lbltitulousuarios
            // 
            lbltitulousuarios.AutoSize = true;
            lbltitulousuarios.Font = new Font("Rockwell Condensed", 26F, FontStyle.Bold);
            lbltitulousuarios.Location = new Point(3, 9);
            lbltitulousuarios.Name = "lbltitulousuarios";
            lbltitulousuarios.Size = new Size(137, 41);
            lbltitulousuarios.TabIndex = 5;
            lbltitulousuarios.Text = "Usuarios";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 545);
            Controls.Add(pnltitulousuarios);
            Controls.Add(lblcorreo);
            Controls.Add(lbltelefono);
            Controls.Add(lbldocumento);
            Controls.Add(lblapellido);
            Controls.Add(lblnombre);
            Controls.Add(dgvusuarios);
            Controls.Add(btncancelarusuarios);
            Controls.Add(btneliminarusuarios);
            Controls.Add(btneditarusuarios);
            Controls.Add(btnguardarusuarios);
            Controls.Add(btnnuevousuarios);
            Controls.Add(txtcorreousuarios);
            Controls.Add(txttelefonousuarios);
            Controls.Add(txtdocumentousuarios);
            Controls.Add(txtapellidousuarios);
            Controls.Add(txtnombreusuarios);
            Name = "FrmUsuarios";
            Text = "Gestión de Usuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvusuarios).EndInit();
            pnltitulousuarios.ResumeLayout(false);
            pnltitulousuarios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombreusuarios;
        private System.Windows.Forms.TextBox txtapellidousuarios;
        private System.Windows.Forms.TextBox txtdocumentousuarios;
        private System.Windows.Forms.TextBox txttelefonousuarios;
        private System.Windows.Forms.TextBox txtcorreousuarios;
        private System.Windows.Forms.Button btnnuevousuarios;
        private System.Windows.Forms.Button btnguardarusuarios;
        private System.Windows.Forms.Button btneditarusuarios;
        private System.Windows.Forms.Button btneliminarusuarios;
        private System.Windows.Forms.Button btncancelarusuarios;
        private System.Windows.Forms.DataGridView dgvusuarios;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lbldocumento;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblcorreo;
        private Panel pnltitulousuarios;
        private Label lbltitulousuarios;
    }
}