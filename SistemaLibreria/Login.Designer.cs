namespace SistemaLibreria
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 56);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "Ususario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 116);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(126, 53);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(209, 29);
            textBoxUsuario.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(144, 113);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.Size = new Size(191, 29);
            textBoxContraseña.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(126, 179);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(132, 30);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Iniciar Sesión";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 238);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Button buttonLogin;
    }
}