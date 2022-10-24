
using System;
using System.Collections.Generic;

namespace MDPTP3
{

	public class Pila : Icoleccionable, Iterable
	{
		List<Icomparable> datos;

		public List<Icomparable> getDatos {
			get {
				return datos;
			}
		}
		
		public Pila()
		{
			datos=new List<Icomparable>();  
		}
		
		public void agregar(Icomparable c)
		{
			datos.Add(c);
		}
		
		public Icomparable desapilar()
		{
			Icomparable aux;
			int tam=datos.Count;
			aux=(Icomparable)datos[tam-1];
			datos.Remove(aux);
			
			return aux;
		}
		
		public bool vacia()
		{
			return datos.Count == 0;
		}
		
		public Icomparable tope()
		{
			int tam=datos.Count;
			
			return (Icomparable) datos[tam-1];
		}
		
		//region Icoleccionable implementation
		
		public int cuantos()
		{
			return this.datos.Count;
		}
		
		public Icomparable minimo()
		{
			//return (Icomparable)datos.Min();
//			Icomparable min=new Numero(100);
//			Icomparable min=new Persona("min",60000000);
			Icomparable min=new Alumno("minimooooooooo",60000000,1000,100);
			
			foreach(Icomparable elem in this.datos)
			{
				if(elem.sosMenor(min))
				{
					min=elem;
				}
			}
			
			return min;
		}

		public Icomparable maximo()
		{
			//return (Icomparable)datos.Max();
//			Icomparable max=new Numero(0);
//			Icomparable max=new Persona("m",0);
			Icomparable max=new Alumno("",0,0,0);
			
			foreach(Icomparable elem in this.datos)
			{
				if(elem.sosMayor(max))
				{
					max=elem;
				}
			}
			
			return max;
		}

	

		public bool contiene(Icomparable c)
		{
			foreach(Icomparable elem in datos)
			{
				if(elem.sosIgual(c))
				{
					return true;
				}
			}
			
			return false;
		}
		//end region
		
		#region Iterable implementation
		public Iterator crearIterador()
		{
			return new IteradorDeColeccion(this);
		}
		#endregion
	}
}
