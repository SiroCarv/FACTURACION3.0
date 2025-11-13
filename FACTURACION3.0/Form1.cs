using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURACION3._0
{
    public partial class Form1 : Form
    {
        private Factura factura;

        public Form1()
        {
            InitializeComponent();
            factura = new Factura();
            ConfigurarEventosTextBox();
        }

        private void ConfigurarEventosTextBox()
        {
            txtNombreProducto.KeyPress += new KeyPressEventHandler(SaltarAlSiguienteTextBox);
            txtCantidadProducto.KeyPress += new KeyPressEventHandler(SaltarAlSiguienteTextBox);
            txtValorProducto.KeyPress += new KeyPressEventHandler(SaltarAlSiguienteTextBox);
            txtClienteNombre.KeyPress += new KeyPressEventHandler(SaltarAlSiguienteTextBox);
            txtNIT.KeyPress += new KeyPressEventHandler(SaltarAlSiguienteTextBox);

            txtNombreProducto.KeyPress += new KeyPressEventHandler(SoloLetras);
            txtClienteNombre.KeyPress += new KeyPressEventHandler(SoloLetras);

            txtCantidadProducto.KeyPress += new KeyPressEventHandler(SoloNumeros);
            txtValorProducto.KeyPress += new KeyPressEventHandler(SoloNumeros);
            txtNIT.KeyPress += new KeyPressEventHandler(SoloNumeros);
        }


        private void SaltarAlSiguienteTextBox(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Cantidad", DataPropertyName = "Cantidad" });
            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Valor", DataPropertyName = "Valor" });
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto
            {
                Nombre = txtNombreProducto.Text,
                Cantidad = int.Parse(txtCantidadProducto.Text),
                Valor = decimal.Parse(txtValorProducto.Text)
            };

            factura.AgregarProducto(producto);
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = factura.Productos;
            LimpiarCamposProducto();
        }

        private void btnMostrarFactura_Click(object sender, EventArgs e)
        {
            factura.ClienteNombre = txtClienteNombre.Text;
            factura.NIT = txtNIT.Text;
            factura.GiftCard = chkGiftCard.Checked ? txtGiftCard.Text : null;

            decimal descuento;
            decimal total = factura.CalcularTotal(out descuento);

            richTextBoxFactura.Text = GenerarFacturaTexto(factura, descuento, total);
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                Producto producto = (Producto)dgvProductos.SelectedRows[0].DataBoundItem;
                factura.EliminarProducto(producto);
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = factura.Productos;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para eliminar.");
            }
        }

        private void LimpiarCamposProducto()
        {
            txtNombreProducto.Clear();
            txtCantidadProducto.Clear();
            txtValorProducto.Clear();
        }

        private string GenerarFacturaTexto(Factura factura, decimal descuento, decimal total)
        {
            string facturaTexto = string.Format("====================================================\n" +
                      "                          SUPERMERCADO EL TILINAZO\n" +
                      "       Av. Principal Santos Dumont, Ciudad Santa Cruz de la Sierra\n" +
                      "                          Tel: 7934-hol-448\n" +
                      "====================================================\n" +
                      "Cliente: {0}\n" +
                      "NIT: {1}\n" +
                      "Fecha: {2:dd/MM/yyyy hh:mm:ss tt}\n" +
                      "====================================================\n" +
                      "CANT  P.UNIT  DETALLE                    SUBTOTAL\n" +
                      "{3}\n" +
                      "====================================================\n" +
                      "DESCUENTO (GIFT CARD):              -Bs{4:N2}\n" +
                      "TOTAL A PAGAR:                        Bs{5:N2}\n" +
                      "====================================================\n" +
                      "Gracias por su compra. ¡Vuelva pronto!",
                      factura.ClienteNombre,
                      factura.NIT,
                      DateTime.Now,
                      string.Join("\n", factura.Productos.Select(p => $"{p.Cantidad}  Bs{p.Valor:N2}  {p.Nombre}                      Bs{p.Cantidad * p.Valor:N2}")),
                      descuento,
                      total);

            return facturaTexto;
        }

        public class Producto
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public decimal Valor { get; set; }
        }

        public class Factura
        {
            public string ClienteNombre { get; set; }
            public string NIT { get; set; }
            public List<Producto> Productos { get; set; } = new List<Producto>();
            public string GiftCard { get; set; }
            private const decimal DescuentoGiftCard = 0.30m;

            public void AgregarProducto(Producto producto)
            {
                Productos.Add(producto);
            }

            public void EliminarProducto(Producto producto)
            {
                Productos.Remove(producto);
            }

            public decimal CalcularTotal(out decimal descuento)
            {
                decimal total = Productos.Sum(p => p.Cantidad * p.Valor);
                descuento = string.IsNullOrEmpty(GiftCard) ? 0 : total * DescuentoGiftCard;
                return total - descuento;
            }
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReproducirVideo_Click(object sender, EventArgs e)
        {
            string videoPath = @"D:\1er SEMESTRE UNIFRANZ\PROGRAMACIÓN 1\HITO 5\FACTU PROYECTO FINAL HITO5\12çFACTURACION3.0O\ArquiJuve.mp4";

            if (System.IO.File.Exists(videoPath))
            {
                var process = new System.Diagnostics.Process
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = videoPath,
                        UseShellExecute = true
                    }
                };

                process.Start();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("El archivo de video no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReiniciarFactura_Click(object sender, EventArgs e)
        {
            factura = new Factura();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = factura.Productos;
            LimpiarCamposProducto();
            txtClienteNombre.Clear();
            txtNIT.Clear();
            txtGiftCard.Clear();
            chkGiftCard.Checked = false;
            richTextBoxFactura.Clear();
        }
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
