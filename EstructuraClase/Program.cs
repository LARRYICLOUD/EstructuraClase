using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES ESCELENTE Y RECONOCIDO");

            //Conjunto de datos pequeños y especificos
            //Datos formen parte de un objeto a un mas grande

            Transferencia transferencia1 = new Transferencia();
            transferencia1.fecha = DateTime.Now;
            transferencia1.monto = "10 Millones de Dolares" ; //10 millones de dolares
            transferencia1.destinatario = "LARRYSALSA";
            transferencia1.numeroCuenta = "333333357221055555";
            transferencia1.concepto = "creacion de aplicacion web";

            Console.WriteLine(transferencia1.ToString());

        }
    }
  struct Transferencia
        // class Transferencia
    {
        public DateTime fecha;
        public string monto;
        public string destinatario;
        public string numeroCuenta;
        public string concepto;

       

        public override string ToString()
        {
            string mensaje;
            mensaje = $"Fecha: {fecha.ToString()} \nMonto: US${monto} \nDestinatario: {destinatario} \nNumero de cuenta:{numeroCuenta} \nConcepto: {concepto}";
            return mensaje;
        }
    }

}
