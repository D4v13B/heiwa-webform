namespace Heiwa
{
    partial class Ordenes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordenes));
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.gBoxRegistrar = new System.Windows.Forms.GroupBox();
            this.lblPromociones = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetalleOrden = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPromociones = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblTotalOrden = new System.Windows.Forms.Label();
            this.gBoxRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(0)))), ((int)(((byte)(21)))));
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(20, 538);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(163, 32);
            this.btnCerrarSesion.TabIndex = 20;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.btnIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIngredientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnIngredientes.Location = new System.Drawing.Point(20, 326);
            this.btnIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(163, 32);
            this.btnIngredientes.TabIndex = 19;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = false;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnProductos.Location = new System.Drawing.Point(20, 268);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(163, 32);
            this.btnProductos.TabIndex = 18;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.btnOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOrdenes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnOrdenes.Location = new System.Drawing.Point(20, 209);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(163, 32);
            this.btnOrdenes.TabIndex = 17;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnUsuario.Location = new System.Drawing.Point(20, 153);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(163, 32);
            this.btnUsuario.TabIndex = 16;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // gBoxRegistrar
            // 
            this.gBoxRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.gBoxRegistrar.Controls.Add(this.lblPromociones);
            this.gBoxRegistrar.Controls.Add(this.lblPrecio);
            this.gBoxRegistrar.Controls.Add(this.cmbUsuario);
            this.gBoxRegistrar.Controls.Add(this.cmbMetodoPago);
            this.gBoxRegistrar.Controls.Add(this.label7);
            this.gBoxRegistrar.Controls.Add(this.btnAgregar);
            this.gBoxRegistrar.Controls.Add(this.label6);
            this.gBoxRegistrar.Controls.Add(this.txtObservaciones);
            this.gBoxRegistrar.Controls.Add(this.label4);
            this.gBoxRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBoxRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.gBoxRegistrar.Location = new System.Drawing.Point(229, 70);
            this.gBoxRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxRegistrar.Name = "gBoxRegistrar";
            this.gBoxRegistrar.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxRegistrar.Size = new System.Drawing.Size(311, 499);
            this.gBoxRegistrar.TabIndex = 15;
            this.gBoxRegistrar.TabStop = false;
            this.gBoxRegistrar.Text = "Administrar";
            // 
            // lblPromociones
            // 
            this.lblPromociones.AutoSize = true;
            this.lblPromociones.BackColor = System.Drawing.Color.Transparent;
            this.lblPromociones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPromociones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.lblPromociones.Location = new System.Drawing.Point(13, 331);
            this.lblPromociones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromociones.Name = "lblPromociones";
            this.lblPromociones.Size = new System.Drawing.Size(274, 31);
            this.lblPromociones.TabIndex = 47;
            this.lblPromociones.Text = "Gestión de Ordenes";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.lblPrecio.Location = new System.Drawing.Point(13, 288);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(274, 31);
            this.lblPrecio.TabIndex = 46;
            this.lblPrecio.Text = "Gestión de Ordenes";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(19, 204);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(201, 24);
            this.cmbUsuario.TabIndex = 28;
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Débito",
            "Yappy",
            "Bitcoin"});
            this.cmbMetodoPago.Location = new System.Drawing.Point(19, 135);
            this.cmbMetodoPago.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(201, 24);
            this.cmbMetodoPago.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(16, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cliente";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnAgregar.Location = new System.Drawing.Point(19, 245);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 31);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Vender";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(17, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Método de Pago:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtObservaciones.Location = new System.Drawing.Point(19, 58);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(276, 49);
            this.txtObservaciones.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(231, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Gestión de Ordenes";
            // 
            // dgvDetalleOrden
            // 
            this.dgvDetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleOrden.Location = new System.Drawing.Point(554, 70);
            this.dgvDetalleOrden.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalleOrden.Name = "dgvDetalleOrden";
            this.dgvDetalleOrden.RowHeadersWidth = 62;
            this.dgvDetalleOrden.RowTemplate.Height = 28;
            this.dgvDetalleOrden.Size = new System.Drawing.Size(271, 233);
            this.dgvDetalleOrden.TabIndex = 13;
            this.dgvDetalleOrden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleOrden_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnReportes.Location = new System.Drawing.Point(20, 439);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(163, 32);
            this.btnReportes.TabIndex = 43;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPromociones
            // 
            this.btnPromociones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(32)))), ((int)(((byte)(53)))));
            this.btnPromociones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPromociones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btnPromociones.Location = new System.Drawing.Point(20, 385);
            this.btnPromociones.Margin = new System.Windows.Forms.Padding(2);
            this.btnPromociones.Name = "btnPromociones";
            this.btnPromociones.Size = new System.Drawing.Size(163, 32);
            this.btnPromociones.TabIndex = 31;
            this.btnPromociones.Text = "Promociones";
            this.btnPromociones.UseVisualStyleBackColor = false;
            this.btnPromociones.Click += new System.EventHandler(this.btnPromociones_Click_1);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(554, 337);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(271, 233);
            this.dgvProductos.TabIndex = 44;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // lblTotalOrden
            // 
            this.lblTotalOrden.AutoSize = true;
            this.lblTotalOrden.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(0)))), ((int)(((byte)(45)))));
            this.lblTotalOrden.Location = new System.Drawing.Point(548, 28);
            this.lblTotalOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalOrden.Name = "lblTotalOrden";
            this.lblTotalOrden.Size = new System.Drawing.Size(274, 31);
            this.lblTotalOrden.TabIndex = 45;
            this.lblTotalOrden.Text = "Gestión de Ordenes";
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Heiwa.Properties.Resources.fondo_blanco;
            this.ClientSize = new System.Drawing.Size(844, 588);
            this.Controls.Add(this.lblTotalOrden);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnPromociones);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnIngredientes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.gBoxRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetalleOrden);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ordenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heiwa - Administrador";
            this.gBoxRegistrar.ResumeLayout(false);
            this.gBoxRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.GroupBox gBoxRegistrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetalleOrden;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Button btnPromociones;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblTotalOrden;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblPromociones;
    }
}