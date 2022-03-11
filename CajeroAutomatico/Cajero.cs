using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico
{
    internal class Cajero
    {
        static void Main(string[] args)
        {
            string nom, ape, id, tel;
            double sal;
            int clave, cuentaC;

            Console.WriteLine("Ingrese sus nombres: ");
            nom = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos: ");
            ape = Console.ReadLine();
            Console.WriteLine("Ingrese su id: ");
            id = Console.ReadLine();
            Console.WriteLine("Ingrese su teléfono: ");
            tel = Console.ReadLine();
            Console.WriteLine("Indique cual será el depósito inicial a la cuenta bancaria: ");
            sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la clave de su cuenta: ");
            clave = int.Parse(Console.ReadLine());
            Random cuenta = new Random();
            cuentaC = cuenta.Next(10000, 99999);

            Usuario cliente = new Usuario(nom, ape, id, tel, clave, sal, cuentaC);

            Console.WriteLine("Su cuenta ha sido creada exitosamente.\nPor favor pulse enter para continuar.");
            Console.ReadKey();

            int resp;

            Console.WriteLine("\n \n -------------------------------- \nBienvenid@ al cajero electrónico de su Banco MiDinero.\n -------------------------------- \n\n");

            do
            {
                Console.WriteLine("\nPor favor ingrese la opción que desea realizar en su cuenta, siendo: ");
                Console.WriteLine("\n1)Depósito. \n2)Retiro. \n3)Consultar saldo. \n4)Mostar toda la información de la cuenta. \n5)Transferir a otra cuenta. \n6)Cambio de clave. \n7)Salir.\n");
                resp = int.Parse(Console.ReadLine());
                double monto = 0;
                int aux = 0, claveNew=0;
                switch (resp)
                {
                    case 1:
                        Console.WriteLine("\nIngrese el valor a depositar: ");
                        monto = double.Parse(Console.ReadLine());
                        cliente.Deposito(monto);
                        
                        break;
                    case 2:
                        Console.WriteLine("\nIngrese el valor a retirar: ");
                        monto = double.Parse(Console.ReadLine());
                        cliente.Retirar(monto);
                        
                        break;
                    case 3:
                        cliente.ConsultaSaldo();
                        
                        break;
                    case 4:
                        Console.WriteLine("\nLos datos de su cuenta son: \n" + cliente.ToString());
                        
                        break;
                    case 5:
                        Console.WriteLine("\nIngrese el valor a transferir: ");
                        monto = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nIngrese el número de cuenta al que desea transferir: ");
                        aux = int.Parse(Console.ReadLine());
                        cliente.Transferencia(monto, aux);
                        

                        break;
                    case 6:
                        //Ingresar cambiar clave
                        Console.WriteLine("Ingrese la clave antigua.");
                        aux = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la nueva clave.");
                        claveNew = int.Parse(Console.ReadLine());
                        cliente.CambiarClave(aux, claveNew);

                        break;
                    case 7:
                        Console.WriteLine("\nGracias por usar nuestros servicios. Hasta pronto.");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("\nOpción incorrecta.");
                        resp = 0;
                        
                        break;
                }
            } while (resp < 7);
        }
    }
}
