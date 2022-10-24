
using System;
using System.Collections.Generic;

namespace MDPTP3
{

	public class Cola : Icoleccionable, Iterable
	{
		List<Icomparable> datos;

		public List<Icomparable> getDatos {
			get {
				return datos;
			}
		}
		
		public Cola()
		{
			this.datos=new List<Icomparable>();
		}
		
		public IComparable desencolar() 
		{
			IComparable temp = (IComparable)this.datos[0];
			datos.Remove((Icomparable)temp);
			return temp;
		}
		
		public IComparable tope() 
		{
			return (IComparable)this.datos[0];
		}
		
		public bool esVacia() 
		{
			return this.datos.Count == 0;
		}
		
		//region Icoleccionable implementation
		
		public int cuantos()
		{
			return this.datos.Count;
		}
		
		public Icomparable minimo()
		{
//			Icomparable min=new Alumno("minimooooooooo",60000000,1000,100);
			Icomparable min=datos[0];
			
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
//			Icomparable max=new Alumno("m",0,0,0);
			Icomparable max=datos[0];
			
			foreach(Icomparable elem in this.datos)
			{
				if(elem.sosMayor(max))
				{
					max=elem;
				}
			}
			
			return max;
		}
		
		public void agregar(Icomparable c)
		{
			this.datos.Add(c);
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
