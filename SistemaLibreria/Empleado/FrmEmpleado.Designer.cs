namespace SistemaLibreria.Empleado
{
    partial class FrmEmpleado
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            textBoxDNI = new TextBox();
            textBoxNombre = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            comboBoxTurno = new ComboBox();
            comboBoxRol = new ComboBox();
            dataGridViewLista = new DataGridView();
            labelTotal = new Label();
            buttonEliminar = new Button();
            label10 = new Label();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            buttonRefrescar = new Button();
            buttonCancelar = new Button();
            buttonActualizarPass = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 49);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 95);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 141);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 188);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 4;
            label5.Text = "Correo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 238);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Turno:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 280);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 6;
            label7.Text = "Usuario:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 327);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 7;
            label8.Text = "Contraseña:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 376);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 8;
            label9.Text = "Rol:";
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(31, 422);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 9;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(126, 422);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(64, 46);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(134, 23);
            textBoxDNI.TabIndex = 11;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(88, 92);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(212, 23);
            textBoxNombre.TabIndex = 12;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(90, 138);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(144, 23);
            textBoxTelefono.TabIndex = 13;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(80, 185);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(193, 23);
            textBoxCorreo.TabIndex = 14;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(84, 277);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(160, 23);
            textBoxUsuario.TabIndex = 15;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(104, 324);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(140, 23);
            textBoxContraseña.TabIndex = 16;
            // 
            // comboBoxTurno
            // 
            comboBoxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTurno.FormattingEnabled = true;
            comboBoxTurno.Items.AddRange(new object[] { "Mañana", "Tarde" });
            comboBoxTurno.Location = new Point(79, 235);
            comboBoxTurno.Name = "comboBoxTurno";
            comboBoxTurno.Size = new Size(121, 23);
            comboBoxTurno.TabIndex = 17;
            // 
            // comboBoxRol
            // 
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "Administrador", "Bibliotecario", "Inventario" });
            comboBoxRol.Location = new Point(64, 373);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(136, 23);
            comboBoxRol.TabIndex = 18;
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToResizeRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(353, 95);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(750, 301);
            dataGridViewLista.TabIndex = 19;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(354, 404);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(116, 15);
            labelTotal.TabIndex = 20;
            labelTotal.Text = "Total de empleados: ";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(977, 422);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(126, 23);
            buttonEliminar.TabIndex = 21;
            buttonEliminar.Text = "Eliminar / Dar Baja";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(353, 49);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 22;
            label10.Text = "Buscar:";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(404, 46);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Ingrese un valor para buscar por DNI exacto, Nombre o Usuario exacto.";
            textBoxBuscar.Size = new Size(386, 23);
            textBoxBuscar.TabIndex = 23;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(806, 46);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 24;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(887, 46);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 25;
            buttonRefrescar.Text = "Refrescar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(225, 422);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 26;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonActualizarPass
            // 
            buttonActualizarPass.Location = new Point(832, 422);
            buttonActualizarPass.Name = "buttonActualizarPass";
            buttonActualizarPass.Size = new Size(130, 23);
            buttonActualizarPass.TabIndex = 27;
            buttonActualizarPass.Text = "Actualizar Contraseña";
            buttonActualizarPass.UseVisualStyleBackColor = true;
            buttonActualizarPass.Click += buttonActualizarPass_Click;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 457);
            Controls.Add(buttonActualizarPass);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(label10);
            Controls.Add(buttonEliminar);
            Controls.Add(labelTotal);
            Controls.Add(dataGridViewLista);
            Controls.Add(comboBoxRol);
            Controls.Add(comboBoxTurno);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDNI);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEmpleado";
            Text = "Empleados";
            Load += FrmEmpleado_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button buttonNuevo;
        private Button buttonGuardar;
        private TextBox textBoxDNI;
        private TextBox textBoxNombre;
        private TextBox textBoxTelefono;
        private TextBox textBoxCorreo;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private ComboBox comboBoxTurno;
        private ComboBox comboBoxRol;
        private DataGridView dataGridViewLista;
        private Label labelTotal;
        private Button buttonEliminar;
        private Label label10;
        private TextBox textBoxBuscar;
        private Button buttonBuscar;
        private Button buttonRefrescar;
        private Button buttonCancelar;
        private Button buttonActualizarPass;
    }
}