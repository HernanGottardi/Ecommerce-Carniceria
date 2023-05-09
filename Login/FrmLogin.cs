
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System;

using ClasesCarniceria;
using formularios;



namespace formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Rellenar los campos para entrar como cliente.
        /// </summary>
        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            // Relleno los datos para cliente con datos que se que existe.
            this.txb_mail.Text = "hernan@gmail.com";
            this.txb_contraseña.Text = "1234";
        }
      
        /// <summary>
        /// Rellenar los campos para entrar como vendedor.
        /// </summary>
        private void btn_Vendedor_Click(object sender, EventArgs e)
        {
            // Relleno los datos para vendedor con datos que se que existe.
            this.txb_mail.Text = "messi@gmail.com";
            this.txb_contraseña.Text = "1234";
        }

        /// <summary>
        /// Boton usado, una vez los datos de los campos son completados. 
        /// Verificando que tipo de usuario es.
        /// </summary>
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
                // Invoco y muestro el formulario Venta.
                FrmVenta paginaVenta = new FrmVenta(mail);
                paginaVenta.Show();
                // Oculto el formulario Login.
                this.Hide();
            }
            else
            {
                if (vendedor.validarVendedorExiste(vendedor))
                {
                    // Invoco y muestro el formulario Heladera.
                    FrmHeladera paginaHeladera = new FrmHeladera(mail);
                    paginaHeladera.Show(this);
                    // Oculto el formulario Login.
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no se reconocen.\nVuelva a intentarlo.", "Error al ingresar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}