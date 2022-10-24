
using System;
using System.Collections.Generic;
using System.Linq;

namespace MDPTP3
{
	
	public class IteradorDeColeccion : Iterator
	{
		List<Icomparable> elementos;
		private int posicion=0;
		
		public IteradorDeColeccion(Cola elementoscola)
		{
			this.elementos=elementoscola.getDatos;
		}
		
		public IteradorDeColeccion(Pila elementospila)
		{
			this.elementos=elementospila.getDatos;
		}
		
		public IteradorDeColeccion(Conjunto elementosconjunto)
		{
			this.elementos=elementosconjunto.getConjunto;
		}
		

		#region Iterator implementation

		public void primero()
		{
			this.posicion=0;
		}

		public void siguiente()
		{
			this.posicion=this.posicion+1;
		}

		public bool fin()
		{
			return this.posicion==elementos.Count;
		}

		public Icomparable actual()
		{
			return elementos[this.posicion];
		}

		#endregion
	}
}
