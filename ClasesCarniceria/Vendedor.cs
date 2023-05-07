using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using ClasesCarniceria;

namespace ClasesCarniceria
{
    public class Vendedor: Usuario
    {
        private string mail;
        private string contraseña;

        List<Cliente> listaClientes;

        public List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }
        public override string Mail { get => mail; set => mail = value; }
        public override string Contraseña { get => contraseña; set => contraseña = value; }
        
        public Vendedor()
        {
            this.HarcodearClientes();
        }

        public Vendedor(string mail, string contraseña) : this()
        { 
            this.mail = mail;
            this.contraseña = contraseña;
        }

        private void HarcodearClientes() 
        {
            ListaClientes = new List<Cliente> 
            { 
                new Cliente("hernan@gmail.com", "1234", 3000),
                new Cliente("rodrigo@gmail.com", "4321", 4000),
                new Cliente("nora@gmail.com", "1111", 5000),
            };
        }

        // Harcodeo la lista para que los datos del usuario tengan con que compararse.
        // Comprobacion de si un input VENDEDOR existe o no.
        public bool validarVendedorExiste(Vendedor v)
        {
            foreach (var vendedor in Carniceria.listaVendedores)
            {
                if (vendedor.Mail == v.Mail && vendedor.Contraseña == v.Contraseña)
                {
                    return true;
                }
            }
            return false;
        }

        public void FijarPrecioPorkilo(Carne producto, decimal precio) 
        {
            producto.PrecioPorKilo = precio;
        }

        public void ReponerProducto(Carne producto, int kilos)
        {
            producto.CantidadKilos = kilos;
        }

        public void CambiarTipoDeCarne(Carne producto, string tipo)
        {
            producto.TipoDeCorte = tipo;
        }

        public string MostrarClientes() 
        {
            List<string> mailClientes = new List<string>();

            for (int i = 0; i < listaClientes.Count; i++)
            {
                string nombre = listaClientes[i].Mail;
                mailClientes.Add(nombre);               
            }
            string mails = string.Join(", ", mailClientes);
            return mails;
        }

        public Cliente MostarCliente(int index)
        { 
            return listaClientes[index];
        }

        public int IndexCliente(string mail) 
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Mail == mail) 
                {
                    return i;
                }
            }
            return -1;
        }

        public Cliente BuscarClientePorMail(string mail)
        {
            int indexCliente = this.IndexCliente(mail);
            if (indexCliente != -1)
            {
                Cliente clienteSelec = this.ListaClientes[indexCliente];
                return clienteSelec;
            }
            else 
            {
                return null;
            }     
        }

        public override string Detallar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Vendedor: ");
            sb.AppendLine($"Mail: {this.Mail}");
            sb.AppendLine($"Lista de clientes: {this.MostrarClientes()}");

            return sb.ToString();
        }
        public static bool operator ==(Cliente c, Vendedor vendedor)
        {
            foreach (var cliente in vendedor.ListaClientes)
            {
                if (cliente.Mail == c.Mail && cliente.Contraseña == c.Contraseña)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Cliente c, Vendedor vendedor)
        {
            return !(c == vendedor);
        }
    }
    
}
