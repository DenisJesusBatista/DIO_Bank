using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {            
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Denis de Jesus");
            
            Console.WriteLine(minhaConta.ToString());
            Console.ReadLine();
        }
    }
}
