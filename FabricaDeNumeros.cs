
using System;

namespace MDPTP3
{
//	TP3 -5)
	public class FabricaDeNumeros : FabricaDeComparables
	{
		override public Icomparable crearAleatorio()
        {
            return new Numero(new Random().Next(0,1000));
        }

        override public Icomparable crearPorTeclado()
        {
            Console.Write("ingrese un numero a comparar: ");
            int numero = int.Parse(Console.ReadLine());
            return new Numero(numero);
        }
		
	}
}
