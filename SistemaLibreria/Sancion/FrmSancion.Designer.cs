namespace SistemaLibreria.Sancion
{
    partial class FrmSancion
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
            comboBoxPrestamo = new ComboBox();
            buttonCancelar = new Button();
            buttonRefrescar = new Button();
            buttonBuscar = new Button();
            textBoxBuscar = new TextBox();
            label10 = new Label();
            buttonEliminar = new Button();
            labelTotal = new Label();
            dataGridViewLista = new DataGridView();
            buttonGuardar = new Button();
            buttonNuevo = new Button();
            label2 = new Label();
            comboBoxMotivo = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            comboBoxEstado = new ComboBox();
            label4 = new Label();
            textBoxMulta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // comboBoxPrestamo
            // 
            comboBoxPrestamo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPrestamo.FormattingEnabled = true;
            comboBoxPrestamo.Location = new Point(83, 21);
            comboBoxPrestamo.Name = "comboBoxPrestamo";
            comboBoxPrestamo.Size = new Size(238, 23);
            comboBoxPrestamo.TabIndex = 106;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(215, 215);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 105;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(803, 20);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 104;
            buttonRefrescar.Text = "Refrescar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(722, 20);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 103;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(393, 21);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Ingrese un valor para buscar por Lector.";
            textBoxBuscar.Size = new Size(321, 23);
            textBoxBuscar.TabIndex = 102;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(342, 24);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 101;
            label10.Text = "Buscar:";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(990, 379);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 23);
            buttonEliminar.TabIndex = 100;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(342, 379);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(110, 15);
            labelTotal.TabIndex = 99;
            labelTotal.Text = "Total de sanciones: ";
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToResizeRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(342, 70);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(725, 301);
            dataGridViewLista.TabIndex = 98;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(116, 215);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 96;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(21, 215);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 95;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 24);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 92;
            label2.Text = "Lector";
            // 
            // comboBoxMotivo
            // 
            comboBoxMotivo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMotivo.FormattingEnabled = true;
            comboBoxMotivo.Items.AddRange(new object[] { "Pérdida", "Daño" });
            comboBoxMotivo.Location = new Point(83, 70);
            comboBoxMotivo.Name = "comboBoxMotivo";
            comboBoxMotivo.Size = new Size(136, 23);
            comboBoxMotivo.TabIndex = 108;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 73);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 107;
            label1.Text = "Motivo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 123);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 109;
            label3.Text = "Multa:";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Pendiente", "Pagado" });
            comboBoxEstado.Location = new Point(83, 168);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(136, 23);
            comboBoxEstado.TabIndex = 111;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 171);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 110;
            label4.Text = "Estado:";
            // 
            // textBoxMulta
            // 
            textBoxMulta.Location = new Point(64, 120);
            textBoxMulta.Name = "textBoxMulta";
            textBoxMulta.Size = new Size(100, 23);
            textBoxMulta.TabIndex = 112;
            // 
            // FrmSancion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 423);
            Controls.Add(textBoxMulta);
            Controls.Add(comboBoxEstado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxMotivo);
            Controls.Add(label1);
            Controls.Add(comboBoxPrestamo);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(label10);
            Controls.Add(buttonEliminar);
            Controls.Add(labelTotal);
            Controls.Add(dataGridViewLista);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSancion";
            Text = "Sanciones";
            Load += FrmSancion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxPrestamo;
        private Button buttonCancelar;
        private Button buttonRefrescar;
        private Button buttonBuscar;
        private TextBox textBoxBuscar;
        private Label label10;
        private Button buttonEliminar;
        private Label labelTotal;
        private DataGridView dataGridViewLista;
        private Button buttonGuardar;
        private Button buttonNuevo;
        private Label label2;
        private ComboBox comboBoxMotivo;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxEstado;
        private Label label4;
        private TextBox textBoxMulta;
    }
}