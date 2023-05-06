using ClasesCarniceria;

namespace formularios
{
    public partial class FrmQuitarCorte : Form
    {
        public FrmQuitarCorte()
        {
            InitializeComponent();
        }

        private void FrmQuitarCorte_Load(object sender, EventArgs e)
        {
            // Cargamos cortes de carne.
            this.lsb_listaDeCortes.Items.Clear();
            foreach (var item in Carniceria.tiposCortes)
            {
                this.lsb_listaDeCortes.Items.Add(item);
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (this.lsb_listaDeCortes.SelectedItem is not null)
            {
                string corteSelec = this.lsb_listaDeCortes.SelectedItem.ToString();

                int indexCorteSelec = Carniceria.IndexCorteCarne(corteSelec);
                if (indexCorteSelec != -1)
                {
                    Carniceria.tiposCortes.RemoveAt(indexCorteSelec);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}