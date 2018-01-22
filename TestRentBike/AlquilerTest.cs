using fmrent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestRentBike
{
    
    
    /// <summary>
    ///This is a test class for AlquilerTest and is intended
    ///to contain all AlquilerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AlquilerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for calcularPrecio por hora
        ///</summary>
        [TestMethod()]
        public void calcularPrecioTest1()
        {
            Alquiler target = new Alquiler(); // TODO: Initialize to an appropriate value
            DateTime fechaAlquiler = new DateTime(2018,01,22); // TODO: Initialize to an appropriate value
            string horaAlquiler = "12";// TODO: Initialize to an appropriate value
            string minutoAlquiler = "30"; // TODO: Initialize to an appropriate value
            DateTime fechaDevolucion = new DateTime(2018, 01, 22); // TODO: Initialize to an appropriate value
            string horaDevolcuion = "13"; // TODO: Initialize to an appropriate value
            string minutoDevolucion = "30";// TODO: Initialize to an appropriate value
            int expected = 5; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.calcularPrecio(fechaAlquiler, horaAlquiler, minutoAlquiler, fechaDevolucion, horaDevolcuion, minutoDevolucion);
            Assert.AreEqual(expected, actual);
           
        }
        /// <summary>
        ///A test for calcularPrecio por dia
        ///</summary>
        [TestMethod()]
        public void calcularPrecioTest2()
        {
            Alquiler target = new Alquiler(); // TODO: Initialize to an appropriate value
            DateTime fechaAlquiler = new DateTime(2018, 01, 22); // TODO: Initialize to an appropriate value
            string horaAlquiler = "12";// TODO: Initialize to an appropriate value
            string minutoAlquiler = "30"; // TODO: Initialize to an appropriate value
            DateTime fechaDevolucion = new DateTime(2018, 01, 23); // TODO: Initialize to an appropriate value
            string horaDevolcuion = "13"; // TODO: Initialize to an appropriate value
            string minutoDevolucion = "30";// TODO: Initialize to an appropriate value
            int expected = 20; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.calcularPrecio(fechaAlquiler, horaAlquiler, minutoAlquiler, fechaDevolucion, horaDevolcuion, minutoDevolucion);
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        ///A test for calcularPrecio por semana
        ///</summary>
        [TestMethod()]
        public void calcularPrecioTest3()
        {
            Alquiler target = new Alquiler(); // TODO: Initialize to an appropriate value
            DateTime fechaAlquiler = new DateTime(2018, 01, 22); // TODO: Initialize to an appropriate value
            string horaAlquiler = "12";// TODO: Initialize to an appropriate value
            string minutoAlquiler = "30"; // TODO: Initialize to an appropriate value
            DateTime fechaDevolucion = new DateTime(2018, 01, 29); // TODO: Initialize to an appropriate value
            string horaDevolcuion = "13"; // TODO: Initialize to an appropriate value
            string minutoDevolucion = "30";// TODO: Initialize to an appropriate value
            int expected = 60; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.calcularPrecio(fechaAlquiler, horaAlquiler, minutoAlquiler, fechaDevolucion, horaDevolcuion, minutoDevolucion);
            Assert.AreEqual(expected, actual);

        }
      
        /// <summary>
        ///A test for calcularPrecio_rentafamiliar
        ///</summary>
        [TestMethod()]
        public void calcularPrecio_rentafamiliarTest()
        {
            Alquiler target = new Alquiler(); // TODO: Initialize to an appropriate value
            int numBicicletas = 3; // TODO: Initialize to an appropriate value
            DateTime fechaAlquiler = new DateTime(2018, 01, 22); // TODO: Initialize to an appropriate value
            string horaAlquiler = "12"; // TODO: Initialize to an appropriate value
            string minutoAlquiler = "30"; // TODO: Initialize to an appropriate value
            DateTime fechaDevolucion = new DateTime(2018, 01, 22); // TODO: Initialize to an appropriate value
            string horaDevolcuion = "13"; // TODO: Initialize to an appropriate value
            string minutoDevolucion = "30"; // TODO: Initialize to an appropriate value
            double expected = 10.5; // TODO: Initialize to an appropriate value
            double actual;
            actual = target.calcularPrecio_rentafamiliar(numBicicletas, fechaAlquiler, horaAlquiler, minutoAlquiler, fechaDevolucion, horaDevolcuion, minutoDevolucion);
            Assert.AreEqual(expected, actual);
    
        }
    }
}
