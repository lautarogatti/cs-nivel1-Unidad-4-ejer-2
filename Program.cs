using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un importante negocio de desinfectante líquido realiza descuentos dependiendo 
            de la cantidad de litros vendidos según la siguiente escala:

            Si vende menos de 100 litros, no hay descuento.
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de 
            litros vendidos y calcule y emita el importe con el descuento  aplicado..*/

            int importe, litros, total;

            Console.WriteLine("Por favor ingrese el importe de su compra:");
            importe = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la cantidad de litros comprada:");
            litros = int.Parse(Console.ReadLine());

            if(litros > 500){
                total = importe - ((importe * 25) / 100);
            } else if(litros >= 301 && litros <= 500){
                total = importe - ((importe * 15) / 100);
            } else if(litros >= 101 && litros <= 300){
                total = importe - ((importe * 10) / 100);
            } else {
                total = importe;
            }

            if(total != importe){
                Console.WriteLine("El total de su compra con el descuento correspondiente es $" + total);
            } else {
                Console.WriteLine("El total de su compra es $" + total + " ya que no cumple los requisitos para un descuento");
            }
        }
    }
}
