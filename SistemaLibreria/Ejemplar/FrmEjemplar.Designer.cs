namespace SistemaLibreria.Ejemplar
{
    partial class FrmEjemplar
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
            textBoxCodigoBarras = new TextBox();
            buttonGuardar = new Button();
            buttonNuevo = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            comboBoxLibro = new ComboBox();
            comboBoxEstado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(215, 154);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 89;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(804, 20);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 88;
            buttonRefrescar.Text = "Refrescar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(723, 20);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 87;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(394, 21);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Ingrese un valor para buscar por Titulo o Código de barras.";
            textBoxBuscar.Size = new Size(321, 23);
            textBoxBuscar.TabIndex = 86;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(343, 24);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 85;
            label10.Text = "Buscar:";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(802, 379);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 23);
            buttonEliminar.TabIndex = 84;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(343, 379);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(115, 15);
            labelTotal.TabIndex = 83;
            labelTotal.Text = "Total de ejemplares: ";
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToResizeRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(343, 70);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(536, 301);
            dataGridViewLista.TabIndex = 82;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // textBoxCodigoBarras
            // 
            textBoxCodigoBarras.Location = new Point(124, 67);
            textBoxCodigoBarras.Name = "textBoxCodigoBarras";
            textBoxCodigoBarras.Size = new Size(213, 23);
            textBoxCodigoBarras.TabIndex = 79;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(116, 154);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 77;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(21, 154);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 76;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 117);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 75;
            label5.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 70);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 73;
            label3.Text = "Codigo de Barras:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 24);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 72;
            label2.Text = "Libro:";
            // 
            // comboBoxLibro
            // 
            comboBoxLibro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLibro.FormattingEnabled = true;
            comboBoxLibro.Location = new Point(61, 21);
            comboBoxLibro.Name = "comboBoxLibro";
            comboBoxLibro.Size = new Size(229, 23);
            comboBoxLibro.TabIndex = 90;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Disponible", "Prestado", "Mantenimiento", "Perdido" });
            comboBoxEstado.Location = new Point(69, 114);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(138, 23);
            comboBoxEstado.TabIndex = 91;
            // 
            // FrmEjemplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 423);
            Controls.Add(comboBoxEstado);
            Controls.Add(comboBoxLibro);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(label10);
            Controls.Add(buttonEliminar);
            Controls.Add(labelTotal);
            Controls.Add(dataGridViewLista);
            Controls.Add(textBoxCodigoBarras);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEjemplar";
            Text = "Ejemplares";
            Load += FrmEjemplar_Load;
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
        private TextBox textBoxCodigoBarras;
        private Button buttonGuardar;
        private Button buttonNuevo;
        private Label label5;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxLibro;
        private ComboBox comboBoxEstado;
    }
}