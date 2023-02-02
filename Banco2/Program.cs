using Banco2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Banco2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //criando o objeto que acessa os atributos da classe
            //Atributo parte do objeto
            //Função  do objeto 

            ContaCorrente conta1 = new ContaCorrente();
            ContaCorrente conta2 = new ContaCorrente();
            ContaCorrente conta3 = new ContaCorrente();

            // adicionando valor aos atributos do objeto    
            //         
            conta1.nome = "Gabriel";
            conta1.agencia = 319;
            conta1.saldo = 2000.00;
            conta1.conta = "1237-x";

            conta2.nome = "Felipe";
            conta2.agencia = 123;
            conta2.saldo = 1000.00;
            conta2.conta = "2345-x";

            conta3.nome = "Mateus";
            conta3.agencia = 432;
            conta3.saldo = 2100.00;
            conta3.conta = "3114-x";   
            
            //Console.WriteLine mensagem será exibida no na tela

            Console.WriteLine(conta1.nome);
            Console.WriteLine("\r"); //Pula uma linha
            Console.WriteLine("saldo: R$" + conta1.saldo);
            Console.WriteLine("Agência: " + conta1.agencia);
            Console.WriteLine("Conta: " + conta1.conta);
            Console.WriteLine("\r");
            conta1.Depositar(300); //Soma valor deposito
            Console.WriteLine("Saldo com deposito: R$" + conta1.saldo); // Deposito mais o saldo
            if(conta1.Sacar(100)) //Subtrai do valor deposito.
            Console.WriteLine("Saldo atual após o saque: R$" + conta1.saldo); // Saca  mais o valor do  saldo
            Console.WriteLine("\r");
            Console.WriteLine("\r");

            Console.WriteLine("SALDO ATUAL DA CONTA QUE IRÁ TRANSFERIU " + conta1.saldo);
            Console.WriteLine("SALDO ATUAL DA CONTA QUE IRÁ RECEBER " + conta2.saldo);
            conta1.Transferir(100, conta2);
            Console.WriteLine("\n");
            Console.WriteLine("SALDO ATUAL APÓS VOCÊ TRANSFERIR: " + conta1.saldo);
            Console.WriteLine("SALDO ATUAL APÓS RECEBER: " + conta2.saldo);
            Console.WriteLine("O valor transferido foi: " + conta1.valorTransferir);



            /*
            Console.WriteLine(conta2.nome);
            
            Console.WriteLine("\r"); //Pula uma linha
            Console.WriteLine("Saldo: R$" + conta2.saldo);
            Console.WriteLine("Agêcia: " + conta2.agencia);
            Console.WriteLine("Conta: " + conta2.conta);
            Console.WriteLine("\r");
            conta2.Depositar(2000); //Soma valor deposito
            Console.WriteLine("Saldo com deposito: R$" + conta2.saldo);  // Deposito mais o saldo
            conta2.Sacar(980); //Subtrai do valor deposito
            Console.WriteLine("Saldo atual após o saque: R$" + conta2.saldo);// Saca  mais o valor  do saldo
            Console.WriteLine("\r");
            Console.WriteLine("\r");
            
            /*
            Console.WriteLine(conta3.nome);
            Console.WriteLine("\r"); //Pula uma linha
            Console.WriteLine("Saldo: R$" + conta3.saldo);
            Console.WriteLine("Agência: " + conta3.agencia);
            Console.WriteLine("Conta: " + conta3.conta);
            Console.WriteLine("\r");
            conta3.Depositar(500); //Soma valor deposito
            Console.WriteLine("Saldo com deposito: R$" + conta3.saldo); // Deposito mais o saldo
            conta3.Sacar(100200); //Subtrai do valor deposito
            Console.WriteLine("Saldo atual após o saque: R$" + conta3.saldo);// Saca  mais o valor do saldo
            Console.WriteLine("\r");
            Console.WriteLine("\r"); */
        }
    }
}