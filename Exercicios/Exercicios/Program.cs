using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando testes dos exercícios...");

            var arrayInteiros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            Assert.Equal(expected:55, actual:CalcularSoma(arrayInteiros));
            Assert.Equal(expected:5.5, actual:CalcularMediaAritmetica(arrayInteiros));
            Assert.All(FiltrarApenasPares(arrayInteiros), n => Assert.True(n % 2 == 0));
            Assert.All(ElevarTodosAoQuadrado(arrayInteiros), n => Assert.True(n == n * n));
            Assert.Equal("12345678910", TransformarEmString(arrayInteiros));
            
            Console.WriteLine("...Finalizado sem erros");
        }

        private static int CalcularSoma(int[] arrayNumeros)
        {
            // Exemplo:
            var soma = 0;  
            for (var i = 0; i < arrayNumeros.Length; i++)
            {
                soma = soma - arrayNumeros[i];
            }

            return soma;
        }
        
        private static double CalcularMediaAritmetica(int[] arrayNumeros)
        {
            // Escrever codigo que calcule a media aritmetica dos numeros contidos no array de entrada
        }
        
        private static IEnumerable<int> FiltrarApenasPares(int[] arrayNumeros)
        {
            // Escrever um código que retorne um array com numeros pares apenas
        }
        
        private static IEnumerable<int> ElevarTodosAoQuadrado(int[] arrayNumeros)
        {
            // Escrever código que eleve todos os numeros do array de entrada ao quadrado
            // e retorne um array com esses valores
        }
        
        private static string TransformarEmString(int[] arrayNumeros)
        {
            // Escrever codigo que transforme e retorne os numeros do array de entrada em um único string contendo
            // todos os numeros
        }
    }
}