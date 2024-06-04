namespace WinFormsApp1.Forms.FormUsuario
{
    partial class FormUsuario
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
            btnVolverInicio = new Button();
            btnActualizar = new Button();
            dgvUsuarios = new DataGridView();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.Location = new Point(406, 31);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(145, 60);
            btnVolverInicio.TabIndex = 0;
            btnVolverInicio.Text = "Volver";
            btnVolverInicio.UseVisualStyleBackColor = true;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(47, 31);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(143, 60);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(47, 126);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(504, 287);
            dgvUsuarios.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(225, 31);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(143, 60);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 450);
            Controls.Add(btnAgregar);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnActualizar);
            Controls.Add(btnVolverInicio);
            Name = "FormUsuario";
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVolverInicio;
        private Button btnActualizar;
        private DataGridView dgvUsuarios;
        private Button btnAgregar;
    }
}