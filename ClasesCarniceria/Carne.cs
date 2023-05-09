using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public class Carne
    {
        private int cantidadKilos;
        private string tipoDeCorte;
        private decimal precioPorKilo;

        public int CantidadKilos { get => cantidadKilos; set => cantidadKilos = value; }
        public string TipoDeCorte { get => tipoDeCorte; set => tipoDeCorte = value; }
        public decimal PrecioPorKilo { get => precioPorKilo; set => precioPorKilo = value; }

        public Carne(int cantidadKilos, string tipoDeCorte, decimal precioPorKilo)
        {
            this.cantidadKilos = cantidadKilos;
            this.tipoDeCorte = tipoDeCorte;
            this.PrecioPorKilo = precioPorKilo;
        }

        /// <summary>
        /// Convertir cada atributo del objeto, en un string.
        /// </summary>
        /// <returns> 
        /// cadena de texto que representa las caracteristicas 
        /// del objeto instanciado del tipo Carne.
        /// </returns>
        public string MostrarDetalles() 
        { 
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Carne: {this.tipoDeCorte}");
            sb.AppendLine($"cantidad de kilos: {this.cantidadKilos}");
            sb.AppendLine($"Precio por kilo: ${this.precioPorKilo}");

            return sb.ToString();
        }
    }
}
