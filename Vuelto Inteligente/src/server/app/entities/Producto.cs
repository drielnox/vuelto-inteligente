using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VueltoInteligente.Server.Application.Entities
{
    public class Producto
    {
        private string v;

        public Producto(string v)
        {
            if (v == null)
            {
                throw new ArgumentNullException("v", "No se puede crear un producto con descripcion nula.");
            }

            if (string.IsNullOrWhiteSpace(v))
            {
                throw new ArgumentException("No se puede crear un producto sin descripcion.", "v");
            }

            this.v = v;
        }
    }
}