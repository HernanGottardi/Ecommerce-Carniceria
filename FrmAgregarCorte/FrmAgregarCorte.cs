using ClasesCarniceria;

namespace formularios
{
    public partial class FrmAgregarCorte : Form
    {
        private string nuevoCorte;
        public FrmAgregarCorte()
        {
            InitializeComponent();
        }

        public string DevolverNuevoCorte()
        {
            return this.nuevoCorte;
        }

        private void btn_aceptar_Click_1(object sender, EventArgs e)
        {
            this.nuevoCorte = this.txb_agregarCorteNuevo.Text;
            if (!string.IsNullOrEmpty(nuevoCorte))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}