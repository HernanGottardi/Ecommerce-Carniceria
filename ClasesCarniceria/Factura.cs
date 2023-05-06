using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public class Factura
    {
        public string mailCliente;
        public int cantidadDeKilos;
        public decimal precioFinal;
        public string corteDeCarne;
        public decimal precioPorKilo;

        public string MailCliente { get => mailCliente; set => mailCliente = value; }
        public int CantidadDeKilos { get => cantidadDeKilos; set => cantidadDeKilos = value; }
        public decimal PrecioFinal { get => precioFinal; set => precioFinal = value; }
        public string CorteDeCarne { get => corteDeCarne; set => corteDeCarne = value; }
        public decimal PrecioPorKilo { get => precioPorKilo; set => precioPorKilo = value; }

        public Factura(string mail, int cantidadKilos, decimal precioPorKilo, decimal precio, string corteDeCarne)
        {
            this.MailCliente = mail;
            this.CantidadDeKilos = cantidadKilos;
            this.precioPorKilo = precioPorKilo;
            this.PrecioFinal = precio;
            this.CorteDeCarne = corteDeCarne;
        }
    }
}
