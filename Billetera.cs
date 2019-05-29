using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Billetera
{
    class Billetera
    {
        public double AhorroTotal { get; set; }
        public double Actual { get; set; }
        public double Dinero { get; set; }
        public string Respuesta { get; set; }
        public List<Billetera> billetera = new List<Billetera>();

        public double IngresarDi() {

            Console.WriteLine("Ingrese 'd' para ingresar dinero a la billetera");
            Respuesta = Console.ReadLine();
            while (Respuesta=="d") {
                Console.WriteLine("Cuanto dinero desea ingresar a la billetera");
                Actual = Convert.ToDouble(Console.ReadLine());
                if (Actual<0 )
                {
                    Console.WriteLine("Ingrese una cantidad valida");
                    Console.WriteLine("Cuanto dinero desea ingresar a la billetera");
                    Actual = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Ingrese 'd' para ingresar dinero la billetera o 'no' para salir");
                Respuesta = Console.ReadLine();
                
            }
            return Actual;
        }
        public double Gastar() {
            double gastar;
            Console.WriteLine("Ingrese 'g' para gastar dinero de la billetera");
            Respuesta = Console.ReadLine();
            while (Respuesta == "g")
            {
                Console.WriteLine("Cuanto dinero desea Gastar");
                gastar = Convert.ToDouble(Console.ReadLine());
                if (Actual < gastar )
                {
                    Console.WriteLine("Fondos insuficientes intente de nuevo");
                    Console.WriteLine("Cuanto dinero desea Gastar");
                    gastar = Convert.ToDouble(Console.ReadLine());
                }
                Actual = Actual - gastar;
                gastar = gastar * 10 / 100;
                var transaccion = new Billetera()
                {
                    Dinero = gastar
                };
                billetera.Add(transaccion);
                Console.WriteLine("Ingrese 'g' para gastar dinero de la billetera o 'no' para salir");
                Respuesta = Console.ReadLine();
            }
            return Actual;
        }
        public void impriMoney() {
            Console.WriteLine("¿Desea saber cuanto dinero hay en la billetera? marque'i'");
            Respuesta = Console.ReadLine();
            if (Respuesta == "i")
            {
                Console.WriteLine($"Su billetera possee un total de:{Actual}");
            }
        }
        public double Depositar()
        {
            Console.WriteLine("¿Desea Depositar el dinero actual? marque'a'");
            Respuesta = Console.ReadLine();
            if (Respuesta == "a")
            {
                if (Actual <= 0)
                {
                    Console.WriteLine("No posse fondos Transaccion fallida");
                }
                if (Actual > 0)
                {
                    Console.WriteLine("transacion realizada con exito");
                    var transaccion = new Billetera()
                    {
                        Dinero = Actual
                    };
                    billetera.Add(transaccion);
                    Actual = 0;
                }
                
            }
            return Actual;
        }
        public void NotificaTrans() {
            int i = 0;
            Console.WriteLine("¿Desea ver las transacciones realizadas? marque 't' ");
            Respuesta = Console.ReadLine();
            if (Respuesta=="t")
            {
                Console.WriteLine("Esta es la lista");
                foreach (var item in billetera)
                {
                    

                    i++;
                    //Console.WriteLine($"transaccion numero {i}: {item.Ahorro}");
                    Console.WriteLine($"transaccion numero {i}: {item.Dinero}");
                }
            }
            Console.WriteLine("¿Desea ver el total de ahorro? marque 'si' ");
            Respuesta = Console.ReadLine();
            if (Respuesta=="si")
            {
                AhorroTotal = billetera.Sum(x => x.Dinero);
                Console.WriteLine($"Total ahorro : {AhorroTotal}");
            }
            

        }
            
    }
}
