namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUsuario = new Button();
            btnProducto = new Button();
            btnProductoVendido = new Button();
            btnVentas = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(29, 120);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(152, 62);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnProducto
            // 
            btnProducto.Location = new Point(222, 120);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(152, 62);
            btnProducto.TabIndex = 1;
            btnProducto.Text = "Producto";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnProductoVendido
            // 
            btnProductoVendido.Location = new Point(419, 120);
            btnProductoVendido.Name = "btnProductoVendido";
            btnProductoVendido.Size = new Size(152, 62);
            btnProductoVendido.TabIndex = 2;
            btnProductoVendido.Text = "Producto Vendido";
            btnProductoVendido.UseVisualStyleBackColor = true;
            btnProductoVendido.Click += btnProductoVendido_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(620, 120);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(152, 62);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(222, 244);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(349, 62);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnVentas);
            Controls.Add(btnProductoVendido);
            Controls.Add(btnProducto);
            Controls.Add(btnUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnProducto;
        private Button btnProductoVendido;
        private Button btnVentas;
        private Button btnSalir;
    }
}
