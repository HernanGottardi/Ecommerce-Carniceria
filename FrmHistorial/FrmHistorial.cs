namespace formularios
{
    using ClasesCarniceria;
    using System.Windows.Forms;

    public partial class FrmHistorial : Form
    {

        private List<Factura> listaFacturas;
        public FrmHistorial()
        {
            InitializeComponent();
        }

        public FrmHistorial(List<Factura> lista) : this()
        {
            this.listaFacturas = lista;
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {

            this.dgv_facturaciones.AutoGenerateColumns = false;
            this.dgv_facturaciones.ColumnCount = 5;

            this.dgv_facturaciones.Columns[0].Name = "MailCliente";
            this.dgv_facturaciones.Columns[1].Name = "CorteDeCarne";
            this.dgv_facturaciones.Columns[2].Name = "CantidadDeKilos";
            this.dgv_facturaciones.Columns[3].Name = "PrecioPorKilo";
            this.dgv_facturaciones.Columns[4].Name = "PrecioFinal";

            this.dgv_facturaciones.DataSource = listaFacturas;

            dgv_facturaciones.Columns["MailCliente"].DataPropertyName = "MailCliente";
            dgv_facturaciones.Columns["CorteDeCarne"].DataPropertyName = "CorteDeCarne";
            dgv_facturaciones.Columns["CantidadDeKilos"].DataPropertyName = "CantidadDeKilos";
            dgv_facturaciones.Columns["PrecioPorKilo"].DataPropertyName = "PrecioPorKilo";
            dgv_facturaciones.Columns["PrecioFinal"].DataPropertyName = "PrecioFinal";


        }
    }
}