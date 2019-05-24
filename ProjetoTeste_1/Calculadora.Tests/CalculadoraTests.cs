using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculadora.Tests
{
    public class CalculadoraTests           //CÓDIGOS DE TESTES
    {
       
        [TestFixture]

        // Classe de Testes:
        public class CalculadoraSimplesDeTests
        {
            /* Teste Classe SOMAR 2 numeros */
            [Test]                                      
            public void DeveAdcionarDoisNumeros()
            {
                //SUT  (SYSTEM UNDER TEST)
                var sut = new CalculadoraSimples();

                var resultado = sut.Adicionar(5, 5);

                Assert.That(resultado, Is.EqualTo(10)); // <-- RESULTADO ESPERADO
            }

            /* Teste Classe MULTIPLICAR 2 numeros */
            [Test]                                           //<---ESTE TESTE VAI DAR ERRO
            public void DeveMulitplicarDoisNumeros()
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.Multiplicar(5,3);

                Assert.That(resultado, Is.EqualTo(15)); 
            }

            /* Teste Classe DIVIDIR 2 numeros */
            [Test]                                            //<---ESTE TESTE VAI DAR ERRO
            public void DeveDividirDoisNumeros()
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.Dividir(10,2);

                Assert.That(resultado, Is.EqualTo(5));
            }

            [Test]                                             //<---ESTE TESTE VAI DAR ERRO
            public void DeveSubtrairDoisNumeros()
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.Subtrair(7,5);

                Assert.That(resultado, Is.EqualTo(2));
            }

            [Test]                                          //<---ESTE TESTE VAI DAR ERRO
            public void DevosomarNumerosDecimais()
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.SomarDecimais(1.1, 2.2);  // 3.3

                Assert.That(resultado, Is.EqualTo(3.3));
            }

            [Test]
            public void DevoSomarNumerosDecimais_UsandoWithin() // IGUAL AO TESTE ANTERIOR USANDO TOLERANCIA DE 0.01
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.SomarDecimais(1.1, 2.2); //3.3

                //Se Resultado estiver entre : 3,29 e 3,31 - Teste ok
                Assert.That(resultado, Is.EqualTo(3.3).Within(0.01));
            }

            [Test]
            public void DevoSomarNumerosDecimais_UsandoWhitinPorcentagem()
            {
                //SUT
                var sut = new CalculadoraSimples();

                var resultado = sut.SomarDecimais(50, 50); //100%

                Assert.That(resultado, Is.EqualTo(101).Within(1).Percent); // Tolerancia de 1%
                
                /* OUTROS TIPO DE TESTE QUE PODEM SER FEITOS 
                 Se é Positivo - Is.Positive
                 Se é Nengativo - Is.Negative
                                
                 */
                

            }
        }
        
    }
}
