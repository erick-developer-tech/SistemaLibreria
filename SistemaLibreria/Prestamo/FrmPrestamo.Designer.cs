namespace SistemaLibreria.Prestamo
{
    partial class FrmPrestamo
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
            groupBox1 = new GroupBox();
            buttonBuscar = new Button();
            dateTimePickerFechaFin = new DateTimePicker();
            dateTimePickerFechaInicio = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            textBoxObservaciones = new TextBox();
            comboBoxEmpleado = new ComboBox();
            comboBoxLector = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonQuitar = new Button();
            buttonAgregarDetalle = new Button();
            comboBoxEjemplar = new ComboBox();
            label6 = new Label();
            dataGridViewLista = new DataGridView();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            buttonEliminar = new Button();
            labelTotal = new Label();
            buttonNuevo = new Button();
            buttonVerDetalles = new Button();
            buttonRefrescar = new Button();
            groupBox3 = new GroupBox();
            buttonActualizarDetalle = new Button();
            dateTimePickerFechaDevolucion = new DateTimePicker();
            label8 = new Label();
            comboBoxEstado = new ComboBox();
            label7 = new Label();
            buttonCancelarDetalle = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonBuscar);
            groupBox1.Controls.Add(dateTimePickerFechaFin);
            groupBox1.Controls.Add(dateTimePickerFechaInicio);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxObservaciones);
            groupBox1.Controls.Add(comboBoxEmpleado);
            groupBox1.Controls.Add(comboBoxLector);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(771, 163);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Generales Prestamo";
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(615, 26);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 10;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dateTimePickerFechaFin
            // 
            dateTimePickerFechaFin.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaFin.Location = new Point(470, 63);
            dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            dateTimePickerFechaFin.Size = new Size(126, 23);
            dateTimePickerFechaFin.TabIndex = 9;
            // 
            // dateTimePickerFechaInicio
            // 
            dateTimePickerFechaInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaInicio.Location = new Point(470, 27);
            dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            dateTimePickerFechaInicio.Size = new Size(126, 23);
            dateTimePickerFechaInicio.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 66);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 7;
            label5.Text = "Fecha Límite:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 30);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha Inicio:";
            // 
            // textBoxObservaciones
            // 
            textBoxObservaciones.Location = new Point(118, 103);
            textBoxObservaciones.Multiline = true;
            textBoxObservaciones.Name = "textBoxObservaciones";
            textBoxObservaciones.Size = new Size(242, 54);
            textBoxObservaciones.TabIndex = 5;
            // 
            // comboBoxEmpleado
            // 
            comboBoxEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmpleado.FormattingEnabled = true;
            comboBoxEmpleado.Location = new Point(94, 63);
            comboBoxEmpleado.Name = "comboBoxEmpleado";
            comboBoxEmpleado.Size = new Size(207, 23);
            comboBoxEmpleado.TabIndex = 4;
            // 
            // comboBoxLector
            // 
            comboBoxLector.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLector.FormattingEnabled = true;
            comboBoxLector.Location = new Point(74, 27);
            comboBoxLector.Name = "comboBoxLector";
            comboBoxLector.Size = new Size(227, 23);
            comboBoxLector.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 103);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 2;
            label3.Text = "Observaciones:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 66);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Empleado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Lector:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonQuitar);
            groupBox2.Controls.Add(buttonAgregarDetalle);
            groupBox2.Controls.Add(comboBoxEjemplar);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(771, 86);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del ejemplar";
            // 
            // buttonQuitar
            // 
            buttonQuitar.ForeColor = Color.Red;
            buttonQuitar.Location = new Point(434, 36);
            buttonQuitar.Name = "buttonQuitar";
            buttonQuitar.Size = new Size(106, 23);
            buttonQuitar.TabIndex = 3;
            buttonQuitar.Text = "Quitar";
            buttonQuitar.UseVisualStyleBackColor = true;
            buttonQuitar.Click += buttonQuitar_Click;
            // 
            // buttonAgregarDetalle
            // 
            buttonAgregarDetalle.ForeColor = Color.Green;
            buttonAgregarDetalle.Location = new Point(322, 35);
            buttonAgregarDetalle.Name = "buttonAgregarDetalle";
            buttonAgregarDetalle.Size = new Size(106, 23);
            buttonAgregarDetalle.TabIndex = 2;
            buttonAgregarDetalle.Text = "Agregar";
            buttonAgregarDetalle.UseVisualStyleBackColor = true;
            buttonAgregarDetalle.Click += buttonAgregarDetalle_Click;
            // 
            // comboBoxEjemplar
            // 
            comboBoxEjemplar.FormattingEnabled = true;
            comboBoxEjemplar.Location = new Point(92, 36);
            comboBoxEjemplar.Name = "comboBoxEjemplar";
            comboBoxEjemplar.Size = new Size(209, 23);
            comboBoxEjemplar.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 39);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 0;
            label6.Text = "Ejemplar:";
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToAddRows = false;
            dataGridViewLista.AllowUserToDeleteRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(12, 367);
            dataGridViewLista.MultiSelect = false;
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(771, 225);
            dataGridViewLista.TabIndex = 2;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(708, 631);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(627, 631);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 4;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(194, 630);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(119, 23);
            buttonEliminar.TabIndex = 5;
            buttonEliminar.Text = "Eliminar Prestamo";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(12, 602);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(100, 15);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "Total de registros:";
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(546, 631);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 7;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonVerDetalles
            // 
            buttonVerDetalles.Location = new Point(12, 630);
            buttonVerDetalles.Name = "buttonVerDetalles";
            buttonVerDetalles.Size = new Size(86, 23);
            buttonVerDetalles.TabIndex = 8;
            buttonVerDetalles.Text = "Ver Detalles";
            buttonVerDetalles.UseVisualStyleBackColor = true;
            buttonVerDetalles.Click += buttonVerDetalles_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(708, 598);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 9;
            buttonRefrescar.Text = "Refrescar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonActualizarDetalle);
            groupBox3.Controls.Add(dateTimePickerFechaDevolucion);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(comboBoxEstado);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(12, 275);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(771, 86);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Estado del ejemplar";
            // 
            // buttonActualizarDetalle
            // 
            buttonActualizarDetalle.Location = new Point(555, 35);
            buttonActualizarDetalle.Name = "buttonActualizarDetalle";
            buttonActualizarDetalle.Size = new Size(75, 23);
            buttonActualizarDetalle.TabIndex = 4;
            buttonActualizarDetalle.Text = "Actualizar";
            buttonActualizarDetalle.UseVisualStyleBackColor = true;
            buttonActualizarDetalle.Click += buttonActualizarDetalle_Click;
            // 
            // dateTimePickerFechaDevolucion
            // 
            dateTimePickerFechaDevolucion.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaDevolucion.Location = new Point(134, 35);
            dateTimePickerFechaDevolucion.Name = "dateTimePickerFechaDevolucion";
            dateTimePickerFechaDevolucion.Size = new Size(167, 23);
            dateTimePickerFechaDevolucion.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(321, 39);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 2;
            label8.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Prestado", "Devuelto", "Dañado", "Perdido" });
            comboBoxEstado.Location = new Point(372, 35);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(167, 23);
            comboBoxEstado.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 38);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 0;
            label7.Text = "Fecha devolución:";
            // 
            // buttonCancelarDetalle
            // 
            buttonCancelarDetalle.Location = new Point(106, 630);
            buttonCancelarDetalle.Name = "buttonCancelarDetalle";
            buttonCancelarDetalle.Size = new Size(75, 23);
            buttonCancelarDetalle.TabIndex = 5;
            buttonCancelarDetalle.Text = "Regresar";
            buttonCancelarDetalle.UseVisualStyleBackColor = true;
            buttonCancelarDetalle.Click += buttonCancelarDetalle_Click;
            // 
            // FrmPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 669);
            Controls.Add(buttonCancelarDetalle);
            Controls.Add(groupBox3);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonVerDetalles);
            Controls.Add(buttonNuevo);
            Controls.Add(labelTotal);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonCancelar);
            Controls.Add(dataGridViewLista);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPrestamo";
            Text = "  Prestamos";
            Load += FrmPrestamo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBoxObservaciones;
        private ComboBox comboBoxEmpleado;
        private ComboBox comboBoxLector;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private DateTimePicker dateTimePickerFechaFin;
        private DateTimePicker dateTimePickerFechaInicio;
        private GroupBox groupBox2;
        private ComboBox comboBoxEjemplar;
        private Label label6;
        private Button buttonAgregarDetalle;
        private DataGridView dataGridViewLista;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private Button buttonEliminar;
        private Label labelTotal;
        private Button buttonNuevo;
        private Button buttonVerDetalles;
        private Button buttonBuscar;
        private Button buttonQuitar;
        private Button buttonRefrescar;
        private GroupBox groupBox3;
        private Label label7;
        private ComboBox comboBoxEstado;
        private Button buttonCancelarDetalle;
        private Button buttonActualizarDetalle;
        private DateTimePicker dateTimePickerFechaDevolucion;
        private Label label8;
    }
}