
using System;

namespace MDPTP3
{
	public class PorLegajo : Istrategy
	{
		
		public PorLegajo(){}
		
		
		#region Istrategy implementation
		public bool sosIgual(Icomparable c,Icomparable o)
		{
			if(((Alumno)c).getLegajo() == ((Alumno)o).getLegajo())
				return true;
			else
				return false;
		}
		public bool sosMenor(Icomparable c,Icomparable o)
		{
			if(((Alumno)c).getLegajo() < ((Alumno)o).getLegajo())
				return true;
			else
				return false;
		}
		public bool sosMayor(Icomparable c, Icomparable o)
		{
			if(((Alumno)c).getLegajo() > ((Alumno)o).getLegajo())
				return true;
			else
				return false;
		}
		#endregion
	}
}
