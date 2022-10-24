
using System;

namespace MDPTP3
{
	public class Numero : Icomparable
	{
		//al informar no me comparaba correctamente,me decia que no podia comparar alumno con numero. Entonces creo una estrategia de comparacion para numero
		Istrategy comparoNumero; 
		int valor;
		
		
		public Numero(int v)
		{
			this.valor=v;
			this.comparoNumero=new StrategyNumero();
		}
		
		public int getValor()
		{
			return this.valor;
		}
		
		public bool sosIgual(Icomparable c)
		{
			return comparoNumero.sosIgual(this, c);
		}
		
		public bool sosMenor(Icomparable c)
		{
			return comparoNumero.sosMenor(this,c);
		}

		public bool sosMayor(Icomparable c)
		{
			return comparoNumero.sosMayor(this, c);
		}
		
		//sobreescribo para tener el valor, le digo como imprimir el objeto
		public override string ToString()
		{
			return string.Format("[{0}]", valor);
		}
	}
}
