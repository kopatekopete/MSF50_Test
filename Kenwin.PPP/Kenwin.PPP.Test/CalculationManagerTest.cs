using Kenwin.PPP.Cliente.Comun;
using Kenwin.PPP.Cliente.Comun.Calculations;
using Kenwin.PPP.Negocio.Comun;
using Kenwin.PPP.Negocio.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Kenwin.PPP.Test
{
    
    
    /// <summary>
    ///This is a test class for CalculationManagerTest and is intended
    ///to contain all CalculationManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CalculationManagerTest
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

        [TestMethod]
        public void CalculationManager_Test()
        {
            var calcManager = CalculationManager<DatosProyecto>.Create();

            calcManager.DefineFormula(x => x.PrecioBruto,
                    x => ((((x.RateFijo.ConvertirADecimal(0) + (x.RateVariable.ConvertirADecimal(0) * CalcularParticipantesAdicionales(x.CantidadTopeRateFijo.ConvertirADecimal(0), x.CantidadParticipantes.ConvertirADecimal(0))))
                    * x.CantidadEventos.ConvertirADecimal(0)) + x.Gastos.ConvertirADecimal(0)) * x.Factor.ConvertirADecimal(1)).ConvertirAString());

            var datos = new DatosProyecto();
            calcManager.ApplyToItem(datos, false);

            datos.CantidadEventos = 1.ToString();
            datos.RateFijo = 250.ToString();
            datos.Factor = 1.ToString();

            Assert.AreEqual(250, datos.PrecioBruto.ConvertirADecimal(0));
        }

        private decimal CalcularParticipantesAdicionales(decimal convertirADecimal, decimal convertirADecimal1)
        {
            return 0;
        }
    }
}
