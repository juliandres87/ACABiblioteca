using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ACABiblioteca.Datos;

namespace ACABiblioteca
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();

            // Vinculación explícita de eventos
            btngenerarreportes.Click += btngenerarreportes_Click;
            btnlimpiarreportes.Click += btnlimpiarreportes_Click;
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            CargarTiposReporte();
        }

        // *** Método Cargar Tipos de Reportes ***
        private void CargarTiposReporte()
        {
            cmbtiporeportes.Items.Clear();

            cmbtiporeportes.Items.Add("Préstamos activos");
            cmbtiporeportes.Items.Add("Préstamos devueltos");
            cmbtiporeportes.Items.Add("Inventario de libros");

            cmbtiporeportes.SelectedIndex = -1;
        }

        // *** Código btngenerarreportes_Click ***
        private void btngenerarreportes_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbtiporeportes.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un tipo de reporte.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "";

                    if (cmbtiporeportes.Text == "Préstamos activos")
                    {
                        consulta = @"SELECT
                                        p.IdPrestamo,
                                        u.Nombre + ' ' + u.Apellido AS Usuario,
                                        l.ISBN,
                                        l.Titulo,
                                        p.FechaPrestamo,
                                        p.Estado
                                     FROM Prestamos p
                                     INNER JOIN Usuarios u
                                        ON p.IdUsuario = u.IdUsuario
                                     INNER JOIN Libros l
                                        ON p.ISBN = l.ISBN
                                     WHERE p.Estado = 'Prestado'
                                     ORDER BY p.FechaPrestamo DESC";
                    }
                    else if (cmbtiporeportes.Text == "Préstamos devueltos")
                    {
                        consulta = @"SELECT
                                        p.IdPrestamo,
                                        u.Nombre + ' ' + u.Apellido AS Usuario,
                                        l.ISBN,
                                        l.Titulo,
                                        p.FechaPrestamo,
                                        p.FechaDevolucion,
                                        p.Estado
                                     FROM Prestamos p
                                     INNER JOIN Usuarios u
                                        ON p.IdUsuario = u.IdUsuario
                                     INNER JOIN Libros l
                                        ON p.ISBN = l.ISBN
                                     WHERE p.Estado = 'Devuelto'
                                     ORDER BY p.FechaDevolucion DESC";
                    }
                    else if (cmbtiporeportes.Text == "Inventario de libros")
                    {
                        consulta = @"SELECT
                                        l.ISBN,
                                        l.Titulo,
                                        a.Nombre + ' ' + a.Apellido AS Autor,
                                        e.Nombre AS Editorial,
                                        l.Categoria,
                                        l.Anio,
                                        l.Existencias
                                     FROM Libros l
                                     INNER JOIN Autores a
                                        ON l.IdAutor = a.IdAutor
                                     INNER JOIN Editoriales e
                                        ON l.IdEditorial = e.IdEditorial
                                     ORDER BY l.Titulo";
                    }

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgvreportes.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // *** Código btnlimpiarreportes_Click ***
        private void btnlimpiarreportes_Click(object sender, EventArgs e)
        {
            cmbtiporeportes.SelectedIndex = -1;
            dgvreportes.DataSource = null;
        }
    }
}