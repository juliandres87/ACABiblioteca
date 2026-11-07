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
    public partial class FrmEditoriales : Form
    {
        private int idEditorialSeleccionada = 0;

        public FrmEditoriales()
        {
            InitializeComponent();

            // Vinculación de eventos de botones y grilla
            btnnuevoeditoriales.Click += btnnuevoeditoriales_Click;
            btnguardareditoriales.Click += btnguardareditoriales_Click;
            btneditareditoriales.Click += btneditareditoriales_Click;
            btneliminareditoriales.Click += btneliminareditoriales_Click;
            btncancelaeditoriales.Click += btncancelaeditoriales_Click;
            dgveditoriales.CellClick += dgveditoriales_CellClick;
        }

        // Se ejecuta al abrir la ventana (evita que el diseñador colapse)
        private void FrmEditoriales_Load(object sender, EventArgs e)
        {
            CargarEditoriales();
        }

        // *** Método Cargar Editoriales ***
        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdEditorial, Nombre FROM Editoriales";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgveditoriales.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las editoriales:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // *** Botón Nuevo ***
        private void btnnuevoeditoriales_Click(object sender, EventArgs e)
        {
            txtnombreeditoriales.Clear();
            idEditorialSeleccionada = 0;
            dgveditoriales.ClearSelection();
            txtnombreeditoriales.Focus();
        }

        // *** Botón Guardar ***
        private void btnguardareditoriales_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombreeditoriales.Text))
            {
                MessageBox.Show(
                    "Complete el nombre de la editorial antes de guardar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "INSERT INTO Editoriales (Nombre) VALUES (@Nombre)";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Nombre", txtnombreeditoriales.Text.Trim());
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Editorial guardada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEditoriales();
                btnnuevoeditoriales_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la editorial:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Clic en la Grilla (Carga instantánea) ***
        private void dgveditoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            idEditorialSeleccionada = Convert.ToInt32(dgveditoriales.Rows[e.RowIndex].Cells["IdEditorial"].Value);
            txtnombreeditoriales.Text = dgveditoriales.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
        }

        // *** Botón Editar ***
        private void btneditareditoriales_Click(object sender, EventArgs e)
        {
            if (idEditorialSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una editorial de la tabla para editar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtnombreeditoriales.Text))
            {
                MessageBox.Show(
                    "El nombre no puede estar vacío.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "UPDATE Editoriales SET Nombre = @Nombre WHERE IdEditorial = @IdEditorial";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Nombre", txtnombreeditoriales.Text.Trim());
                        comando.Parameters.AddWithValue("@IdEditorial", idEditorialSeleccionada);
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Editorial actualizada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEditoriales();
                btnnuevoeditoriales_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la editorial:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Botón Eliminar ***
        private void btneliminareditoriales_Click(object sender, EventArgs e)
        {
            if (idEditorialSeleccionada == 0)
            {
                MessageBox.Show(
                    "Seleccione una editorial de la tabla para eliminar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar esta editorial?",
                "Biblioteca",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "DELETE FROM Editoriales WHERE IdEditorial = @IdEditorial";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@IdEditorial", idEditorialSeleccionada);
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Editorial eliminada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEditoriales();
                btnnuevoeditoriales_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la editorial:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Botón Cancelar ***
        private void btncancelaeditoriales_Click(object sender, EventArgs e)
        {
            btnnuevoeditoriales_Click(null, null);
        }
    }
}
