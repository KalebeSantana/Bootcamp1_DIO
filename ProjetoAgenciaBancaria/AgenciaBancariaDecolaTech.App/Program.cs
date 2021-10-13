using AgenciaBancariaDecolaTech.Dominio;
using System;

namespace AgenciaBancariaDecolaTech.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("rua teste", "1847528", "Guarulhos", "SP");
                Cliente cliente = new Cliente("Kalebe", "234131", "1241892673498", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta: " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                string senha = "abc12321342";
                conta.Abrir(senha);

                Console.WriteLine("Conta: " + conta.Situacao + ": " +conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo: " + conta.Saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
