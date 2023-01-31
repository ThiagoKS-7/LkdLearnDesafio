using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LkdLearnDesafio
{
    public class PessoaJuridica : Cliente
    {
        public int Codigo { get; private set; }
        public string Cnpj { get; private set; }
        public string Nome { get; private set; }

        public const decimal Taxa = 2.0m;


        public PessoaJuridica(int codigo, string nome, string cnpj) : base(codigo, nome)
        {
            Codigo = codigo;
            Nome = nome;
            Cnpj = cnpj;
        }


        public override void ExibirExtrato()
        {
            foreach (string e in Extrato)
            {
                Console.WriteLine(e);
            }
        }

        public override void Sacar(decimal valor)
        {
            Saldo -= (valor + Taxa);
            Extrato.Add($"saque {valor}");
            Console.WriteLine("Saque realizado com sucesso!");
        }

        public override void Depositar(decimal valor)
        {
            Saldo += (valor + Taxa);
            Extrato.Add($"deposito {valor}");
            Console.WriteLine("Depósito realizado com sucesso!");
        }
    }
}
