using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VueltoInteligente.Server.Application.Entities;

namespace VueltoInteligente.Test.Server.Application.Entities
{
    /// <summary>
    /// Descripción resumida de CajaPrueba
    /// </summary>
    [TestClass]
    public class CajaPrueba
    {
        public CajaPrueba()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PuedoCrearUnaCajaSinMonedas()
        {
            var caja = new Caja();

            Assert.IsNotNull(caja);
        }

        [TestMethod]
        public void PuedoAgregarUnaMonedaAUnaCaja()
        {
            var caja = new Caja();
            var moneda = new Moneda(10);

            caja.AgregarMoneda(moneda);

            Assert.IsNotNull(caja.ObtenerMoneda(moneda));
            Assert.IsTrue(caja.ObtenerMonedas().Count() == 1);
        }

        [TestMethod]
        public void PuedoAgregarVariasMonedasDelMismoValorAUnaCaja()
        {
            var caja = new Caja();
            var moneda1 = new Moneda(10);
            var moneda2 = new Moneda(10);
            var moneda3 = new Moneda(10);

            caja.AgregarMoneda(moneda1);
            caja.AgregarMoneda(moneda2);
            caja.AgregarMoneda(moneda3);

            Assert.IsNotNull(caja.ObtenerMoneda(moneda1));
            Assert.IsNotNull(caja.ObtenerMoneda(moneda2));
            Assert.IsNotNull(caja.ObtenerMoneda(moneda3));

            Assert.IsTrue(caja.ObtenerMonedas().Count() == 3);
        }

        [TestMethod]
        public void PuedoAgregarVariasMonedasDeDiferentesValoresAUnaCaja()
        {
            var caja = new Caja();
            var moneda1 = new Moneda(10);
            var moneda2 = new Moneda(25);
            var moneda3 = new Moneda(50);

            caja.AgregarMoneda(moneda1);
            caja.AgregarMoneda(moneda2);
            caja.AgregarMoneda(moneda3);

            Assert.IsNotNull(caja.ObtenerMoneda(moneda1));
            Assert.IsNotNull(caja.ObtenerMoneda(moneda2));
            Assert.IsNotNull(caja.ObtenerMoneda(moneda3));

            Assert.IsTrue(caja.ObtenerMonedas().Count() == 3);
        }
    }
}
