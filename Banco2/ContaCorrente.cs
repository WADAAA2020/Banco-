
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco2;
public class ContaCorrente
{
    public double valorTransferir; 
    public int agencia = 0;
    public string conta = "";
    public string nome = "";
    public double saldo = 0.0; public void Depositar(double valor)
    {
        this.saldo += valor;
    }
    public bool Sacar(double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
            return true;
        }

        else
        {
            Console.WriteLine("Saldo" + " insuficiente para realizar o saque.");
            return false;
        }
    }

    public bool Transferir(double valor, ContaCorrente ContaDestino)
    {
        if (this.saldo >= valor)
        {
            valorTransferir = valor;
            this.saldo -= valor;
            ContaDestino.saldo += valor;
            return true;
        }

        else
        {
            Console.WriteLine("Saldo insuficiente para transferir");
            return false;
        }
    }
}


