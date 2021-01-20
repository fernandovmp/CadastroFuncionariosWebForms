using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroFuncionario.Validacoes
{
    public static class ValidadorCpf
    {
        public static bool NaoEhValido(long cpf) => !EhValido(cpf);

        public static bool EhValido(long cpf)
        {
            long numeroCpf = cpf;
            int digitoVerificadorCpf2 = ObterUltimoDigitoEDeslocarUmaCasaPraDireita(ref numeroCpf);
            int digitoVerificadorCpf1 = ObterUltimoDigitoEDeslocarUmaCasaPraDireita(ref numeroCpf);
            int digitoAnterior = ObterUltimoDigito(numeroCpf);
            int digito, somaDigitoVerificador1 = 0, somaDigitoVerificador2 = 0;
            bool todosDigitosIguais = true;
            for(int i = 0; i < 9; i++)
            {
                digito = ObterUltimoDigitoEDeslocarUmaCasaPraDireita(ref numeroCpf);
                somaDigitoVerificador1 += (9 - i) * digito;
                somaDigitoVerificador2 += (3 + i) * digito;
                todosDigitosIguais = todosDigitosIguais && digito == digitoAnterior;
                digitoAnterior = digito;
            }
            if (todosDigitosIguais)
            {
                return false;
            }
            int digitoVerificador1 = somaDigitoVerificador1 % 11 % 10;
            somaDigitoVerificador2 += digitoVerificador1 * 2;
            somaDigitoVerificador2 *= 10;
            int digitoVerificador2 = somaDigitoVerificador2 % 11 % 10;
            return digitoVerificador1 == digitoVerificadorCpf1 && digitoVerificador2 == digitoVerificadorCpf2;
        }

        private static int ObterUltimoDigitoEDeslocarUmaCasaPraDireita(ref long numero)
        {
            int digito = ObterUltimoDigito(numero);
            numero /= 10;
            return digito;
        }
        private static int ObterUltimoDigito(long numero) => (int) (numero % 10);

    }
}