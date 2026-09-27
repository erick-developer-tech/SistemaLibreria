namespace SistemaLibreria.Libro
{
    partial class FrmLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCancelar = new Button();
            buttonRefrescar = new Button();
            buttonBuscar = new Button();
            textBoxBuscar = new TextBox();
            label10 = new Label();
            buttonEliminar = new Button();
            labelTotal = new Label();
            dataGridViewLista = new DataGridView();
            textBoxAño = new TextBox();
            textBoxEditorial = new TextBox();
            textBoxAutor = new TextBox();
            textBoxTitulo = new TextBox();
            buttonGuardar = new Button();
            buttonNuevo = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(215, 206);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 71;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(877, 21);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 70;
            buttonRefrescar.Text = "Refrescar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(796, 21);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 69;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(394, 21);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Ingrese un valor para buscar por Titulo, Autor o Editorial.";
            textBoxBuscar.Size = new Size(386, 23);
            textBoxBuscar.TabIndex = 68;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 24);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 67;
            label10.Text = "Buscar:";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(875, 379);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 23);
            buttonEliminar.TabIndex = 66;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(344, 379);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(87, 15);
            labelTotal.TabIndex = 65;
            labelTotal.Text = "Total de libros: ";
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToResizeRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(343, 70);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(609, 301);
            dataGridViewLista.TabIndex = 64;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // textBoxAño
            // 
            textBoxAño.Location = new Point(56, 160);
            textBoxAño.Name = "textBoxAño";
            textBoxAño.Size = new Size(95, 23);
            textBoxAño.TabIndex = 63;
            // 
            // textBoxEditorial
            // 
            textBoxEditorial.Location = new Point(77, 113);
            textBoxEditorial.Name = "textBoxEditorial";
            textBoxEditorial.Size = new Size(183, 23);
            textBoxEditorial.TabIndex = 62;
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(65, 67);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(225, 23);
            textBoxAutor.TabIndex = 61;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(65, 21);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(225, 23);
            textBoxTitulo.TabIndex = 60;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(116, 206);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 59;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(21, 206);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 58;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 163);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 57;
            label5.Text = "Año:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 116);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 56;
            label4.Text = "Editorial:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 70);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 55;
            label3.Text = "Autor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 24);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 54;
            label2.Text = "Titulo:";
            // 
            // FrmLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 423);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(label10);
            Controls.Add(buttonEliminar);
            Controls.Add(labelTotal);
            Controls.Add(dataGridViewLista);
            Controls.Add(textBoxAño);
            Controls.Add(textBoxEditorial);
            Controls.Add(textBoxAutor);
            Controls.Add(textBoxTitulo);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLibro";
            Text = "Libros";
            Load += FrmLibro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonRefrescar;
        private Button buttonBuscar;
        private TextBox textBoxBuscar;
        private Label label10;
        private Button buttonEliminar;
        private Label labelTotal;
        private DataGridView dataGridViewLista;
        private TextBox textBoxAño;
        private TextBox textBoxEditorial;
        private TextBox textBoxAutor;
        private TextBox textBoxTitulo;
        private Button buttonGuardar;
        private Button buttonNuevo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}