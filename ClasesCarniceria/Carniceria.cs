using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{

    public static class Carniceria
    {   
        public static List<string> tiposCortes = new List<string> 
        { 
            "Lomo", 
            "Tira de asado", 
            "Bife ancho", 
            "Falda", 
            "Cola de Cuadril"
        };
       
        public static List<Vendedor> listaVendedores = new List<Vendedor>
            {
                new Vendedor("messi@gmail.com", "1234"),
                new Vendedor("dibu@gmail.com", "4321"),
                new Vendedor("kun@gmail.com", "1111"),
            };

        public static List<Carne> listaProductos = new List<Carne>
            {
                new Carne(10, tiposCortes[0], 100),
                new Carne(11, tiposCortes[1], 200),
                new Carne(30, tiposCortes[2], 300),
                new Carne(5, tiposCortes[3], 350),
                new Carne(5, tiposCortes[4], 450)
            };

        public static int IndexCarne(string tipoCorte)
        {
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].TipoDeCorte == tipoCorte)
                {
                    return i;
                }
            }
            return -1;
        }

        public static Carne BuscarCarnePorCorte(string corte)
        {

            int indexProducto = Carniceria.IndexCarne(corte);
            if (indexProducto != -1)
            {
                Carne c = Carniceria.listaProductos[indexProducto];
                return c;
            }
            else
            {
                return null;
            }
        }

        public static int IndexCorteCarne(string tipoCorte) 
        {
            for (int i = 0; i < tiposCortes.Count; i++)
            {
                if (tiposCortes[i] == tipoCorte) 
                {
                    return i;
                }
            }
            return -1;
        }
      
    }   
}
