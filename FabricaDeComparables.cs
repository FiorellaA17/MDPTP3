﻿
using System;
using System.Collections.Generic;

namespace MDPTP3
{
//	TP3 - 4) Implemente la interface FabricaDeComparables.
	public abstract class FabricaDeComparables
	{
		public const int NUMERO = 1;
		public const int ALUMNO= 2;
		public const int VENDEDOR=3;
		
		
		public static Icomparable crearPorTeclado(int seleccion)
		{
			FabricaDeComparables fabrica= null;
			
			switch(seleccion)
			{
				case NUMERO: 
					fabrica = new FabricaDeNumeros();
			        break;
				case ALUMNO:
			        fabrica = new FabricaDeAlumnos();
			        break;
			 	case VENDEDOR:
			        fabrica = new FabricaDeVendedores();
			        break;
			}
			
			return fabrica.crearPorTeclado();
		}
		
		public abstract Icomparable crearPorTeclado();
		
		public static Icomparable crearAleatorio(int opcion)
		{
			FabricaDeComparables fabrica= null;
			
			if(opcion==1)
			{
				fabrica=new FabricaDeNumeros();
			}
			
			if(opcion==2)
			{
				fabrica=new FabricaDeAlumnos();
			}
			
			if(opcion==3)
			{
				fabrica=new FabricaDeVendedores();
			}
						
			return fabrica.crearAleatorio();
		}
		
		public abstract Icomparable crearAleatorio();
		
	}
}
