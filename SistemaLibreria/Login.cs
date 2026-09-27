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

namespace SistemaLibreria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region MÉTODOS INTERNOS
        private void ProcesarLogin()
        {
            try
            {
                string usuario = textBoxUsuario.Text.Trim();
                string contrasenia = textBoxContraseña.Text.Trim();

                DTOEmpleado dto = new DTOEmpleado(ConexionHelper.ObtenerConfiguracion());

                // Obtener el usuario desde la base de datos
                MEmpleado empleado = dto.Login(usuario).FirstOrDefault();

                // Validar si existe el usuario y si la contraseña coincide
                if (empleado != null && Encriptacion.EsIgualHash(empleado.Contraseña, contrasenia))
                {
                    MessageBox.Show($"¡Bienvenido al sistema, {empleado.Nombre}!",
                                    "Acceso Concedido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    MenuNavegacion menu = new MenuNavegacion(empleado.Nombre, empleado.Rol, empleado.Turno);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error, credenciales incorrectas o no existe el usuario.",
                                    "Acceso Denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar con el sistema!",
                                    "Error Técnico",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
        }
        #endregion
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ProcesarLogin();
        }
    }
}
