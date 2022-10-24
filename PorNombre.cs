
using System;

namespace MDPTP3
{
	public class PorNombre : Istrategy
	{
		
		public PorNombre(){}

		#region Istrategy implementation

		public bool sosIgual(Icomparable c,Icomparable o)
		{
			if(((Alumno)c).getNombre().Length == ((Alumno)o).getNombre().Length)
				return true;
			else
				return false;
		}

		public bool sosMenor(Icomparable c,Icomparable o)
		{
			if(((Alumno)c).getNombre().Length < ((Alumno)o).getNombre().Length)
				return true;
			else
				return false;
		}

		public bool sosMayor(Icomparable c,Icomparable o)
		{
			if(((Alumno)c).getNombre().Length > ((Alumno)o).getNombre().Length)
				return true;
			else
				return false;
		}

		#endregion
	}
}
