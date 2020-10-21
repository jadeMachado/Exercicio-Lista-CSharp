using System;
using System.Globalization;
using System.Collections.Generic;

namespace ClassesAtributosMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionario = new List<Funcionario>();

            Console.Write("Quantos funcionários deseja cadastrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Dados do {i}º funcionário:");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário Bruto: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionario.Add(new Funcionario(nome, salario));
            }

            double somaSalarios = 0;

            for (int i = 0; i < funcionario.Count; i++)
            {
                somaSalarios += funcionario[i].Salario;
            }

            Console.WriteLine("A média dos salários é: " + somaSalarios / quantidade);
        }
    }
}
