using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos.DTOs;
using AccesoDatos.Models;
using SistemaLibreria.Utilidades;
using AccesoDatos.Data;

namespace SistemaLibreria.Empleado
{
    public partial class FrmEmpleado : Form
    {
        // Variables globales para el manejo controles
        public bool isNuevo = false;
        public bool editar = false;
        public bool actualizarContraseña = false;
        public FrmEmpleado()
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
            textBoxUsuario.Clear();
            textBoxContraseña.Clear();

            // ComboBoxes (regresar a sin selección)
            comboBoxTurno.SelectedIndex = -1;
            comboBoxRol.SelectedIndex = -1;

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
                comboBoxTurno.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBoxContraseña.Enabled = true;
                comboBoxRol.Enabled = true;
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
                comboBoxTurno.Enabled = true;
                textBoxUsuario.Enabled = true;
                textBoxContraseña.Enabled = false;
                comboBoxRol.Enabled = true;
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
                comboBoxTurno.Enabled = false;
                textBoxUsuario.Enabled = false;
                textBoxContraseña.Enabled = false;
                comboBoxRol.Enabled = false;
                buttonNuevo.Enabled = true;
                buttonGuardar.Enabled = false;
                buttonCancelar.Enabled = false;
            }
            if (actualizarContraseña)
            {
                textBoxDNI.Enabled = false;
                textBoxNombre.Enabled = false;
                textBoxTelefono.Enabled = false;
                textBoxCorreo.Enabled = false;
                comboBoxTurno.Enabled = false;
                textBoxUsuario.Enabled = true;
                textBoxContraseña.Enabled = true;
                comboBoxRol.Enabled = false;
                buttonNuevo.Enabled = false;
                buttonGuardar.Enabled = true;
                buttonCancelar.Enabled = true;
            }
        }
        private void CargarEmpleados()
        {
            try
            {
                DTOEmpleado emp = new DTOEmpleado(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = emp.ObtenerEmpleados().ToList();
                dataGridViewLista.DataSource = lista;

                // Ocultar la columna Contraseña para que no falle al intentar dibujarla como imagen
                if (dataGridViewLista.Columns["Contraseña"] != null)
                {
                    dataGridViewLista.Columns["Contraseña"].Visible = false;
                }

                labelTotal.Text = $"Total de empleados: {lista.Count}";
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
                DTOEmpleado emp = new DTOEmpleado(ConexionHelper.ObtenerConfiguracion());

                // Asignamos la lista directamente
                var lista = emp.BuscarEmpleado(textBoxBuscar.Text.Trim()).ToList();
                dataGridViewLista.DataSource = lista;

                // Ocultar la columna Contraseña para que no falle al intentar dibujarla como imagen
                if (dataGridViewLista.Columns["Contraseña"] != null)
                {
                    dataGridViewLista.Columns["Contraseña"].Visible = false;
                }

                labelTotal.Text = $"Total de empleados: {lista.Count}";
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
                DTOEmpleado emp = new DTOEmpleado(ConexionHelper.ObtenerConfiguracion());
                MEmpleado me = new MEmpleado();

                if (isNuevo)
                {
                    me.DNI = textBoxDNI.Text.Trim();
                    me.Nombre = textBoxNombre.Text.Trim();
                    me.Telefono = textBoxTelefono.Text.Trim();
                    me.Correo = textBoxCorreo.Text.Trim();
                    me.Turno = comboBoxTurno.Text;
                    me.Usuario = textBoxUsuario.Text.Trim();
                    me.Contraseña = Encriptacion.CalcularHash(textBoxContraseña.Text.Trim());
                    me.Rol = comboBoxRol.Text;

                    if (emp.InsertarEmpleado(me))
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
                    me.DNI = textBoxDNI.Text.Trim();
                    me.Nombre = textBoxNombre.Text.Trim();
                    me.Telefono = textBoxTelefono.Text.Trim();
                    me.Correo = textBoxCorreo.Text.Trim();
                    me.Turno = comboBoxTurno.Text;
                    me.Usuario = textBoxUsuario.Text.Trim();
                    me.Rol = comboBoxRol.Text;

                    if (emp.ActualizarEmpleado(me))
                    {
                        MessageBox.Show(
                            "Se actualizó el registro correctamente.",
                            "Operación realizada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

                if (actualizarContraseña)
                {
                    if (string.IsNullOrWhiteSpace(textBoxContraseña.Text))
                    {
                        MessageBox.Show("Ingresa la nueva contraseña.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (dataGridViewLista.CurrentRow != null)
                    {
                        var empSeleccionado = (MEmpleado)dataGridViewLista.CurrentRow.DataBoundItem;
                        byte[] passHash = Encriptacion.CalcularHash(textBoxContraseña.Text.Trim());

                        if (emp.CambiarContraseñaEmpleado(empSeleccionado.Id, passHash))
                        {
                            MessageBox.Show("Contraseña actualizada con éxito.",
                                "Operación realizada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
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

        private void ActulizarPass() 
        {
            if (dataGridViewLista.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un empleado de la tabla para cambiar su contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cargar datos del empleado seleccionado
            var emp = (MEmpleado)dataGridViewLista.CurrentRow.DataBoundItem;

            textBoxUsuario.Text = emp.Usuario;
            textBoxContraseña.Clear();

            // Activar banderas
            isNuevo = false;
            editar = false;
            actualizarContraseña = true;

            textBoxContraseña.Focus();
        }

        private void Eliminar()
        {
            if (dataGridViewLista.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un empleado de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el empleado de la fila seleccionada usando DataBoundItem
            var empSeleccionado = (MEmpleado)dataGridViewLista.CurrentRow.DataBoundItem;

            // Cuadro de diálogo de confirmación
            DialogResult respuesta = MessageBox.Show(
                $"¿Estás seguro de dar de baja al empleado '{empSeleccionado.Nombre}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si la respuesta es un si
            if (respuesta == DialogResult.Yes)
            {
                DTOEmpleado dto = new DTOEmpleado(ConexionHelper.ObtenerConfiguracion());

                if (dto.EliminarEmpleado(empSeleccionado.Id))
                {
                    MessageBox.Show("El empleado ha sido dado de baja correctamente.",
                        "Operación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
        #endregion
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

            isNuevo = false;
            editar = false;
            actualizarContraseña = false;

            CargarEmpleados();
            HabilitarControles();
            LimpiarCampos();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            editar = false;
            actualizarContraseña = false;

            HabilitarControles();
        }

        private void FrmEmpleado_Load_1(object sender, EventArgs e)
        {
            // La posición siempre inicia desde la esquina superior izquierda
            this.Top = 0;
            this.Left = 0;

            HabilitarControles();
            CargarEmpleados();
        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewLista.CurrentRow == null) return;

            // Convertir la fila seleccionada al objeto MEmpleado
            var emp = (MEmpleado)dataGridViewLista.CurrentRow.DataBoundItem;

            if (emp != null)
            {
                textBoxDNI.Text = emp.DNI;
                textBoxNombre.Text = emp.Nombre;
                textBoxTelefono.Text = emp.Telefono;
                textBoxCorreo.Text = emp.Correo;
                comboBoxTurno.Text = emp.Turno;
                textBoxUsuario.Text = emp.Usuario;
                comboBoxRol.Text = emp.Rol;

                // Limpiamos el campo de contraseña por seguridad
                textBoxContraseña.Clear();

                isNuevo = false;
                editar = true;
                actualizarContraseña = false;

                HabilitarControles();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            isNuevo = false;
            editar = false;
            actualizarContraseña = false;

            HabilitarControles();
            LimpiarCampos();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();

            LimpiarCampos();
            HabilitarControles();
            CargarEmpleados();
        }

        private void buttonActualizarPass_Click(object sender, EventArgs e)
        {
            ActulizarPass();

            HabilitarControles();
        }
    }
}
