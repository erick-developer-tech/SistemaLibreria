namespace SistemaLibreria
{
    partial class MenuNavegacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripNavegacion = new MenuStrip();
            librosToolStripMenuItem = new ToolStripMenuItem();
            ejemplaresToolStripMenuItem = new ToolStripMenuItem();
            lectoresToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            prestamosToolStripMenuItem = new ToolStripMenuItem();
            sancionesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            menuStripNavegacion.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripNavegacion
            // 
            menuStripNavegacion.Items.AddRange(new ToolStripItem[] { librosToolStripMenuItem, ejemplaresToolStripMenuItem, lectoresToolStripMenuItem, empleadosToolStripMenuItem, prestamosToolStripMenuItem, sancionesToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            menuStripNavegacion.Location = new Point(0, 0);
            menuStripNavegacion.Name = "menuStripNavegacion";
            menuStripNavegacion.Size = new Size(1465, 24);
            menuStripNavegacion.TabIndex = 0;
            menuStripNavegacion.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(51, 20);
            librosToolStripMenuItem.Text = "Libros";
            librosToolStripMenuItem.Click += librosToolStripMenuItem_Click;
            // 
            // ejemplaresToolStripMenuItem
            // 
            ejemplaresToolStripMenuItem.Name = "ejemplaresToolStripMenuItem";
            ejemplaresToolStripMenuItem.Size = new Size(76, 20);
            ejemplaresToolStripMenuItem.Text = "Ejemplares";
            ejemplaresToolStripMenuItem.Click += ejemplaresToolStripMenuItem_Click;
            // 
            // lectoresToolStripMenuItem
            // 
            lectoresToolStripMenuItem.Name = "lectoresToolStripMenuItem";
            lectoresToolStripMenuItem.Size = new Size(63, 20);
            lectoresToolStripMenuItem.Text = "Lectores";
            lectoresToolStripMenuItem.Click += lectoresToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(77, 20);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // prestamosToolStripMenuItem
            // 
            prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            prestamosToolStripMenuItem.Size = new Size(74, 20);
            prestamosToolStripMenuItem.Text = "Prestamos";
            prestamosToolStripMenuItem.Click += prestamosToolStripMenuItem_Click;
            // 
            // sancionesToolStripMenuItem
            // 
            sancionesToolStripMenuItem.Name = "sancionesToolStripMenuItem";
            sancionesToolStripMenuItem.Size = new Size(72, 20);
            sancionesToolStripMenuItem.Text = "Sanciones";
            sancionesToolStripMenuItem.Click += sancionesToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Margin = new Padding(900, 0, 0, 0);
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(88, 20);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // MenuNavegacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1465, 815);
            Controls.Add(menuStripNavegacion);
            IsMdiContainer = true;
            MainMenuStrip = menuStripNavegacion;
            Name = "MenuNavegacion";
            Text = "Menu Principal";
            menuStripNavegacion.ResumeLayout(false);
            menuStripNavegacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripNavegacion;
        private ToolStripMenuItem librosToolStripMenuItem;
        private ToolStripMenuItem ejemplaresToolStripMenuItem;
        private ToolStripMenuItem lectoresToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem prestamosToolStripMenuItem;
        private ToolStripMenuItem sancionesToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        //private ToolStripMenuItem libroToolStripMenuItem;
        //private ToolStripMenuItem ejemplarToolStripMenuItem;
        //private ToolStripMenuItem empleadoToolStripMenuItem;
        //private ToolStripMenuItem lectorToolStripMenuItem;
        //private ToolStripMenuItem prestamosToolStripMenuItem;
        //private ToolStripMenuItem sancionesToolStripMenuItem;
    }
}
