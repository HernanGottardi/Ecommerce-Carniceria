
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System;

using ClasesCarniceria;
using formulario;

namespace FrmLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Evento: Boton automatico para CLIENTE.       
        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            // Relleno los datos para cliente con datos que se que existe.
            this.txb_mail.Text = "hernan@gmail.com";
            this.txb_contraseña.Text = "1234";
        }
        // Evento: Boton automatico para VENDEDOR.
        private void btn_Vendedor_Click(object sender, EventArgs e)
        {
            // Relleno los datos para vendedor con datos que se que existe.
            this.txb_mail.Text = "messi@gmail.com";
            this.txb_contraseña.Text = "1234";
        }

        // Evento: Boton para ingreso manual tanto de Cliente como de Vendedor. Puede ser cualquiera de los dos.
        private void btn_ingresoManual_Click(object sender, EventArgs e)
        {
            // Informacion capturada en el formulario.
            string mail = this.txb_mail.Text;
            string contraseña = this.txb_contraseña.Text;

            Cliente cliente = new Cliente(mail, contraseña);
            Vendedor vendedor = new Vendedor(mail, contraseña);

            // Pregunto si el cliente esta dentro de la lista de clientes del vendedor.
            if (cliente == vendedor)
            {
                // Oculto el formulario Login.
                this.Hide();
                // Invoco y muestro el formulario Venta.
                FrmVenta paginaVenta = new FrmVenta(mail);
                paginaVenta.Show(this);

                // Muestro en pantalla del nuevo formulario el saludo.
                paginaVenta.SaludarCliente();
            }
            else
            {
                if (vendedor.validarVendedorExiste(vendedor))
                {
                    // Oculto el formulario Login.
                    this.Hide();
                    // Invoco y muestro el formulario Heladera.
                    FrmHeladera paginaHeladera = new FrmHeladera(mail);
                    paginaHeladera.Show(this);
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no se reconocen.\nVuelva a intentarlo.", "Error al ingresar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}