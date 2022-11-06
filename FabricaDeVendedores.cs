
using System;

namespace MDPTP3
{
//	TP3- 9)Implemente  una  fábrica  concreta  para  la  clase  Vendedor 
//	y  compruebe  el  correcto funcionamiento del método main del ejercicio 6. Compare a los vendedores por el campo bonus.
	
	public class FabricaDeVendedores : FabricaDeComparables
	{
		override public Icomparable crearPorTeclado()
		{
			 Console.Write("ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("ingrese dni: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("ingrese Sueldo basico: ");
            int sueldo = int.Parse(Console.ReadLine());

            return new Vendedor(nombre,dni,sueldo);
		}
		
	 	override public Icomparable crearAleatorio( )
        {
           string [] listaNombres= {"Ana", "juan", "jose", "ruth", "gael", "pedro", "esther", "maria", "belen", "pablo", "lucas", "mia", "lucia", "Leonel", "Dante","milena","giovanni","luciano","mauro","stefania","catalina","milton"};
			Random random = new Random();

            string auxNombre = listaNombres[random.Next(0, listaNombres.Length)];
           
            return new Vendedor(auxNombre,random.Next(50000000), random.Next(500000));
        }
	}
}
