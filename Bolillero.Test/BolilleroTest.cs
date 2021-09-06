using Bolillero.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bolillero.Test
{
    [TestClass]
    public class BolilleroTest
    {
        public Bolillero.Core.Bolillero Bolillero { get; set; }

        [TestMethod]

        public void CantidadBolillasAfuera()
        {
            Bolillero = new Bolillero.Core.Bolillero(10);

            Bolillero.SacarBolilla();

            Assert.AreEqual(1, Bolillero.Cantidadafuera);
            Assert.AreEqual(9, Bolillero.Cantidadadentro);
        }
        [TestMethod]
        public void Probabilidad()
        {
            Bolillero = new Bolillero.Core.Bolillero(5);
            var jugadafacil = new List<byte>() { 2 };
            var ganadas = Bolillero.jugarNVeces(jugadafacil, 100);

            Assert.AreEqual(0.2, ganadas / 100, 0.5);


        }

    }
}