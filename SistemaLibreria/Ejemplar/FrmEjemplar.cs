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

namespace SistemaLibreria.Ejemplar
{
    public partial class FrmEjemplar : Form
    {
        // Variables globales para el manejo controles
        public bool isNuevo = false;
        public bool editar = false;

        public FrmEjemplar()
        {
            InitializeComponent();
        }
        #region MÉTODOS INTERNOS
        private void LimpiarCampos()
        {
            // Cajas de texto
            comboBoxLibro.SelectedIndex = -1;
            textBoxCodigoBarras.Clear();
            comboBoxEstado.SelectedIndex = -1;

            // Quitar la selección visual del DataGridView
            dataGridViewLista.ClearSelection();
        }
        public void HabilitarControles()
        {
            if (isNuevo)
            {
                comboBoxLibro.Enabled = true;
                textBoxCodigoBarras.Enabled = true;
                comboBoxEstado.Enabled = true;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            if (editar)
            {
                comboBoxLibro.Enabled = true;
                textBoxCodigoBarras.Enabled = true;
                comboBoxEstado.Enabled = true;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            if (!isNuevo && !editar)
            {
                comboBoxLibro.Enabled = false;
                textBoxCodigoBarras.Enabled = false;
                comboBoxEstado.Enabled = false;
                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
            }
        }

        private void CargarLibrosCombo()
        {
            try
            {
                DTOLibro dto = new DTOLibro(ConexionHelper.ObtenerConfiguracion());
                var listaLibros = dto.ObtenerLibros().ToList();

                comboBoxLibro.DataSource = listaLibros;
                comboBoxLibro.DisplayMember = "Titulo"; // Lo que el usuario ve
                comboBoxLibro.ValueMember = "Id"; // Guarda el id interno
                comboBoxLibro.SelectedIndex = -1;
            }
            catch (Exception) 
            {
                MessageBox.Show(
                    "Error al cargar la lista de libros.",
                    "Error de Carga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CargarEjemplares()
        {
            try
            {
                DTOEjemplar eje = new DTOEjemplar(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = eje.ObtenerEjemplares().ToList();
                dataGridViewLista.DataSource = lista;

                // Ocultar la columna IdLibro si existe
                if (dataGridViewLista.Columns["IdLibro"] != null)
                {
                    dataGridViewLista.Columns["IdLibro"].Visible = false;
                }

                labelTotal.Text = $"Total de ejemplares: {lista.Count}";
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
                DTOEjemplar eje = new DTOEjemplar(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = eje.BuscarEjemplar(textBoxBuscar.Text.Trim()).ToList();
                dataGridViewLista.DataSource = lista;

                // Ocultar la columna IdLibro si existe
                if (dataGridViewLista.Columns["IdLibro"] != null)
                {
                    dataGridViewLista.Columns["IdLibro"].Visible = false;
                }

                labelTotal.Text = $"Total de ejemplares: {lista.Count}";
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
                DTOEjemplar eje = new DTOEjemplar(ConexionHelper.ObtenerConfiguracion());
                MEjemplar me = new MEjemplar();

                if (isNuevo)
                {
                    me.IdLibro = Convert.ToInt32(comboBoxLibro.SelectedValue);
                    me.CodigoBarras = textBoxCodigoBarras.Text.Trim();
                    me.Estado = comboBoxEstado.Text;

                    if (eje.InsertarEjemplar(me))
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
                    me.Id = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                    me.IdLibro = Convert.ToInt32(comboBoxLibro.SelectedValue);
                    me.CodigoBarras = textBoxCodigoBarras.Text.Trim();
                    me.Estado = comboBoxEstado.Text;

                    if (eje.ActualizarEjemplar(me))
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
                MessageBox.Show("Por favor, selecciona un ejemplar de la tabla.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ejemplar de la fila seleccionada usando DataBoundItem
            var ejeSeleccionado = (MEjemplar)dataGridViewLista.CurrentRow.DataBoundItem;

            // Cuadro de diálogo de confirmación
            DialogResult respuesta = MessageBox.Show(
                $"¿Estás seguro de dar de baja el ejemplar \n'Codigo Barras: {ejeSeleccionado.CodigoBarras} \nTitulo: {ejeSeleccionado.Titulo}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si la respuesta es un si
            if (respuesta == DialogResult.Yes)
            {
                DTOEjemplar dto = new DTOEjemplar(ConexionHelper.ObtenerConfiguracion());

                if (dto.EliminarEjemplar(ejeSeleccionado.Id))
                {
                    MessageBox.Show("El ejemplar ha sido eliminadó correctamente.",
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

            CargarEjemplares();
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
            CargarEjemplares();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();

            LimpiarCampos();
            HabilitarControles();
            CargarEjemplares();
        }

        private void FrmEjemplar_Load(object sender, EventArgs e)
        {
            // La posición siempre inicia desde la esquina superior izquierda
            this.Top = 0;
            this.Left = 0;

            CargarLibrosCombo();
            HabilitarControles();
            CargarEjemplares();
        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {

            if (dataGridViewLista.CurrentRow == null) return;

            // Convertir la fila seleccionada al objeto MEjemplar
            var eje = (MEjemplar)dataGridViewLista.CurrentRow.DataBoundItem;

            if (eje != null)
            {
                comboBoxLibro.SelectedValue = eje.IdLibro; // Selecciona por el id interno
                textBoxCodigoBarras.Text = eje.CodigoBarras;
                comboBoxEstado.Text = eje.Estado;

                isNuevo = false;
                editar = true;

                HabilitarControles();
            }
        }
    }
}
