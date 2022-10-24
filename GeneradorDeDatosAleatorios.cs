
using System;

namespace MDPTP3
{
	//TP3 -2) Implemente la clase GeneradorDeDatosAleatorios.
	
	public class GeneradorDeDatosAleatorios
	{
		public GeneradorDeDatosAleatorios()
		{
		}
		
		public int numeroAleatorio(int max)
		{
			Random random = new Random();
			int numAleatorio=random.Next(max+1);
			
			return numAleatorio;

		}
		
		public String stringAleatorio(int cant)
		{
			string cadena="";
			Random rand = new Random();	
			
			for(int i=0; i< cant; i++)
			{
				int numero = rand.Next(26);
				char letra = (char)(((int)'A')+numero); //a partir de A
				cadena=cadena+letra;
			
			}
			return cadena;
		}
	}
}
