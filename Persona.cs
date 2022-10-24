
using System;

namespace MDPTP3
{
public class Persona : Icomparable
	{
		string nombre;
		int dni;
		
//		public Persona(){}
		
		public Persona(string nombre, int dni)
		{
			this.nombre=nombre;
			this.dni=dni;
		}
		
		public string getNombre()
		{
			return this.nombre;
		}
		
		public int getDni()
		{
			return this.dni;
		}

		#region Icomparable implementation

		public virtual bool sosIgual(Icomparable c)
		{
			if(this.getDni() == ((Persona)c).getDni())
				return true;
			else
				return false;
			
//			throw new NotImplementedException();
		}

		public virtual bool sosMenor(Icomparable c)
		{
			
			if(this.getDni() < ((Persona)c).getDni())
				return true;
			else
				return false;
//			throw new NotImplementedException();
		}

		public virtual bool sosMayor(Icomparable c)
		{
			if(this.getDni() > ((Persona)c).getDni())
				return true;
			else
				return false;
//			throw new NotImplementedException();
		}

		#endregion
		
		public override string ToString()
		{
			return string.Format("{0}", dni);
		}
	}
}
