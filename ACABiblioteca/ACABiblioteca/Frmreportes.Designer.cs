namespace ACABiblioteca
{
    partial class FrmReportes
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
            cmbtiporeportes = new ComboBox();
            btngenerarreportes = new Button();
            btnlimpiarreportes = new Button();
            dgvreportes = new DataGridView();
            lbltiporeporte = new Label();
            pnlreportes = new Panel();
            lblreportestitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvreportes).BeginInit();
            pnlreportes.SuspendLayout();
            SuspendLayout();
            // 
            // cmbtiporeportes
            // 
            cmbtiporeportes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtiporeportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cmbtiporeportes.FormattingEnabled = true;
            cmbtiporeportes.Location = new Point(546, 140);
            cmbtiporeportes.Name = "cmbtiporeportes";
            cmbtiporeportes.Size = new Size(260, 23);
            cmbtiporeportes.TabIndex = 0;
            // 
            // btngenerarreportes
            // 
            btngenerarreportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btngenerarreportes.Location = new Point(517, 196);
            btngenerarreportes.Name = "btngenerarreportes";
            btngenerarreportes.Size = new Size(95, 30);
            btngenerarreportes.TabIndex = 1;
            btngenerarreportes.Text = "Generar";
            btngenerarreportes.UseVisualStyleBackColor = true;
            // 
            // btnlimpiarreportes
            // 
            btnlimpiarreportes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnlimpiarreportes.Location = new Point(632, 196);
            btnlimpiarreportes.Name = "btnlimpiarreportes";
            btnlimpiarreportes.Size = new Size(95, 30);
            btnlimpiarreportes.TabIndex = 2;
            btnlimpiarreportes.Text = "Limpiar";
            btnlimpiarreportes.UseVisualStyleBackColor = true;
            // 
            // dgvreportes
            // 
            dgvreportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvreportes.Location = new Point(260, 247);
            dgvreportes.Name = "dgvreportes";
            dgvreportes.Size = new Size(720, 240);
            dgvreportes.TabIndex = 3;
            // 
            // lbltiporeporte
            // 
            lbltiporeporte.AutoSize = true;
            lbltiporeporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbltiporeporte.Location = new Point(441, 143);
            lbltiporeporte.Name = "lbltiporeporte";
            lbltiporeporte.Size = new Size(102, 15);
            lbltiporeporte.TabIndex = 0;
            lbltiporeporte.Text = "Tipo De Reporte:";
            // 
            // pnlreportes
            // 
            pnlreportes.BackColor = Color.PowderBlue;
            pnlreportes.Controls.Add(lblreportestitulo);
            pnlreportes.Dock = DockStyle.Top;
            pnlreportes.Location = new Point(0, 0);
            pnlreportes.Name = "pnlreportes";
            pnlreportes.Size = new Size(1261, 87);
            pnlreportes.TabIndex = 4;
            // 
            // lblreportestitulo
            // 
            lblreportestitulo.AutoSize = true;
            lblreportestitulo.Font = new Font("Rockwell Condensed", 26F, FontStyle.Bold);
            lblreportestitulo.Location = new Point(3, 9);
            lblreportestitulo.Name = "lblreportestitulo";
            lblreportestitulo.Size = new Size(298, 41);
            lblreportestitulo.TabIndex = 0;
            lblreportestitulo.Text = "Gestión de Reportes";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 499);
            Controls.Add(pnlreportes);
            Controls.Add(lbltiporeporte);
            Controls.Add(dgvreportes);
            Controls.Add(btnlimpiarreportes);
            Controls.Add(btngenerarreportes);
            Controls.Add(cmbtiporeportes);
            Name = "FrmReportes";
            Text = "Gestión de Reportes";
            Load += FrmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvreportes).EndInit();
            pnlreportes.ResumeLayout(false);
            pnlreportes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbtiporeportes;
        private System.Windows.Forms.Button btngenerarreportes;
        private System.Windows.Forms.Button btnlimpiarreportes;
        private System.Windows.Forms.DataGridView dgvreportes;
        private System.Windows.Forms.Label lbltiporeporte;
        private Panel pnlreportes;
        private Label lblreportestitulo;
    }
}