using ClasesCarniceria;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace formularios
{
    public partial class FrmElegirProducto : Form
    {
        private decimal monto;
        private string mail;
        public FrmElegirProducto()
        {
            InitializeComponent();
        }

        public FrmElegirProducto(decimal monto, string mail) : this()
        {
            this.monto = monto;
            this.mail = mail;
        }

        private void ConfigurarListaProductos()
        {
            this.lsb_listaProductos.Items.Clear();
            foreach (var item in Carniceria.listaProductos)
            {
                if (item.CantidadKilos > 0) 
                {
                    this.lsb_listaProductos.Items.Add(item.TipoDeCorte);
                }
                
            }
        }

        private void ConfiguracionComboBoxPagos()
        {
            foreach (FormasDePago item in Enum.GetValues(typeof(FormasDePago)))
            {
                this.cb_formasDePago.Items.Add(item);
            }
        }

        private void rellenarTitulo(decimal monto, string mail)
        {
            this.lb_montoActual.Text = $"El monto de {this.mail} es: ${this.monto}";
        }

        private void ActualizarMontoCliente(Cliente c)
        {
            if (c != null)
            {
                c.CantidadDinero = this.monto;
            }
        }

        private void FrmElegirProducto_Load_1(object sender, EventArgs e)
        {

            this.ConfigurarListaProductos();
            this.ConfiguracionComboBoxPagos();
            this.rellenarTitulo(this.monto, this.mail);

        }

        private void btn_buscadorProductos_Click(object sender, EventArgs e)
        {
            if (this.txb_buscadorProductos.Text is not null)
            {
                string nombreBuscado = txb_buscadorProductos.Text;
                int indiceEncontrado = lsb_listaProductos.FindString(nombreBuscado);

                if (indiceEncontrado != ListBox.NoMatches)
                {
                    // Aca lo que hago es fijar en la lista el elemento encontrado.
                    lsb_listaProductos.SetSelected(indiceEncontrado, true);
                    Carne c = Carniceria.listaProductos[indiceEncontrado];
                    this.txb_detalles.Text = c.MostrarDetalles();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún nombre que coincida con la búsqueda.");
                }
            }
            else
            {
                MessageBox.Show("Error: Debes escribir algo en el buscador.");
            }
        }

        private decimal ValidarPuedePagar(Cliente c, decimal precio, FormasDePago forma)
        {
            decimal precioAux;
            decimal recarga;

            if (forma == FormasDePago.TarjetaCredito)
            {
                recarga = precio * 5 / 100;
                precioAux = recarga + precio;
                if (precioAux <= c.CantidadDinero)
                {
                    return precioAux;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (precio <= c.CantidadDinero)
                {
                    return precio;
                }
                else
                {
                    return -1;
                }
            }

        }


        private void btn_comprar_Click(object sender, EventArgs e)
        {

            if (lsb_listaProductos.SelectedItem is not null)
            {

                string tipoCorte = this.lsb_listaProductos.SelectedItem.ToString();
                Carne carneSelec = Carniceria.BuscarCarnePorCorte(tipoCorte);

                Vendedor v = new Vendedor();
                Cliente clienteSelec = v.BuscarClientePorMail(this.mail);
                // Los clientes traen un valor por defecto que debe ser modificado por el monto que ingreso el usuario. 
                this.ActualizarMontoCliente(clienteSelec);

                if (carneSelec != null && clienteSelec != null)
                {
                    int cantidadkilos = (int)this.nud_cantidadKilos.Value;

                    if (cantidadkilos != -1 && cantidadkilos <= carneSelec.CantidadKilos && cantidadkilos != 0)
                    {
                        decimal precio = carneSelec.PrecioPorKilo * cantidadkilos;

                        if (cb_formasDePago.SelectedItem != null)
                        {
                            FormasDePago forma = (FormasDePago)Enum.Parse(typeof(FormasDePago), cb_formasDePago.SelectedItem.ToString());

                            decimal res = this.ValidarPuedePagar(clienteSelec, precio, forma);
                            if (res >= 0)
                            {
                                FrmFactura form = new FrmFactura(forma, tipoCorte, cantidadkilos, carneSelec.PrecioPorKilo, res);
                                DialogResult resForm = form.ShowDialog();
                                if (resForm == DialogResult.OK)
                                {
                                    // actualizo informacion en programa.
                                    carneSelec.CantidadKilos -= cantidadkilos;
                                    clienteSelec.CantidadDinero -= res;
                                    this.monto -= res;
                                    // actualizo informacion en pantalla.
                                    this.rellenarTitulo(this.monto, this.mail);
                                    this.txb_detalles.Text = carneSelec.MostrarDetalles();
                                    this.ConfigurarListaProductos();
                                }
                            }
                            else { MessageBox.Show("Error: El precio supera el monto del usuario."); }
                        }
                        else { MessageBox.Show("Error: Tenes que seleccionar un tipo de pago."); }
                    }
                    else { MessageBox.Show("Error: La cantidad de kilos no puede ser 0 o mayor a la cantidad fijada."); }
                }
            }
            else { MessageBox.Show("Error: Tenes que seleccionar un producto."); }
        }


        private void btn_detallar_Click(object sender, EventArgs e)
        {
            string corteCarne = this.lsb_listaProductos.SelectedItem.ToString();
            Carne c = Carniceria.BuscarCarnePorCorte(corteCarne);
            if (c != null)
            {
                this.txb_detalles.Text = c.MostrarDetalles();
            }
        }
    }
}