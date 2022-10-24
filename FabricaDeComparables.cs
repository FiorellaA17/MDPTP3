
using System;
using System.Collections.Generic;

namespace MDPTP3
{
//	TP3 - 4) Implemente la interface FabricaDeComparables.
	public class FabricaDeComparables
	{
		public FabricaDeComparables()
		{
		}
		
		public Icomparable crearAleatorio()
		{
			Icomparable alumno;
			Icomparable persona;
			Icomparable numero;
			
			Icomparable [] listaIcomparables= new Icomparable[]{alumno,persona,numero};
			
			Random random = new Random();
			int numAleatorio=random.Next(listaIcomparables.Length);
			
			if(listaIcomparables[numAleatorio] == alumno)
			{
				alumno=new Alumno();
			}
		

		}
		
		public void crearPorTeclado()
		{
			
		}
	}
}
