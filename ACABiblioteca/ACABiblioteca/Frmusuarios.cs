using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    public partial class FrmUsuarios : Form
    {
        private int idUsuarioSeleccionado = 0;

        public FrmUsuarios()
        {
            InitializeComponent();

            // Vinculación de eventos de botones y grilla
            btnnuevousuarios.Click += btnnuevousuarios_Click;
            btnguardarusuarios.Click += btnguardarusuarios_Click;
            btneditarusuarios.Click += btneditarusuarios_Click;
            btneliminarusuarios.Click += btneliminarusuarios_Click;
            btncancelarusuarios.Click += btncancelarusuarios_Click;
            dgvusuarios.CellClick += dgvusuarios_CellClick;
        }

        // Se ejecuta al abrir la ventana (evita que el diseñador colapse al intentar conectar con la BD)
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        // *** Método Cargar Usuarios ***
        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdUsuario, Nombre, Apellido, Documento, Telefono, Correo FROM Usuarios";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvusuarios.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // *** Código btnnuevousuarios_Click ***
        private void btnnuevousuarios_Click(object sender, EventArgs e)
        {
            txtnombreusuarios.Clear();
            txtapellidousuarios.Clear();
            txtdocumentousuarios.Clear();
            txttelefonousuarios.Clear();
            txtcorreousuarios.Clear();

            idUsuarioSeleccionado = 0;
            dgvusuarios.ClearSelection();
            txtnombreusuarios.Focus();
        }

        // *** Código btnguardarusuarios_Click ***
        private void btnguardarusuarios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombreusuarios.Text) ||
                string.IsNullOrWhiteSpace(txtapellidousuarios.Text) ||
                string.IsNullOrWhiteSpace(txtdocumentousuarios.Text) ||
                string.IsNullOrWhiteSpace(txttelefonousuarios.Text) ||
                string.IsNullOrWhiteSpace(txtcorreousuarios.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de guardar.",
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

                    string consulta =
                        "INSERT INTO Usuarios " +
                        "(Nombre, Apellido, Documento, Telefono, Correo) " +
                        "VALUES " +
                        "(@Nombre, @Apellido, @Documento, @Telefono, @Correo)";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Nombre", txtnombreusuarios.Text.Trim());
                        comando.Parameters.AddWithValue("@Apellido", txtapellidousuarios.Text.Trim());
                        comando.Parameters.AddWithValue("@Documento", txtdocumentousuarios.Text.Trim());
                        comando.Parameters.AddWithValue("@Telefono", txttelefonousuarios.Text.Trim());
                        comando.Parameters.AddWithValue("@Correo", txtcorreousuarios.Text.Trim());

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Usuario guardado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarUsuarios();
                btnnuevousuarios_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el usuario:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Método Celda Click (Carga automática al hacer un clic en la grilla) ****
        private void dgvusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Guardamos el ID interno para la edición y eliminación
            idUsuarioSeleccionado = Convert.ToInt32(dgvusuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value);

            // Pasamos los valores de las celdas a las cajas de texto correspondientes
            txtnombreusuarios.Text = dgvusuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtapellidousuarios.Text = dgvusuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtdocumentousuarios.Text = dgvusuarios.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
            txttelefonousuarios.Text = dgvusuarios.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            txtcorreousuarios.Text = dgvusuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
        }

        // *** Código btneditarusuarios_Click ***
        private void btneditarusuarios_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un usuario de la tabla para editar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtnombreusuarios.Text) ||
                string.IsNullOrWhiteSpace(txtapellidousuarios.Text) ||
                string.IsNullOrWhiteSpace(txtdocumentousuarios.Text) ||
                string.IsNullOrWhiteSpace(txttelefonousuarios.Text) ||
                string.IsNullOrWhiteSpace(txtcorreousuarios.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de editar.",
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

                    string consulta =
                        "UPDATE Usuarios SET " +
                        "Nombre = @Nombre, " +
                        "Apellido = @Apellido, " +
                        "Documento = @Documento, " +
                        "Telefono = @Telefono, " +
                        "Correo = @Correo " +
                        "WHERE IdUsuario = @IdUsuario";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@Nombre", txtnombreusuarios.Text.Trim());
                        comando.Parameters.AddWithValue("@Apellido", txtapellidousuarios.Text.Trim());
                        comando.Parameters.AddWithValue("@Documento", txtdocumentousuarios.Text.Trim());
                        comando.Parameters.AddWithValue("@Telefono", txttelefonousuarios.Text.Trim());
                        comando.Parameters.AddWithValue("@Correo", txtcorreousuarios.Text.Trim());
                        comando.Parameters.AddWithValue("@IdUsuario", idUsuarioSeleccionado);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Usuario actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarUsuarios();
                btnnuevousuarios_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Código btneliminarusuarios_Click ***
        private void btneliminarusuarios_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un usuario de la tabla para eliminar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este usuario?",
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

                    string consulta = "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@IdUsuario", idUsuarioSeleccionado);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Usuario eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarUsuarios();
                btnnuevousuarios_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Código btncancelarusuarios_Click ***
        private void btncancelarusuarios_Click(object sender, EventArgs e)
        {
            btnnuevousuarios_Click(null, null);
        }
    }
}
