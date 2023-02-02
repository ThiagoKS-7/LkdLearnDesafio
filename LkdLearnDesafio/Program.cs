using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco;
/*
 *  Criar um console app para movimentações financeiras
 *  Criar Clientes, PessoaFisica e PessoaJuridica
 *  Criar uma lista de movimentações para cada cliente
 *  PJ - R$2 reais; PF - R$1
 * 
*/
namespace LkdLearnDesafio
{
    public class Program
    {
        public static void Main()
        {
            Sistema s = Sistema.GetInstance();
            s.run();

        }
    }
}
