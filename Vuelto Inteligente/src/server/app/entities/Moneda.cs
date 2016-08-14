using System;

namespace VueltoInteligente.Server.Application.Entities
{
    public class Moneda
    {
        public Moneda(int valor)
        {
            if (valor == 0)
            {
                throw new ArgumentOutOfRangeException("valor", valor, "No se puede crear una moneda con valor cero.");
            }

            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("valor", valor, "No se puede crear una moneda con valor negativo.");
            }

            Valor = valor;
        }

        public int Valor { get; internal set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var moneda = obj as Moneda;

            return Valor == moneda.Valor;
        }
    }
}