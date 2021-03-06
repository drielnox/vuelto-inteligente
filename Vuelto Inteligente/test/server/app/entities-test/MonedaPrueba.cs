﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VueltoInteligente.Server.Application.Entities;

namespace VueltoInteligente.Test.Server.Application.Entities
{
    /// <summary>
    /// Descripción resumida de MonedaPrueba
    /// </summary>
    [TestClass]
    public class MonedaPrueba
    {
        public MonedaPrueba()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        /// Obtiene o establece el contexto de las pruebas que proporciona
        /// información y funcionalidad para la serie de pruebas actual.
        /// </summary>
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
        public void SePuedaCrearUnaMonedaConValor()
        {
            var moneda = new Moneda(10);

            Assert.IsNotNull(moneda);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NoSePuedeCrearUnaMonedaConValorNegativo()
        {
            var moneda = new Moneda(-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NoSePuedaCrearUnaMonedaConValorCero()
        {
            var moneda = new Moneda(0);
        }

        [TestMethod]
        public void UnaMonedaConValorDiezEsIgualAOtraMonedaConValorDiez()
        {
            var moneda1 = new Moneda(10);
            var moneda2 = new Moneda(10);

            Assert.AreEqual(moneda1, moneda2);
        }
        
        [TestMethod]
        public void UnaMonedaConValorDiezNoEsIgualAAlgoNulo()
        {
            var moneda = new Moneda(10);

            var isEqual = moneda.Equals(null);

            Assert.IsFalse(isEqual);
        }
    }
}
