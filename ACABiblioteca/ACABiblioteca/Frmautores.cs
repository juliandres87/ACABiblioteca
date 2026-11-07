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
    public partial class FrmAutores : Form
    {
        private int idAutorSeleccionado = 0;

        public FrmAutores()
        {
            InitializeComponent();
            CargarAutores();

            // Vinculación de eventos de botones y tabla (Cambiado a CellClick para carga con un solo clic)
            btnnuevoautores.Click += btnnuevoautores_Click;
            btnguardarautores.Click += btnguardarautores_Click;
            btneditarautores.Click += btneditarautores_Click;
            btneliminarautores.Click += btneliminarautores_Click;
            btncancelarautores.Click += btncancelarautores_Click;
            dgvautores.CellClick += dgvautores_CellClick;
        }

        // 1. Cargar Autores en la Grilla
        private void CargarAutores()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT IdAutor, Nombre, Apellido FROM Autores";
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgvautores.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los autores:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Botón Nuevo (Limpiar campos)
        private void btnnuevoautores_Click(object sender, EventArgs e)
        {
            txtnombreautores.Clear();
            txtapellidoautores.Clear();
            idAutorSeleccionado = 0;
            dgvautores.ClearSelection();
            txtnombreautores.Focus();
        }

        // 3. Botón Guardar (Insertar)
        private void btnguardarautores_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtnombreautores.Text) || string.IsNullOrWhiteSpace(txtapellidoautores.Text))
                {
                    MessageBox.Show("Complete todos los campos antes de guardar.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "INSERT INTO Autores (Nombre, Apellido) VALUES (@Nombre, @Apellido)";
                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtnombreautores.Text.Trim());
                        cmd.Parameters.AddWithValue("@Apellido", txtapellidoautores.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Autor guardado correctamente.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAutores();
                btnnuevoautores_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el autor:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Botón Editar (Actualizar)
        private void btneditarautores_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAutorSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un autor de la tabla para editar.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtnombreautores.Text) || string.IsNullOrWhiteSpace(txtapellidoautores.Text))
                {
                    MessageBox.Show("Complete todos los campos antes de editar.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "UPDATE Autores SET Nombre = @Nombre, Apellido = @Apellido WHERE IdAutor = @IdAutor";
                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtnombreautores.Text.Trim());
                        cmd.Parameters.AddWithValue("@Apellido", txtapellidoautores.Text.Trim());
                        cmd.Parameters.AddWithValue("@IdAutor", idAutorSeleccionado);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Autor actualizado correctamente.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAutores();
                btnnuevoautores_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el autor:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5. Botón Eliminar
        private void btneliminarautores_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAutorSeleccionado == 0)
                {
                    MessageBox.Show("Seleccione un autor de la tabla para eliminar.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este autor?", "Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No) return;

                Conexion conexion = new Conexion();
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "DELETE FROM Autores WHERE IdAutor = @IdAutor";
                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@IdAutor", idAutorSeleccionado);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Autor eliminado correctamente.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAutores();
                btnnuevoautores_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el autor:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 6. Botón Cancelar
        private void btncancelarautores_Click(object sender, EventArgs e)
        {
            btnnuevoautores_Click(null, null);
        }

        // 7. Clic sencillo en la grilla para cargar los datos en los TextBox al instante
        private void dgvautores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            idAutorSeleccionado = Convert.ToInt32(dgvautores.Rows[e.RowIndex].Cells["IdAutor"].Value);
            txtnombreautores.Text = dgvautores.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtapellidoautores.Text = dgvautores.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
        }
    }
}