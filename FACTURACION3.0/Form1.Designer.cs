namespace FACTURACION3._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelClienteNombre = new System.Windows.Forms.Label();
            this.labelNIT = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.labelCantidadProducto = new System.Windows.Forms.Label();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtValorProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValorProducto = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.chkGiftCard = new System.Windows.Forms.CheckBox();
            this.labelGiftCard = new System.Windows.Forms.Label();
            this.txtGiftCard = new System.Windows.Forms.TextBox();
            this.btnMostrarFactura = new System.Windows.Forms.Button();
            this.richTextBoxFactura = new System.Windows.Forms.RichTextBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReproducirVideo = new System.Windows.Forms.Button();
            this.btnReiniciarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(128, 11);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(190, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "SUPERMERCADO EL TILINAZO";
            // 
            // labelClienteNombre
            // 
            this.labelClienteNombre.AutoSize = true;
            this.labelClienteNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelClienteNombre.Location = new System.Drawing.Point(68, 34);
            this.labelClienteNombre.Name = "labelClienteNombre";
            this.labelClienteNombre.Size = new System.Drawing.Size(99, 13);
            this.labelClienteNombre.TabIndex = 1;
            this.labelClienteNombre.Text = "Nombre del Cliente:";
            // 
            // labelNIT
            // 
            this.labelNIT.AutoSize = true;
            this.labelNIT.BackColor = System.Drawing.Color.Transparent;
            this.labelNIT.Location = new System.Drawing.Point(139, 60);
            this.labelNIT.Name = "labelNIT";
            this.labelNIT.Size = new System.Drawing.Size(28, 13);
            this.labelNIT.TabIndex = 2;
            this.labelNIT.Text = "NIT:";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtClienteNombre.Location = new System.Drawing.Point(190, 27);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(133, 20);
            this.txtClienteNombre.TabIndex = 3;
            // 
            // labelCantidadProducto
            // 
            this.labelCantidadProducto.AutoSize = true;
            this.labelCantidadProducto.BackColor = System.Drawing.Color.Transparent;
            this.labelCantidadProducto.Location = new System.Drawing.Point(115, 112);
            this.labelCantidadProducto.Name = "labelCantidadProducto";
            this.labelCantidadProducto.Size = new System.Drawing.Size(52, 13);
            this.labelCantidadProducto.TabIndex = 4;
            this.labelCantidadProducto.Text = "Cantidad:";
            // 
            // txtNIT
            // 
            this.txtNIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNIT.Location = new System.Drawing.Point(190, 53);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(133, 20);
            this.txtNIT.TabIndex = 6;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombreProducto.Location = new System.Drawing.Point(190, 79);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(133, 20);
            this.txtNombreProducto.TabIndex = 7;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCantidadProducto.Location = new System.Drawing.Point(190, 105);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(133, 20);
            this.txtCantidadProducto.TabIndex = 8;
            // 
            // txtValorProducto
            // 
            this.txtValorProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtValorProducto.Location = new System.Drawing.Point(190, 131);
            this.txtValorProducto.Name = "txtValorProducto";
            this.txtValorProducto.Size = new System.Drawing.Size(133, 20);
            this.txtValorProducto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(57, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre del Producto:";
            // 
            // labelValorProducto
            // 
            this.labelValorProducto.AutoSize = true;
            this.labelValorProducto.BackColor = System.Drawing.Color.Transparent;
            this.labelValorProducto.Location = new System.Drawing.Point(133, 138);
            this.labelValorProducto.Name = "labelValorProducto";
            this.labelValorProducto.Size = new System.Drawing.Size(34, 13);
            this.labelValorProducto.TabIndex = 12;
            this.labelValorProducto.Text = "Valor:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarProducto.Location = new System.Drawing.Point(95, 157);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(119, 30);
            this.btnAgregarProducto.TabIndex = 13;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(60, 193);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(305, 122);
            this.dgvProductos.TabIndex = 14;
            // 
            // chkGiftCard
            // 
            this.chkGiftCard.AutoSize = true;
            this.chkGiftCard.BackColor = System.Drawing.Color.Transparent;
            this.chkGiftCard.Location = new System.Drawing.Point(170, 321);
            this.chkGiftCard.Name = "chkGiftCard";
            this.chkGiftCard.Size = new System.Drawing.Size(171, 17);
            this.chkGiftCard.TabIndex = 15;
            this.chkGiftCard.Text = "¿Tiene un código de gift card?";
            this.chkGiftCard.UseVisualStyleBackColor = false;
            // 
            // labelGiftCard
            // 
            this.labelGiftCard.AutoSize = true;
            this.labelGiftCard.BackColor = System.Drawing.Color.Transparent;
            this.labelGiftCard.Location = new System.Drawing.Point(68, 351);
            this.labelGiftCard.Name = "labelGiftCard";
            this.labelGiftCard.Size = new System.Drawing.Size(102, 13);
            this.labelGiftCard.TabIndex = 16;
            this.labelGiftCard.Text = "Código de Gift Card:";
            // 
            // txtGiftCard
            // 
            this.txtGiftCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGiftCard.Location = new System.Drawing.Point(190, 344);
            this.txtGiftCard.Name = "txtGiftCard";
            this.txtGiftCard.Size = new System.Drawing.Size(133, 20);
            this.txtGiftCard.TabIndex = 17;
            // 
            // btnMostrarFactura
            // 
            this.btnMostrarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMostrarFactura.Location = new System.Drawing.Point(160, 370);
            this.btnMostrarFactura.Name = "btnMostrarFactura";
            this.btnMostrarFactura.Size = new System.Drawing.Size(127, 33);
            this.btnMostrarFactura.TabIndex = 18;
            this.btnMostrarFactura.Text = "Mostrar Factura";
            this.btnMostrarFactura.UseVisualStyleBackColor = false;
            this.btnMostrarFactura.Click += new System.EventHandler(this.btnMostrarFactura_Click);
            // 
            // richTextBoxFactura
            // 
            this.richTextBoxFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxFactura.Location = new System.Drawing.Point(453, 8);
            this.richTextBoxFactura.Name = "richTextBoxFactura";
            this.richTextBoxFactura.Size = new System.Drawing.Size(335, 407);
            this.richTextBoxFactura.TabIndex = 19;
            this.richTextBoxFactura.Text = "";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarProducto.Location = new System.Drawing.Point(234, 157);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(119, 30);
            this.btnEliminarProducto.TabIndex = 20;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "©COPYRIGHT Sirocarv-Bueno17";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnReproducirVideo
            // 
            this.btnReproducirVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReproducirVideo.Location = new System.Drawing.Point(12, 381);
            this.btnReproducirVideo.Name = "btnReproducirVideo";
            this.btnReproducirVideo.Size = new System.Drawing.Size(109, 34);
            this.btnReproducirVideo.TabIndex = 22;
            this.btnReproducirVideo.Text = "Salir";
            this.btnReproducirVideo.UseVisualStyleBackColor = false;
            this.btnReproducirVideo.Click += new System.EventHandler(this.btnReproducirVideo_Click);
            // 
            // btnReiniciarFactura
            // 
            this.btnReiniciarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReiniciarFactura.Location = new System.Drawing.Point(320, 370);
            this.btnReiniciarFactura.Name = "btnReiniciarFactura";
            this.btnReiniciarFactura.Size = new System.Drawing.Size(127, 33);
            this.btnReiniciarFactura.TabIndex = 23;
            this.btnReiniciarFactura.Text = "Reiniciar Factura";
            this.btnReiniciarFactura.UseVisualStyleBackColor = false;
            this.btnReiniciarFactura.Click += new System.EventHandler(this.btnReiniciarFactura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FACTURACION3._0.Properties.Resources.Imagen_de_WhatsApp_2024_12_08_a_las_21_24_26_31ea5155;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReiniciarFactura);
            this.Controls.Add(this.btnReproducirVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.richTextBoxFactura);
            this.Controls.Add(this.btnMostrarFactura);
            this.Controls.Add(this.txtGiftCard);
            this.Controls.Add(this.labelGiftCard);
            this.Controls.Add(this.chkGiftCard);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.labelValorProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorProducto);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtNIT);
            this.Controls.Add(this.labelCantidadProducto);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.labelNIT);
            this.Controls.Add(this.labelClienteNombre);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL TILINAZO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelClienteNombre;
        private System.Windows.Forms.Label labelNIT;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label labelCantidadProducto;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.TextBox txtValorProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValorProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.CheckBox chkGiftCard;
        private System.Windows.Forms.Label labelGiftCard;
        private System.Windows.Forms.TextBox txtGiftCard;
        private System.Windows.Forms.Button btnMostrarFactura;
        private System.Windows.Forms.RichTextBox richTextBoxFactura;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReproducirVideo;
        private System.Windows.Forms.Button btnReiniciarFactura;
    }
}

