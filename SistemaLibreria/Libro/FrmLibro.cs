using AccesoDatos.Data;
using AccesoDatos.DTOs;
using AccesoDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLibreria.Libro
{
    public partial class FrmLibro : Form
    {
        // Variables globales para el manejo controles
        public bool isNuevo = false;
        public bool editar = false;
        public FrmLibro()
        {
            InitializeComponent();
        }

        #region MÉTODOS INTERNOS
        private void LimpiarCampos()
        {
            // Cajas de texto
            textBoxTitulo.Clear();
            textBoxAutor.Clear();
            textBoxEditorial.Clear();
            textBoxAño.Clear();

            // Quitar la selección visual del DataGridView
            dataGridViewLista.ClearSelection();
        }
        public void HabilitarControles()
        {
            if (isNuevo)
            {
                textBoxTitulo.Enabled = true;
                textBoxAutor.Enabled = true;
                textBoxEditorial.Enabled = true;
                textBoxAño.Enabled = true;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            if (editar)
            {
                textBoxTitulo.Enabled = true;
                textBoxAutor.Enabled = true;
                textBoxEditorial.Enabled = true;
                textBoxAño.Enabled = true;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            if (!isNuevo && !editar)
            {
                textBoxTitulo.Enabled = false;
                textBoxAutor.Enabled = false;
                textBoxEditorial.Enabled = false;
                textBoxAño.Enabled = false;
                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
            }
        }
        private void CargarLibros()
        {
            try
            {
                DTOLibro lib = new DTOLibro(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = lib.ObtenerLibros().ToList();
                dataGridViewLista.DataSource = lista;


                labelTotal.Text = $"Total de libros: {lista.Count}";
            }
            catch (Exception)
            {
                MessageBox.Show(
                       "Error al cargar los datos.",
                       "Operación inválida",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void BuscarDatos()
        {
            try
            {
                DTOLibro lib = new DTOLibro(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = lib.BuscarLibro(textBoxBuscar.Text.Trim()).ToList();
                dataGridViewLista.DataSource = lista;

                labelTotal.Text = $"Total de libros: {lista.Count}";
            }
            catch (Exception)
            {
                MessageBox.Show(
                       "Error al cargar los datos.",
                       "Operación inválida",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void Guardar()
        {
            try
            {
                DTOLibro lib = new DTOLibro(ConexionHelper.ObtenerConfiguracion());
                MLibro ml = new MLibro();

                if (isNuevo)
                {
                    ml.Titulo = textBoxTitulo.Text.Trim();
                    ml.Autor = textBoxAutor.Text.Trim();
                    ml.Editorial = textBoxEditorial.Text.Trim();
                    ml.Año = Convert.ToInt32(textBoxAño.Text.Trim());

                    if (lib.InsertarLibro(ml))
                    {
                        MessageBox.Show(
                            "Se realizo el registro correctamente.",
                            "Operación realizada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

                if (editar)
                {
                    ml.Id = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                    ml.Titulo = textBoxTitulo.Text.Trim();
                    ml.Autor = textBoxAutor.Text.Trim();
                    ml.Editorial = textBoxEditorial.Text.Trim();
                    ml.Año = Convert.ToInt32(textBoxAño.Text.Trim());

                    if (lib.ActualizarLibro(ml))
                    {
                        MessageBox.Show(
                            "Se actualizó el registro correctamente.",
                            "Operación realizada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                       "Error en registrar los datos.",
                       "Operación inválida",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        private void Eliminar()
        {
            if (dataGridViewLista.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un libro de la tabla.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtener el libro de la fila seleccionada usando DataBoundItem
            var libSeleccionado = (MLibro)dataGridViewLista.CurrentRow.DataBoundItem;

            // Cuadro de diálogo de confirmación
            DialogResult respuesta = MessageBox.Show(
                $"¿Estás seguro de dar de baja el libro '{libSeleccionado.Titulo}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si la respuesta es un si
            if (respuesta == DialogResult.Yes)
            {
                DTOLibro dto = new DTOLibro(ConexionHelper.ObtenerConfiguracion());

                if (dto.EliminarLibro(libSeleccionado.Id))
                {
                    MessageBox.Show("El libro ha sido eliminadó correctamente.",
                        "Operación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            editar = false;

            HabilitarControles();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

            isNuevo = false;
            editar = false;

            CargarLibros();
            HabilitarControles();
            LimpiarCampos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            isNuevo = false;
            editar = false;

            HabilitarControles();
            LimpiarCampos();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();

            LimpiarCampos();
            HabilitarControles();
            CargarLibros();
        }

        private void FrmLibro_Load(object sender, EventArgs e)
        {
            // La posición siempre inicia desde la esquina superior izquierda
            this.Top = 0;
            this.Left = 0;

            HabilitarControles();
            CargarLibros();
        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewLista.CurrentRow == null) return;

            // Convertir la fila seleccionada al objeto MLibro
            var lib = (MLibro)dataGridViewLista.CurrentRow.DataBoundItem;

            if (lib != null)
            {
                textBoxTitulo.Text = lib.Titulo;
                textBoxAutor.Text = lib.Autor;
                textBoxEditorial.Text = lib.Editorial;
                textBoxAño.Text = Convert.ToString(lib.Año);

                isNuevo = false;
                editar = true;

                HabilitarControles();
            }
        }
    }
}
