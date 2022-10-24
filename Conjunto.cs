
using System;
using System.Collections.Generic;

namespace MDPTP3
{
	
//	3) Implemente la clase Conjunto. Un Conjunto es una colección que almacena elementos sin repetición.
//	Es decir, si se intenta almacenar un elemento que ya está en el conjunto, éste elemento no se almacena ya que sino estaría repetido.
	
	public class Conjunto : Icoleccionable, Iterable
	{
		
//		En C#, HashSet es una colección desordenada de elementos únicos. 
//		Admite la implementación de conjuntos y utiliza la tabla hash para el almacenamiento. Esta colección es de la colección de tipos genéricos 
//		y se define en System.Collections.Generic namespace. Generalmente se usa cuando queremos evitar que se coloquen elementos duplicados
//		en la colección. El rendimiento del HashSet es mucho mejor en comparación con la lista.
		List<Icomparable> conjunto;

		public List<Icomparable> getConjunto {
			get {
				return conjunto;
			}
		}

//		public HashSet<Icomparable> conjunto;

//		public HashSet<Icomparable> getConjunto {
//			get {
//				return conjunto;
//			}
//		}
		
		public Conjunto()
		{
			this.conjunto=new List<Icomparable>();
//			this.conjunto=new HashSet<Icomparable>();
		}
		
		public void agregar(Icomparable elemento)
		{
			if(pertenece(elemento)==false)
				conjunto.Add(elemento);
		}
		
		public bool pertenece(Icomparable elemento)
		{
			foreach(var elem in conjunto)
			{
				if(elem==elemento)
					return true;
			}
			return false;
		}

		public int cuantos()
		{
			return conjunto.Count;
		}

		public Icomparable minimo()
		{
			Icomparable min=new Alumno("minimooooooooo",60000000,1000,100);
			
			foreach(Icomparable elem in conjunto)
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
			Icomparable max=new Alumno("",0,0,0);
			
			foreach(Icomparable elem in conjunto)
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
			foreach(Icomparable elem in conjunto)
			{
				if(elem.sosIgual(c))
				{
					return true;
				}
			}
			
			return false;
		}

		#region Iterable implementation

		public Iterator crearIterador()
		{
			return new IteradorDeColeccion(this);
		}

		#endregion
	}
}
