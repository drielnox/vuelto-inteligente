using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VueltoInteligente.Server.Application.Entities
{
    public class Moneda
    {
        private int v;

        public Moneda(int v)
        {
            if (v == 0)
            {
                throw new ArgumentOutOfRangeException("v", v, "No se puede crear una moneda con valor cero.");
            }

            if (v < 0)
            {
                throw new ArgumentOutOfRangeException("v", v, "No se puede crear una moneda con valor negativo.");
            }

            this.v = v;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var moneda = obj as Moneda;

            return v == moneda.v;
        }
    }
}