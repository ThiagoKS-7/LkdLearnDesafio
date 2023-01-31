using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LkdLearnDesafio
{
    public abstract class Cliente
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public decimal Saldo { get; set; }

        public List<string> Extrato { get; private set; }
        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public abstract void ExibirExtrato();

        public abstract void Sacar(decimal valor);

        public abstract void Depositar(decimal valor);
    }
}
