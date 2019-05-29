using System;

namespace Billetera
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Billetera banco = new Billetera();
            Billetera banco1 = new Billetera();
            banco.IngresarDi();
            banco.Gastar();
            banco.impriMoney();
            banco.Depositar();
            banco1.impriMoney();
            banco.NotificaTrans();

        }
    }
}
