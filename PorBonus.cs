
using System;

namespace MDPTP3
{

	public class PorBonus : Istrategy
	{
		public PorBonus(){}

		#region Istrategy implementation

		public bool sosIgual(Icomparable c, Icomparable o)
		{
			if(((Vendedor)c).getBonus() == ((Vendedor)o).getBonus())
				return true;
			else
				return false;
		}

		public bool sosMenor(Icomparable c, Icomparable o)
		{
			if(((Vendedor)c).getBonus() < ((Vendedor)o).getBonus())
				return true;
			else
				return false;
		}

		public bool sosMayor(Icomparable c, Icomparable o)
		{
			if(((Vendedor)c).getBonus() > ((Vendedor)o).getBonus())
				return true;
			else
				return false;
		}

		#endregion
	}
}
