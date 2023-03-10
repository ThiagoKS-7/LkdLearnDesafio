using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class PessoaFisica : Cliente
    {
        public int Codigo { get; private set; }
        public string Cpf { get; private set; }
        public string Nome { get; private set; }

        public const decimal Taxa = 1.0m;


        public PessoaFisica(int codigo, string nome, string cpf) : base(codigo, nome)
        {
            Nome = nome;
            Cpf = cpf;
        }


        public override void ExibirExtrato()
        {
            if (Extrato.Count > 1)
            {
                foreach (string e in Extrato)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine("\n\n=========================\n\n");
            } else
            {
                Console.WriteLine("Não há histórico");
            }

        }

        public void MostraDadosPf()
        {
            Console.WriteLine(
                $"Código: {Codigo}\n" +
                $"Nome: {Nome}\n" +
                $"Saldo: {Saldo}\n" +
                $"CPF: {Cpf}\n" +
                $"Tipo da conta: {GetType()}\n"
            );
        }
        public override void ExecutarOpcao(int o)
        {
            switch (o)
            {
                case 1:
                    MostraDadosPf();
                    break;
                case 2:
                    ExibirExtrato();
                    break;
                case 3:
                    Console.Write("Digite um valor: ");
                    decimal v = Convert.ToDecimal(Console.ReadLine());
                    Sacar(v);
                    break;
                case 4:
                    Console.Write("Digite um valor: ");
                    decimal u = Convert.ToDecimal(Console.ReadLine());
                    Depositar(u);
                    break;
                default:
                    Console.WriteLine("Fim do programa! Aperte qualquer tecla para sair...");
                    Console.ReadLine();
                    break;
            }
        }

        public override void Sacar(decimal valor)
        {
            if (Saldo > 0)
            {
                Saldo -= valor + Taxa;
                Extrato.Add($"* Saque  ( - R$ {valor});");
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor + Taxa;
            Extrato.Add($"* Depósito  ( + R$ {valor});");
            Console.WriteLine("Depósito realizado com sucesso!");
        }
    }
}
