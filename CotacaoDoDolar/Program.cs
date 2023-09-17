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
                byte i = 0; 
                Console.WriteLine("dirija quantos dolares ira comprar:");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double resultado = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

                Console.WriteLine("Valor a ser pago em reais:\n" + resultado);
                while (i == 0)
                {
                    Console.WriteLine("deseja operar novamente?\n" +
                                      "[s]Sim / [n]Não");
                    string desejo = Console.ReadLine();

                    if (desejo == "s")
                    {
                        escolha = true;
                        i++;
                    }
                    else if (desejo == "n")
                    {
                        escolha = false;
                        i++;
                    }
                    else if (desejo != "s" & desejo != "n")
                    {
                        Console.WriteLine("opção invalida por favor repita");
                        i = 0;
                    }
                }
            }
        }
    }
}