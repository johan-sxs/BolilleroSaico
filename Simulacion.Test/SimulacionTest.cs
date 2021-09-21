using Bolillero.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Simulacion.Test
{
    [TestClass]
    public class SimulacionTest
    {
        Simulacion Simulacion {get; set;}

        [TestMethod]
        public void SimultaneidadConTask()
        {
            var bolillero = new Bolillero.Core.Bolillero(10);

            Simulacion = new Simulacion();

            var jugada  = new List<byte>{5};

            long cantidadVeces = 1000000;
            double esperado = cantidadVeces/10;
            var ganadasSinHilos = Simulacion.simularSinHilos(bolillero, cantidadVeces, jugada);

            var ganadasConHilos = Simulacion.simularConHilos(bolillero, cantidadVeces, jugada, 4);

            Assert.AreEqual(ganadasConHilos/esperado, ganadasSinHilos/esperado, 0.1);
            
        }
    }
}
