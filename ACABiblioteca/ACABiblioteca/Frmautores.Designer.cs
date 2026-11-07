namespace ACABiblioteca
{
    partial class FrmAutores
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
            txtnombreautores = new TextBox();
            txtapellidoautores = new TextBox();
            btnnuevoautores = new Button();
            btnguardarautores = new Button();
            btneditarautores = new Button();
            btneliminarautores = new Button();
            btncancelarautores = new Button();
            dgvautores = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            pnltituloautores = new Panel();
            lbltituloautores = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvautores).BeginInit();
            pnltituloautores.SuspendLayout();
            SuspendLayout();
            // 
            // txtnombreautores
            // 
            txtnombreautores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtnombreautores.Location = new Point(564, 120);
            txtnombreautores.Name = "txtnombreautores";
            txtnombreautores.Size = new Size(200, 23);
            txtnombreautores.TabIndex = 0;
            // 
            // txtapellidoautores
            // 
            txtapellidoautores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtapellidoautores.Location = new Point(564, 160);
            txtapellidoautores.Name = "txtapellidoautores";
            txtapellidoautores.Size = new Size(200, 23);
            txtapellidoautores.TabIndex = 1;
            // 
            // btnnuevoautores
            // 
            btnnuevoautores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnnuevoautores.Location = new Point(407, 209);
            btnnuevoautores.Name = "btnnuevoautores";
            btnnuevoautores.Size = new Size(75, 30);
            btnnuevoautores.TabIndex = 2;
            btnnuevoautores.Text = "Nuevo";
            btnnuevoautores.UseVisualStyleBackColor = true;
            // 
            // btnguardarautores
            // 
            btnguardarautores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnguardarautores.Location = new Point(492, 209);
            btnguardarautores.Name = "btnguardarautores";
            btnguardarautores.Size = new Size(75, 30);
            btnguardarautores.TabIndex = 3;
            btnguardarautores.Text = "Guardar";
            btnguardarautores.UseVisualStyleBackColor = true;
            // 
            // btneditarautores
            // 
            btneditarautores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btneditarautores.Location = new Point(577, 209);
            btneditarautores.Name = "btneditarautores";
            btneditarautores.Size = new Size(75, 30);
            btneditarautores.TabIndex = 4;
            btneditarautores.Text = "Editar";
            btneditarautores.UseVisualStyleBackColor = true;
            // 
            // btneliminarautores
            // 
            btneliminarautores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btneliminarautores.Location = new Point(662, 209);
            btneliminarautores.Name = "btneliminarautores";
            btneliminarautores.Size = new Size(75, 30);
            btneliminarautores.TabIndex = 5;
            btneliminarautores.Text = "Eliminar";
            btneliminarautores.UseVisualStyleBackColor = true;
            // 
            // btncancelarautores
            // 
            btncancelarautores.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncancelarautores.Location = new Point(747, 209);
            btncancelarautores.Name = "btncancelarautores";
            btncancelarautores.Size = new Size(75, 30);
            btncancelarautores.TabIndex = 6;
            btncancelarautores.Text = "Cancelar";
            btncancelarautores.UseVisualStyleBackColor = true;
            // 
            // dgvautores
            // 
            dgvautores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvautores.Location = new Point(278, 275);
            dgvautores.Name = "dgvautores";
            dgvautores.Size = new Size(700, 262);
            dgvautores.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(494, 123);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(494, 163);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido:";
            label2.Click += label1_Click_1;
            // 
            // pnltituloautores
            // 
            pnltituloautores.BackColor = Color.PowderBlue;
            pnltituloautores.Controls.Add(lbltituloautores);
            pnltituloautores.Dock = DockStyle.Top;
            pnltituloautores.Location = new Point(0, 0);
            pnltituloautores.Name = "pnltituloautores";
            pnltituloautores.Size = new Size(1272, 74);
            pnltituloautores.TabIndex = 10;
            // 
            // lbltituloautores
            // 
            lbltituloautores.AutoSize = true;
            lbltituloautores.Font = new Font("Rockwell Condensed", 26F, FontStyle.Bold);
            lbltituloautores.Location = new Point(3, 9);
            lbltituloautores.Name = "lbltituloautores";
            lbltituloautores.Size = new Size(284, 41);
            lbltituloautores.TabIndex = 0;
            lbltituloautores.Text = "Gestión de Autores";
            // 
            // FrmAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 566);
            Controls.Add(pnltituloautores);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvautores);
            Controls.Add(btncancelarautores);
            Controls.Add(btneliminarautores);
            Controls.Add(btneditarautores);
            Controls.Add(btnguardarautores);
            Controls.Add(btnnuevoautores);
            Controls.Add(txtapellidoautores);
            Controls.Add(txtnombreautores);
            Name = "FrmAutores";
            Text = "Gestión de Autores";
            Load += FrmAutores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvautores).EndInit();
            pnltituloautores.ResumeLayout(false);
            pnltituloautores.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombreautores;
        private System.Windows.Forms.TextBox txtapellidoautores;
        private System.Windows.Forms.Button btnnuevoautores;
        private System.Windows.Forms.Button btnguardarautores;
        private System.Windows.Forms.Button btneditarautores;
        private System.Windows.Forms.Button btneliminarautores;
        private System.Windows.Forms.Button btncancelarautores;
        private System.Windows.Forms.DataGridView dgvautores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Panel pnltituloautores;
        private Label lbltituloautores;
    }
}