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

namespace SistemaLibreria.Sancion
{
    public partial class FrmSancion : Form
    {
        // Variables globales para el manejo controles
        public bool isNuevo = false;
        public bool editar = false;
        public FrmSancion()
        {
            InitializeComponent();
        }

        #region MÉTODOS INTERNOS
        private void LimpiarCampos()
        {
            // Cajas de texto
            comboBoxPrestamo.SelectedIndex = -1;
            comboBoxMotivo.SelectedIndex = -1;
            textBoxMulta.Text = string.Empty;
            comboBoxEstado.SelectedIndex = -1;

            // Quitar la selección visual del DataGridView
            dataGridViewLista.ClearSelection();
        }
        public void HabilitarControles()
        {
            if (isNuevo)
            {
                comboBoxPrestamo.Enabled = true;
                comboBoxMotivo.Enabled = true;
                textBoxMulta.Enabled = true;
                comboBoxEstado.Enabled = false;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            if (editar)
            {
                comboBoxPrestamo.Enabled = true;
                comboBoxMotivo.Enabled = true;
                textBoxMulta.Enabled = true;
                comboBoxEstado.Enabled = true;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            if (!isNuevo && !editar)
            {
                comboBoxPrestamo.Enabled = false;
                comboBoxMotivo.Enabled = false;
                textBoxMulta.Enabled = false;
                comboBoxEstado.Enabled = false;
                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
            }
        }

        private void CargarPrestamosCombo()
        {
            try
            {
                DTOPrestamo dto = new DTOPrestamo(ConexionHelper.ObtenerConfiguracion());
                var listaPrestamos = dto.ObtenerPrestamos().ToList();

                comboBoxPrestamo.DataSource = listaPrestamos;
                comboBoxPrestamo.DisplayMember = "InfoCombo"; // Lo que el usuario ve
                comboBoxPrestamo.ValueMember = "Id"; // Guarda el id interno
                comboBoxPrestamo.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Error al cargar la lista de prestamos.",
                    "Error de Carga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CargarSanciones()
        {
            try
            {
                DTOSancion dto = new DTOSancion(ConexionHelper.ObtenerConfiguracion());
                // Asignamos la lista directamente
                var lista = dto.ObtenerSanciones().ToList();
                dataGridViewLista.DataSource = lista;

                // Ocultar la columna IdLector si existe
                if (dataGridViewLista.Columns["IdLector"] != null)
                {
                    dataGridViewLista.Columns["IdLector"].Visible = false;
                }

                labelTotal.Text = $"Total de sanciones: {lista.Count}";
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
                DTOSancion dto = new DTOSancion(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = dto.BuscarSanciones(textBoxBuscar.Text.Trim()).ToList();
                dataGridViewLista.DataSource = lista;

                // Ocultar la columna IdLector si existe
                if (dataGridViewLista.Columns["IdLector"] != null)
                {
                    dataGridViewLista.Columns["IdLector"].Visible = false;
                }

                labelTotal.Text = $"Total de sanciones: {lista.Count}";
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
                DTOSancion dto = new DTOSancion(ConexionHelper.ObtenerConfiguracion());
                MSancion ms = new MSancion();

                if (isNuevo)
                {
                    ms.IdPrestamo = Convert.ToInt32(comboBoxPrestamo.SelectedValue);
                    ms.Motivo = comboBoxMotivo.SelectedItem.ToString();
                    ms.Multa = Convert.ToDecimal(textBoxMulta.Text.Trim());

                    if (dto.InsertarSancion(ms))
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
                    ms.Id = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                    ms.IdPrestamo = Convert.ToInt32(comboBoxPrestamo.SelectedValue);
                    ms.Motivo = comboBoxMotivo.SelectedItem.ToString();
                    ms.Multa = Convert.ToDecimal(textBoxMulta.Text.Trim());
                    ms.Estado = comboBoxEstado.SelectedItem.ToString();

                    if (dto.ActualizarSancion(ms))
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
                MessageBox.Show("Por favor, selecciona una sanción de la tabla.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtener la sanción de la fila seleccionada usando DataBoundItem
            var sancionSeleccionada = (MSancion)dataGridViewLista.CurrentRow.DataBoundItem;

            // Cuadro de diálogo de confirmación
            DialogResult respuesta = MessageBox.Show(
                $"¿Estás seguro de dar de baja la sanción \n'IdPrestamo: {sancionSeleccionada.IdPrestamo} \nLector: {sancionSeleccionada.Nombre}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si la respuesta es un si
            if (respuesta == DialogResult.Yes)
            {
                DTOSancion dto = new DTOSancion(ConexionHelper.ObtenerConfiguracion());

                if (dto.EliminarSancion(sancionSeleccionada.Id))
                {
                    MessageBox.Show("La sanción ha sido eliminada correctamente.",
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

            CargarSanciones();
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
            CargarSanciones();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();

            LimpiarCampos();
            HabilitarControles();
            CargarSanciones();
        }

        private void FrmSancion_Load(object sender, EventArgs e)
        {
            // La posición siempre inicia desde la esquina superior izquierda
            this.Top = 0;
            this.Left = 0;

            CargarPrestamosCombo();
            HabilitarControles();
            CargarSanciones();
        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewLista.CurrentRow == null) return;

            // Convertir la fila seleccionada al objeto MSancion
            var san = (MSancion)dataGridViewLista.CurrentRow.DataBoundItem;

            if (san != null)
            {
                comboBoxPrestamo.SelectedValue = san.IdPrestamo; // Selecciona por el id interno
                comboBoxMotivo.Text = san.Motivo;
                textBoxMulta.Text = san.Multa.ToString();
                comboBoxEstado.Text = san.Estado;

                isNuevo = false;
                editar = true;

                HabilitarControles();
            }
        }
    }
}
