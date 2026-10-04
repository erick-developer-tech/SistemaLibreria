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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuNavegacion));
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
            menuStripNavegacion.Padding = new Padding(6, 10, 0, 10);
            menuStripNavegacion.Size = new Size(1465, 103);
            menuStripNavegacion.TabIndex = 0;
            menuStripNavegacion.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            librosToolStripMenuItem.Image = Properties.Resources.image_libros;
            librosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            librosToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            librosToolStripMenuItem.Size = new Size(76, 83);
            librosToolStripMenuItem.Text = "Libros";
            librosToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            librosToolStripMenuItem.Click += librosToolStripMenuItem_Click;
            // 
            // ejemplaresToolStripMenuItem
            // 
            ejemplaresToolStripMenuItem.Image = Properties.Resources.image_ejemplares;
            ejemplaresToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ejemplaresToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            ejemplaresToolStripMenuItem.Name = "ejemplaresToolStripMenuItem";
            ejemplaresToolStripMenuItem.Size = new Size(76, 83);
            ejemplaresToolStripMenuItem.Text = "Ejemplares";
            ejemplaresToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            ejemplaresToolStripMenuItem.Click += ejemplaresToolStripMenuItem_Click;
            // 
            // lectoresToolStripMenuItem
            // 
            lectoresToolStripMenuItem.Image = Properties.Resources.image_lectores;
            lectoresToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            lectoresToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            lectoresToolStripMenuItem.Name = "lectoresToolStripMenuItem";
            lectoresToolStripMenuItem.Size = new Size(76, 83);
            lectoresToolStripMenuItem.Text = "Lectores";
            lectoresToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            lectoresToolStripMenuItem.Click += lectoresToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Image = Properties.Resources.image_empleados;
            empleadosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            empleadosToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(77, 83);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // prestamosToolStripMenuItem
            // 
            prestamosToolStripMenuItem.Image = Properties.Resources.image_prestamos;
            prestamosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            prestamosToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            prestamosToolStripMenuItem.Size = new Size(76, 83);
            prestamosToolStripMenuItem.Text = "Prestamos";
            prestamosToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            prestamosToolStripMenuItem.Click += prestamosToolStripMenuItem_Click;
            // 
            // sancionesToolStripMenuItem
            // 
            sancionesToolStripMenuItem.Image = Properties.Resources.image_sanciones;
            sancionesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sancionesToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            sancionesToolStripMenuItem.Name = "sancionesToolStripMenuItem";
            sancionesToolStripMenuItem.Size = new Size(76, 83);
            sancionesToolStripMenuItem.Text = "Sanciones";
            sancionesToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            sancionesToolStripMenuItem.Click += sancionesToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Image = Properties.Resources.cerrar_sesion;
            cerrarSesiónToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cerrarSesiónToolStripMenuItem.Margin = new Padding(750, 0, 0, 0);
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(88, 83);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // MenuNavegacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1465, 815);
            Controls.Add(menuStripNavegacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStripNavegacion;
            MaximizeBox = false;
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
