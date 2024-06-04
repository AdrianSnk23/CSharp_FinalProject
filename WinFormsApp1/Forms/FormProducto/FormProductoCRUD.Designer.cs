namespace WinFormsApp1.Forms.FormProducto
{
    partial class FormProductoCRUD
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtDescripcion = new TextBox();
            txtCosto = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            txtIdUsuario = new TextBox();
            btnVolverForm = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(147, 52);
            label1.Name = "label1";
            label1.Size = new Size(31, 30);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(56, 101);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(112, 149);
            label3.Name = "label3";
            label3.Size = new Size(66, 30);
            label3.TabIndex = 2;
            label3.Text = "Costo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 206);
            label4.Name = "label4";
            label4.Size = new Size(166, 30);
            label4.TabIndex = 3;
            label4.Text = "Precio De Venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(112, 259);
            label5.Name = "label5";
            label5.Size = new Size(63, 30);
            label5.TabIndex = 4;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(67, 314);
            label6.Name = "label6";
            label6.Size = new Size(111, 30);
            label6.TabIndex = 5;
            label6.Text = "Id Usuario";
            // 
            // txtId
            // 
            txtId.Location = new Point(241, 57);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(160, 23);
            txtId.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(241, 108);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(160, 23);
            txtDescripcion.TabIndex = 7;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(241, 156);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(160, 23);
            txtCosto.TabIndex = 8;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(241, 213);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(160, 23);
            txtPrecioVenta.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(241, 266);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(160, 23);
            txtStock.TabIndex = 10;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(241, 323);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(160, 23);
            txtIdUsuario.TabIndex = 11;
            // 
            // btnVolverForm
            // 
            btnVolverForm.Location = new Point(15, 395);
            btnVolverForm.Name = "btnVolverForm";
            btnVolverForm.Size = new Size(104, 37);
            btnVolverForm.TabIndex = 12;
            btnVolverForm.Text = "Volver";
            btnVolverForm.UseVisualStyleBackColor = true;
            btnVolverForm.Click += btnVolverForm_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(156, 395);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 37);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(297, 395);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 37);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormProductoCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolverForm);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormProductoCRUD";
            Text = "FormProductoCRUD";
            Load += FormProductoCRUD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtDescripcion;
        private TextBox txtCosto;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private TextBox txtIdUsuario;
        private Button btnVolverForm;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}