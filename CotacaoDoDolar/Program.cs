using System.Globalization;

namespace CotacaoDoDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool escolha = true;
            Console.WriteLine("Olá, Bem vindo ao sistema de cotação de Dolar\n" +
                              "por favor dirija qual a cotação atual para a conversão:");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (escolha == true)
            {
                Console.WriteLine("dirija quantos dolares ira comprar:");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

                Console.WriteLine("Valor as SerializableAttribute pago em reais:\n" + resultado);

                Console.WriteLine("deseja operar novamente?\n" +
                                  "[s]Sim / [n]Não");

            }
        }
    }
}