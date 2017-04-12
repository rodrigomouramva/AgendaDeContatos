using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AgendaDeContatosCore.Testes
{
    [TestClass]
    public class DadoUmaEntidadeBaseTeste
    {
        [TestMethod]
        public void ComparandoUmaEntidadeComoBooleanoRetornaTrueSeEntidadeNãoENulo()
        {

            var entidade = new EntidadeFake();

            Assert.IsTrue(entidade);

        }        
    }
}
