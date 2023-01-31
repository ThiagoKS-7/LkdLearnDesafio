using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LkdLearnDesafio
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

        public void run(Dictionary<string, Cliente> lista)
        {
            MostraMenu(lista);
        }

        public void MostraMenu(Dictionary<string, Cliente> lista)
        {
            string c = "";
            if (lista.Count > 0)
            {
                while (!lista.ContainsKey(c))
                {
                    Console.Write("Digite o codigo do cliente: ");
                    c = Console.ReadLine();
                }
            } else
            {
                Console.WriteLine("Nenhum cliente encontrado");
            }
        }
    }
}
