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
    public partial class FrmPrestamos : Form
    {
        private int idPrestamoSeleccionado = 0;

        public FrmPrestamos()
        {
            InitializeComponent();

            // Vinculación de eventos con nuestros nombres de controles
            btnnuevoprestamos.Click += btnnuevoprestamos_Click;
            btnguardarprestamos.Click += btnguardarprestamos_Click;
            btneditarprestamos.Click += btneditarprestamos_Click;
            btneliminarprestamos.Click += btneliminarprestamos_Click;
            btncancelarprestamos.Click += btncancelarprestamos_Click;
            dgvprestamos.CellClick += dgvprestamos_CellClick;
        }

        // Se ejecuta al abrir la ventana
        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarLibros();
            CargarPrestamos();
        }

        // *** Método Cargar Préstamos ***
        private void CargarPrestamos()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT * FROM Prestamos";
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgvprestamos.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los préstamos:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    string consulta = "SELECT IdUsuario, Nombre, Apellido FROM Usuarios ORDER BY Nombre, Apellido";
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        tabla.Columns.Add("NombreCompleto", typeof(string));
                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["NombreCompleto"] = fila["Nombre"].ToString() + " " + fila["Apellido"].ToString();
                        }

                        cbousuarios.DataSource = tabla;
                        cbousuarios.DisplayMember = "NombreCompleto";
                        cbousuarios.ValueMember = "IdUsuario";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Método Cargar Libros ***
        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT ISBN, Titulo FROM Libros ORDER BY Titulo";
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        cbolibros.DataSource = tabla;
                        cbolibros.DisplayMember = "Titulo";
                        cbolibros.ValueMember = "ISBN";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los libros:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Botón Nuevo ***
        private void btnnuevoprestamos_Click(object sender, EventArgs e)
        {
            idPrestamoSeleccionado = 0;
            cbousuarios.SelectedIndex = -1;
            cbolibros.SelectedIndex = -1;
            dtpfechaprestamo.Value = DateTime.Now;
            dtpfechadevolucion.Value = DateTime.Now;
            dgvprestamos.ClearSelection();
        }

        // *** Botón Guardar ***
        private void btnguardarprestamos_Click(object sender, EventArgs e)
        {
            if (cbousuarios.SelectedIndex == -1 || cbolibros.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario y un libro antes de guardar.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = Convert.ToInt32(cbousuarios.SelectedValue);
            string isbn = cbolibros.SelectedValue.ToString();
            DateTime fechaPrestamo = dtpfechaprestamo.Value;
            DateTime fechaDevolucion = dtpfechadevolucion.Value;

            try
            {
                Conexion conexion = new Conexion();
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    // 1. Comprobar existencias
                    string consultaExistencias = "SELECT Existencias FROM Libros WHERE ISBN = @ISBN";
                    using (SqlCommand comandoExistencias = new SqlCommand(consultaExistencias, cn))
                    {
                        comandoExistencias.Parameters.AddWithValue("@ISBN", isbn);
                        int existencias = Convert.ToInt32(comandoExistencias.ExecuteScalar());

                        if (existencias <= 0)
                        {
                            MessageBox.Show("No hay existencias disponibles de este libro.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 2. Registrar el préstamo con estado inicial 'Prestado'
                    string consulta = @"INSERT INTO Prestamos (IdUsuario, ISBN, FechaPrestamo, FechaDevolucion, Estado)
                                        VALUES (@IdUsuario, @ISBN, @FechaPrestamo, @FechaDevolucion, 'Prestado')";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        comando.Parameters.AddWithValue("@ISBN", isbn);
                        comando.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                        comando.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion);
                        comando.ExecuteNonQuery();
                    }

                    // 3. Descontar una existencia del libro (-1)
                    string descontarExistencias = "UPDATE Libros SET Existencias = Existencias - 1 WHERE ISBN = @ISBN";
                    using (SqlCommand comando = new SqlCommand(descontarExistencias, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", isbn);
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Préstamo registrado correctamente.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPrestamos();
                btnnuevoprestamos_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el préstamo:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Clic en la Grilla ***
        private void dgvprestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            idPrestamoSeleccionado = Convert.ToInt32(dgvprestamos.Rows[e.RowIndex].Cells["IdPrestamo"].Value);
            cbousuarios.SelectedValue = Convert.ToInt32(dgvprestamos.Rows[e.RowIndex].Cells["IdUsuario"].Value);
            cbolibros.SelectedValue = dgvprestamos.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();

            if (dgvprestamos.Rows[e.RowIndex].Cells["FechaPrestamo"].Value != DBNull.Value)
            {
                dtpfechaprestamo.Value = Convert.ToDateTime(dgvprestamos.Rows[e.RowIndex].Cells["FechaPrestamo"].Value);
            }

            if (dgvprestamos.Rows[e.RowIndex].Cells["FechaDevolucion"].Value != DBNull.Value)
            {
                dtpfechadevolucion.Value = Convert.ToDateTime(dgvprestamos.Rows[e.RowIndex].Cells["FechaDevolucion"].Value);
            }
        }

        // *** Botón Editar (Registrar Devolución) ***
        private void btneditarprestamos_Click(object sender, EventArgs e)
        {
            try
            {
                if (idPrestamoSeleccionado == 0 || dgvprestamos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un préstamo de la tabla para registrar la devolución.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string isbn = dgvprestamos.CurrentRow.Cells["ISBN"].Value.ToString();
                string estado = dgvprestamos.CurrentRow.Cells["Estado"].Value.ToString();

                if (estado == "Devuelto")
                {
                    MessageBox.Show("Este préstamo ya se encuentra registrado como devuelto.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fechaDevolucion = dtpfechadevolucion.Value;

                DialogResult respuesta = MessageBox.Show("¿Está seguro de registrar la devolución de este libro?", "Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No) return;

                Conexion conexion = new Conexion();
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    // 1. Actualizar estado a 'Devuelto' y fecha de devolución
                    string consulta = @"UPDATE Prestamos 
                                        SET FechaDevolucion = @FechaDevolucion, 
                                            Estado = 'Devuelto' 
                                        WHERE IdPrestamo = @IdPrestamo";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion);
                        comando.Parameters.AddWithValue("@IdPrestamo", idPrestamoSeleccionado);
                        comando.ExecuteNonQuery();
                    }

                    // 2. Devolver existencia al libro (+1)
                    string actualizarExistencias = "UPDATE Libros SET Existencias = Existencias + 1 WHERE ISBN = @ISBN";
                    using (SqlCommand comando = new SqlCommand(actualizarExistencias, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", isbn);
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Devolución registrada correctamente.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPrestamos();
                btnnuevoprestamos_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la devolución:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Botón Eliminar ***
        private void btneliminarprestamos_Click(object sender, EventArgs e)
        {
            try
            {
                if (idPrestamoSeleccionado == 0 || dgvprestamos.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un préstamo para eliminar.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string isbn = dgvprestamos.CurrentRow.Cells["ISBN"].Value.ToString();
                string estado = dgvprestamos.CurrentRow.Cells["Estado"].Value.ToString();

                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este préstamo?", "Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No) return;

                Conexion conexion = new Conexion();
                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "DELETE FROM Prestamos WHERE IdPrestamo = @IdPrestamo";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@IdPrestamo", idPrestamoSeleccionado);
                        comando.ExecuteNonQuery();
                    }

                    if (estado == "Prestado")
                    {
                        string actualizarExistencias = "UPDATE Libros SET Existencias = Existencias + 1 WHERE ISBN = @ISBN";
                        using (SqlCommand comando = new SqlCommand(actualizarExistencias, cn))
                        {
                            comando.Parameters.AddWithValue("@ISBN", isbn);
                            comando.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Préstamo eliminado correctamente.", "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPrestamos();
                btnnuevoprestamos_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el préstamo:\n" + ex.Message, "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Botón Cancelar ***
        private void btncancelarprestamos_Click(object sender, EventArgs e)
        {
            btnnuevoprestamos_Click(null, null);
        }
    }
}