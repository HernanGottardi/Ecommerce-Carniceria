using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public abstract class Usuario
    {
        public abstract string Contraseña 
        {
            get;
            set; 
        }
        public abstract string Mail 
        {
            get;
            set; 
        }

        public virtual string Detallar()
        {
            return "Hola, soy un Usuario";
        }

    }
}
