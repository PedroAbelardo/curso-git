using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Heranca.Testes
{
    [TestClass]
    public class SquareTeste
    {
        [TestMethod]
        public void TestMethod1()
        {
            Square square = new Square();

            square.Width = 2.0;

            resultado = square.Area();

            Assert.AreEqual(resultado);
        }
    }
}
