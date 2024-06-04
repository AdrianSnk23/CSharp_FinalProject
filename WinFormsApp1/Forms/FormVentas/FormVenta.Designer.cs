namespace WinFormsApp1.Forms.FormVentas
{
    partial class FormVenta
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
            dgvVenta = new DataGridView();
            btnVolverInicio = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // dgvVenta
            // 
            dgvVenta.AllowUserToAddRows = false;
            dgvVenta.AllowUserToDeleteRows = false;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(110, 147);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.ReadOnly = true;
            dgvVenta.RowTemplate.Height = 25;
            dgvVenta.Size = new Size(580, 268);
            dgvVenta.TabIndex = 5;
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
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVenta);
            Controls.Add(btnVolverInicio);
            Controls.Add(button1);
            Name = "FormVenta";
            Text = "FormVenta";
            Load += FormVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVenta;
        private Button btnVolverInicio;
        private Button button1;
    }
}