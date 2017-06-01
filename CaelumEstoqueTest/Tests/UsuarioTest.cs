using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaelumEstoque.Models;

namespace CaelumEstoqueTest
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void UsuarioComIdNomeESenhaCriadoComSucesso()
        {
            var usuario = new Usuario()
            {
                Id = 1,
                Nome = "TCE",
                Senha = "#TCE#"
            };

            Assert.IsNotNull(usuario);
            Assert.AreEqual(1, usuario.Id);
            Assert.AreEqual("TCE", usuario.Nome);
            Assert.AreEqual("#TCE#", usuario.Senha);
        }
    }
}
