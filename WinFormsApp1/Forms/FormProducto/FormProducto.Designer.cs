namespace WinFormsApp1.Forms.FormProducto
{
    partial class FormProducto
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
            btnActualizar = new Button();
            btnVolverInicio = new Button();
            dgvProducto = new DataGridView();
            btnAgregarProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(39, 56);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(187, 64);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.Location = new Point(432, 56);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(187, 64);
            btnVolverInicio.TabIndex = 1;
            btnVolverInicio.Text = "Volver";
            btnVolverInicio.UseVisualStyleBackColor = true;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.AllowUserToAddRows = false;
            dgvProducto.AllowUserToDeleteRows = false;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(38, 160);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.ReadOnly = true;
            dgvProducto.RowTemplate.Height = 25;
            dgvProducto.Size = new Size(580, 268);
            dgvProducto.TabIndex = 2;
            dgvProducto.CellClick += dgvProducto_CellClick;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(239, 56);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(187, 64);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 450);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dgvProducto);
            Controls.Add(btnVolverInicio);
            Controls.Add(btnActualizar);
            Name = "FormProducto";
            Text = "FormProducto";
            Load += FormProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnActualizar;
        private Button btnVolverInicio;
        private DataGridView dgvProducto;
        private Button btnAgregarProducto;
    }
}