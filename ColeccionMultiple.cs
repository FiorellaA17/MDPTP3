
using System;

namespace MDPTP3
{

public class ColeccionMultiple : Icoleccionable
	{
		Pila P;
		Cola C;
		
		public ColeccionMultiple(Pila p, Cola c )
		{
			P=new Pila();
			C=new Cola();
			
			this.P=p;
			this.C=c;
		}

		#region Icoleccionable implementation

		public int cuantos()
		{
			int total= this.P.cuantos() + this.C.cuantos();
			return total;
		}

		public Icomparable minimo()
		{
			Icomparable minP= P.minimo();
			Icomparable minC= C.minimo();
			
//			if(((Persona)minP).getDni() > ((Persona)minC).getDni()) //para que compare Dni, debo castear a persona y pedir el dni
			if(minP.sosMenor(minC))
				return minP;
			else
				return minC;
		}

		public Icomparable maximo()
		{
			Icomparable maxP= P.maximo();
			Icomparable maxC= C.maximo();
			
			if(((Persona)maxP).getDni() > ((Persona)maxC).getDni()) //modifico cambiando por getDni y casteando a persona
				return maxP;
			else
				return maxC;
		}

		public void agregar(Icomparable c)
		{
			throw new NotImplementedException();
		}

		public bool contiene(Icomparable c)
		{
			bool auxP=P.contiene(c);
			bool auxC=C.contiene(c);
			
			if(auxP == true || auxC == true)
				return true;
			else
				return false;
			
		}

		#endregion

		public Iterator crearIterador()
		{
			throw new NotImplementedException();
		}
	}
}
