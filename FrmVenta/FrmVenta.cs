using formulario;
using formularios;

namespace formulario
{
    public partial class FrmVenta : Form
    {

        public string email;

        public FrmVenta()
        {
            InitializeComponent();
            this.lb_saludo.Text = $"Hola Cliente!";
        }

        public FrmVenta(string email) : this()
        {
            this.email = email;
        }

        public void SaludarCliente()
        {
            this.lb_saludo.Text = $"Hola {this.email}!";
        }


        private void bt_enviarMonto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tx_saldo.Text))
            {
                string saldoStr = this.tx_saldo.Text;
                bool resp = decimal.TryParse(saldoStr, out decimal saldoDec);

                if (resp == true)
                {
                    FrmElegirProducto form = new FrmElegirProducto(saldoDec, this.email);
                    form.Show();
                    this.Hide();
                }
            }
        }
    }
}