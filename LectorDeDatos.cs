
using System;

namespace MDPTP3
{
	
//	TP3 -3) Implemente la clase LectorDeDatos.
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		
		public int numeroPorTeclado()
		{
			Console.WriteLine("ingrese un numero");
            int num = int.Parse(Console.ReadLine());
            return num;
		}
		
		public string stringPorTeclado()
		{
			Console.WriteLine("ingrese una palabra");
			string palabra = Console.ReadLine();
            return palabra;
		}
		
	}
}
