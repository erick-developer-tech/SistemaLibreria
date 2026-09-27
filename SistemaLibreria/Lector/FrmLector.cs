using AccesoDatos.Data;
using AccesoDatos.DTOs;
using AccesoDatos.Models;
using SistemaLibreria.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLibreria.Lector
{
    public partial class FrmLector : Form
    {
        // Variables globales para el manejo controles
        public bool isNuevo = false;
        public bool editar = false;

        public FrmLector()
        {
            InitializeComponent();
        }

        #region MÉTODOS INTERNOS
        private void LimpiarCampos()
        {
            // Cajas de texto
            textBoxDNI.Clear();
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();

            // Quitar la selección visual del DataGridView
            dataGridViewLista.ClearSelection();
        }
        public void HabilitarControles()
        {
            if (isNuevo)
            {
                textBoxDNI.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxTelefono.Enabled = true;
                textBoxCorreo.Enabled = true;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            if (editar)
            {
                textBoxDNI.Enabled = true;
                textBoxNombre.Enabled = true;
                textBoxTelefono.Enabled = true;
                textBoxCorreo.Enabled = true;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            if (!isNuevo && !editar)
            {
                textBoxDNI.Enabled = false;
                textBoxNombre.Enabled = false;
                textBoxTelefono.Enabled = false;
                textBoxCorreo.Enabled = false;
                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
            }
        }
        private void CargarLectores()
        {
            try
            {
                DTOLector lec = new DTOLector(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = lec.ObtenerLectores().ToList();
                dataGridViewLista.DataSource = lista;


                labelTotal.Text = $"Total de lectores: {lista.Count}";
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
                DTOLector lec = new DTOLector(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = lec.BuscarLector(textBoxBuscar.Text.Trim()).ToList();
                dataGridViewLista.DataSource = lista;

                labelTotal.Text = $"Total de lectores: {lista.Count}";
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
                DTOLector lec = new DTOLector(ConexionHelper.ObtenerConfiguracion());
                MLector ml = new MLector();

                if (isNuevo)
                {
                    ml.DNI = textBoxDNI.Text.Trim();
                    ml.Nombre = textBoxNombre.Text.Trim();
                    ml.Telefono = textBoxTelefono.Text.Trim();
                    ml.Correo = textBoxCorreo.Text.Trim();

                    if (lec.InsertarLector(ml))
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
                    ml.DNI = textBoxDNI.Text.Trim();
                    ml.Nombre = textBoxNombre.Text.Trim();
                    ml.Telefono = textBoxTelefono.Text.Trim();
                    ml.Correo = textBoxCorreo.Text.Trim();

                    if (lec.ActualizarLector(ml))
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
                MessageBox.Show("Por favor, selecciona un lector de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el lector de la fila seleccionada usando DataBoundItem
            var lecSeleccionado = (MLector)dataGridViewLista.CurrentRow.DataBoundItem;

            // Cuadro de diálogo de confirmación
            DialogResult respuesta = MessageBox.Show(
                $"¿Estás seguro de dar de baja al lector '{lecSeleccionado.Nombre}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si la respuesta es un si
            if (respuesta == DialogResult.Yes)
            {
                DTOLector dto = new DTOLector(ConexionHelper.ObtenerConfiguracion());

                if (dto.EliminarLector(lecSeleccionado.Id))
                {
                    MessageBox.Show("El lector ha sido eliminadó correctamente.",
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

            CargarLectores();
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
            CargarLectores();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();

            LimpiarCampos();
            HabilitarControles();
            CargarLectores();
        }

        private void FrmLector_Load(object sender, EventArgs e)
        {
            // La posición siempre inicia desde la esquina superior izquierda
            this.Top = 0;
            this.Left = 0;

            HabilitarControles();
            CargarLectores();
        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewLista.CurrentRow == null) return;

            // Convertir la fila seleccionada al objeto MLector
            var lec = (MLector)dataGridViewLista.CurrentRow.DataBoundItem;

            if (lec != null)
            {
                textBoxDNI.Text = lec.DNI;
                textBoxNombre.Text = lec.Nombre;
                textBoxTelefono.Text = lec.Telefono;
                textBoxCorreo.Text = lec.Correo;

                isNuevo = false;
                editar = true;

                HabilitarControles();
            }
        }
    }
}
