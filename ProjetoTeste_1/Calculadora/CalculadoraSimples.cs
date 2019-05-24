using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraSimples              //CÓDIGOS DE PRODUÇÃO
    {
        // Metodo para SOMAR 2 numeros

        public int Adicionar(int num1, int num2)
        {
            return num1 + num2;
        }
        // Metodo para MULTIPLICAR  2 numeros                        <---ESTE TESTE VAI DAR ERRO
        public int Multiplicar (int num1, int num2)
        {
            //para fins de demos (bug) => O Correto é return num1 * num2
            return num1 + num2;
        }
        // Metodo para DIVIDIR 2 numeros                              <---ESTE TESTE VAI DAR ERRO
        public int Dividir (int num1, int num2)
        {
            //para fins de demos (bug) => O Correto é : return num1 * num2
            return num1 + num2;
        }
        // Metodo para Subtrair 2 numeros                              <---ESTE TESTE VAI DAR ERRO
        public int Subtrair(int num1, int num2)
        {
            //para fins de demos (bug) => O Correto é return num1 - num2
            return num1 * num2;
        }
        // Metodo para Somar Decimais
        public double SomarDecimais (double num1, double num2)
        {
            return num1 + num2;
        }
                
    }
}
