namespace WinFormsApp1.Forms.FormProductoVendido
{
    partial class FormProductoVendido
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
            dgvProductoVendido = new DataGridView();
            btnVolverInicio = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductoVendido).BeginInit();
            SuspendLayout();
            // 
            // dgvProductoVendido
            // 
            dgvProductoVendido.AllowUserToAddRows = false;
            dgvProductoVendido.AllowUserToDeleteRows = false;
            dgvProductoVendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductoVendido.Location = new Point(110, 147);
            dgvProductoVendido.Name = "dgvProductoVendido";
            dgvProductoVendido.ReadOnly = true;
            dgvProductoVendido.RowTemplate.Height = 25;
            dgvProductoVendido.Size = new Size(580, 268);
            dgvProductoVendido.TabIndex = 5;
            dgvProductoVendido.CellContentClick += dgvProductoVendido_CellContentClick;
            // 
            // btnVolverInicio
            // 
            btnVolverInicio.Location = new Point(503, 36);
            btnVolverInicio.Name = "btnVolverInicio";
            btnVolverInicio.Size = new Size(187, 64);
            btnVolverInicio.TabIndex = 4;
            btnVolverInicio.Text = "Volver";
            btnVolverInicio.UseVisualStyleBackColor = true;
            btnVolverInicio.Click += btnVolverInicio_Click;
            // 
            // button1
            // 
            button1.Location = new Point(110, 36);
            button1.Name = "button1";
            button1.Size = new Size(187, 64);
            button1.TabIndex = 3;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormProductoVendido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductoVendido);
            Controls.Add(btnVolverInicio);
            Controls.Add(button1);
            Name = "FormProductoVendido";
            Text = "FormProductoVendido";
            Load += FormProductoVendido_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductoVendido).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductoVendido;
        private Button btnVolverInicio;
        private Button button1;
    }
}