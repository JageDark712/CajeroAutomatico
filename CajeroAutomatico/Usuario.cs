using System;

namespace CajeroAutomatico
{
    public class Usuario
    {

        private string nombre { get; set; }
        private string apellido { get; set; }
        private string id { get; set; }
        private string tel { get; set; }
        private int clave { get; set; }
        private double saldo { get; set; }
        private int cuenta { get; set; }

        public Usuario(string nombrePa, string apellidoPa, string idPa, string telPa, int clavePa, double saldoPa, int cuentaPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;
            id = idPa;
            tel = telPa;
            clave = clavePa;
            saldo = saldoPa;
            cuenta = cuentaPa;

        }

        public int CambiarClave(int clavePa, int ClaveNew)
        {
            if (clavePa == clave)
            {
                clave = ClaveNew;
            }
            else
            {
                Console.WriteLine($"La clave antigua ingresada es incorrecta! ");
            }
            return clave;
        }
        public void ConsultaSaldo()
        {
            Console.WriteLine($"Saldo:{saldo}", 18);
        }
        public double Deposito(double montoPa)
        {
            saldo += montoPa;
            Console.WriteLine("Depósito exitoso.");
            return saldo;
        }
        public double Retirar(double montoPa)
        {
            if (montoPa <= saldo)
            {
                saldo -= montoPa;
                Console.WriteLine("Retiro exitoso.");
            }
            else
            { Console.WriteLine("Saldo insuficiente."); }
            return saldo;
        }
        public double Transferencia(double montoPa, int numCuentaPa)
        {
            int cuentatransf = numCuentaPa;
            if (montoPa <= saldo)
            {
                saldo -= montoPa;
                Console.WriteLine($"Transferencia exitosa a la cuenta: {cuentatransf}");
            }
            else { Console.WriteLine("Saldo insuficiente, por favor intentelo de nuevo."); }
            return saldo;
        }

        public override string ToString()
        {
            return ($"\nNombre usuario: {nombre}" +
                    $"\nApellido: {apellido}" +
                    $"\nIdentificacion: {id}" +
                    $"\nTelefono: {tel}" +
                    $"\nSaldo: {saldo}" +
                    $"\nNumero de cuenta: {cuenta}"/* +
                    $"\nClave: {clave}"*/);
        }

    }

}
