using ClasesCarniceria;

namespace formularios
{
    public partial class FrmFactura : Form
    {
        private string corteDeCarne;
        private int cantidadKilos;
        private decimal precioKilo;
        private decimal precioFinal;
        private FormasDePago forma;
        private Cliente cliente;
        private Carne carne;
        public FrmFactura()
        {
            InitializeComponent();
        }

        public FrmFactura(FormasDePago forma, string corteDeCarne, int cantidadKilos, decimal precioKilo, decimal precioFinal) : this()
        {
            this.corteDeCarne = corteDeCarne;
            this.cantidadKilos = cantidadKilos;
            this.precioKilo = precioKilo;
            this.precioFinal = precioFinal;
            this.forma = forma;
            this.cliente = cliente;
            this.carne = carne;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            this.txb_nombreKilos.Text = $"{this.corteDeCarne} -------- {this.cantidadKilos}Kg X ${this.precioKilo}";
            this.txb_formaDePago.Text = $"Forma de Pago: {this.forma}";
            this.txb_precioFinal.Text = $"TOTAL: ${this.precioFinal}";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_confirmar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}