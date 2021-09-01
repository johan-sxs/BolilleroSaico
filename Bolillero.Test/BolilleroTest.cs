using Bolillero.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bolillero.Test
{
    [TestClass]
    public class BolilleroTest
    {
        public Bolillero.Core Bolillero {get;get;}
    
    [TestMethod]

  public void CantidadBolillasAfuera()
 {
    Bolillero= new Bolillero.Core.Bolillero{10};

    Bolillero.SacarBolilla();

    Assert.AreEqual(1, Bolillero.Cantidadafuera)
    Assert.AreEqual(9, Bolillero.CantidadAdentro)
 }
       

  }
}