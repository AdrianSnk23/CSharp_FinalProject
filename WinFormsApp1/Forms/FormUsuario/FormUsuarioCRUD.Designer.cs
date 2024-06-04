namespace WinFormsApp1.Forms.FormUsuario
{
    partial class FormUsuarioCRUD
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
            txtGuardar = new Button();
            txtEliminar = new Button();
            btnVolver = new Button();
            txtMail = new TextBox();
            txtContraseña = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtIdUsuario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtGuardar
            // 
            txtGuardar.Location = new Point(364, 404);
            txtGuardar.Name = "txtGuardar";
            txtGuardar.Size = new Size(118, 38);
            txtGuardar.TabIndex = 29;
            txtGuardar.Text = "Guardar";
            txtGuardar.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            txtEliminar.Location = new Point(196, 404);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(118, 38);
            txtEliminar.TabIndex = 28;
            txtEliminar.Text = "Eliminar";
            txtEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(33, 404);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(118, 38);
            btnVolver.TabIndex = 27;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(304, 317);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(178, 23);
            txtMail.TabIndex = 26;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(304, 242);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(178, 23);
            txtContraseña.TabIndex = 25;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(304, 185);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(178, 23);
            txtNombreUsuario.TabIndex = 24;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(304, 126);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(178, 23);
            txtApellido.TabIndex = 23;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(304, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 23);
            txtNombre.TabIndex = 22;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(304, 11);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.ReadOnly = true;
            txtIdUsuario.Size = new Size(178, 23);
            txtIdUsuario.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(145, 310);
            label6.Name = "label6";
            label6.Size = new Size(67, 30);
            label6.TabIndex = 20;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(91, 235);
            label5.Name = "label5";
            label5.Size = new Size(121, 30);
            label5.TabIndex = 19;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 178);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 18;
            label4.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(120, 119);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 17;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(121, 57);
            label2.Name = "label2";
            label2.Size = new Size(91, 30);
            label2.TabIndex = 16;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(181, 4);
            label1.Name = "label1";
            label1.Size = new Size(31, 30);
            label1.TabIndex = 15;
            label1.Text = "Id";
            // 
            // FormUsuarioCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(txtGuardar);
            Controls.Add(txtEliminar);
            Controls.Add(btnVolver);
            Controls.Add(txtMail);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtIdUsuario);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUsuarioCRUD";
            Text = "FormUsuarioCRUD";
            Load += FormUsuarioCRUD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtGuardar;
        private Button txtEliminar;
        private Button btnVolver;
        private TextBox txtMail;
        private TextBox txtContraseña;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtIdUsuario;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}