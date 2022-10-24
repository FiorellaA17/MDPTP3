
using System;

namespace MDPTP3
{
	public class PorDni : Istrategy
	{

		public PorDni(){}

		#region Istrategy implementation

		public bool sosIgual(Icomparable c,Icomparable o)
		{
			if(((Alumno)c).getDni() == ((Alumno)o).getDni())
				return true;
			else
				return false;
		}

		public bool sosMenor(Icomparable c,Icomparable o)
		{
			if(((Alumno)c).getDni() < ((Alumno)o).getDni())
				return true;
			else
				return false;
		}

		public bool sosMayor(Icomparable c,Icomparable o)
		{
			if(((Alumno)c).getDni() > ((Alumno)o).getDni())
				return true;
			else
				return false;
		}

		#endregion
	}
}
