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
    public partial class Frmlibros : Form
    {
        private bool modoEdicion = false;

        public Frmlibros()
        {
            InitializeComponent();
            CargarLibros();
            CargarAutores();
            CargarEditoriales();


            btnBuscar.Click += btnbuscar_Click;
            btnguardar.Click += btnguardar_Click;
            btnnuevo.Click += btnnuevo_Click;
            btneditar.Click += btnEditar_Click;
            btneliminar.Click += btnEliminar_Click;
            btncancelar.Click += btnCancelar_Click;
            dgvlibros.CellDoubleClick += dgvlibros_CellDoubleClick;

            dgvlibros.CellClick += dgvlibros_CellClick;
        }

        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvlibros.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarAutores()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT IdAutor, Nombre, Apellido FROM Autores ORDER BY Nombre, Apellido";
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        tabla.Columns.Add("NombreCompleto", typeof(string));
                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["NombreCompleto"] = fila["Nombre"].ToString() + " " + fila["Apellido"].ToString();
                        }
                        cmbautor.DataSource = tabla;
                        cmbautor.DisplayMember = "NombreCompleto";
                        cmbautor.ValueMember = "IdAutor";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los autores:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdEditorial, Nombre FROM Editoriales ORDER BY Nombre";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        cmbeditorial.DataSource = tabla;
                        cmbeditorial.DisplayMember = "Nombre";
                        cmbeditorial.ValueMember = "IdEditorial";
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvlibros.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un libro para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string isbn = dgvlibros.CurrentRow.Cells["ISBN"].Value.ToString();

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este libro?",
                    "Biblioteca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.No)
                {
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "DELETE FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", isbn);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                modoEdicion = false;
                txtisbn.Enabled = true;

                CargarLibros();

                btnnuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarisbm.Text))
                {
                    MessageBox.Show(
                        "Por favor, ingrese un ISBN para buscar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT * FROM Libros WHERE ISBN = @ISBN";
                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@ISBN", txtBuscarisbm.Text.Trim());
                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtisbn.Text = lector["ISBN"].ToString();
                                txttitulo.Text = lector["Titulo"].ToString();
                                cmbautor.SelectedValue = Convert.ToInt32(lector["IdAutor"]);
                                cmbeditorial.SelectedValue = Convert.ToInt32(lector["IdEditorial"]);

                                txtcategoria.Text = lector["Categoria"].ToString();
                                txtano.Text = lector["Anio"].ToString();
                                txtexistencias.Text = lector["Existencias"].ToString();

                                MessageBox.Show(
                                    "Libro encontrado y cargado en los campos de texto.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró ningún libro con el ISBN proporcionado.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pnltitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbl_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void lbntitulolib_Click(object sender, EventArgs e)
        {
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtisbn.Clear();
            txttitulo.Clear();
            cmbautor.SelectedIndex = -1;
            cmbeditorial.SelectedIndex = -1;
            txtcategoria.Clear();
            txtano.Clear();
            txtexistencias.Clear();
            txtisbn.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtisbn.Text) ||
                    string.IsNullOrWhiteSpace(txttitulo.Text) ||
                    cmbautor.SelectedIndex == -1 ||
                    cmbeditorial.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtcategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtano.Text) ||
                    string.IsNullOrWhiteSpace(txtexistencias.Text))
                {
                    MessageBox.Show(
                        "Por favor, complete todos los campos antes de guardar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                int anio, existencias;

                if (!int.TryParse(txtano.Text, out anio))
                {
                    MessageBox.Show(
                        "Por favor, ingrese un año válido.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtano.Focus();
                    return;
                }

                if (!int.TryParse(txtexistencias.Text, out existencias))
                {
                    MessageBox.Show(
                        "Por favor, ingrese un número válido de existencias.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtexistencias.Focus();
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "INSERT INTO Libros (ISBN, Titulo, IdAutor, IdEditorial, Categoria, Anio, Existencias) " +
                                      "VALUES (@ISBN, @Titulo, @IdAutor, @IdEditorial, @Categoria, @Anio, @Existencias)";

                    using (SqlCommand cmd = new SqlCommand(consulta, cn))
                    {
                        cmd.Parameters.AddWithValue("@ISBN", txtisbn.Text.Trim());
                        cmd.Parameters.AddWithValue("@Titulo", txttitulo.Text.Trim());
                        cmd.Parameters.AddWithValue("@IdAutor", Convert.ToInt32(cmbautor.SelectedValue));
                        cmd.Parameters.AddWithValue("@IdEditorial", Convert.ToInt32(cmbeditorial.SelectedValue));
                        cmd.Parameters.AddWithValue("@Categoria", txtcategoria.Text.Trim());
                        cmd.Parameters.AddWithValue("@Anio", anio);
                        cmd.Parameters.AddWithValue("@Existencias", existencias);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show(
                            modoEdicion ? "Libro actualizado correctamente." : "Libro guardado correctamente.",
                            "Biblioteca",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        CargarLibros();
                        btnnuevo_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvlibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtisbn.Text = dgvlibros.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
            txttitulo.Text = dgvlibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();

            cmbautor.SelectedValue = Convert.ToInt32(
                dgvlibros.Rows[e.RowIndex].Cells["IdAutor"].Value
            );

            cmbeditorial.SelectedValue = Convert.ToInt32(
                dgvlibros.Rows[e.RowIndex].Cells["IdEditorial"].Value
            );

            txtcategoria.Text = dgvlibros.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            txtano.Text = dgvlibros.Rows[e.RowIndex].Cells["Anio"].Value.ToString();
            txtexistencias.Text = dgvlibros.Rows[e.RowIndex].Cells["Existencias"].Value.ToString();


        }
        private void dgvlibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que no se haga clic en los encabezados de la tabla
            if (e.RowIndex < 0)
                return;

            txtisbn.Text = dgvlibros.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
            txttitulo.Text = dgvlibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();

            cmbautor.SelectedValue = Convert.ToInt32(
                dgvlibros.Rows[e.RowIndex].Cells["IdAutor"].Value
            );

            cmbeditorial.SelectedValue = Convert.ToInt32(
                dgvlibros.Rows[e.RowIndex].Cells["IdEditorial"].Value
            );

            txtcategoria.Text = dgvlibros.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            txtano.Text = dgvlibros.Rows[e.RowIndex].Cells["Anio"].Value.ToString();
            txtexistencias.Text = dgvlibros.Rows[e.RowIndex].Cells["Existencias"].Value.ToString();

            // Opcional: Activamos el modo edición para que al presionar Guardar/Editar sepa que es una actualización
            modoEdicion = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtisbn.Text) ||
                    string.IsNullOrWhiteSpace(txttitulo.Text) ||
                    cmbautor.SelectedIndex == -1 ||
                    cmbeditorial.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtcategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtano.Text) ||
                    string.IsNullOrWhiteSpace(txtexistencias.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int anio;
                int existencias;

                if (!int.TryParse(txtano.Text, out anio))
                {
                    MessageBox.Show(
                        "El año debe ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!int.TryParse(txtexistencias.Text, out existencias))
                {
                    MessageBox.Show(
                        "Las existencias deben ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Libros
                                SET Titulo = @Titulo,
                                    IdAutor = @IdAutor,
                                    IdEditorial = @IdEditorial,
                                    Categoria = @Categoria,
                                    Anio = @Anio,
                                    Existencias = @Existencias
                                WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", txtisbn.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", txttitulo.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", Convert.ToInt32(cmbautor.SelectedValue));
                        comando.Parameters.AddWithValue("@IdEditorial", Convert.ToInt32(cmbeditorial.SelectedValue));
                        comando.Parameters.AddWithValue("@Categoria", txtcategoria.Text.Trim());
                        comando.Parameters.AddWithValue("@Anio", anio);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtisbn.Clear();
            txttitulo.Clear();
            txtcategoria.Clear();
            txtano.Clear();
            txtexistencias.Clear();

            cmbautor.SelectedIndex = -1;
            cmbeditorial.SelectedIndex = -1;

            modoEdicion = false;
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void PnlDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
