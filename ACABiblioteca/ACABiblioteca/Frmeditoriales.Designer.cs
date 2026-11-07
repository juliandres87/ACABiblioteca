namespace ACABiblioteca
{
    partial class FrmEditoriales
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
            txtnombreeditoriales = new TextBox();
            btnnuevoeditoriales = new Button();
            btnguardareditoriales = new Button();
            btneditareditoriales = new Button();
            btneliminareditoriales = new Button();
            btncancelaeditoriales = new Button();
            dgveditoriales = new DataGridView();
            lblnombreeditoriales = new Label();
            pnltituloeditoriales = new Panel();
            lbleditoriales = new Label();
            ((System.ComponentModel.ISupportInitialize)dgveditoriales).BeginInit();
            pnltituloeditoriales.SuspendLayout();
            SuspendLayout();
            // 
            // txtnombreeditoriales
            // 
            txtnombreeditoriales.Location = new Point(577, 128);
            txtnombreeditoriales.Name = "txtnombreeditoriales";
            txtnombreeditoriales.Size = new Size(250, 23);
            txtnombreeditoriales.TabIndex = 0;
            // 
            // btnnuevoeditoriales
            // 
            btnnuevoeditoriales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnnuevoeditoriales.Location = new Point(407, 188);
            btnnuevoeditoriales.Name = "btnnuevoeditoriales";
            btnnuevoeditoriales.Size = new Size(75, 30);
            btnnuevoeditoriales.TabIndex = 1;
            btnnuevoeditoriales.Text = "Nuevo";
            btnnuevoeditoriales.UseVisualStyleBackColor = true;
            // 
            // btnguardareditoriales
            // 
            btnguardareditoriales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnguardareditoriales.Location = new Point(497, 188);
            btnguardareditoriales.Name = "btnguardareditoriales";
            btnguardareditoriales.Size = new Size(75, 30);
            btnguardareditoriales.TabIndex = 2;
            btnguardareditoriales.Text = "Guardar";
            btnguardareditoriales.UseVisualStyleBackColor = true;
            // 
            // btneditareditoriales
            // 
            btneditareditoriales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btneditareditoriales.Location = new Point(587, 188);
            btneditareditoriales.Name = "btneditareditoriales";
            btneditareditoriales.Size = new Size(75, 30);
            btneditareditoriales.TabIndex = 3;
            btneditareditoriales.Text = "Editar";
            btneditareditoriales.UseVisualStyleBackColor = true;
            // 
            // btneliminareditoriales
            // 
            btneliminareditoriales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btneliminareditoriales.Location = new Point(677, 188);
            btneliminareditoriales.Name = "btneliminareditoriales";
            btneliminareditoriales.Size = new Size(75, 30);
            btneliminareditoriales.TabIndex = 4;
            btneliminareditoriales.Text = "Eliminar";
            btneliminareditoriales.UseVisualStyleBackColor = true;
            // 
            // btncancelaeditoriales
            // 
            btncancelaeditoriales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncancelaeditoriales.Location = new Point(767, 188);
            btncancelaeditoriales.Name = "btncancelaeditoriales";
            btncancelaeditoriales.Size = new Size(75, 30);
            btncancelaeditoriales.TabIndex = 5;
            btncancelaeditoriales.Text = "Cancelar";
            btncancelaeditoriales.UseVisualStyleBackColor = true;
            // 
            // dgveditoriales
            // 
            dgveditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgveditoriales.Location = new Point(277, 258);
            dgveditoriales.Name = "dgveditoriales";
            dgveditoriales.Size = new Size(700, 242);
            dgveditoriales.TabIndex = 6;
            // 
            // lblnombreeditoriales
            // 
            lblnombreeditoriales.AutoSize = true;
            lblnombreeditoriales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblnombreeditoriales.Location = new Point(497, 131);
            lblnombreeditoriales.Name = "lblnombreeditoriales";
            lblnombreeditoriales.Size = new Size(56, 15);
            lblnombreeditoriales.TabIndex = 0;
            lblnombreeditoriales.Text = "Nombre:";
            // 
            // pnltituloeditoriales
            // 
            pnltituloeditoriales.BackColor = Color.PowderBlue;
            pnltituloeditoriales.Controls.Add(lbleditoriales);
            pnltituloeditoriales.Dock = DockStyle.Top;
            pnltituloeditoriales.Location = new Point(0, 0);
            pnltituloeditoriales.Name = "pnltituloeditoriales";
            pnltituloeditoriales.Size = new Size(1270, 85);
            pnltituloeditoriales.TabIndex = 7;
            // 
            // lbleditoriales
            // 
            lbleditoriales.AutoSize = true;
            lbleditoriales.Font = new Font("Rockwell Condensed", 26F, FontStyle.Bold);
            lbleditoriales.Location = new Point(12, 9);
            lbleditoriales.Name = "lbleditoriales";
            lbleditoriales.Size = new Size(171, 41);
            lbleditoriales.TabIndex = 0;
            lbleditoriales.Text = "Editoriales";
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 525);
            Controls.Add(pnltituloeditoriales);
            Controls.Add(lblnombreeditoriales);
            Controls.Add(dgveditoriales);
            Controls.Add(btncancelaeditoriales);
            Controls.Add(btneliminareditoriales);
            Controls.Add(btneditareditoriales);
            Controls.Add(btnguardareditoriales);
            Controls.Add(btnnuevoeditoriales);
            Controls.Add(txtnombreeditoriales);
            Name = "FrmEditoriales";
            Text = "Gestión de Editoriales";
            Load += FrmEditoriales_Load;
            ((System.ComponentModel.ISupportInitialize)dgveditoriales).EndInit();
            pnltituloeditoriales.ResumeLayout(false);
            pnltituloeditoriales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombreeditoriales;
        private System.Windows.Forms.Button btnnuevoeditoriales;
        private System.Windows.Forms.Button btnguardareditoriales;
        private System.Windows.Forms.Button btneditareditoriales;
        private System.Windows.Forms.Button btneliminareditoriales;
        private System.Windows.Forms.Button btncancelaeditoriales;
        private System.Windows.Forms.DataGridView dgveditoriales;
        private System.Windows.Forms.Label lblnombreeditoriales;
        private Panel pnltituloeditoriales;
        private Label lbleditoriales;
    }
}