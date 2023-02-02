using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class Cliente
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public decimal Saldo { get; set; }

        public List<string> Extrato { get; set; }
        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Extrato = new List<string>();
            Extrato.Add("\n\n========= EXTRATO =========\n\n");
        }

        public abstract void ExibirExtrato();
        public abstract void ExecutarOpcao(int o);
        public abstract void Sacar(decimal valor);
        public abstract void Depositar(decimal valor);
    }
}
