using System;
using System.Collections.Generic;

namespace VueltoInteligente.Server.Application.Entities
{
    public class Caja
    {
        private IList<Moneda> _monedas;

        public Caja()
        {
            _monedas = new List<Moneda>();
        }

        public void AgregarMoneda(Moneda moneda)
        {
            _monedas.Add(moneda);
        }

        public Moneda ObtenerMoneda(Moneda moneda)
        {
            var indice = _monedas.IndexOf(moneda);

            return _monedas[indice];
        }

        public IEnumerable<Moneda> ObtenerMonedas()
        {
            return _monedas;
        }
    }
}