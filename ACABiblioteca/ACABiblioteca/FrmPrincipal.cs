using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ACABiblioteca.Datos; // Asegúrate de tener este using si tu clase Conexion está ahí

namespace ACABiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            //Conexion conexion = new Conexion();
            //try
            //{
            //using (var conn = conexion.ObtenerConexion())
            //{
            //conn.Open();
            // Corregido: los parámetros van dentro del mismo MessageBox.Show
            //MessageBox.Show("Conexión exitosa a la base de datos.",
            //"ACAbiblioteca",
            //MessageBoxButtons.OK,
            //MessageBoxIcon.Information);
            //}
            //}
            //  catch (Exception ex)
            //{
            // Corregido: parámetros integrados correctamente
            //MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
            // "ACAbiblioteca",
            // MessageBoxButtons.OK,
            // MessageBoxIcon.Error);
            //}

            AbrirFormulario(new Frminicio());
        }

        private void AbrirFormulario(Form formulario)
        {
            PlnContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            PlnContenido.Controls.Add(formulario);
            formulario.Show();
        }

        private void piclogo_Click(object sender, EventArgs e)
        {
        }

        private void LblSubtitulo_Click(object sender, EventArgs e)
        {
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frminicio());
        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frmlibros()); // Asegúrate que el nombre coincida con tu clase real
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frmusuarios());
        }

        private void bntAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frmautores());
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frmeditoriales());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frmprestamos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frmreportes());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}