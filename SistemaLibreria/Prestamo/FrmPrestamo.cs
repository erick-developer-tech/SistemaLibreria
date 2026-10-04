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

namespace SistemaLibreria.Prestamo
{
    public partial class FrmPrestamo : Form
    {
        // Colección en memoria para el listado de ejemplares de un prestamo
        private BindingList<MDetallePrestamo> listaDetalles = new BindingList<MDetallePrestamo>();

        // Variables globales para el manejo controles
        public bool isNuevo = false;
        public bool editar = false;
        public bool actualizarDetalles = false;

        private int idDetalleSeleccionado = 0;
        public FrmPrestamo()
        {
            InitializeComponent();
        }

        #region MÉTODOS INTERNOS
        private void LimpiarCampos()
        {
            // Cajas de texto
            comboBoxLector.SelectedIndex = -1;
            comboBoxEmpleado.SelectedIndex = -1;
            textBoxObservaciones.Clear();
            comboBoxEjemplar.SelectedIndex = -1;
            listaDetalles.Clear();

            // Quitar la selección visual del DataGridView
            dataGridViewLista.ClearSelection();
        }
        public void HabilitarControles()
        {
            if (isNuevo)
            {
                comboBoxLector.Enabled = true;
                comboBoxEmpleado.Enabled = true;
                textBoxObservaciones.Enabled = true;
                comboBoxEjemplar.Enabled = true;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            if (editar)
            {
                comboBoxLector.Enabled = true;
                comboBoxEmpleado.Enabled = true;
                textBoxObservaciones.Enabled = true;
                comboBoxEjemplar.Enabled = true;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
            if (!isNuevo && !editar)
            {
                comboBoxLector.Enabled = false;
                comboBoxEmpleado.Enabled = false;
                textBoxObservaciones.Enabled = false;
                comboBoxEjemplar.Enabled = false;
                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
            }
        }

        private void controlesDetalles()
        {
            if (actualizarDetalles)
            {
                // Activa los controles para actualizar el detalle
                dateTimePickerFechaDevolucion.Enabled = true;
                comboBoxEstado.Enabled = true;
                buttonAgregarDetalle.Enabled = false;
                buttonQuitar.Enabled = false;
                buttonVerDetalles.Enabled = false;
                buttonBuscar.Enabled = false;
                buttonEliminar.Enabled = false;
                buttonNuevo.Enabled=false;
                buttonRefrescar.Enabled = false;
                buttonActualizarDetalle.Enabled = true;
                buttonCancelarDetalle.Enabled = true;
            }
            else
            {
                dateTimePickerFechaDevolucion.Enabled = false;
                comboBoxEstado.Enabled = false;
                buttonAgregarDetalle.Enabled = true;
                buttonQuitar.Enabled = true;
                buttonVerDetalles.Enabled = true;
                buttonBuscar.Enabled = true;
                buttonEliminar.Enabled = true;
                buttonNuevo.Enabled = true;
                buttonRefrescar.Enabled = true;
                buttonActualizarDetalle.Enabled = false;
                buttonCancelarDetalle.Enabled = false;
            }
        }
        // Para cargar los datos de los combos lectores y empleados
        private void CargarLectoresCombo()
        {
            try
            {
                DTOLector dto = new DTOLector(ConexionHelper.ObtenerConfiguracion());
                var listaLectores = dto.ObtenerLectores().ToList();

                comboBoxLector.DataSource = listaLectores;
                comboBoxLector.DisplayMember = "Nombre"; // Lo que el usuario ve
                comboBoxLector.ValueMember = "Id"; // Guarda el id interno
                comboBoxLector.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Error al cargar la lista de lectores.",
                    "Error de Carga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEmpleadosCombo()
        {
            try
            {
                DTOEmpleado dto = new DTOEmpleado(ConexionHelper.ObtenerConfiguracion());
                var listaEmpleados = dto.ObtenerEmpleados().ToList();

                comboBoxEmpleado.DataSource = listaEmpleados;
                comboBoxEmpleado.DisplayMember = "Nombre"; // Lo que el usuario ve
                comboBoxEmpleado.ValueMember = "Id"; // Guarda el id interno
                comboBoxEmpleado.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Error al cargar la lista de empleados.",
                    "Error de Carga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEjemplaresCombo()
        {
            try
            {
                DTOEjemplar dto = new DTOEjemplar(ConexionHelper.ObtenerConfiguracion());
                var listaEjemplares = dto.ObtenerEjemplares().ToList();

                comboBoxEjemplar.DataSource = listaEjemplares;
                comboBoxEjemplar.DisplayMember = "CodigoBarras"; // Lo que el usuario ve
                comboBoxEjemplar.ValueMember = "Id"; // Guarda el id interno
                comboBoxEjemplar.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Error al cargar la lista de ejemplares.",
                    "Error de Carga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CargarPrestamos()
        {
            try
            {
                DTOPrestamo pre = new DTOPrestamo(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = pre.ObtenerPrestamos().ToList();
                dataGridViewLista.DataSource = lista;

                // Ocultar la columna IdEmpleado o IdLectore si existe
                if (dataGridViewLista.Columns["IdEmpleado"] != null || dataGridViewLista.Columns["IdLector"] != null)
                {
                    dataGridViewLista.Columns["IdLector"].Visible = false;
                    dataGridViewLista.Columns["IdEmpleado"].Visible = false;
                }

                labelTotal.Text = $"Total de prestamos: {lista.Count}";
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

        private void BuscarPrestamos()
        {
            try
            {
                DTOPrestamo pre = new DTOPrestamo(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = pre.BuscarPrestamosFechas(dateTimePickerFechaInicio.Value, dateTimePickerFechaFin.Value).ToList();
                dataGridViewLista.DataSource = lista;

                // Ocultar la columna IdEmpleado o IdLectore si existe
                if (dataGridViewLista.Columns["IdEmpleado"] != null || dataGridViewLista.Columns["IdLector"] != null)
                {
                    dataGridViewLista.Columns["IdLector"].Visible = false;
                    dataGridViewLista.Columns["IdEmpleado"].Visible = false;
                }

                labelTotal.Text = $"Total de prestamos: {lista.Count}";
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

        private void CargarDetallesPrestamo(int idPrestamo)
        {
            try
            {
                DTOPrestamo pre = new DTOPrestamo(ConexionHelper.ObtenerConfiguracion());
                // Asignamos la lista directamente
                var listaDetalles = pre.ObtenerDetallePrestamo(idPrestamo).ToList();
                dataGridViewLista.DataSource = listaDetalles;
                labelTotal.Text = $"Total de detalles: {listaDetalles.Count}";
            }
            catch (Exception)
            {
                MessageBox.Show(
                       "Error al cargar los detalles del prestamo.",
                       "Operación inválida",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }
        private void Guardar()
        {
            try
            {
                if (comboBoxLector.SelectedValue == null || comboBoxEmpleado.SelectedValue == null)
                {
                    MessageBox.Show("Selecciona un Lector y un Empleado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTOPrestamo pre = new DTOPrestamo(ConexionHelper.ObtenerConfiguracion());
                MPrestamo mp = new MPrestamo();

                if (isNuevo)
                {
                    mp.FechaLimite = dateTimePickerFechaFin.Value;
                    mp.IdLector = Convert.ToInt32(comboBoxLector.SelectedValue);
                    mp.IdEmpleado = Convert.ToInt32(comboBoxEmpleado.SelectedValue);
                    mp.Observaciones = textBoxObservaciones.Text.Trim();
                    mp.Detalles = listaDetalles.ToList();

                    if (pre.RegistrarPrestamo(mp))
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
                    mp.Id = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                    mp.FechaLimite = dateTimePickerFechaFin.Value;
                    mp.Observaciones = textBoxObservaciones.Text.Trim();

                    if (pre.ActualizarPrestamo(mp))
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
                MessageBox.Show("Por favor, selecciona un prestamo de la tabla.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtener el prestamo de la fila seleccionada usando DataBoundItem
            var preSeleccionado = (MPrestamo)dataGridViewLista.CurrentRow.DataBoundItem;

            // Cuadro de diálogo de confirmación
            DialogResult respuesta = MessageBox.Show(
                $"¿Estás seguro de dar de baja el prestamo \n'Id: {preSeleccionado.Id} \nLector: {preSeleccionado.Lector}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si la respuesta es un si
            if (respuesta == DialogResult.Yes)
            {
                DTOPrestamo dto = new DTOPrestamo(ConexionHelper.ObtenerConfiguracion());

                if (dto.EliminarPrestamo(preSeleccionado.Id))
                {
                    MessageBox.Show("El prestamo ha sido eliminadó correctamente.",
                        "Operación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        // Método para agregar un ejemplar al datagrid de detalles del prestamo
        private void agregarEjemplar()
        {
            // Validar que se haya seleccionado un ejemplar en el ComboBox
            if (comboBoxEjemplar.SelectedItem == null || comboBoxEjemplar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un ejemplar de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir el objeto seleccionado a MEjemplar
            var ejemplarSeleccionado = (MEjemplar)comboBoxEjemplar.SelectedItem;

            // Evitar agregar dos veces el mismo ejemplar al carrito
            if (listaDetalles.Any(d => d.IdEjemplar == ejemplarSeleccionado.Id))
            {
                MessageBox.Show("Este ejemplar ya se encuentra agregado en la lista.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Crear la fila del detalle
            MDetallePrestamo detalle = new MDetallePrestamo
            {
                IdEjemplar = ejemplarSeleccionado.Id,
                CodigoBarras = ejemplarSeleccionado.CodigoBarras,
                Titulo = ejemplarSeleccionado.Titulo, // Muestra el título en la tabla si tu modelo lo contempla
                Estado = "Prestado"
            };

            // Agregar a la BindingList (el DataGridView se actualiza automáticamente)
            listaDetalles.Add(detalle);
        }
        // Método para quitar un ejemplar del datagrid de detalles del prestamo
        private void quitarEjemplar()
        {
            if (dataGridViewLista.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una fila de la lista para quitar el ejemplar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Si la tabla actualmente muestra la lista temporal del carrito
            if (dataGridViewLista.DataSource == listaDetalles)
            {
                var detalleSeleccionado = (MDetallePrestamo)dataGridViewLista.CurrentRow.DataBoundItem;
                if (detalleSeleccionado != null)
                {
                    listaDetalles.Remove(detalleSeleccionado);
                }
            }
        }

        private void actualizarDetalle()
        {
            try
            {
                if (idDetalleSeleccionado == 0 || comboBoxEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, selecciona un detalle haciendo doble clic sobre la tabla.",
                        "Atención", 
                        
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DTOPrestamo dto = new DTOPrestamo(ConexionHelper.ObtenerConfiguracion());
                MDetallePrestamo md = new MDetallePrestamo
                {
                    IdDetalle = idDetalleSeleccionado,
                    Estado = comboBoxEstado.SelectedItem.ToString(), // Se toma la opción seleccionada ("Devuelto", "Dañado", etc.)
                    FechaDevolucion = dateTimePickerFechaDevolucion.Value
                };

                if (dto.ActualizarDetallePrestamo(md))
                {
                    MessageBox.Show("Detalle actualizado correctamente.",
                        "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiamos el ID seleccionado para la siguiente operación
                    idDetalleSeleccionado = 0;
                    comboBoxEstado.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el detalle: {ex.Message}",
                    "Operación inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            editar = false;

            HabilitarControles();
            dataGridViewLista.DataSource = listaDetalles; // Aseguramos que el DataGridView muestre la lista temporal
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

            isNuevo = false;
            editar = false;

            CargarPrestamos();
            HabilitarControles();
            LimpiarCampos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            isNuevo = false;
            editar = false;

            HabilitarControles();
            LimpiarCampos();
            CargarPrestamos();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            BuscarPrestamos();
        }

        private void buttonVerDetalles_Click(object sender, EventArgs e)
        {
            if (dataGridViewLista.CurrentRow != null)
            {
                int idPrestamo = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["Id"].Value);
                CargarDetallesPrestamo(idPrestamo);
                actualizarDetalles = true;
                controlesDetalles();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();

            LimpiarCampos();
            HabilitarControles();
            CargarPrestamos();
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            // La posición siempre inicia desde la esquina superior izquierda
            this.Top = 0;
            this.Left = 0;

            CargarEjemplaresCombo();
            CargarEmpleadosCombo();
            CargarLectoresCombo();
            HabilitarControles();
            CargarPrestamos();
        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewLista.CurrentRow == null) return;

            if (!actualizarDetalles)
            {
                // Doble clic sobre la lista de PRÉSTAMOS (Cabecera)
                var pre = (MPrestamo)dataGridViewLista.CurrentRow.DataBoundItem;

                if (pre != null)
                {
                    comboBoxLector.SelectedValue = pre.IdLector;
                    comboBoxEmpleado.SelectedValue = pre.IdEmpleado;
                    dateTimePickerFechaInicio.Value = pre.FechaInicio;
                    dateTimePickerFechaFin.Value = pre.FechaLimite;
                    textBoxObservaciones.Text = pre.Observaciones;

                    isNuevo = false;
                    editar = true;

                    HabilitarControles();
                }
            }
            else
            {
                // Doble clic sobre la lista de DETALLES
                var detalle = (MDetallePrestamo)dataGridViewLista.CurrentRow.DataBoundItem;

                if (detalle != null)
                {
                    idDetalleSeleccionado = detalle.IdDetalle; // Guardamos el ID que actualizaremos en SQL

                    comboBoxEstado.SelectedItem = detalle.Estado; // o comboBoxEstado.Text = detalle.Estado;

                    // Si ya tiene fecha de devolución la asignamos; si no, ponemos la fecha actual
                    dateTimePickerFechaDevolucion.Value = detalle.FechaDevolucion ?? DateTime.Now;
                }
            }
        }

        private void buttonAgregarDetalle_Click(object sender, EventArgs e)
        {
            agregarEjemplar();
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            quitarEjemplar();
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            CargarPrestamos();
        }

        private void buttonActualizarDetalle_Click(object sender, EventArgs e)
        {
            actualizarDetalle();

            if (dataGridViewLista.CurrentRow != null)
            {
                int idPrestamo = Convert.ToInt32(dataGridViewLista.CurrentRow.Cells["IdPrestamo"].Value);
                CargarDetallesPrestamo(idPrestamo);
            }
        }

        private void buttonCancelarDetalle_Click(object sender, EventArgs e)
        {
            actualizarDetalles = false;
            controlesDetalles();
            comboBoxEstado.SelectedIndex = -1;
        }
    }
}
