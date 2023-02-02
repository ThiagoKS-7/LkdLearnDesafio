using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Sistema
    {

        private Sistema() { }

        private static Sistema _instance;

        public static Sistema GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Sistema();
            }
            return _instance;
        }

        public void run()
        {
            MostraMenu(PegaClientes());
        }

        public Dictionary<int, Cliente> PegaClientes()
        {
            Dictionary<int, Cliente> l = new Dictionary<int, Cliente>();
            l.Add(1, new PessoaFisica(1, "Teste", "123"));
            l.Add(2, new PessoaJuridica(2, "Teste2", "123"));
            return l;
        }

        public void MostraMenu(Dictionary<int, Cliente> lista)
        {
            int c = -5;
            if (lista.Count > 0)
            {
                while (!lista.ContainsKey(c))
                {
                    Console.Write("Digite o codigo do cliente: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Cliente cl = lista.FirstOrDefault(x => x.Key == c).Value;
                    Console.Write($"\nQual operação você deseja fazer, {cl.Nome}?");
                    MostraOpcoes(cl);
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente encontrado");
            }
        }

        private void MostraOpcoes(Cliente cl)
        {
            int o = 999;
            while (o > 0)
            {
                Console.WriteLine(
                    $"\n1 - Ver dados \n" +
                    $"2 - Exibir extrato \n" +
                    $"3 - Sacar valor \n" +
                    $"4 - Depositar valor \n" +
                    $"0 - Sair\n"
                    );
                Console.Write("Digite o número da opção: ");
                o = Convert.ToInt32(Console.ReadLine());
                cl.ExecutarOpcao(o);

            }

        }


    }
}
