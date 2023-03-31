using System;
using System.Globalization;

namespace CsE5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCICIO 5
            //COLETA DE DADOS PRODUTO 1
            Console.WriteLine("soma de produtos\n\n");
            Console.WriteLine("Codigo do produto 1: ");
            int cod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do produto 1: ");
            int quant1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitario do produto 1: ");
            double preco1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calculo1 = quant1 * preco1;

            //LIMPEZA DE TELA
            Console.Clear();

            //COLETA DE DADOS PRODUTO 2
            Console.WriteLine("Soma de produtos\n\n");
            Console.WriteLine("Codigo do produto 2: ");
            int cod2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do produto 2: ");
            int quant2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor unitario do produto 2: ");
            double preco2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double calculo2 = quant2 * preco2;

            //LIMPEZA DE TELA
            Console.Clear();

            //CÁLCULOS E RETORNO DE DADOS
            Console.WriteLine("Soma de produtos\n");
            double soma = calculo1 + calculo2;
            int somaQuantidade = quant1 + quant2;
            Console.WriteLine("Produto 1 (x" + quant1 + "): " + ("R$ " + calculo1.ToString("F2", CultureInfo.InvariantCulture)));
            Console.WriteLine("Produto 2 (x" + quant2 + "): " + ("R$ " + calculo2.ToString("F2", CultureInfo.InvariantCulture)));
            Console.WriteLine("Total de itens: " + somaQuantidade);
            Console.WriteLine("Total a pagar: " + ("R$ " + soma.ToString("F2", CultureInfo.InvariantCulture)));
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
