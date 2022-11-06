﻿
using System;

namespace MDPTP3
{
	public class StrategyNumero : Istrategy
	{
		public StrategyNumero()
		{
		}

		#region Istrategy implementation

		public bool sosIgual(Icomparable c, Icomparable o)
		{
			if(((Numero)c).getValor() == ((Numero)o).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
			
		}

		public bool sosMenor(Icomparable c, Icomparable o)
		{
			if(((Numero)c).getValor() < ((Numero)o).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool sosMayor(Icomparable c, Icomparable o)
		{
			if(((Numero)c).getValor() > ((Numero)o).getValor())
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion
	}
}
