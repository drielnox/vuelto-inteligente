﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VueltoInteligente.Server.Application.Entities;

namespace VueltoInteligente.Test.Server.Application.Entities
{
    /// <summary>
    /// Descripción resumida de ProductoPrueba
    /// </summary>
    [TestClass]
    public class ProductoPrueba
    {
        public ProductoPrueba()
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
        public void PuedoCrearUnProducto()
        {
            var producto = new Producto("Manzana");

            Assert.IsNotNull(producto);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NoPuedoCrearUnProductoConDescripcionVacia()
        {
            var producto = new Producto(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NoPuedoCrearUnProductoConDescripcionNula()
        {
            var producto = new Producto(null);
        }
    }
}
