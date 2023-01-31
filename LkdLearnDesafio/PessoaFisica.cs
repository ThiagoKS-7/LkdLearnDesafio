using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LkdLearnDesafio
{
    public class PessoaFisica : Cliente
    {
        public int Codigo { get; private set; }
        public string Cpf { get; private set; }
        public string Nome { get; private set; }

        public const decimal Taxa = 1.0m;


        public PessoaFisica(int codigo, string nome, string cpf):base(codigo, nome)
        {
            Codigo = codigo;
            Nome = nome;
            Cpf = cpf;
        }


        public override void ExibirExtrato() {
            foreach(string e in Extrato)
            {
                Console.WriteLine(e);
            }
        }

        public override void Sacar(decimal valor) {
            Saldo -= (valor + Taxa);
            Extrato.Add($"saque {valor}");
            Console.WriteLine("Saque realizado com sucesso!");
        }

        public override void Depositar(decimal valor) {
            Saldo += (valor + Taxa);
            Extrato.Add($"deposito {valor}");
            Console.WriteLine("Depósito realizado com sucesso!");
        }
    }
}
