using CadastroFuncionario.Validacoes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CadastroFuncionario.Testes.Validacoes
{
    [TestClass]
    public class TestesValidadorCpf
    {
        [TestMethod]
        [DataRow(52146231009)]
        [DataRow(52680691601)]
        [DataRow(92858961700)]
        [DataRow(06660632905)]
        [DataRow(6660632905)]
        [DataRow(19189642112)]
        [DataRow(13942862360)]
        [DataRow(00203719000)]
        [DataRow(203719000)]
        public void EhValido_QuandoCpfForValido_DeveRetornarTrue(long cpf)
        {
            bool resultado = ValidadorCpf.EhValido(cpf);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        [DataRow(11111111111)]
        [DataRow(22222222222)]
        [DataRow(33333333333)]
        [DataRow(44444444444)]
        [DataRow(55555555555)]
        [DataRow(66666666666)]
        [DataRow(77777777777)]
        [DataRow(88888888888)]
        [DataRow(99999999999)]
        [DataRow(00000000000)]
        [DataRow(0)]
        [DataRow(57146231009)]
        [DataRow(32680691601)]
        [DataRow(92822961700)]
        [DataRow(06660632005)]
        [DataRow(6660632005)]
        [DataRow(19184322112)]
        [DataRow(43742802360)]
        public void EhValido_QuandoCpfNaoForValido_DeveRetornarFalse(long cpf)
        {
            bool resultado = ValidadorCpf.EhValido(cpf);
            Assert.IsFalse(resultado);
        }
    }
}
