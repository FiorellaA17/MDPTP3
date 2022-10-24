
using System;

namespace MDPTP3
{
//	4) Implemente la clase Diccionario.
//	Un Diccionario es una colección que almacena elementos,donde cada elemento tiene una clave asociada. Las claves no pueden repetirse.
	
//	5) Haga que las clases Conjunto y Diccionario implementen la interface Coleccionable.
//		En el caso de Diccionario, los métodos minimo, máximo y contiene deben hacer referencia a los valores asociados, no a las claves.
//		En el método agregar puede usar una clave única por defecto, que maneja el propio diccionario para ir agregando los valores 
//		asociados a esas claves únicas.
	
	public class Diccionario : Icoleccionable
	{
		Conjunto conjuntoDiccionario=new Conjunto();
		ClaveValor cv;

		public Conjunto getConjuntoDiccionario {
			get {
				return conjuntoDiccionario;
			}
		}
			
		public Diccionario()
		{
		}
		
		public void agregar(Icomparable clave, Icomparable valor)
		{
			cv=new ClaveValor(clave,valor);
			this.conjuntoDiccionario.agregar(cv);	
		}
		
		public Icomparable valorDe(Icomparable clave)
		{	
			Iterator iteradorConjunto=conjuntoDiccionario.crearIterador();
            while(!iteradorConjunto.fin())
            {
                Icomparable elem=iteradorConjunto.actual();
                if(clave.sosIgual(elem))
                {
                    return elem;
                }
                
                iteradorConjunto.siguiente();
            }
            
            return null;
		}
		
		
		#region Icoleccionable implementation
		public int cuantos()
		{
			return getConjuntoDiccionario.cuantos();
//			throw new NotImplementedException();
		}
		public Icomparable minimo()
		{
			return conjuntoDiccionario.minimo();

		}
		public Icomparable maximo()
		{
			return conjuntoDiccionario.maximo();
		}
		public void agregar(Icomparable c)
		{
			conjuntoDiccionario.agregar(c);
		}
		public bool contiene(Icomparable c)
		{
			return conjuntoDiccionario.contiene(c);
		}
		#endregion

		public Iterator crearIterador()
		{
			return new IteradorDeColeccion(getConjuntoDiccionario);
//			throw new NotImplementedException();
		}
	}
}
