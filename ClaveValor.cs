
using System;

namespace MDPTP3
{
//	Sugerencia: implemente una clase auxiliar ClaveValor que lo único que hace es almacenar una clave (que puede ser cualquier Comparable)
//	y un valor asociado (que puede ser cualquier otro objeto). 
//	Luego puede usar la clase Conjunto para que un diccionario almacene instancias de la clase ClaveValor,
//	las cuales son creadas en el método agregar y valorDe.

	public class ClaveValor : Icomparable
	{
		Icomparable clave;
		Icomparable valor;
		
		public ClaveValor(Icomparable c, Icomparable v)
		{
			this.clave=c;
			this.valor=v;
		}

		public Icomparable getclave()
		{
			return this.clave;
		}
		
		public Icomparable getvalor()
		{
			return this.valor;
		} 
		#region Icomparable implementation

		public bool sosIgual(Icomparable c)
		{
			throw new NotImplementedException();
		}

		public bool sosMenor(Icomparable c)
		{
			throw new NotImplementedException();
		}

		public bool sosMayor(Icomparable c)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
