using SistemaLibreria.Ejemplar;
using SistemaLibreria.Empleado;
using SistemaLibreria.Lector;
using SistemaLibreria.Libro;

namespace SistemaLibreria
{
    public partial class MenuNavegacion : Form
    {
        public MenuNavegacion(string nombre, string rol, string turno)
        {
            InitializeComponent();
            DefinirRol(rol);
        }

        #region MÉTODOS INTERNOS
        private void DefinirRol(string textoRol)
        {
            // Rol del administrador del sistema
            if (textoRol.Equals("Administrador"))
            {
                librosToolStripMenuItem.Enabled = true;
                ejemplaresToolStripMenuItem.Enabled = true;
                lectoresToolStripMenuItem.Enabled = true;
                empleadosToolStripMenuItem.Enabled = true;
                prestamosToolStripMenuItem.Enabled = true;
                sancionesToolStripMenuItem.Enabled = true;
            }
            // Rol del bibliotecario
            else if (textoRol.Equals("Bibliotecario"))
            {
                librosToolStripMenuItem.Enabled = false;
                ejemplaresToolStripMenuItem.Enabled = false;
                lectoresToolStripMenuItem.Enabled = true;
                empleadosToolStripMenuItem.Enabled = false;
                prestamosToolStripMenuItem.Enabled = true;
                sancionesToolStripMenuItem.Enabled = true;
            }
            else
            {
                // Para el del inventario
                librosToolStripMenuItem.Enabled = true;
                ejemplaresToolStripMenuItem.Enabled = true;
                lectoresToolStripMenuItem.Enabled = false;
                empleadosToolStripMenuItem.Enabled = false;
                prestamosToolStripMenuItem.Enabled = false;
                sancionesToolStripMenuItem.Enabled = false;
            }
        }
        #endregion

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si hay un formulario hijo activo, lo cerramos
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            FrmLibro frm = new FrmLibro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ejemplaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si hay un formulario hijo activo, lo cerramos
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            FrmEjemplar frm = new FrmEjemplar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void lectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si hay un formulario hijo activo, lo cerramos
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            FrmLector frm = new FrmLector();
            frm.MdiParent = this;
            frm.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si hay un formulario hijo activo, lo cerramos
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }

            FrmEmpleado frm = new FrmEmpleado();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
