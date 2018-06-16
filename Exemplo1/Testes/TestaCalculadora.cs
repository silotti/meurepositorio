using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Exemplo1;

namespace Testes
{
    [TestClass]
    public class TestaCalculadora
    {
        [TestMethod]
        public void TestSoma()
        {
            Somar c = new Somar();
            int resultado = c.Soma(3, 4);
            Assert.AreEqual(7, resultado);
        }
    }
}
