
using ClasesCarniceria;
using System.Diagnostics.Eventing.Reader;

namespace formularios
{
    public partial class FrmModificarCorte : Form
    {
        public FrmModificarCorte()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lsb_listaDeCortes.Items.Clear();
            foreach (var item in Carniceria.tiposCortes)
            {
                this.lsb_listaDeCortes.Items.Add(item);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (this.lsb_listaDeCortes.SelectedItem != null)
            {
                string corteSelec = this.lsb_listaDeCortes.SelectedItem.ToString();
                int indexCorteSelec = Carniceria.IndexCorteCarne(corteSelec);

                // modifico.
                if (!(string.IsNullOrEmpty(txb_nuevoNombre.Text)))
                {
                    Carniceria.tiposCortes[indexCorteSelec] = this.txb_nuevoNombre.Text;
                    this.DialogResult = DialogResult.OK;
                } else { MessageBox.Show("Error: Falto ingresar un nuevo nombre para el corte seleccionado."); }
            } else { MessageBox.Show("Error: No seleccionaste un corte de carne."); }
        }   

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}