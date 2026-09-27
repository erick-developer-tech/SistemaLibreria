namespace SistemaLibreria.Lector
{
    partial class FrmLector
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
            labelTotal = new Label();
            dataGridViewLista = new DataGridView();
            textBoxCorreo = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxNombre = new TextBox();
            textBoxDNI = new TextBox();
            buttonGuardar = new Button();
            buttonNuevo = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(217, 214);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 53;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(879, 29);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 52;
            buttonRefrescar.Text = "Refrescar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(798, 29);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 51;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(396, 29);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Ingrese un valor para buscar por DNI exacto o Nombre.";
            textBoxBuscar.Size = new Size(386, 23);
            textBoxBuscar.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(345, 32);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 49;
            label10.Text = "Buscar:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(346, 387);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(99, 15);
            labelTotal.TabIndex = 47;
            labelTotal.Text = "Total de lectores: ";
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToResizeRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(345, 78);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(609, 301);
            dataGridViewLista.TabIndex = 46;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(72, 168);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(193, 23);
            textBoxCorreo.TabIndex = 41;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(82, 121);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(144, 23);
            textBoxTelefono.TabIndex = 40;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(80, 75);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(212, 23);
            textBoxNombre.TabIndex = 39;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(56, 29);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(134, 23);
            textBoxDNI.TabIndex = 38;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(118, 214);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 37;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(23, 214);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 36;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 171);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 31;
            label5.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 124);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 30;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 78);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 29;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 32);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 28;
            label2.Text = "DNI:";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(877, 387);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 23);
            buttonEliminar.TabIndex = 48;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // FrmLector
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
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDNI);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLector";
            Text = "k";
            Load += FrmLector_Load;
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
        private Label labelTotal;
        private DataGridView dataGridViewLista;
        private TextBox textBoxCorreo;
        private TextBox textBoxTelefono;
        private TextBox textBoxNombre;
        private TextBox textBoxDNI;
        private Button buttonGuardar;
        private Button buttonNuevo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonEliminar;
    }
}